using Fizzler;
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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Dashboard_Firmy.Formularze
{
    public partial class Edytuj_lot : Form
    {
        public Edytuj_lot()
        {
            InitializeComponent();

        }
        //Wczytywanie danych z bazy


        //Button z updatem
        private void EdytujLotButt_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"DataSource=..\..\BazaDanych\baza12_3.db;"))
            {
                connection.Open();
                //Update wszystkich danych podanego lotu
                string query = $"Update Loty set MiejsceWylotu = '{MiejsceWylotuTextBox.Text}', MiejscePrzylotu = '{MiejscePrzylotuTextBox.Text}', IloscMiejsc = '{IloscMiejscNumber.Text}', CenaBiletu = '{CenaBiletuNumber.Text}', CenaBagazu = '{CenaBagazuNumber.Text}', IDprzewoznika = '{IdPrzewoznikaNumber.Text}', DataWylotu = '{DataWylotuTextBox.Text}', DataPrzylotu = '{DataPrzylotuTextBox.Text}', GodzinaWylotu = '{GodzinaWylotuTextBox.Text}', GodzinaPrzylotu = '{GodzinaPrzylotuTextBox.Text}', CzasTrwaniaLotu = '{CzasTrwaniaLotuNumber.Text}',Przesiadki = '{PrzesiadkiTextBox.Text}',LiczbaPrzesiadek = '{LiczbaPrzesiadekNumber.Text}' WHERE IDlotu = '{IdLotuSNumber.Text}';";
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
