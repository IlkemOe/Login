using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Registrierung registrierung = new Registrierung();
            Benutzer benutzer = registrierung.LeseBenutzerAusCsv().FirstOrDefault(b => b.AngemeldetBleiben);

            if (benutzer != null)
            {
                
                Homescreen homescreen = new Homescreen(benutzer.Benutzername,benutzer.Status, benutzer.AngemeldetBleiben);
                Application.Run(homescreen);
            }
            else
            {
                Application.Run(new LoginBildschirm());
            }
        }

    }
}

