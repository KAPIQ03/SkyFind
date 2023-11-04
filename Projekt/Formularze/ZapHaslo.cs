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
    public partial class ZapHaslo : Form
    {
        public ZapHaslo()
        {
            InitializeComponent();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Close();
        }
    }
}
