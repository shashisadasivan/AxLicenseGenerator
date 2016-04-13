using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Ax2012LicenseGen
{
    static class Program
    {
        public static bool DebugMode;

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool FreeConsole();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            DebugMode = false;
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    if (item.Equals("--debug-mode-shs"))
                    {
                        DebugMode = true;
                        break;
                    }
                }
            }
            if (DebugMode)
            {
                MessageBox.Show(GetDefaultExeConfigPath(ConfigurationUserLevel.None));
                MessageBox.Show(GetDefaultExeConfigPath(ConfigurationUserLevel.PerUserRoaming));
                MessageBox.Show(GetDefaultExeConfigPath(ConfigurationUserLevel.PerUserRoamingAndLocal));
                AllocConsole();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            if(DebugMode)
                FreeConsole();
        }

        public static string GetDefaultExeConfigPath(ConfigurationUserLevel userLevel)
        {
            try
            {
                var UserConfig = ConfigurationManager.OpenExeConfiguration(userLevel);
                return UserConfig.FilePath;
            }
            catch (ConfigurationException e)
            {
                return e.Filename;
            }
        }
    }
}
