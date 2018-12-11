using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
            void ExtractResource(string resource)
            {
                string exePath = Application.StartupPath.ToString() + "\\ADDCHECK.EXE";
                Stream stream = GetType().Assembly.GetManifestResourceStream(resource);
                byte[] bytes = new byte[(int)stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                File.WriteAllBytes(exePath, bytes);
                System.Diagnostics.Process.Start(exePath);
            }
            ExtractResource("ADDCHECK.EXE");
            ExtractResource("AddCheck5.0.EXE");
            ExtractResource("ADDCHECK5.6.EXE");

            InitializeComponent();
            
            Version[] Versions = new Version[20];
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
            foreach(var V in Versions)
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
            
        }
    }
}
