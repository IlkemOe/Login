using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class PasswortVergessenForm : Form
    {
        private Registrierung _registrierung;
        string CsvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Data\Benutzer.csv");
        private Benutzer _gefundenerBenutzer;
        private SicherheitsabfrageFürPW _sicherheitsabfrageFürPW;
        public PasswortVergessenForm(LoginBildschirm loginBildschirm, Benutzer benutzer)
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _registrierung = new Registrierung();
            _gefundenerBenutzer = benutzer;
            ButtonBestätigenV.Enabled = false;

            //Farben            
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
        private string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        private void PasswortVergessenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void TextboxEmailV_Leave(object sender, EventArgs e)
        {
            if (RegexEmail(TextboxEmailV.Text))
            {
                LabelEmailFormatV.Visible = false;
            }
            else if (TextboxEmailV.Text == "E-Mail")
            {
                LabelEmailFormatV.Visible = false;
            }
            else
            {
                LabelEmailFormatV.Visible = true;
            }
        }
        private void TextboxEmailV_TextChanged(object sender, EventArgs e)
        {
            if (RegexEmail(TextboxEmailV.Text))
            {
                LabelEmailFormatV.Visible = false;
            }
            string email = TextboxBenutzernameV.Text;

            bool emailExistiert = EmailExistiert(email);

            ButtonBestätigenV.Enabled = emailExistiert;

            ButtonBestätigenV.BackColor = emailExistiert ? Farben.Surfie : Farben.ButtonOpacity;


        }
        private void TextboxBenutzernameV_TextChanged(object sender, EventArgs e)
        {

            string benutzername = TextboxBenutzernameV.Text;
            bool benutzerExistiert = BenutzerExistiert(benutzername);

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
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, vCon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
