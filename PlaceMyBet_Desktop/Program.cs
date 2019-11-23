using PlaceMyBet_Desktop.BusinessLayer;
using PlaceMyBet_Desktop.DataAccessLayer;
using PlaceMyBet_Desktop.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceMyBet_Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            Application.Run(new LoginForm());
        }
    }
}
