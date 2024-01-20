using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Firmy.Formularze
{
    public partial class Usun_lot : Form
    {
        public Usun_lot()
        {
            InitializeComponent();

        }
        //Wczytywanie danych z bazy


        //Button z Deletem
        private void UsuńLotButt_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                //Delete danego lotu o id podanego lotu
                string query = $"Delete from Loty where IDlotu = '{IdLotuNumber.Text}';";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            label1.Visible = true;
        }
    }
}
