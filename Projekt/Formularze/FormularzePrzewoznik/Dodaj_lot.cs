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
    public partial class Dodaj_lot : Form

    {
        public Dodaj_lot()
        {
            InitializeComponent();
            //    ReadDataU();
        }
        //Wczytywanie danych z bazy

        //Button z Insertem
        private void DodajLotButt_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                //Insert wszystkich danych lotu
                string query = $@"INSERT INTO Loty (MiejsceWylotu, MiejscePrzylotu, IloscMiejsc, CenaBiletu, CenaBagazu, IDprzewoznika, 
                           DataWylotu, DataPrzylotu, GodzinaWylotu, GodzinaPrzylotu, CzasTrwaniaLotu, Przesiadki, LiczbaPrzesiadek) 
                           VALUES ('{MiejsceWylotuTextBox.Text}', '{MiejscePrzylotuTextBox.Text}', 
                           '{IloscMiejscNumber.Text}', '{CenaBiletuNumber.Text}', '{CenaBagazuNumber.Text}', '{IdPrzewoznikaNumber.Text}', 
                           '{DataWylotuTextBox.Text}', '{DataPrzylotuTextBox.Text}', '{GodzinaWylotuTextBox.Text}', '{GodzinaPrzylotuTextBox.Text}', 
                           '{CzasTrwaniaLotuNumber.Text}', '{PrzesiadkiTextBox.Text}', '{LiczbaPrzesiadekNumber.Text}');";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            label4.Visible = true;

        }

       
    }
}
