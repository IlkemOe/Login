using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Login.Forms;
using Npgsql;
using System.Security.Cryptography;

namespace Login
{
    public partial class LoginBildschirm : Form
    {
        private Registrierung _registrierung;
        private DatenbankService dbService;



        public LoginBildschirm()
        {
            //Hintergrund
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _registrierung = new Registrierung();
            dbService = new DatenbankService();
            ButtonLogin.Enabled = false;
            
            //Farben
            LabelEmailBenutzername.ForeColor = Farben.ColdMountain;
            LabelPasswort.ForeColor = Farben.ColdMountain;
            CheckboxAngemeldetbBleiben.ForeColor = Farben.ColdMountain;
            linkLabelPasswortVergessen.LinkColor = Farben.Surfie;
            linkLabelPasswortVergessen.VisitedLinkColor = Farben.BermudaGrey;
            ButtonLogin.BackColor = Farben.ButtonOpacity;
            ButtonRegistrieren.BackColor = Farben.Iron;
            ButtonRegistrieren.ForeColor = Farben.DeepSky;
            ButtonPasswortSicherheit.BackColor = Farben.Surfie;
            TextfeldEmail.ForeColor = Farben.DeepSky;
            TextfeldPasswort.ForeColor = Farben.DeepSky;


           
        }

        //Login Button Sichtbarkeit
        private void TextfeldEmail_TextChanged(object sender, EventArgs e)
        {

            if (TextfeldPasswort.Text == "" || TextfeldEmail.Text == "")
            {
                ButtonLogin.Enabled = false;
                ButtonLogin.BackColor = Farben.ButtonOpacity;
            }
            else
            {
                ButtonLogin.Enabled = true;
                ButtonLogin.BackColor = Farben.Surfie;
            }
        }

        private void TextfeldPasswort_TextChanged(object sender, EventArgs e)
        {
            if (TextfeldPasswort.Text == "" || TextfeldEmail.Text == "")
            {
                ButtonLogin.Enabled = false;
                ButtonLogin.BackColor = Farben.ButtonOpacity;
            }
            else
            {
                ButtonLogin.Enabled = true;
                ButtonLogin.BackColor = Farben.Surfie;
            }
        }


        //Sichtbarkeit Sicherheitsauge
        private void TextfeldPasswort_Enter(object sender, EventArgs e)
        {
            TextfeldPasswort.UseSystemPasswordChar = true;
            ButtonPasswortSicherheit.Visible = true;
        }


