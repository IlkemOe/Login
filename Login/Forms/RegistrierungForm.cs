using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class RegistrierungForm : Form
    {
        private LoginBildschirm _loginBildschirm;
        private Registrierung _registrierung;
        public RegistrierungForm(LoginBildschirm loginBildschirm)
        {
            this.BackColor = Farben.IceWhite;
            
            InitializeComponent();
            _loginBildschirm = loginBildschirm;
            _registrierung = new Registrierung();
            TextboxPasswortR.UseSystemPasswordChar = true;
            TextboxPasswortWiederholen.UseSystemPasswordChar = true;
            
            //Farben
            ButtonJetztRegistrieren.BackColor = Farben.ButtonOpacity;
            ButtonZurückR.ForeColor = Farben.DeepSky;
            ButtonZurückR.BackColor = Farben.Iron;
            ButtonFragezeichen.BackColor = Farben.Iron;
            ButtonFragezeichen.ForeColor = Farben.DeepSky;
            LabelVorname.ForeColor = Farben.ColdMountain;
            LabelNachname.ForeColor = Farben.ColdMountain;
            LabelEmail.ForeColor = Farben.ColdMountain;
            LabelBenutzername.ForeColor = Farben.ColdMountain;
            LabelPasswortR.ForeColor = Farben.ColdMountain;
            LabelPasswortWiederholen.ForeColor = Farben.ColdMountain;           
            LabelSicherheitsfrage.ForeColor = Farben.ColdMountain;
            TextboxVorname.ForeColor = Farben.DeepSky;
            TextboxNachname.ForeColor = Farben.DeepSky;
            TextboxEmail.ForeColor = Farben.DeepSky;
            TextboxBenutzername.ForeColor = Farben.DeepSky;
            TextboxPasswortR.ForeColor = Farben.DeepSky;
            TextboxPasswortWiederholen.ForeColor = Farben.DeepSky;
            TextboxSicherheitsantwort.ForeColor = Farben.DeepSky;
            ComboboxSicherheitsfrage.ForeColor = Farben.DeepSky;
            LabelEmailFormat.BackColor = Farben.OldRuby;
            LabelPasswortVorgaben.BackColor = Farben.OldRuby;
            LabelPasswortFehler.BackColor = Farben.OldRuby;
            LabelSicherheitsfrageGrund.BackColor = Farben.OldRuby;
        }
        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        private void TextboxVorname_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }
        private void TextboxNachname_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }
        private void TextboxEmail_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
            if (RegexEmail(TextboxEmail.Text))
            {
                LabelEmailFormat.Visible = false;
            }
            else if (TextboxEmail.Text == "E-Mail")
            {
                LabelEmailFormat.Visible = false;
            }
            else
            {
                LabelEmailFormat.Visible = true;
            }
        }
        private void TextboxBenutzername_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }
        private void TextboxPasswortR_Leave(object sender, EventArgs e)
        {
            if (TextboxPasswortR.Text != TextboxPasswortWiederholen.Text)
            {
                LabelPasswortFehler.Visible = true;
            }
            else
            {
                LabelPasswortFehler.Visible = false;
            }
        }
        private void TextboxPasswortR_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }
        private void TextboxPasswortWiederholen_Leave(object sender, EventArgs e)
        {
            if (TextboxPasswortR.Text != TextboxPasswortWiederholen.Text)
            {
                LabelPasswortVorgaben.Visible = true;
            }
            else
            {
                LabelPasswortVorgaben.Visible = false;
            }
        }
        private void TextboxPasswortWiederholen_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
            bool istPasswortValidiert = PasswortValidieren(TextboxPasswortR.Text);
            bool stimmtPasswortÜberein = TextboxPasswortR.Text == TextboxPasswortWiederholen.Text;
            if (!stimmtPasswortÜberein)
            {
                LabelPasswortFehler.Visible = true;
            }
            else
            {
                LabelPasswortFehler.Visible = false;
            }
            if (!istPasswortValidiert)
            {
                LabelPasswortVorgaben.Visible = true;
            }
            else
            {
                LabelPasswortVorgaben.Visible = false;
            }
        }
        private void TextboxSicherheitsfrage_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }
        public void RegistrierenKontrolle()
        {
            if (TextboxVorname.Text == "Vorname" || TextboxNachname.Text == "Nachname" || TextboxEmail.Text == "E-Mail" || RegexEmail(TextboxEmail.Text) == false || TextboxBenutzername.Text == "Benutzername" || TextboxPasswortR.Text == "Passwort" || ComboboxSicherheitsfrage.SelectedIndex == -1 || TextboxSicherheitsantwort.Text == "Ihre Antwort..." || TextboxPasswortWiederholen.Text != TextboxPasswortR.Text || TextboxVorname.Text == "" || TextboxNachname.Text == "" || TextboxEmail.Text == "" || TextboxBenutzername.Text == "" || TextboxPasswortR.Text == "" || TextboxSicherheitsantwort.Text == "")
            {
                ButtonJetztRegistrieren.BackColor = Farben.ButtonOpacity;
                ButtonJetztRegistrieren.Enabled = false;
            }
            else
            {
                ButtonJetztRegistrieren.BackColor = Farben.Surfie;
                ButtonJetztRegistrieren.Enabled = true;
            }
        }
        private bool RegexEmail(string Email)
        {
            Regex regex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            bool result;
            result = regex.IsMatch(Email);
            return result;
        }
        private bool PasswortValidieren(string Passwort)
        {
            if (Passwort.Length < 8)
                return false;
            if (!Passwort.Any(char.IsUpper))
                return false;
            if (!Passwort.Any(char.IsLower))
                return false;
            if (!Passwort.Any(char.IsDigit))
                return false;
            if (!Passwort.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }
        private void ButtonJetztRegistrieren_Click(object sender, EventArgs e)
        {           
           
            string vorname = TextboxVorname.Text;
            string nachname = TextboxNachname.Text;
            string email = TextboxEmail.Text;
            string benutzername = TextboxBenutzername.Text;
            string passwort = TextboxPasswortR.Text;
            string sicherheitsfrage = ComboboxSicherheitsfrage.SelectedItem.ToString();
            string sicherheitsantwort = TextboxSicherheitsantwort.Text;
            string status = "Benutzer";
            bool angemeldetBleiben = false;

            if (NEUERBENUTZER())
            {
                InsertData(vorname, nachname, email, benutzername, passwort, sicherheitsfrage, sicherheitsantwort, status, angemeldetBleiben);
                MessageBox.Show("Registrierung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _loginBildschirm.Show();
                this.Close();
            }
            else
            {

            }

        }

        public bool NEUERBENUTZER()
        {
            string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) from Benutzertabelle WHERE benutzername = @Benutzername AND email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Benutzername", TextboxBenutzername.Text);
                    cmd.Parameters.AddWithValue("@Email", TextboxEmail.Text);


                    long Benutzerexistiert = Convert.ToInt64(cmd.ExecuteScalar());
                    if (Benutzerexistiert > 0)
                    {
                        MessageBox.Show("Email und/oder Benutzername bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }


                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) from Benutzertabelle WHERE email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", TextboxEmail.Text);
                    long Benutzerexistiert = Convert.ToInt64(cmd.ExecuteScalar());
                    if (Benutzerexistiert > 0)
                    {
                        MessageBox.Show("Email bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) from Benutzertabelle WHERE benutzername = @Benutzername", conn))
                {
                    cmd.Parameters.AddWithValue("@Benutzername", TextboxBenutzername.Text);
                    long Benutzerexistiert = Convert.ToInt64(cmd.ExecuteScalar());
                    if (Benutzerexistiert > 0)
                    {
                        MessageBox.Show("Benutzername bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
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
        public void InsertData(string vorname, string nachname, string email, string benutzername, string passwort, string sicherheitsfrage, string sicherheitsantwort, string status, bool angemeldetbleiben)
        {
            string passwortHash = HashPasswort(passwort);
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    string sql = @"INSERT INTO BenutzerTabelle (name, vorname, email, benutzername, passworthash, sicherheitsfrage, sicherheitsantwort, status, angemeldetbleiben) 
                           VALUES (@name, @vorname, @email, @benutzername, @passworthash, @sicherheitsfrage, @sicherheitsantwort, @status, @angemeldetbleiben)";
                    using (NpgsqlCommand vCmd = new NpgsqlCommand(sql, vCon))
                    {
                        vCmd.Parameters.AddWithValue("@name", nachname);
                        vCmd.Parameters.AddWithValue("@vorname", vorname);
                        vCmd.Parameters.AddWithValue("@email", email);
                        vCmd.Parameters.AddWithValue("@benutzername", benutzername);
                        vCmd.Parameters.AddWithValue("@passworthash", passwortHash);
                        vCmd.Parameters.AddWithValue("@sicherheitsfrage", sicherheitsfrage);
                        vCmd.Parameters.AddWithValue("@sicherheitsantwort", sicherheitsantwort);
                        vCmd.Parameters.AddWithValue("@status", status);
                        vCmd.Parameters.AddWithValue("@angemeldetbleiben", angemeldetbleiben);

                        vCmd.ExecuteNonQuery();
                        Console.WriteLine("Benutzer erfolgreich hinzugefügt.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    throw;
                }
            }
        }
        private void PictureboxFragezeichen_MouseHover(object sender, EventArgs e)
        {
            LabelSicherheitsfrageGrund.Visible = true;
            ButtonFragezeichen.BackColor = Farben.Illusion;
        }
        private void PictureboxFragezeichen_MouseLeave(object sender, EventArgs e)
        {
            LabelSicherheitsfrageGrund.Visible = false;
            ButtonFragezeichen.BackColor = Farben.Iron;
        }
        private void ButtonZurückR_Click(object sender, EventArgs e)
        {
            this.Hide();
            _loginBildschirm.Show();
        }

        private void ButtonJetztRegistrieren_MouseHover(object sender, EventArgs e)
        {
            ButtonJetztRegistrieren.BackColor = Farben.DarkSurfie;
        }

        private void ButtonJetztRegistrieren_MouseLeave(object sender, EventArgs e)
        {
            ButtonJetztRegistrieren.BackColor = Farben.Surfie;
        }

        private void ButtonJetztRegistrieren_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonJetztRegistrieren.BackColor = Farben.BlueShadow;
        }
        private void Textbox_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.BackColor = Farben.ArcticWhite;

            }
        }
        private void Textbox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.BackColor = Color.White;
            }
        }

        private void ButtonZurückR_MouseHover(object sender, EventArgs e)
        {
            ButtonZurückR.BackColor = Farben.Illusion;
        }

        private void ButtonZurückR_MouseLeave(object sender, EventArgs e)
        {
            ButtonZurückR.BackColor = Farben.Iron;
        }

    }
}
