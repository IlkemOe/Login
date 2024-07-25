using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Login.Forms
{
    public partial class BearbeitenBenutzer : Form
    {
        private string _email;
        private Homescreen _homescreen;
        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        public BearbeitenBenutzer(string email, Homescreen homescreen)
        {
            InitializeComponent();
            _email = email;
            _homescreen = homescreen;
            LoadUserData();
        }

        private void LoadUserData()
        {
            
            DataTable dt = _homescreen.getdata($"SELECT * FROM benutzerTabelle WHERE email = '{_email}'");
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                TextboxNachname.Text = row["name"].ToString();
                TextboxVorname.Text = row["Vorname"].ToString();
                TextboxEmail.Text = row["email"].ToString();
                TextboxBenutzername.Text = row["benutzername"].ToString();
                ComboboxSicherheitsfrage.Text = row["sicherheitsfrage"].ToString();
                TextboxSicherheitsantwort.Text = row["sicherheitsantwort"].ToString();
                CheckboxStatus.Checked = row["status"].ToString() == "Admin";
                //CheckboxAngemeldetBleiben.Checked = Convert.ToBoolean(row["angemeldetbleiben"]);
                TextboxPasswort.Text = "";
                TextboxPasswortWiederholen.Text = "";
            }

        }
        
        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
                {

                    vCon.Open();
                    string status = CheckboxStatus.Checked ? "Admin" : "Benutzer";
                    string sqlUpdate = @"UPDATE benutzerTabelle
                                         SET name = @name, 
                                             vorname = @vorname, 
                                             benutzername = @benutzername, 
                                             passworthash = @passworthash, 
                                             sicherheitsfrage = @sicherheitsfrage, 
                                             sicherheitsantwort = @sicherheitsantwort, 
                                             status = @status, 
                                             angemeldetbleiben = @angemeldetbleiben
                                         WHERE email = @original_email";
                    using (NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, vCon))
                    {
                        cmdUpdate.Parameters.AddWithValue("@name", TextboxNachname.Text);
                        cmdUpdate.Parameters.AddWithValue("@Vorname", TextboxVorname.Text);
                        cmdUpdate.Parameters.AddWithValue("@original_email", _email);
                        cmdUpdate.Parameters.AddWithValue("@benutzername", TextboxBenutzername.Text);
                        cmdUpdate.Parameters.AddWithValue("@passworthash", HashPasswort(TextboxPasswort.Text)); // Hash-Funktion für das Passwort
                        cmdUpdate.Parameters.AddWithValue("@sicherheitsfrage", ComboboxSicherheitsfrage.Text);
                        cmdUpdate.Parameters.AddWithValue("@sicherheitsantwort", TextboxSicherheitsantwort.Text);
                        cmdUpdate.Parameters.AddWithValue("@status", status);
                        //cmdUpdate.Parameters.AddWithValue("@angemeldetbleiben", checkBoxAngemeldetBleiben.Checked);

                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Daten wurden erfolgreich aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der Daten: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string HashPasswort(string passwort)
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
        
    }
}
