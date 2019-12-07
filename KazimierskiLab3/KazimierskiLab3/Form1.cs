using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KazimierskiLab3
{
    public partial class Form1 : Form
    {
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method of button to sign in data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FormWarehouse formWarehouse = new FormWarehouse();
            
            SignIn sigin = new SignIn(UsernameTextBox.Text, PasswordTextBox.Text);
            if(sigin.SignInWarehouse())
            {
                formWarehouse.Show();
                

            }
            else
            {
                MessageBox.Show("Nie udalo sie");
            }
        }
    }
}
