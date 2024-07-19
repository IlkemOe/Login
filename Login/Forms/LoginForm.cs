using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Svg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using Login.Forms;
using Npgsql;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Security.Cryptography;

namespace Login
{
    public partial class LoginBildschirm : Form
    {
        private Registrierung _registrierung;

        public LoginBildschirm()
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _registrierung = new Registrierung();
            ButtonLogin.Enabled = false;
            TextfeldPasswort.UseSystemPasswordChar = false;
            SetTextBoxPadding(this.TextfeldEmail, new Padding(8));
            
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


            ÜberprüfeAngemeldetenBenutzer();
        }
       
        private void ÜberprüfeAngemeldetenBenutzer()
        {
            Benutzer angemeldeterBenutzer = _registrierung.FindeAngemeldetenBenutzer();
            if (angemeldeterBenutzer != null)
            {
                Homescreen homescreen = new Homescreen(angemeldeterBenutzer.Benutzername, angemeldeterBenutzer.Status, angemeldeterBenutzer.AngemeldetBleiben);
                homescreen.Show();
                this.Hide();
            }
        }
        private void TextfeldPasswort_Enter(object sender, EventArgs e)
        {
            TextfeldPasswort.UseSystemPasswordChar = true;
            ButtonPasswortSicherheit.Visible = true;
        }
        //Login Button Sichtbarkeit
        private void TextfeldEmail_TextChanged(object sender, EventArgs e)
        {

            if (TextfeldEmail.Text == "E-Mail / Benutzername" || TextfeldPasswort.Text == "" || TextfeldEmail.Text == "")
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
            if (TextfeldEmail.Text == "E-Mail / Benutzername" || TextfeldPasswort.Text == "" || TextfeldEmail.Text == "")
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
        private void ButtonRegistrieren_Click(object sender, EventArgs e)
        {
            RegistrierungForm registrierung = new RegistrierungForm(this);
            registrierung.Show();
            this.Hide();


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
        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        private bool BenutzerAnmelden(string benutzernameOderEmail, string passwort)
        {

            string passwortHash = HashPasswort(passwort);

            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    string sql = "SELECT COUNT(*) FROM BenutzerTabelle WHERE (benutzername = @benutzernameOderEmail OR email = @benutzernameOderEmail) AND passworthash = @passwortHash";
                    using (NpgsqlCommand vCmd = new NpgsqlCommand(sql, vCon))
                    {
                        vCmd.Parameters.AddWithValue("@benutzernameOderEmail", benutzernameOderEmail);
                        if (benutzernameOderEmail == "root")
                        {
                            vCmd.Parameters.AddWithValue("@passwortHash", passwort);
                        }
                        else
                        {
                            vCmd.Parameters.AddWithValue("@passwortHash", passwortHash);
                        }

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
        private string BenutzerStatus(string benutzernameOderEmail)
        {
            string status = string.Empty;

            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    string sql = "SELECT status FROM BenutzerTabelle WHERE benutzername = @benutzername OR email = @benutzername";
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
        public void ButtonLogin_Click(object sender, EventArgs e)
        {

            string benutzernameOderEmail = TextfeldEmail.Text;
            string passwort = TextfeldPasswort.Text;
            bool loggedIN = BenutzerAnmelden(benutzernameOderEmail, passwort);
            string status = BenutzerStatus(benutzernameOderEmail);
            bool angemeldetBleiben = CheckboxAngemeldetbBleiben.Checked;
            if (loggedIN)
            {
                Homescreen homescreen = new Homescreen(benutzernameOderEmail, status, angemeldetBleiben);
                homescreen.Show();
                this.Hide();
                MessageBox.Show("Login erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }   
            
            else
                
            {
                MessageBox.Show("Fehler bei der Anmeldung. Überprüfen Sie Ihre Anmeldeinformationen.");
                // Anzeige einer Fehlermeldung oder erneuter Anmeldeversuch
            }
        }
        //    try
        //    {
        //        bool erfolgreichAngemeldet = false;
        //        string benutzername = string.Empty;
        //        string email = string.Empty;
        //        string status = string.Empty;
        //        bool angemeldetBleiben = CheckboxAngemeldetbBleiben.Checked;
        //        if (emailOderBenutzername.Contains("@"))
        //        {
        //            erfolgreichAngemeldet = _registrierung.KontrolliereEmailundPasswort(emailOderBenutzername, passwort);
        //            if (erfolgreichAngemeldet)
        //            {
        //                email = emailOderBenutzername;
        //                benutzername = _registrierung.FindeBenutzernameVonEmail(email);
        //            }
        //        }
        //        else
        //        {
        //            erfolgreichAngemeldet = _registrierung.KontrolliereBenutzernameundPasswort(emailOderBenutzername, passwort);
        //            if (erfolgreichAngemeldet)
        //            {
        //                benutzername = emailOderBenutzername;
        //                email = _registrierung.FindeEmailVonBenutzer(benutzername);
        //            }
        //        }
        //        if (erfolgreichAngemeldet)
        //        {
        //            _registrierung.SetzeAngemeldetBleiben(email, angemeldetBleiben);
        //            status = _registrierung.FindeStatusVonEmail(benutzername);

        //            Homescreen homescreen = new Homescreen(benutzername, status, angemeldetBleiben);
        //            homescreen.Show();
        //            this.Hide();

        //            MessageBox.Show("Login erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        else
        //        {
        //            MessageBox.Show("Ungültige E-Mail/Benutzername oder Passwort.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void linkLabelPasswortVergessen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PasswortVergessenForm passwortVergessen = new PasswortVergessenForm(this, null);
            passwortVergessen.Show();
            this.Hide();
        }

        private void LoginBildschirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginBildschirm_Load(object sender, EventArgs e)
        {          
            if (CheckboxAngemeldetbBleiben.Checked == true)
            {
                ButtonPasswortSicherheit.Enabled = false;
            }
            else
            {
                ButtonPasswortSicherheit.Enabled = true;
            }
        }

        private void ButtonRegistrieren_MouseHover(object sender, EventArgs e)
        {
            ButtonRegistrieren.BackColor = Farben.Illusion;
        }
        private void ButtonRegistrieren_MouseLeave(object sender, EventArgs e)
        {
            ButtonRegistrieren.BackColor = Farben.Iron;
        }
        private void ButtonRegistrieren_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonRegistrieren.BackColor = Farben.Mystic;
        }

        private void ButtonLogin_MouseHover(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = Farben.BlueShadow;
        }

        private void ButtonLogin_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogin.BackColor = Farben.Surfie;
        }

        private void ButtonLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonLogin.BackColor = Farben.DarkSurfie;
        }

        private void ButtonPasswortSicherheit_MouseHover(object sender, EventArgs e)
        {
            ButtonPasswortSicherheit.BackColor = Farben.DarkSurfie;
        }

        private void ButtonPasswortSicherheit_MouseLeave(object sender, EventArgs e)
        {
            ButtonPasswortSicherheit.BackColor = Farben.Surfie;
        }

        private void ButtonPasswortSicherheit_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonPasswortSicherheit.BackColor = Farben.DarkSurfie;
        }

        private void TextfeldEmail_MouseHover(object sender, EventArgs e)
        {
            TextfeldEmail.BackColor = Farben.ArcticWhite;
        }

        private void TextfeldEmail_MouseLeave(object sender, EventArgs e)
        {
            TextfeldEmail.BackColor = Color.White;
        }

        private void TextfeldPasswort_MouseHover(object sender, EventArgs e)
        {
            TextfeldPasswort.BackColor = Farben.ArcticWhite;
        }

        private void TextfeldPasswort_MouseLeave(object sender, EventArgs e)
        {
            TextfeldPasswort.BackColor = Color.White;
        }

        private void SetTextBoxPadding(System.Windows.Forms.TextBox textBox, Padding padding)
        {
            textBox.Padding = padding;
        }

        private void SetButtonPadding(System.Windows.Forms.Button button, Padding padding)
        {
            button.Padding = padding;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
