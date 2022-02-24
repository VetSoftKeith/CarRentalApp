using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Car_Rental_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLandingPage());
        }
    }

    internal static class Globals
    {
        public static CarRentalEntities db = new CarRentalEntities();
        public static List<State> stateList = db.States.ToList();
    }
}