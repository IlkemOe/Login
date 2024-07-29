using Npgsql;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{

    public partial class SicherheitsabfrageFürPW : Form
    {
        private Form _previousForm;
        private Benutzer _gefundenerBenutzer;
        private Registrierung _registrierung;
        private PasswortZurücksetzen _passwortZurücksetzen;
        private readonly string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        public SicherheitsabfrageFürPW(Form previousForm, Benutzer benutzer)
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _previousForm = previousForm;
            _gefundenerBenutzer = benutzer;

            setzeFarben(); 
    
            string sicherheitsfrage = GetSicherheitsfrage(benutzer.Email);
            if (sicherheitsfrage != null)
            {
                ComboboxSicherheitsfrageAuswählen.Items.Add(_gefundenerBenutzer.Sicherheitsfrage);
                ComboboxSicherheitsfrageAuswählen.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Fehler beim Abrufen der Sicherheitsfrage.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            AddEventHandler();
        }


        private void setzeFarben()
        {
            LabelFragezeichen.BackColor = Farben.Iron;
            LabelFragezeichen.ForeColor = Farben.ColdMountain;
            LabelErklärung.BackColor = Farben.OldRuby;
            TextboxSIcherheitsfrageAntwort.ForeColor = Farben.DeepSky;
            SicherheitsfrageBeantworten.ForeColor = Farben.ColdMountain;
            ButtonZurückPWV.BackColor = Farben.Iron;
            ButtonZurückPWV.ForeColor = Farben.DeepSky;
            ButtonÜberprüfen.BackColor = Farben.Surfie;
        }


        private void AddEventHandler()
        {
            LabelFragezeichen.MouseHover += LabelFragezeichen_MouseHover;
            LabelFragezeichen.MouseLeave += LabelFragezeichen_MouseLeave;
            ButtonZurückPWV.Click += ButtonZurückPWV_Click;
            ButtonÜberprüfen.Click += ButtonÜberprüfen_Click;
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                textBox.MouseHover += Textbox_MouseHover;
                textBox.MouseLeave += Textbox_MouseLeave;
            }
        }


        private string GetSicherheitsfrage(string email)
        {
            string sicherheitsfrage = null;
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    string sql = "SELECT sicherheitsfrage FROM benutzerTabelle WHERE email = @Email";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, vCon))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        sicherheitsfrage = cmd.ExecuteScalar()?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Abrufen der Sicherheitsfrage: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return sicherheitsfrage;
        }


        private void LabelFragezeichen_MouseHover(object sender, EventArgs e)
        {
            LabelErklärung.Visible = true;
        }


        private void LabelFragezeichen_MouseLeave(object sender, EventArgs e)
        {
            LabelErklärung.Visible = false;
        }


        private void ButtonZurückPWV_Click(object sender, EventArgs e)
        {
            this.Hide();
            _previousForm.Show();           
        }

        private void ButtonÜberprüfen_Click(object sender, EventArgs e)
        {
            string benutzerAntwort = TextboxSIcherheitsfrageAntwort.Text;
            string gewählteFrage = ComboboxSicherheitsfrageAuswählen.SelectedItem.ToString();
            if (!_gefundenerBenutzer.Sicherheitsfrage.Equals(gewählteFrage, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Die ausgewählte Frage stimmt nicht überein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!_gefundenerBenutzer.Sicherheitsantwort.Equals(benutzerAntwort, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Die Antwort ist nicht korrekt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sie können nun ein neues Passwort eingeben.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _passwortZurücksetzen = new PasswortZurücksetzen(this, _gefundenerBenutzer);
                this.Hide();
                _passwortZurücksetzen.Show();
            }
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


        private void SicherheitsabfrageFürPW_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
