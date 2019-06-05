using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperAddCheck
{
    public partial class FrmSuperAddCheck : Form
    {
        public FrmSuperAddCheck()
        {
           
            InitializeComponent();
            
            List<Version> Versions = new List<Version>();

            using (var reader = new StreamReader(@"\\HCDC02\USERS\awilson\CatScan\Versions.csv"))
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Versions.Add(new Version(values[0], values[1], Convert.ToInt32(values[2]), Double.Parse(values[3], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo)));
                }

            foreach (var V in Versions)
            {
                CmbVersion.Items.Add(V.LongName);
                CmbVersion.Sorted = true;
                CmbVersion.SelectedIndex = 0;
            }
            
        }
        
        private void FrmSuperAddCheck_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\Temp\\ADDCHECK.exe"))
            {
                File.Delete("C:\\Temp\\ADDCHECK.exe");
                ExtractResource(1.0);
            }
            else ExtractResource(1.0);
            //ExtractResource(5.0);
        }
               
        void ExtractResource(double acheck)
        {
            switch (acheck)
            {
                case 1.0:
                    byte[] exeBytes = Properties.Resources.ADDCHECK;
                    string exeToRun = @"C:\Temp\ADDCHECK.exe";
                    using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                    {
                        exeFile.Write(exeBytes, 0, exeBytes.Length);
                    }

                    using (Process exeProcess = Process.Start(exeToRun, " \"C:\\Users\\awilson\\Documents\\CatScan dat Fixes\\KZN\\HC_Pocket_PC_20190515232550.dat\""))
                    {
                        exeProcess.WaitForExit();
                    }
                    break;

                case 5.0:
                    byte[] exeBytes2 = Properties.Resources.AddCheck5_0;
                    string exeToRun2 = @"C:\Temp\AddCheck" + acheck.ToString($"F{1}") + ".exe";
                    using (FileStream exeFile = new FileStream(exeToRun2, FileMode.CreateNew))
                    {
                        exeFile.Write(exeBytes2, 0, exeBytes2.Length);
                    }

                    using (Process exeProcess = Process.Start(exeToRun2))
                    {
                        exeProcess.WaitForExit();
                    }
                    break;

                case 5.6:
                    byte[] exeBytes3 = Properties.Resources.AddCheck5_6;
                    string exeToRun3 = @"C:\Temp\AddCheck" + acheck.ToString($"F{1}") + ".exe";
                    using (FileStream exeFile = new FileStream(exeToRun3, FileMode.CreateNew))
                    {
                        exeFile.Write(exeBytes3, 0, exeBytes3.Length);
                    }

                    using (Process exeProcess = Process.Start(exeToRun3, "keepcr"))
                    {
                        exeProcess.WaitForExit();
                    }
                    break;
            }

        }
    }
}
