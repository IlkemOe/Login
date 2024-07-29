using Npgsql;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class RegistrierungForm : Form
    {

        private LoginBildschirm _loginBildschirm;
        private Registrierung _registrierung;
        private readonly string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";


        public RegistrierungForm(LoginBildschirm loginBildschirm)
        {
            this.BackColor = Farben.IceWhite;
            
            InitializeComponent();
            _loginBildschirm = loginBildschirm;
            _registrierung = new Registrierung();

            InitializeForm();
        }

        private void InitializeForm()
        {
            TextboxPasswortR.UseSystemPasswordChar = true;
            TextboxPasswortWiederholen.UseSystemPasswordChar = true;

            setzeFarben();

            AddEventHandlers();
        }


        private void setzeFarben()
        {
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


        //Kontrolliert änderungen in Feldern
        private void AddEventHandlers()
        {
            TextboxVorname.TextChanged += Textbox_TextChanged;
            TextboxNachname.TextChanged += Textbox_TextChanged;
            TextboxEmail.TextChanged += TextboxEmail_TextChanged;
            TextboxBenutzername.TextChanged += Textbox_TextChanged;
            TextboxPasswortR.TextChanged += TextboxPasswortR_TextChanged;
            TextboxPasswortR.Leave += TextboxPasswortR_Leave;
            TextboxPasswortWiederholen.TextChanged += TextboxPasswortWiederholen_TextChanged;
            TextboxPasswortWiederholen.Leave += TextboxPasswortWiederholen_Leave;
            TextboxSicherheitsantwort.TextChanged += Textbox_TextChanged;
            ButtonJetztRegistrieren.Click += ButtonJetztRegistrieren_Click;
            ButtonZurückR.Click += ButtonZurückR_Click;
            ButtonFragezeichen.MouseHover += PictureboxFragezeichen_MouseHover;
            ButtonFragezeichen.MouseLeave += PictureboxFragezeichen_MouseLeave;
            ButtonJetztRegistrieren.MouseHover += ButtonJetztRegistrieren_MouseHover;
            ButtonJetztRegistrieren.MouseLeave += ButtonJetztRegistrieren_MouseLeave;
            ButtonJetztRegistrieren.MouseDown += ButtonJetztRegistrieren_MouseDown;
            ButtonZurückR.MouseHover += ButtonZurückR_MouseHover;
            ButtonZurückR.MouseLeave += ButtonZurückR_MouseLeave;
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                textBox.MouseHover += Textbox_MouseHover;
                textBox.MouseLeave += Textbox_MouseLeave;
            }
        }


        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }


        private void TextboxEmail_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
            RegistrierenKontrolle();
            LabelEmailFormat.Visible = !RegexEmail(TextboxEmail.Text) && TextboxEmail.Text != "E-Mail";
        }


        private void TextboxPasswortR_Leave(object sender, EventArgs e)
        {
            LabelPasswortFehler.Visible = TextboxPasswortR.Text != TextboxPasswortWiederholen.Text;
        }


        private void TextboxPasswortR_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }


        private void TextboxPasswortWiederholen_Leave(object sender, EventArgs e)
        {
            LabelPasswortVorgaben.Visible = TextboxPasswortR.Text != TextboxPasswortWiederholen.Text;
        }


        private void TextboxPasswortWiederholen_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
            bool istPasswortValidiert = PasswortValidieren(TextboxPasswortR.Text);
            bool stimmtPasswortÜberein = TextboxPasswortR.Text == TextboxPasswortWiederholen.Text;
            LabelPasswortFehler.Visible = !stimmtPasswortÜberein;
            LabelPasswortVorgaben.Visible = !istPasswortValidiert;
        }


        private void TextboxSicherheitsfrage_TextChanged(object sender, EventArgs e)
        {
            RegistrierenKontrolle();
        }


        public void RegistrierenKontrolle()
        {
            bool isFormValid = TextboxVorname.Text != "Vorname" && !string.IsNullOrEmpty(TextboxVorname.Text) &&
                               TextboxNachname.Text != "Nachname" && !string.IsNullOrEmpty(TextboxNachname.Text) &&
                               RegexEmail(TextboxEmail.Text) && TextboxEmail.Text != "E-Mail" &&
                               TextboxBenutzername.Text != "Benutzername" && !string.IsNullOrEmpty(TextboxBenutzername.Text) &&
                               TextboxPasswortR.Text != "Passwort" && !string.IsNullOrEmpty(TextboxPasswortR.Text) &&
                               ComboboxSicherheitsfrage.SelectedIndex != -1 &&
                               TextboxSicherheitsantwort.Text != "Ihre Antwort..." && !string.IsNullOrEmpty(TextboxSicherheitsantwort.Text) &&
                               TextboxPasswortR.Text == TextboxPasswortWiederholen.Text;

            ButtonJetztRegistrieren.BackColor = isFormValid ? Farben.Surfie : Farben.ButtonOpacity;
            ButtonJetztRegistrieren.Enabled = isFormValid;
        }


        private bool RegexEmail(string email)
        {
            Regex regex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return regex.IsMatch(email);
        }


        private bool PasswortValidieren(string passwort)
        {
            return passwort.Length >= 8 &&
                   passwort.Any(char.IsUpper) &&
                   passwort.Any(char.IsLower) &&
                   passwort.Any(char.IsDigit) &&
                   passwort.Any(ch => !char.IsLetterOrDigit(ch));
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

            if (IstNeuerBenutzer())
            {
                InsertData(vorname, nachname, email, benutzername, passwort, sicherheitsfrage, sicherheitsantwort, status, angemeldetBleiben);
                MessageBox.Show("Registrierung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _loginBildschirm.Show();
                this.Close();
            }
        }


        public bool IstNeuerBenutzer()
        {
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();
                bool benutzerExistiert = false;

                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM Benutzertabelle WHERE benutzername = @Benutzername OR email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Benutzername", TextboxBenutzername.Text);
                    cmd.Parameters.AddWithValue("@Email", TextboxEmail.Text);
                    benutzerExistiert = Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                }

                if (benutzerExistiert)
                {
                    MessageBox.Show("Email und/oder Benutzername bereits vergeben!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
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
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public void InsertData(string vorname, string nachname, string email, string benutzername, string passwort, string sicherheitsfrage, string sicherheitsantwort, string status, bool angemeldetbleiben)
        {
            string passwortHash = HashPasswort(passwort);
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
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
