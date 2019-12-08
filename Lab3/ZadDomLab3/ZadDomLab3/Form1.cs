using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadDomLab3
{
    public partial class Form1 : Form
    {
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            
            FormForHeadTeacher formForHeadTeacher = new FormForHeadTeacher();
            FormForStudents studentsForm = new FormForStudents();

            SignIn sigin = new SignIn(TextBoxUserName.Text, TextBoxUserPassword.Text);
            if (sigin.SignInSchool())
            {

                int NumberOfWorker = 0;
                int NumberOfPesel = 0;
                using (var connection = dbConnectionWareHouse())
                {
                    connection.Open();

                    SqlCommand comand = new SqlCommand("Select * From LogIns INNER JOIN Worker ON Worker.Pesel = LogIns.UserPesel   Where LogIns.UserName = '" + TextBoxUserName.Text + "'AND LogIns.UserPassword = '" + TextBoxUserPassword.Text + "'", connection);
                    SqlDataReader dataReader = comand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        // MessageBox.Show(dataReader.GetValue(8).ToString());

                        NumberOfWorker = Int32.Parse(dataReader.GetValue(8).ToString());
                        NumberOfPesel = Int32.Parse(dataReader.GetValue(1).ToString());
                    }
                    connection.Close();


                    if (NumberOfWorker == 1)
                    {
                        MessageBox.Show("Witaj Dyrektorze");
                        formForHeadTeacher.SetUserName(TextBoxUserName.Text);
                        formForHeadTeacher.SetPassword(TextBoxUserPassword.Text);
                        formForHeadTeacher.GetDataFromTable();
                        formForHeadTeacher.Show();
                    
                    }
                    else if (NumberOfWorker == 2)
                    {
                        MessageBox.Show("Witaj Nauczycielu");
                    }
                    else if (NumberOfWorker == 3)
                    {
                        MessageBox.Show("Witaj Pracowniku Sekretariatu");
                    }
                    else if (NumberOfWorker == 4)
                    {
                        MessageBox.Show("Witaj Mistrzu");
                    }
                    else
                    {

                        MessageBox.Show("Witaj Uczniu");
                        studentsForm.SetUserName(TextBoxUserName.Text);
                        studentsForm.SetPassword(TextBoxUserPassword.Text);
                        studentsForm.GetDataFromTable();
                        studentsForm.Show();
                    }

                }
                  

            }
            else
            {
                MessageBox.Show("Nie udalo sie");
            }
        }
    }
}
