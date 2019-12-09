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
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            TextBoxUserPassword.PasswordChar = '*';
        }

        /// <summary>
        /// Method of action Button to log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {

            #region ObjectOfClasses

            //Creating object of Forms
            FormForHeadTeacher formForHeadTeacher = new FormForHeadTeacher();
            FormForStudents studentsForm = new FormForStudents();
            TeacherForm teacherForm = new TeacherForm();
            SecretariatForm secretariatForm = new SecretariatForm();
            WoznyForm woznyForm = new WoznyForm();

            //object of clas checking if log in is correct
            SignIn sigin = new SignIn(TextBoxUserName.Text, TextBoxUserPassword.Text);
            #endregion

            #region LogInLogic
            //method of log in, and also opening correct forms
            if (sigin.SignInSchool())
            {
                //Depending from worker number form DataBase, correct form will be open
                int NumberOfWorker = 0;
                int NumberOfPesel = 0;
                using (var connection = dbConnectionWareHouse())
                {
                    connection.Open();

                    SqlCommand comand = new SqlCommand("Select * From LogIns INNER JOIN Worker ON Worker.Pesel = LogIns.UserPesel   Where LogIns.UserName = '" + TextBoxUserName.Text + "'AND LogIns.UserPassword = '" + TextBoxUserPassword.Text + "'", connection);
                    SqlDataReader dataReader = comand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        

                        NumberOfWorker = Int32.Parse(dataReader.GetValue(8).ToString());
                        NumberOfPesel = Int32.Parse(dataReader.GetValue(1).ToString());
                    }
                    connection.Close();

                    //1 is Head Teacher
                    if (NumberOfWorker == 1)
                    {
                        MessageBox.Show("Witaj Dyrektorze");
                        formForHeadTeacher.SetUserName(TextBoxUserName.Text);
                        formForHeadTeacher.SetPassword(TextBoxUserPassword.Text);
                        
                        formForHeadTeacher.Show();
                    
                    }
                    //2 is Teacher
                    else if (NumberOfWorker == 2)
                    {
                        MessageBox.Show("Witaj Nauczycielu");
                        teacherForm.SetUserName(TextBoxUserName.Text);
                        teacherForm.SetPassword(TextBoxUserPassword.Text);
                        
                        teacherForm.Show();
                    }
                    //3 is secretariat worker
                    else if (NumberOfWorker == 3)
                    {
                        MessageBox.Show("Witaj Pracowniku Sekretariatu");
                        secretariatForm.SetUserName(TextBoxUserName.Text);
                        secretariatForm.SetPassword(TextBoxUserPassword.Text);
                        
                        secretariatForm.Show();
                    }
                    //4 is Wozny
                    else if (NumberOfWorker == 4)
                    {
                        MessageBox.Show("Witaj Mistrzu");
                        woznyForm.SetUserName(TextBoxUserName.Text);
                        woznyForm.SetPassword(TextBoxUserName.Text);
                        
                        woznyForm.Show();

                    }
                    //anything else is for students
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
            #endregion
        }

    }
}
