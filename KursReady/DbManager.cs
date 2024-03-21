using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;


namespace KursReady
{
    public class DbManager
    {
        SQLiteConnection conn;

        public DbManager(string path)
        {
            conn = new SQLiteConnection("Data Source = " + path);
            conn.Open();
        }

        ~DbManager()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Dispose();
            }
        }

        private string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] raw_string = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_string);
            string hash = Encoding.Unicode.GetString(raw_hash);

            sha256.Clear();
            return hash;
        }

        public bool AddUser(string login, string password)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO users VALUES ('" + login +
                        "', '" + getHash(password) + "')";
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }

            return false;
        }

        public bool CheckUser(string login, string password)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT * FROM users WHERE login='" + login +
                        "' and password='" + getHash(password) + "'";
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return false;
                    else
                        return true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }

            return false;
        }
    }
}
