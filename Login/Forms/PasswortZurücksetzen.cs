using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class PasswortZurücksetzen : Form
    {
        private Form _previousForm;
        private Benutzer _benutzer;
        private Registrierung _registrierung;
        private LoginBildschirm _login;
        private string vStrConnection = "Server=localhost;Port=3169;User Id=postgres;Password=Passwort1!;Database=Datenbank;";
        public PasswortZurücksetzen(Form previousForm, Benutzer benutzer)
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _previousForm = previousForm;
            _registrierung =  new Registrierung();
            _benutzer = benutzer;
            TextboxPwZurücksetzen.UseSystemPasswordChar = true;
            TextboxPWZwiederholen.UseSystemPasswordChar = true;

            //Farben
            ButtonBestätigenPWZ.BackColor = Farben.ButtonOpacity;
            ButtonZurückPWZ.BackColor = Farben.Iron;
            ButtonZurückPWZ.ForeColor = Farben.DeepSky;
            LabelPwZurücksetzen.ForeColor = Farben.ColdMountain;
            LabelPwWiederholen.ForeColor = Farben.ColdMountain;
            TextboxPwZurücksetzen.ForeColor = Farben.DeepSky;
            TextboxPWZwiederholen.ForeColor = Farben.DeepSky;

        }

        private void ButtonZurückPWZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            _previousForm.Show();
        }

        private void PasswortZurücksetzen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TextboxPwZurücksetzen_Enter(object sender, EventArgs e)
        {           
                PasswortKontrolle();           
        }

        private void TextboxPwZurücksetzen_Leave(object sender, EventArgs e)
        {
                PasswortKontrolle();
        }

        private void TextboxPWZwiederholen_Enter(object sender, EventArgs e)
        {
                PasswortKontrolle();
        }

        private void TextboxPWZwiederholen_Leave(object sender, EventArgs e)
        {
                PasswortKontrolle();
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

        private void TextboxPWZwiederholen_TextChanged(object sender, EventArgs e)
        {
            bool istPasswortValidiert = PasswortValidieren(TextboxPwZurücksetzen.Text);
            bool stimmtPasswortÜberein = TextboxPwZurücksetzen.Text == TextboxPWZwiederholen.Text;
            LabelPasswortFehlerZ.Visible = !stimmtPasswortÜberein;
            LabelPasswortVorgabenZ.Visible = !istPasswortValidiert;
            PasswortKontrolle();
        }
        public void PasswortKontrolle()
        {
            if (TextboxPwZurücksetzen.Text == "" || TextboxPWZwiederholen.Text == "" || LabelPasswortFehlerZ.Visible == true || LabelPasswortVorgabenZ.Visible == true)
            {
                ButtonBestätigenPWZ.Enabled = false;
                ButtonBestätigenPWZ.BackColor = Farben.ButtonOpacity;
            }
                
            
            else
            {
                ButtonBestätigenPWZ.Enabled = true;
                ButtonBestätigenPWZ.BackColor = Farben.Surfie;
            }
        }

        private void ButtonBestätigenPWZ_Click(object sender, EventArgs e)
        {
            string neuesPasswort = HashPasswort(TextboxPwZurücksetzen.Text);
            DatenbankService dbService = new DatenbankService();
            bool erfolg = dbService.UpdatePassword(_benutzer.Email, _benutzer.Benutzername, neuesPasswort);

            if (erfolg)
            {
                MessageBox.Show("Das Passwort wurde erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _login = new LoginBildschirm();
                this.Hide();
                _login.Show();
            }
            else
            {
                MessageBox.Show("Fehler beim Aktualisieren des Passworts.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PasswortAktualisieren(string email, string benutzername, string neuesPasswort)
        {
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE \"Benutzertabelle\" SET \"Passworthash\" = @neuesPasswort WHERE \"Email\" = @Email AND \"Benutzername\" = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("neuesPasswort", neuesPasswort);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Benutzername", benutzername);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Das Passwort wurde erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fehler beim Aktualisieren des Passworts.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    


        private void TextboxPwZurücksetzen_TextChanged(object sender, EventArgs e)
        {
            PasswortKontrolle();
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
    }
}

