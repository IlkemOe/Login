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

            var angemeldeterBenutzer = LoginBildschirm.FindeAngemeldetenBenutzer();
            if (angemeldeterBenutzer != null)
            {
                // Direkt zum Hauptbildschirm, wenn ein Benutzer gefunden wird
                Application.Run(new Homescreen(angemeldeterBenutzer.Benutzername, angemeldeterBenutzer.Status, angemeldeterBenutzer.AngemeldetBleiben));
            }
            else
            {
                // Zeige erst das Login-Formular, wenn kein Benutzer angemeldet ist
                Application.Run(new LoginBildschirm());
            }
        }

    }
}

