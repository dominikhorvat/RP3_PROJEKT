using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //radimo izmjenu putanje sadržanu u |DataDirectory| kako bi se promjene
            //koje radimo pomoću forme, a utječu na bazu mogle spremati
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string parentDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\"));
            AppDomain.CurrentDomain.SetData("DataDirectory", parentDirectory);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrijava());
            //Application.Run(new FormStvoriZaposlenika());
            //Application.Run(new FormKonobar(new Employee()
            //{
            //    Id = 9,
            //    Username = "konobar",
            //    Authorization = "Konobar",
            //    Coffee = 2,
            //    Juice = 1,
            //    LastLogin = DateTime.Now
            //}));
        }
    }
}
