using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAddCheck
{
    public class Version
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public int BuildNo { get; set; }
        public double DatabaseVer { get; set; }
        public Version(string LName, string SName, int Build, double DBVer)
        {
            LongName = LName;
            ShortName = SName;
            BuildNo = Build;
            DatabaseVer = DBVer;
        }
    }
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string file = args[0];

                if (File.Exists(file))
                {
                    string name = Path.GetFileNameWithoutExtension(file);

                    byte[] bytes = File.ReadAllBytes(file);
                    byte[] outp = bytes.Where(c => c >= 128).ToArray();
                    File.WriteAllBytes(name + "_Bad_characters.txt", outp);

                    byte[] goodbytes = File.ReadAllBytes(file);
                    byte[] goodoutp = goodbytes.Where(c => c <= 128).ToArray();
                    File.WriteAllBytes(name + "_fixed.dat", goodoutp);
                }
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSuperAddCheck());
        }

    }
        
}
