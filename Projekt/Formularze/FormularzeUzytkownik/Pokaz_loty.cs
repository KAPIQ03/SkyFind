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

namespace Projekt
{
    public partial class Pokaz_loty : Form
    {
        private const string ConnectionString = @"Data Source=..\..\BazaDanych\baza12_3.db;";
        public Pokaz_loty()
        {
            InitializeListView();
            WyswietlLoty();
        }
        private void InitializeListView()
        {
            listViewLoty = new ListView();
            listViewLoty.View = View.Details;
            listViewLoty.FullRowSelect = true;
            listViewLoty.GridLines = true;
            listViewLoty.Font = new System.Drawing.Font("Lato", 12, System.Drawing.FontStyle.Regular);

            //Dodaj kolumny do kontrolki ListView

            listViewLoty.Columns.Add("ID Lotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Liczba Przesiadek", 120, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Miejsce Wylotu", 120, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Miejsce Przylotu", 120, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Ilość Miejsc", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Cena Biletu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Cena Bagażu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("ID Przewoźnika", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Data Wylotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Data Przylotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Godzina Wylotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Godzina Przylotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Czas Trwania Lotu", 80, HorizontalAlignment.Left);
            listViewLoty.Columns.Add("Przesiadki", 120, HorizontalAlignment.Left);

            //listViewLoty.Size = new Size(990, 500);
            listViewLoty.Dock = DockStyle.Fill;
            // Dodaj kontrolkę ListView do formularza
            this.Controls.Add(listViewLoty);
        }

        private void WyswietlLoty()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Loty";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["IDlotu"].ToString());
                            item.SubItems.Add(reader["LiczbaPrzesiadek"].ToString());
                            item.SubItems.Add(reader["MiejsceWylotu"].ToString());
                            item.SubItems.Add(reader["MiejscePrzylotu"].ToString());
                            item.SubItems.Add(reader["IloscMiejsc"].ToString());
                            item.SubItems.Add(reader["CenaBiletu"].ToString());
                            item.SubItems.Add(reader["CenaBagazu"].ToString());
                            item.SubItems.Add(reader["IDprzewoznika"].ToString());
                            item.SubItems.Add(reader["DataWylotu"].ToString());
                            item.SubItems.Add(reader["DataPrzylotu"].ToString());
                            item.SubItems.Add(reader["GodzinaWylotu"].ToString());
                            item.SubItems.Add(reader["GodzinaPrzylotu"].ToString());
                            item.SubItems.Add(reader["CzasTrwaniaLotu"].ToString());
                            item.SubItems.Add(reader["Przesiadki"].ToString());


                            listViewLoty.Items.Add(item);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
