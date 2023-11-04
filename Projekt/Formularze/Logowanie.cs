using Dashboard_Firmy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            string haslo = tbHaslo.Text;
            string login = tbLogin.Text;

            if(haslo != "123" || login != "admin" ) { 
                lbValidation.Visible = true;
            }
            else
            {
                lbValidation.Visible = false;

                DashboardPrzewoznik dashboard = new DashboardPrzewoznik();
                dashboard.Show();
                this.Hide();
            }
        }

        private void linkHaslo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ZapHaslo zapHaslo = new ZapHaslo();
            zapHaslo.Show();
            this.Close();
        }

        private void linkLZarejestruj_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            rejestracja.Show();
            this.Close();
        }
    }
}