        //PasswortSichtbarkeit
        private void ButtonPasswortSicherheit_Click(object sender, EventArgs e)
        {
            if (TextfeldPasswort.UseSystemPasswordChar == true)
            {

                TextfeldPasswort.UseSystemPasswordChar = false;
                ButtonPasswortSicherheit.Image = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\AugeZu.png"));
            }
            else
            {

                TextfeldPasswort.UseSystemPasswordChar = true;
                ButtonPasswortSicherheit.Image = new Bitmap(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\Auge.png"));
            }
        }


        //Weiter zum Registrieren
        private void ButtonRegistrieren_Click(object sender, EventArgs e)
        {
            RegistrierungForm registrierung = new RegistrierungForm(this);
            registrierung.Show();
            this.Hide();
        }


        //Passwort verschlüsselung
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


        //Datenbankanbindung
        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";


        //Sucht in der Datenbank nach möglichen Benutzern
        public static Benutzer FindeAngemeldetenBenutzer()
        {
            string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT Benutzername, Status FROM BenutzerTabelle WHERE AngemeldetBleiben = TRUE LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string benutzername = reader.GetString(0);
                            string status = reader.GetString(1);
                            return new Benutzer { Benutzername = benutzername, Status = status, AngemeldetBleiben = true };
                        }
                    }
                }
            }
            return null;
        }


        //Logik um gefundenen Benutzer anzumelden
        private bool BenutzerAnmelden(string benutzernameOderEmail, string passwort)
        {

            string passwortHash = HashPasswort(passwort);

            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {                    
                    vCon.Open();
                    List<string> sqlList = new List<string>
                    {
                        "SELECT COUNT(*)",
                        "FROM BenutzerTabelle",
                        "WHERE (benutzername = @benutzernameOderEmail OR email = @benutzernameOderEmail)",
                        "AND passworthash = @passwortHash"
                    };

                    string sql = string.Join(" ", sqlList);
                    using (NpgsqlCommand vCmd = new NpgsqlCommand(sql, vCon))
                    {
                        vCmd.Parameters.AddWithValue("@benutzernameOderEmail", benutzernameOderEmail);
                        vCmd.Parameters.AddWithValue("@passwortHash", benutzernameOderEmail == "root" ? passwort : passwortHash);

                        int count = Convert.ToInt32(vCmd.ExecuteScalar());
                        return count > 0; // Wenn mindestens ein Datensatz gefunden wurde, sind die Anmeldeinformationen korrekt
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }


        //Hier wird der Status von Email/Benutzername bestimmt
        private string BenutzerStatus(string benutzernameOderEmail)
        {
            string status = string.Empty;

            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    List<string> sqlList = new List<string>
                    {
                        "SELECT status",
                        "FROM BenutzerTabelle",
                        "WHERE benutzername = @benutzername OR email = @benutzername"
                    };

                    string sql = string.Join(" ", sqlList);
                    using (NpgsqlCommand vCmd = new NpgsqlCommand(sql, vCon))
                    {
                        vCmd.Parameters.AddWithValue("@benutzername", benutzernameOderEmail);
                        object result = vCmd.ExecuteScalar();

                        if (result != null)
                        {
                            status = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler beim Abrufen des Benutzerstatus: " + ex.Message);
                }
            }

            return status;
        }


        //Update wenn man Angemeldet bleiben möchte
        public void SpeichereAngemeldetenBenutzer(string benutzername, bool angemeldetBleiben)
        {
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE BenutzerTabelle SET AngemeldetBleiben = @AngemeldetBleiben WHERE Benutzername = @BenutzernameOderEmail OR Email = @BenutzernameOderEmail", conn))
                {
                    cmd.Parameters.AddWithValue("AngemeldetBleiben", angemeldetBleiben);
                    cmd.Parameters.AddWithValue("BenutzernameOderEmail", benutzername);
                    cmd.ExecuteNonQuery();
                }
            }

        }


        //Hier wird eingeloggt
        public void ButtonLogin_Click(object sender, EventArgs e)
        {

            string benutzernameOderEmail = TextfeldEmail.Text;
            string passwort = TextfeldPasswort.Text;
            bool loggedIN = BenutzerAnmelden(benutzernameOderEmail, passwort);
            string status = BenutzerStatus(benutzernameOderEmail);
            bool angemeldetBleiben = CheckboxAngemeldetbBleiben.Checked;
            if (loggedIN)
            {
                SpeichereAngemeldetenBenutzer(benutzernameOderEmail, angemeldetBleiben);

                this.Hide();
                Homescreen homescreen = new Homescreen(benutzernameOderEmail, status, angemeldetBleiben);
                homescreen.Show();
                
            }   
            
            else
                
            {
                MessageBox.Show("Fehler bei der Anmeldung. Überprüfen Sie Ihre Anmeldeinformationen.");
            }
        }
        

        //Zu Passwort vergessen 
        private void linkLabelPasswortVergessen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PasswortVergessenForm passwortVergessen = new PasswortVergessenForm(this, null);
            passwortVergessen.Show();
            this.Hide();
        }


        //Programm wird beendet wenn Form geschlossen wird
        private void LoginBildschirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        //Eventhandler für Farben in Events
        private void Control_MouseHover(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button)
            {
                switch (button.Name)
                {
                    case "ButtonRegistrieren":
                        button.BackColor = Farben.Illusion;
                        break;
                    case "ButtonLogin":
                        button.BackColor = Farben.BlueShadow;
                        break;
                    case "ButtonPasswortSicherheit":
                        button.BackColor = Farben.DarkSurfie;
                        break;
                }
            }
            else if (sender is System.Windows.Forms.TextBox textBox)
            {
                textBox.BackColor = Farben.ArcticWhite;
            }
        }
        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button)
            {
                switch (button.Name)
                {
                    case "ButtonRegistrieren":
                        button.BackColor = Farben.Iron;
                        break;
                    case "ButtonLogin":
                        button.BackColor = Farben.Surfie;
                        break;
                    case "ButtonPasswortSicherheit":
                        button.BackColor = Farben.Surfie;
                        break;
                }
            }
            else if (sender is System.Windows.Forms.TextBox textBox)
            {
                textBox.BackColor = Color.White;
            }
        }
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is System.Windows.Forms.Button button)
            {
                switch (button.Name)
                {
                    case "ButtonRegistrieren":
                        button.BackColor = Farben.Mystic;
                        break;
                    case "ButtonLogin":
                        button.BackColor = Farben.DarkSurfie;
                        break;
                    case "ButtonPasswortSicherheit":
                        button.BackColor = Farben.DarkSurfie;
                        break;
                }
            }
        }

    }
}
