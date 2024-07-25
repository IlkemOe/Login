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
using Login.Forms;

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
            ButtonSpeichern.BackColor = Farben.Surfie;
            ButtonNeu.ForeColor = Farben.Surfie;

        }

        string vStrConnection = "Server=localhost; port=3169 ; user id=postgres ; password=Passwort1!; Database=Datenbank;";

        private void connection()
        {
            NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection);
            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
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
                ButtonBenutzerliste.Visible = false;
                DataTable dtgetdata = getdata("SELECT * FROM benutzerTabelle;");
                dg.DataSource = dtgetdata;
                dg.ReadOnly = false;
                dg.AllowUserToAddRows = true;
                dg.AllowUserToDeleteRows = true;
                dg.EditMode = DataGridViewEditMode.EditOnEnter;
                ButtonBenutzerliste.Visible = false;
                ButtonNeu.Visible = true;
                ButtonBearbeiten.Visible = true;
                ButtonLöschen.Visible = true;
                dg.ClearSelection();
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
            DataTable dtgetdata = getdata("SELECT * FROM benutzerTabelle;");
            dg.DataSource = dtgetdata;
            dg.ClearSelection();

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
                            List<string> sqlInsertList = new List<string>
                            {
                                "INSERT INTO benutzerTabelle (name, vorname, email, benutzername, passworthash, sicherheitsfrage, sicherheitsantwort, status, angemeldetbleiben)",
                                "VALUES (@name, @vorname, @email, @benutzername, @passworthash, @sicherheitsfrage, @sicherheitsantwort, @status, @angemeldetbleiben)"
                            };

                            string sqlInsert = string.Join(" ", sqlInsertList);
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
                            List<string> sqlUpdateList = new List<string>
                            {
                                "UPDATE benutzerTabelle",
                                "SET name = @name,",
                                "vorname = @vorname,",
                                "email = @email,",
                                "benutzername = @benutzername,",
                                "passworthash = @passworthash,",
                                "sicherheitsfrage = @sicherheitsfrage,",
                                "sicherheitsantwort = @sicherheitsantwort,",
                                "status = @status,",
                                "angemeldetbleiben = @angemeldetbleiben",
                                "WHERE email = @original_email"
                            };
                            string sqlUpdate = string.Join(" ", sqlUpdateList);

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
                            List<string> sqlDeleteList = new List<string>
                            {
                                "DELETE FROM benutzerTabelle",
                                "WHERE email = @original_email"
                            };

                            string sqlDelete = string.Join(" ", sqlDeleteList);
                            using (NpgsqlCommand cmdDelete = new NpgsqlCommand(sqlDelete, vCon))
                            {
                                cmdDelete.Parameters.AddWithValue("@original_email", row["email", DataRowVersion.Original]);
                                cmdDelete.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Aktualisieren der Datenbank: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonNeu_Click(object sender, EventArgs e)
        {
            NeuenBenutzerHinzufügen neuerBenutzer = new NeuenBenutzerHinzufügen();
            neuerBenutzer.Show();
        }

        private void LöscheAusgewählteReihe()
        {
            if (dg.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Sind Sie sicher, dass Sie die ausgewählte Zeile löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string email = dg.SelectedRows[0].Cells["email"].Value.ToString();

                        using (NpgsqlConnection vCon = new NpgsqlConnection(vStrConnection))
                        {
                            vCon.Open();
                            string sqlLöschen = "DELETE FROM benutzerTabelle WHERE email = @original_email";

                            using (NpgsqlCommand cmdDelete = new NpgsqlCommand(sqlLöschen, vCon))
                            {
                                cmdDelete.Parameters.AddWithValue("@original_email", email);
                                cmdDelete.ExecuteNonQuery();
                            }
                        }

                        dg.Rows.RemoveAt(dg.SelectedRows[0].Index);
                        MessageBox.Show("Die Zeile wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Löschen der Zeile: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Zeile zum Löschen aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ButtonLöschen_Click(object sender, EventArgs e)
        {
            LöscheAusgewählteReihe();
        }

        private void ButtonBearbeiten_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count > 0)
            {
                string email = dg.SelectedRows[0].Cells["email"].Value.ToString();
                BearbeitenBenutzer bearbeitenBenutzer = new BearbeitenBenutzer(email, this);
                bearbeitenBenutzer.ShowDialog();
                // Aktualisieren Sie die DataGridView-Daten nach dem Schließen des Bearbeiten-Fensters
                DataTable dtgetdata = getdata("SELECT * FROM benutzerTabelle;");
                dg.DataSource = dtgetdata;
                dg.ClearSelection();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Zeile zum Bearbeiten aus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    

