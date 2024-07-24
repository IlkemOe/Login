using System;
using System.Windows.Forms;
using Npgsql;

public class DatenbankService
{
    private string vStrConnection = "Server=localhost;Port=3169;User Id=postgres;Password=Passwort1!;Database=Datenbank;";

    public bool UpdatePassword(string email, string benutzername, string neuesPasswort)
    {
        using (var conn = new NpgsqlConnection(vStrConnection))
        {
            try
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE \"Benutzertabelle\" SET \"Passworthash\" = @neuesPasswort WHERE \"Email\" = @Email AND \"Benutzername\" = @Benutzername", conn))
                {
                    cmd.Parameters.AddWithValue("neuesPasswort", neuesPasswort);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Benutzername", benutzername);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren des Passworts: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public string HoleAngemeldetenBenutzer()
    {
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();

                string sql = "SELECT Benutzername FROM AngemeldeterBenutzer WHERE AngemeldetBleiben = TRUE";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }
    }


