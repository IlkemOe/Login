using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public class Registrierung
    {
        public static string CsvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data\Benutzer.csv");
        public void AktualisiereBenutzer(Benutzer aktualisierterBenutzer)
        {
            var benutzerListe = LeseBenutzerAusCsv();
            var index = benutzerListe.FindIndex(b => b.Email == aktualisierterBenutzer.Email);
            if (index != -1)
            {
                benutzerListe[index] = aktualisierterBenutzer;
                SchreibeBenutzerInCsv(benutzerListe);
            }
        }
        public bool IstEmailBereitsRegistriert(string email)
        {
            return LeseBenutzerAusCsv().Any(b => b.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
        public bool IstBenutzernameBereitsVergeben(string benutzername)
        {
            return LeseBenutzerAusCsv().Any(b => b.Benutzername.Equals(benutzername, StringComparison.OrdinalIgnoreCase));
        }
        public void BenutzerRegistrieren(string vorname, string nachname, string email, string benutzername, string passwort, string sicherheitsfrage, string sicherheitsantwort, string status, bool angemeldetBleiben)
        {
            if (IstEmailBereitsRegistriert(email))
            {
                throw new InvalidOperationException("Ein Konto mit dieser E-Mail existiert bereits.");
            }
            else if(IstBenutzernameBereitsVergeben(benutzername))
            {
                throw new InvalidOperationException("Der Benutzername ist bereits vergeben.");
            }          
            string passwortHash = HashPasswort(passwort);

            bool fileExists = File.Exists(CsvFilePath);
            using (var writer = new StreamWriter(CsvFilePath, true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    writer.WriteLine("Vorname; Nachname; E-Mail; Benutzername; PasswortHash; Sicherheitsfrage; Sicherheitsantwort; Status; AngemeldetBleiben");
                }
                writer.WriteLine($"{vorname};{nachname};{email};{benutzername};{passwortHash};{sicherheitsfrage};{sicherheitsantwort};{status};{angemeldetBleiben}");
            }
        }
        public List<Benutzer> LeseBenutzerAusCsv()
        {
            var benutzerListe = new List<Benutzer>();
            if (File.Exists(CsvFilePath))
            {
                var lines = File.ReadAllLines(CsvFilePath, Encoding.UTF8);
                foreach (var line in lines.Skip(1)) //Überspringt die Überschrift
                {
                    var feld = line.Split(';');
                    if (feld.Length == 9)
                    {
                        var benutzer = new Benutzer
                        {
                            Vorname = feld[0],
                            Nachname = feld[1],
                            Email = feld[2],
                            Benutzername = feld[3],
                            PasswortHash = feld[4],
                            Sicherheitsfrage = feld[5],
                            Sicherheitsantwort = feld[6],
                            Status = feld[7],
                            AngemeldetBleiben = feld[8] == "True" 
                        };
                        benutzerListe.Add(benutzer);
                    }
                }
            }
            return benutzerListe;
        }
        private void SchreibeBenutzerInCsv(List<Benutzer> benutzerListe)
        {
            using (var writer = new StreamWriter(CsvFilePath, false, Encoding.UTF8))
            {
                writer.WriteLine("Vorname;Nachname;Email;Benutzername;PasswortHash;Sicherheitsfrage;Sicherheitsantwort;Status;AngemeldetBleiben");
                foreach (var benutzer in benutzerListe)
                {
                    writer.WriteLine($"{benutzer.Vorname};{benutzer.Nachname};{benutzer.Email};{benutzer.Benutzername};{benutzer.PasswortHash};{benutzer.Sicherheitsfrage};{benutzer.Sicherheitsantwort};{benutzer.Status};{benutzer.AngemeldetBleiben}");
                }
            }
        }
        public bool BenutzerAnmelden(string identifier, string passwort)
        {
            
            if (identifier.Contains("@"))
            {
                
                return KontrolliereEmailundPasswort(identifier, passwort);
            }
            else
            {
                return KontrolliereBenutzernameundPasswort(identifier, passwort);
            }
        }
        public bool KontrolliereEmailundPasswort(string email, string passwort)
        {
            string passwortHash = HashPasswort(passwort);
            var benutzer = LeseBenutzerAusCsv().FirstOrDefault(b => b.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && b.PasswortHash == passwortHash);
            return benutzer != null;
        }
        public bool KontrolliereBenutzernameundPasswort(string benutzername, string passwort)
        {
            string passwortHash = HashPasswort(passwort);
            var benutzer = LeseBenutzerAusCsv().FirstOrDefault(b => b.Benutzername.Equals(benutzername, StringComparison.OrdinalIgnoreCase) && b.PasswortHash == passwortHash);
            return benutzer != null;
        }
        private string HashPasswort(string passwort)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwort));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public Benutzer FindeBenutzer(string email, string benutzername)
        {
            return LeseBenutzerAusCsv().FirstOrDefault(b => b.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && b.Benutzername.Equals(benutzername, StringComparison.OrdinalIgnoreCase));
        }
        public string FindeBenutzernameVonEmail(string email)
        {
            string[] zeilen = File.ReadAllLines(CsvFilePath, Encoding.UTF8);
            foreach (var zeile in zeilen)
            {
                string[] felder = zeile.Split(';');
                if(felder.Length >=4 && felder[2].Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Benutzername gefunden: {felder[3]}"); // Debug-Ausgabe
                    return felder[3];                 
                }
            }
            return null;
        }
        public string FindeEmailVonBenutzer(string benutzername)
        {
            string[] zeilen = File.ReadAllLines(CsvFilePath, Encoding.UTF8);
            foreach (var zeile in zeilen)
            {
                string[] felder = zeile.Split(';');
                if (felder.Length >= 4 && felder[3].Equals(benutzername, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Benutzername gefunden: {felder[2]}"); // Debug-Ausgabe
                    return felder[2];
                }
            }
            return null;
        }
        public string FindeStatusVonEmail(string benutzername)
        {
            Console.WriteLine($"CSV-Dateipfad: {CsvFilePath}"); // Debug-Ausgabe
            string[] zeilen = File.ReadAllLines(CsvFilePath, Encoding.UTF8);
            foreach (var zeile in zeilen)
            {
                string[] felder = zeile.Split(';');
                Console.WriteLine($"Zeile: {zeile}"); // Debug-Ausgabe
                if (felder.Length >= 8 && felder[3].Equals(benutzername, StringComparison.OrdinalIgnoreCase))
                {
                    return felder[7];
                }
            }
            return null;
        }
        public void SetzeAngemeldetBleiben(string email, bool angemeldetBleiben) //ändern vom namen bool
        {
            var benutzerliste = LeseBenutzerAusCsv();
            foreach (var benutzer in benutzerliste)
            {
                    benutzer.AngemeldetBleiben = benutzer.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && angemeldetBleiben || benutzer.Benutzername.Equals(email, StringComparison.OrdinalIgnoreCase) && angemeldetBleiben;   //hier ist der fehler             
                
            }
            SchreibeBenutzerInCsv(benutzerliste);
        }
        public Benutzer FindeAngemeldetenBenutzer()
        {
            return LeseBenutzerAusCsv().FirstOrDefault(b => b.AngemeldetBleiben == true);
        }
        public void SetzeAngemeldetBleibenAufFalse(string email, bool angemeldetBleiben)
        {
            var benutzerliste = LeseBenutzerAusCsv();
            foreach (var benutzer in benutzerliste)
            {
                benutzer.AngemeldetBleiben = false;

            }
            SchreibeBenutzerInCsv(benutzerliste);
        }
    }
}
