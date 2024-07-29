using Npgsql;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login
{
    public partial class PasswortVergessenForm : Form
    {
        private Registrierung _registrierung;
        private Benutzer _gefundenerBenutzer;
        private SicherheitsabfrageFürPW _sicherheitsabfrageFürPW;
        private readonly string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        public PasswortVergessenForm(LoginBildschirm loginBildschirm, Benutzer benutzer)
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _registrierung = new Registrierung();
            _gefundenerBenutzer = benutzer;

            setzeFarben();
            AddEventHandler();         
        }

       
        private void setzeFarben()
        {
            LabelEmailV.ForeColor = Farben.ColdMountain;
            LabelBenutzernameV.ForeColor = Farben.ColdMountain;
            TextboxEmailV.ForeColor = Farben.DeepSky;
            TextboxBenutzernameV.ForeColor = Farben.DeepSky;
            LabelHinweis.BackColor = Farben.SisterAct;
            LabelEmailFormatV.BackColor = Farben.OldRuby;
            LabelEmailNichtVerfügbarV.BackColor = Farben.OldRuby;
            ButtonBestätigenV.BackColor = Farben.ButtonOpacity;
            ButtonZurückPasswortVergessen.ForeColor = Farben.DeepSky;
            ButtonZurückPasswortVergessen.BackColor = Farben.Iron;
        }
        

        private void AddEventHandler()
        {
            TextboxEmailV.TextChanged += TextboxEmailV_TextChanged;
            TextboxEmailV.Leave += TextboxEmailV_Leave;
            TextboxBenutzernameV.TextChanged += TextboxBenutzernameV_TextChanged;
            ButtonBestätigenV.Click += ButtonBestätigenV_Click;
            ButtonZurückPasswortVergessen.Click += ButtonZurückPasswortVergessen_Click;
            ButtonZurückPasswortVergessen.MouseHover += ButtonZurückPasswortVergessen_MouseHover;
            ButtonZurückPasswortVergessen.MouseLeave += ButtonZurückPasswortVergessen_MouseLeave;
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                textBox.MouseHover += Textbox_MouseHover;
                textBox.MouseLeave += Textbox_MouseLeave;
            }
        }


        //Anwendung schließen
        private void PasswortVergessenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void TextboxEmailV_Leave(object sender, EventArgs e)
        {
            LabelEmailFormatV.Visible = !RegexEmail(TextboxEmailV.Text) && TextboxEmailV.Text != "E-Mail";
        }


        private void TextboxEmailV_TextChanged(object sender, EventArgs e)
        {
            bool emailExistiert = EmailExistiert(TextboxEmailV.Text);

            ButtonBestätigenV.Enabled = emailExistiert;
            ButtonBestätigenV.BackColor = emailExistiert ? Farben.Surfie : Farben.ButtonOpacity;

            LabelEmailFormatV.Visible = !RegexEmail(TextboxEmailV.Text) && TextboxEmailV.Text != "E-Mail";
        }


        private void TextboxBenutzernameV_TextChanged(object sender, EventArgs e)
        {
            bool benutzerExistiert = BenutzerExistiert(TextboxBenutzernameV.Text);

            ButtonBestätigenV.Enabled = benutzerExistiert;
            ButtonBestätigenV.BackColor = benutzerExistiert ? Farben.Surfie : Farben.ButtonOpacity;
        }        


        public bool RegexEmail(string email)
        {
            Regex regex = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return regex.IsMatch(email);
        }


        private bool EmailExistiert(string email)
        {
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                vCon.Open();
                string query = "SELECT COUNT(*) FROM benutzertabelle WHERE email = @Email";
                using (var cmd = new NpgsqlCommand(query, vCon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }


        private bool BenutzerExistiert(string benutzername)
        {
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                vCon.Open();
                string query = "SELECT COUNT(*) FROM benutzertabelle WHERE benutzername = @Benutzername";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, vCon))
                {
                    cmd.Parameters.AddWithValue("@Benutzername", benutzername);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        private void ButtonBestätigenV_Click(object sender, EventArgs e)
        {
            _gefundenerBenutzer = FindeBenutzer(TextboxEmailV.Text, TextboxBenutzernameV.Text);
            if (_gefundenerBenutzer != null)
            {
                LabelEmailNichtVerfügbarV.Visible = false;
                _sicherheitsabfrageFürPW = new SicherheitsabfrageFürPW(this, _gefundenerBenutzer);               
                this.Hide();
                _sicherheitsabfrageFürPW.Show();
            }
            else
            {
                LabelEmailNichtVerfügbarV.Visible = true;
            }
        }


        private Benutzer FindeBenutzer(string email, string benutzername)
        {
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                vCon.Open();
                string query = "SELECT * FROM benutzerTabelle WHERE email = @Email And benutzername = @Benutzername";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, vCon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Benutzername", benutzername);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Benutzer
                            {
                                Nachname = reader["name"].ToString(),
                                Vorname = reader["vorname"].ToString(),
                                Email = reader["email"].ToString(),
                                Benutzername = reader["benutzername"].ToString(),
                                PasswortHash = reader["passworthash"].ToString(),
                                Sicherheitsfrage = reader["sicherheitsfrage"].ToString(),
                                Sicherheitsantwort = reader["sicherheitsantwort"].ToString(),
                                Status = reader["status"].ToString(),
                                AngemeldetBleiben = Convert.ToBoolean(reader["angemeldetbleiben"])
                            };
                        }
                    }
                }
            }
            return null;
        }


        private void ButtonZurückPasswortVergessen_Click(object sender, EventArgs e)
        {
            LoginBildschirm loginForm = Application.OpenForms.OfType<LoginBildschirm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.Show();
            }
            this.Hide();
        }


        private void ButtonZurückPasswortVergessen_MouseHover(object sender, EventArgs e)
        {
            ButtonZurückPasswortVergessen.BackColor = Farben.Illusion;
        }


        private void ButtonZurückPasswortVergessen_MouseLeave(object sender, EventArgs e)
        {
            ButtonZurückPasswortVergessen.BackColor = Farben.Iron;
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
