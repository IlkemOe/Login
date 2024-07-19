using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Benutzer
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public string Benutzername { get; set; }
        public string PasswortHash { get; set; }
        public string Sicherheitsfrage { get; set; }
        public string Sicherheitsantwort { get; set; }
        public string Status { get; set; }

        public bool AngemeldetBleiben { get; set; }
    }
    

}

