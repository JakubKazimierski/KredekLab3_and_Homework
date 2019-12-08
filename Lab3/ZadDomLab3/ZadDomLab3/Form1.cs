using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadDomLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            
            AfterLogInForm afterLogInForm = new AfterLogInForm();

            SignIn sigin = new SignIn(TextBoxUserName.Text, TextBoxUserPassword.Text);
            if (sigin.SignInSchool())
            {
                afterLogInForm.SetUserName(TextBoxUserName.Text);
                afterLogInForm.SetPassword(TextBoxUserPassword.Text);
                afterLogInForm.GetDataFromTable();
                afterLogInForm.Show();


            }
            else
            {
                MessageBox.Show("Nie udalo sie");
            }
        }
    }
}
