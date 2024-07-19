using Npgsql;
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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{

    public partial class Homescreen : Form
    {
        private string _benutzername;
        private string _status;
        private bool _angemeldetBleiben;
        private Registrierung _registrierung;
        public Homescreen(string benutzernameOderEmail, string status, bool angemeldetBleiben)
        {
            this.BackColor = Farben.ArcticWhite;
            InitializeComponent();
            _benutzername = benutzernameOderEmail;
            _status = status;
            LabelBenutzername.Text = $"Herzlich Willkommen, {_benutzername}!";
            LabelStatus.Text = $"Status: {_status}";
            _angemeldetBleiben = angemeldetBleiben;
            _registrierung = new Registrierung();
            dg.Visible = false;
            dg.ReadOnly = false;
            //Farben
            LabelBenutzername.ForeColor = Farben.DeepSky;
            LabelStatus.ForeColor = Farben.DeepSky;
            LabelAnmeldeNachricht.ForeColor = Farben.DeepSky;
            LabelDatum.ForeColor = Farben.DeepSky;
            LabelUhrzeit.ForeColor = Farben.DeepSky;
            ButtonLogout.BackColor = Farben.Iron;
            ButtonLogout.ForeColor = Farben.DeepSky;
            ButtonBenutzerliste.BackColor = Farben.Surfie;
            ButtonSpeichern.BackColor = Farben.Iron;
            ButtonSpeichern.ForeColor = Farben.DeepSky;
        }
        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;
        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }

            vCon.Open();
        }
        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();
                    using (NpgsqlCommand vCmd = new NpgsqlCommand(sql, vCon))
                    {
                        using (NpgsqlDataReader dr = vCmd.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return dt;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            string email = _benutzername;
            bool angemeldetBleiben = _angemeldetBleiben;
            var ausloggen = MessageBox.Show("Möchten Sie sich wirklich ausloggen?", "Ausloggen?", MessageBoxButtons.YesNo);
            if (ausloggen == DialogResult.Yes)
            {
                _registrierung.SetzeAngemeldetBleibenAufFalse(email, angemeldetBleiben);
                this.Hide();
                LoginBildschirm loginBildschirm = new LoginBildschirm();
                loginBildschirm.Show();
            }

        }

        private void Homescreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Homescreen_Load(object sender, EventArgs e)
        {

            TimerUhrzeit.Start();
            LabelUhrzeit.Text = DateTime.Now.ToLongTimeString();
            LabelDatum.Text = DateTime.Now.ToLongDateString();

            Console.WriteLine("Homescreen_Load aufgerufen");
            Console.WriteLine($"Benutzername: {_benutzername}, Status: {_status}");

            if (_status == "Admin")
            {
                ButtonBenutzerliste.Visible = true;
            }

        }

        private void TimerUhrzeit_Tick(object sender, EventArgs e)
        {
            LabelUhrzeit.Text = DateTime.Now.ToLongTimeString();
            TimerUhrzeit.Start();
        }

        private void ButtonBenutzerliste_Click(object sender, EventArgs e)
        {
            if (_status == "Admin")
            {
                dg.Visible = true;
                ButtonSpeichern.Visible = true;
                //dg.EditMode = DataGridViewEditMode.EditOnEnter;
                DataTable dtgetdata = getdata("SELECT * FROM benutzerTabelle;");
                dg.DataSource = dtgetdata;

                // Optional: Konfiguration des DataGridView für die Bearbeitung
                dg.ReadOnly = false;
                dg.AllowUserToAddRows = true;
                dg.AllowUserToDeleteRows = true;
            }
            else
            {
                MessageBox.Show("Sie haben keine Berechtigung, die Benutzerliste zu bearbeiten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            
                // Beispiel: Speichern der geänderten Daten im DataGridView zurück in die Datenbank
                DataTable dt = (DataTable)dg.DataSource;
                UpdateDatabase(dt); // Implementieren Sie diese Methode entsprechend
            
        }
        private void UpdateDatabase(DataTable dt)
        {
            using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
            {
                try
                {
                    vCon.Open();

                    // Loop through each row in the DataTable
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                        {
                            // INSERT new record
                            string sqlInsert = "INSERT INTO benutzerTabelle (name, vorname, email, benutzername, passworthash, sicherheitsfrage, sicherheitsantwort, status, angemeldetbleiben) " +
                                               "VALUES (@name, @vorname, @email, @benutzername, @passworthash, @sicherheitsfrage, @sicherheitsantwort, @status, @angemeldetbleiben)";
                            using (NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, vCon))
                            {
                                cmdInsert.Parameters.AddWithValue("@name", row["name"]);
                                cmdInsert.Parameters.AddWithValue("@vorname", row["vorname"]);
                                cmdInsert.Parameters.AddWithValue("@email", row["email"]);
                                cmdInsert.Parameters.AddWithValue("@benutzername", row["benutzername"]);
                                cmdInsert.Parameters.AddWithValue("@passworthash", row["passworthash"]);
                                cmdInsert.Parameters.AddWithValue("@sicherheitsfrage", row["sicherheitsfrage"]);
                                cmdInsert.Parameters.AddWithValue("@sicherheitsantwort", row["sicherheitsantwort"]);
                                cmdInsert.Parameters.AddWithValue("@status", row["status"]);
                                cmdInsert.Parameters.AddWithValue("@angemeldetbleiben", row["angemeldetbleiben"]);

                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Modified)
                        {
                            // UPDATE existing record
                            string sqlUpdate = "UPDATE benutzerTabelle " +
                                               "SET name = @name, " +
                                                   "vorname = @vorname, " +
                                                   "email = @email, " +
                                                   "benutzername = @benutzername, " +
                                                   "passworthash = @passworthash, " +
                                                   "sicherheitsfrage = @sicherheitsfrage, " +
                                                   "sicherheitsantwort = @sicherheitsantwort, " +
                                                   "status = @status, " +
                                                   "angemeldetbleiben = @angemeldetbleiben " +
                                               "WHERE email = @original_email"; 

                            using (NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, vCon))
                            {
                                cmdUpdate.Parameters.AddWithValue("@name", row["name"]);
                                cmdUpdate.Parameters.AddWithValue("@vorname", row["vorname"]);
                                cmdUpdate.Parameters.AddWithValue("@email", row["email"]);
                                cmdUpdate.Parameters.AddWithValue("@benutzername", row["benutzername"]);
                                cmdUpdate.Parameters.AddWithValue("@passworthash", row["passworthash"]);
                                cmdUpdate.Parameters.AddWithValue("@sicherheitsfrage", row["sicherheitsfrage"]);
                                cmdUpdate.Parameters.AddWithValue("@sicherheitsantwort", row["sicherheitsantwort"]);
                                cmdUpdate.Parameters.AddWithValue("@status", row["status"]);
                                cmdUpdate.Parameters.AddWithValue("@angemeldetbleiben", row["angemeldetbleiben"]);
                                cmdUpdate.Parameters.AddWithValue("@original_email", row["email", DataRowVersion.Original]);

                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else if (row.RowState == DataRowState.Deleted)
                        {
                            // DELETE record
                            string sqlDelete = "DELETE FROM benutzerTabelle WHERE email = @original_email";
                            using (NpgsqlCommand cmdDelete = new NpgsqlCommand(sqlDelete, vCon))
                            {
                                cmdDelete.Parameters.AddWithValue("@original_email", row["email", DataRowVersion.Original]);
                                cmdDelete.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Daten erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Aktualisieren der Datenbank: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
    

