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
    public partial class SignInPage : Form
    {
        public static string name;
        public SignInPage()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string password = passwordTxt.Text!="" ? passwordTxt.Text : null;
            string email = emailTxt.Text != "" ? emailTxt.Text : null;
            name = nameTxt.Text != "" ? nameTxt.Text : null;
            string surname = surnameTxt.Text != "" ? surnameTxt.Text : null;

            
            if (password != null && email != null && name != null && surname != null)
            {
                if (email.Contains("@"))
                {
                    using (var sw = new StreamWriter("Dati.txt", true))
                    {
                        sw.WriteLine($"{name}:{surname}:{email}:{password}");
                    }
                    this.Close();
                }    
                else
                {
                    MessageBox.Show("Email non accettata");
                }
            }
            else
            {
                MessageBox.Show("Completare tutti i campi");
            }
                   
        }
    }
}
