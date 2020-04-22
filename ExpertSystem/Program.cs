using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void strtsp()
        {
            Application.Run(new splash());
        }
        static void Main()
        {
            Thread th = new Thread(new ThreadStart(strtsp));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Thread.Sleep(5000);
            th.Abort(); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}
