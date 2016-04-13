using System;
using System.Collections.Generic;
using System.Text;

namespace Ax2012LicenseGen
{
    class GenerateLicenseCommand
    {
        public string AxUtilLocation { get; set; }
        public string FilenameOutput { get; set; }
        public string LicenseCode { get; set; }
        public string CustomerName { get; set; }
        public string SerialNo { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public uint? UserCount { get; set; }

        public string CertificatePath { get; set; }
        public string PasswdCertificate { get; set; }

        public GenerateLicenseCommand(string axUtilLocation, string filenameOut, string licenseCode, string customerName, string serialNo)
        {
            this.AxUtilLocation = axUtilLocation;
            this.FilenameOutput = filenameOut;
            this.LicenseCode = licenseCode;
            this.CustomerName = customerName;
            this.SerialNo = serialNo;

            this.SetCertificatePathAndPasswd();
        }

        private void SetCertificatePathAndPasswd()
        {
            // this.CertificatePath = Properties.Settings.Default.CertificatePath;
            //this.PasswdCertificate = Properties.Settings.Default.CertificatePassword;
            this.CertificatePath = Settings.GetInstance().GetCerificatePath();
            this.PasswdCertificate = Settings.GetInstance().GetCertificatePassword();
        }

        private string GetCommand()
        {

            string baseString = "/C axutil genlicense /file:\"{0}\" /certificatepath:\"{1}\" /licensecode:\"{2}\" /customer:\"{3}\" /serialnumber:{4} /password:{5}";
            string expiryString = " /Expirationdate:";
            string usercountString = " /Usercount:";

            string commandStr = string.Format(baseString, FilenameOutput, this.CertificatePath, this.LicenseCode, this.CustomerName, this.SerialNo, this.PasswdCertificate);
            if (this.ExpiryDate.HasValue == true)
            {
                commandStr += expiryString + this.ExpiryDate.Value.ToString("MM/dd/yyyy"); //Requires americano formato
            }
            if (this.UserCount.HasValue == true)
            {
                commandStr += usercountString + this.UserCount.Value.ToString();
            }
            commandStr = commandStr.Replace("\n", "");
            return commandStr;
        }

        public string GenerateLicense()
        {
            string command = this.GetCommand();
            Console.WriteLine(command);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo();

            if (Program.DebugMode)
                startinfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            else
                startinfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            startinfo.WorkingDirectory = this.AxUtilLocation;
            startinfo.FileName = "cmd.exe";
            startinfo.Arguments = command;
            startinfo.UseShellExecute = false;
            startinfo.RedirectStandardOutput = true;
            process.StartInfo = startinfo;
            process.Start();
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            return output;
        }
    }
}
