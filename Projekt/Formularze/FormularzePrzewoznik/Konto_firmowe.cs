using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Dashboard_Firmy.Formularze
{
    public partial class Konto_firmowe : Form
    {
        string oldEmail;
        public Konto_firmowe(string login)
        {
            InitializeComponent();
            ReadDataU(login);
        }
        bool ReadDataU(string login)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string query = $"SELECT Login, Haslo, Email, NazwaPrzewoznika FROM Przewoznicy WHERE Login = '{login}'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            NazwaPTextBox.Text = reader.GetString(3);
                            emailTextBox.Text = reader.GetString(2);
                            oldEmail = reader.GetString(2);
                            hasloTextBox.Text = reader.GetString(1);
                            loginTextBox.Text = reader.GetString(0);
                        }
                    }
                }
                connection.Close();
            }
            return false;
        }
        private void ZapiszDane_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                string query = $"UPDATE Przewoznicy SET Haslo = '{hasloTextBox.Text}', Login = '{loginTextBox.Text}',Email = '{emailTextBox.Text}',NazwaPrzewoznika = '{NazwaPTextBox.Text}' WHERE Email = '{oldEmail}';";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    oldEmail = emailTextBox.Text;
                }
                connection.Close();
            }
        }
    }
}
