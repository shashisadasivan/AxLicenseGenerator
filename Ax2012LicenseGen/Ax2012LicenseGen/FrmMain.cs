using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ax2012LicenseGen
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // this.panelCertificate.Visible = Program.DebugMode;
            this.panelCertificate.Visible = true; // this is always to be true. Need to allow to change the certificate path
            this.txtAxUtilFolder.Text = Settings.GetInstance().AxUtilLocation;
            this.txtCertificatePath.Text = Settings.GetInstance().CertificatePath;
            this.txtOutputPath.Text = Settings.GetInstance().DefaultOutPath;
            if (!txtOutputPath.Text.EndsWith("\\"))
                txtOutputPath.Text += "\\";
            /*
            this.txtAxUtilFolder.Text = Properties.Settings.Default.AxUtilLocation;
            this.txtCertificatePath.Text = Properties.Settings.Default.CertificatePath;
            this.txtOutputPath.Text = Properties.Settings.Default.DefaultOutPath;
            if (!txtOutputPath.Text.EndsWith("\\"))
                txtOutputPath.Text += "\\";
            */
        }

        private void chkBoxLicenseExpiry_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePickerExpiry.Enabled = this.chkBoxLicenseExpiry.Checked ? true : false;
        }

        private void btnChooseCertificate_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = this.txtCertificatePath.Text;
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtCertificatePath.Text = this.openFileDialog1.FileName;
                Settings.GetInstance().SetCertificatePath(this.openFileDialog1.FileName);
                //Settings.GetInstance().CertificatePath = this.openFileDialog1.FileName;
                Settings.Save();
                //Properties.Settings.Default.CertificatePath = this.openFileDialog1.FileName;
                //Properties.Settings.Default.Save();
            }
        }

        private void btnOutputPathDialog_Click(object sender, EventArgs e)
        {
            //this.saveFileDialog1.FileName = this.txtOutputPath.Text;
            //if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    var path = this.saveFileDialog1.FileName;
            //    if (!path.EndsWith("\\"))
            //        path += "\\";
            //    this.txtOutputPath.Text = path;
            //    Settings.GetInstance().DefaultOutPath = path;
            //    Settings.Save();
            //    //Properties.Settings.Default.DefaultOutPath = path;
            //    //Properties.Settings.Default.Save();
            //}
            this.folderBrowserDialog1.SelectedPath = this.txtOutputPath.Text;
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var path = this.folderBrowserDialog1.SelectedPath;
                if (!path.EndsWith("\\"))
                    path += "\\";

                this.txtOutputPath.Text = path;
                Settings.GetInstance().DefaultOutPath = path;
                Settings.Save();
            }
        }

        private bool ValidateFields()
        {
            bool hasError = false;
            this.errorProvider1.Clear();

            if (string.IsNullOrEmpty(this.txtAxUtilFolder.Text) == true)
            {
                this.errorProvider1.SetError(this.txtAxUtilFolder, "Required");
                hasError = true;
            }
            else
            {
                string location = this.txtAxUtilFolder.Text;
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(location);
                if (dirInfo.Exists)
                {
                    var files = dirInfo.GetFiles("axutil.exe", System.IO.SearchOption.TopDirectoryOnly);
                    if (files.Length <= 0)
                    {
                        this.errorProvider1.SetError(this.btnAxUtilFolder, "Folder does not contain AxUtil.exe");
                        hasError = true;
                    }
                }
                else
                {
                    this.errorProvider1.SetError(this.btnAxUtilFolder, "Folder does not exist");
                    hasError = true;
                }
            }
            if (string.IsNullOrEmpty(this.txtOutputPath.Text) == true)
            {
                this.errorProvider1.SetError(this.btnOutputPathDialog, "Required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(this.txtCertificatePath.Text) == true)
            {
                this.errorProvider1.SetError(this.btnChooseCertificate, "Required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(this.txtLicenseCode.Text) == true)
            {
                this.errorProvider1.SetError(this.txtLicenseCode, "Required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(this.txtCustomer.Text) == true)
            {
                this.errorProvider1.SetError(this.txtCustomer, "Required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(this.txtSerialNo.Text) == true)
            {
                this.errorProvider1.SetError(this.txtSerialNo, "Required");
                hasError = true;
            }

            if (string.IsNullOrEmpty(this.txtPwd.Text) == true)
            {
                this.errorProvider1.SetError(this.txtPwd, "Required");
                hasError = true;
            }

            if (this.chkBoxLicenseExpiry.Checked == true
                    && this.dateTimePickerExpiry.Value.Date <= DateTime.Now.Date)
            {
                this.errorProvider1.SetError(this.dateTimePickerExpiry, "Expires today or before today");
                hasError = true;
            }

            return !hasError; //return validate to false if hasError
        }
        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {
             this.GenerateLicenseCommand();
        }

        private void GenerateLicenseCommand()
        {
            if (this.ValidateFields() == true)
            {
                GenerateLicenseCommand licenseGenerator = new GenerateLicenseCommand(this.txtAxUtilFolder.Text, this.txtOutputPath.Text, this.txtLicenseCode.Text, this.txtCustomer.Text, this.txtSerialNo.Text);
                if (this.chkBoxLicenseExpiry.Checked)
                    licenseGenerator.ExpiryDate = this.dateTimePickerExpiry.Value.Date;
                if (this.numericUserCount.Value > 0)
                    licenseGenerator.UserCount = (uint)this.numericUserCount.Value;
                string output = licenseGenerator.GenerateLicense();
                if (!string.IsNullOrEmpty(output))
                {
                    this.txtHelp.Text = output;
                    this.errorProvider1.SetError(this.txtHelp, "Error generating license");
                }
                else
                {
                    this.txtHelp.Text = "License generated";
                }
            }
        }
        private void CreateFileName()
        {
            string fileFormat = "{0}_{1}_{2}_{3}.txt";
            string custName = this.txtCustomer.Text.Replace(" ", "");
            if (custName.Length > 6)
                custName = custName.Substring(0, 6);
            string serialNum = this.txtSerialNo.Text.Replace(" ", "");
            string licenseCode = this.txtLicenseCode.Text.Replace(" ", "");

            // string filename = string.Format(fileFormat, Properties.Settings.Default.OutFilePrefix, custName, serialNum, licenseCode);
            string filename = string.Format(fileFormat, Settings.GetInstance().OutfilePrefix, custName, serialNum, licenseCode);

            string savePathFile = this.txtOutputPath.Text;
            int lastSlashPos = savePathFile.LastIndexOf("\\");

            System.IO.FileInfo fi = new System.IO.FileInfo(this.txtOutputPath.Text);
            string directoryName = fi.DirectoryName;
            if (directoryName == null && lastSlashPos > 0)
                directoryName = this.txtOutputPath.Text.Substring(0, lastSlashPos + 1);

            if (!directoryName.EndsWith("\\"))
                directoryName += "\\";
            
            filename = directoryName + filename;

            this.txtOutputPath.Text = filename;
        }

        private void Focus_Enter(object sender, EventArgs e)
        {
            if (sender is Control)
            {
                string helpText = "";
                if (sender == this.txtAxUtilFolder || sender == this.btnAxUtilFolder)
                    helpText = "Location of AxUtil.exe";
                else if (sender == this.txtOutputPath || sender == this.btnOutputPathDialog)
                    helpText = "Specifies the location and name of the generated license file";
                else if (sender == this.txtCertificatePath || sender == this.btnChooseCertificate)
                    helpText = "Specifies the path to the certificate used to generate the license file";
                else if (sender == this.txtLicenseCode)
                    helpText = "Specifies the name of the licencode code used to generate the license file.\nLicense code of Module to be licensed";
                else if (sender == this.txtCustomer)
                    helpText = "Specifies the customer name used to generate the license file";
                else if (sender == this.txtSerialNo)
                    helpText = "Specifies the serial number used to generate the license file";
                else if (sender == this.txtPwd)
                    helpText = "The value of this parameter must match the password of the given certificate when generating a license file";
                else if (sender == this.dateTimePickerExpiry || sender == this.chkBoxLicenseExpiry)
                    helpText = "Specifies expiration date of the generated license. This parameter is optional";
                else if (sender == this.numericUserCount)
                    helpText = "Specifies the number of simultaneous users for the the generated license. This parameter is optional (Set count to 0)";
                else if (sender == this.btnGenerateLicense)
                    helpText = "Generate the license";
                else if (sender == this.btnCancel)
                    helpText = "Exit application";
                else
                    helpText = "";
                this.txtHelp.Text = helpText;
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAxUtilFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.SelectedPath = this.txtAxUtilFolder.Text;
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtAxUtilFolder.Text = this.folderBrowserDialog1.SelectedPath;
                Settings.GetInstance().AxUtilLocation = this.txtAxUtilFolder.Text;
                Settings.Save();
                //Properties.Settings.Default.AxUtilLocation = this.txtAxUtilFolder.Text;
                //Properties.Settings.Default.Save();
            }
        }

        private void txtFileNameHandler_TextChanged(object sender, EventArgs e)
        {
            this.CreateFileName();
        }

        private void txtPwd_Validated(object sender, EventArgs e)
        {
            if(this.txtPwd.Text.Length > 0)
            {
                // Settings.GetInstance().CertificatePassword = this.txtPwd.Text;
                Settings.GetInstance().SetPassword(this.txtPwd.Text);
                Settings.Save();
                //Properties.Settings.Default.CertificatePassword = this.txtPwd.Text;
                //Properties.Settings.Default.Save();
                // Save the password
            }
        }
    }
}
