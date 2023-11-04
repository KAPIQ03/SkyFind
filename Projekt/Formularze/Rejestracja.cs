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
    public partial class Rejestracja : Form
    {
        Logowanie logowanie = new Logowanie();
        public Rejestracja()
        {
            InitializeComponent();
            
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            logowanie.Show();
            this.Close();
        }

        private void btnUtwoz_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string haslo = tbHaslo.Text;
            string pHaslo = tbPowtorzHaslo.Text;
            string email = tbEmail.Text;
            string rKonta = cbRodzaj.Text;

            bool CzyLoginPoprawny(string emailSprawdzany)
            {
                for(int i = 0; i != emailSprawdzany.Length; i++)
                {
                    if (emailSprawdzany[i] == '@')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }

            if (!CzyLoginPoprawny(email)){
                lbEmail.Visible = true;
            }
            else
            {
                lbEmail.Visible = false;    
            }

            if (haslo != pHaslo|| haslo == "")
            {
                if(haslo == ""||pHaslo == "")
                {
                    lbValidation.Text = "Te pola są wymagane";
                }
                else
                {
                    lbValidation.Text = "Hasła nie są takie same";
                }
                lbValidation.Visible = true;
            }
            else if(haslo == "" || login == "" || email == "" || rKonta == "")
            {

            }
            else
            {
                lbValidation.Visible = false;
                logowanie.Show();
                this.Close();
            }
            
        }
    }
}
