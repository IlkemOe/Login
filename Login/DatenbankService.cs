using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace Login
{
    public class DatenbankService
    {
        private string vStrConnection = "Server=localhost;Port=3169;User Id=postgres;Password=Passwort1!;Database=Datenbank;";

        public bool UpdatePassword(string email, string username, string newPassword)
        {
            using (var conn = new NpgsqlConnection(vStrConnection))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("UPDATE BenutzerTabelle SET Passworthash = @newPassword WHERE Email = @Email AND Benutzername = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("newPassword", newPassword);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
    }
}

