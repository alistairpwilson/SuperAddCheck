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
            
            Version[] Versions = new Version[25];
            Versions[0] = new Version("5_00_875", "5.0", 875, 99.0);
            Versions[1] = new Version("5_00_876", "5.0", 876, 100.0);
            Versions[2] = new Version("5_00_877", "5.0", 877, 100.0);
            Versions[3] = new Version("5_00_878", "5.0", 878, 101.0);
            Versions[4] = new Version("5_00_880", "5.0", 880, 102.0);
            Versions[5] = new Version("5_00_881", "5.0", 881, 102.1);
            Versions[6] = new Version("5_00_882", "5.0", 882, 102.2);
            Versions[7] = new Version("5_00_883", "5.0", 883, 103.0);
            Versions[8] = new Version("5_50_884", "5.5", 884, 103.1);
            Versions[9] = new Version("5_50_885", "5.5", 885, 103.2);
            Versions[10] = new Version("5_50_886", "5.5", 886, 103.2);
            Versions[11] = new Version("5_50_888", "5.5", 888, 104.0);
            Versions[12] = new Version("5_50_889", "5.5", 889, 104.0);
            Versions[13] = new Version("5_50_890", "5.5", 890, 104.0);
            Versions[14] = new Version("5_50_891", "5.5", 891, 105.0);
            Versions[15] = new Version("5_50_892", "5.5", 892, 106.0);
            Versions[16] = new Version("5_60_894", "5.6", 894, 107.0);
            Versions[17] = new Version("5_60_895", "5.6", 895, 107.0);
            Versions[18] = new Version("5_60_896", "5.6", 896, 108.0);
            Versions[19] = new Version("5_60_897", "5.6", 897, 109.0);
            Versions[20] = new Version("5_60_898", "5.6", 898, 109.1);
            Versions[21] = new Version("6_00_900", "6.0", 900, 110.0);
            Versions[22] = new Version("6_00_905", "6.0", 905, 111.0);
            Versions[23] = new Version("6_00_906", "6.0", 906, 111.1);
            Versions[24] = new Version("6_00_907", "6.0", 907, 112.0);

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
