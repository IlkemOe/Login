using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{

    public partial class SicherheitsabfrageFürPW : Form
    {
        private Form _previousForm;
        private Benutzer _gefundenerBenutzer;
        private Registrierung _registrierung;
        private PasswortZurücksetzen _passwortZurücksetzen;
        public SicherheitsabfrageFürPW(Form previousForm, Benutzer benutzer)
        {
            this.BackColor = Farben.IceWhite;
            InitializeComponent();
            _previousForm = previousForm;
            _gefundenerBenutzer = benutzer;

            //Farben
            LabelFragezeichen.BackColor = Farben.Iron;
            LabelFragezeichen.ForeColor = Farben.ColdMountain;
            LabelErklärung.BackColor = Farben.OldRuby;
            TextboxSIcherheitsfrageAntwort.ForeColor = Farben.DeepSky;
            SicherheitsfrageBeantworten.ForeColor = Farben.ColdMountain;
            ButtonZurückPWV.BackColor = Farben.Iron;
            ButtonZurückPWV.ForeColor = Farben.DeepSky;
            ButtonÜberprüfen.BackColor = Farben.Surfie;

            ComboboxSicherheitsfrageAuswählen.Items.Add(_gefundenerBenutzer.Sicherheitsfrage);
            ComboboxSicherheitsfrageAuswählen.SelectedIndex = 0;
        }

        private void LabelFragezeichen_MouseHover(object sender, EventArgs e)
        {
            LabelErklärung.Visible = true;
        }

        private void LabelFragezeichen_MouseLeave(object sender, EventArgs e)
        {
            LabelErklärung.Visible = false;
        }

        private void SicherheitsabfrageFürPW_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            else if(!_gefundenerBenutzer.Sicherheitsantwort.Equals(benutzerAntwort))
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
    }
}
