using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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
        public bool IsEmailValid(string email)
        {
            if (email != "")
            {
                for (int i = 0; i != email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        return true;
                    }
                    else
                    {
                        lbVEmail.Text = "E-mail nie jest poprawny";
                    }
                }
            }
            else
            {
                lbVEmail.Text = "To pole jest wymagane";
                return false;

            }
            return false;
        }
        int number;
        public void SendMail(string email)
        {
            string fromMail = "SkyFind.rejestracja@gmail.com";
            string fromPassword = "ixjg gpdq nugc zaln";
            string toMail = email;
            string login = "Kacper";
            Random rnd = new Random();
            number = rnd.Next(1000, 10000);
            Console.WriteLine(number);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Rejestracja";
            message.To.Add(new MailAddress(toMail));
            message.Body = $"Wtaj {login},<br> Twój kod do edycji hasła to: <b>{number}</b><br>Ta wiadomość została wygenerowana automatycznie";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
        private void btnDalej_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (!IsEmailValid(email))
            {
                IsEmailValid(email);
                lbVEmail.Visible = true;
                lbEmail.ForeColor = Color.Red;
            }
            else
            {
                lbVEmail.Visible = false;
                lbEmail.ForeColor = Color.Black;

                SendMail(email);
                KodZapHaslo kodZapHaslo = new KodZapHaslo(number);
                kodZapHaslo.Show();
                this.Close();
            }
        }
    }
}
