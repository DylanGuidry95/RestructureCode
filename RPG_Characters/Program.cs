using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace RPG_Characters
{
    static class Program
    {
        public static string SaveDataDirectory = @"C:\Users\dylan.guidry\Documents\My Games\D&D_Creator";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateApplicationDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void CreateApplicationDirectory()
        {
            if (!Directory.Exists(SaveDataDirectory))
            {
                Directory.CreateDirectory(SaveDataDirectory);
                Directory.CreateDirectory(SaveDataDirectory + "/Characters");
                Directory.CreateDirectory(SaveDataDirectory + "/Weapons");
                Directory.CreateDirectory(SaveDataDirectory + "/Armor");
                Directory.CreateDirectory(SaveDataDirectory + "/Classes");
                Directory.CreateDirectory(SaveDataDirectory + "/Races");
            }

        }
    }
}
