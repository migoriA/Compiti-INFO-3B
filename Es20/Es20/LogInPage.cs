using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Es20
{
    public partial class LogInPage : Form
    {
        public static string password;
        public static string email;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            var field = new string[4];
            var sr = new StreamReader("Dati.txt");
            string line = "";
            bool ok = false;
            password = passwordTxt.Text != "" ? passwordTxt.Text : null;
            email = emailTxt.Text != "" ? emailTxt.Text : null;
            
            if (email != null && password != null)
            {
                while (!ok && sr.Peek()>-1)
                {
                    line = sr.ReadLine();
                    field = line.Split(':');
                    if (field[2]==email && field[3] == password)
                    {
                        ok = true;
                    }
                    else
                    {
                        ok = false;
                    }
                }
                sr.Close();
            }
            else
            {
                MessageBox.Show("Completa gli spazi mancanti");
            }
            if (ok)
            {
                //apre pagina conto
            }
            else
            {
                MessageBox.Show("Email o password non corrette");
            }
        }

        private void SignInLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var SignIn = new SignInPage();
            SignIn.Show();
        }
    }
}
