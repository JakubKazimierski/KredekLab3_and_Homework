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
    public partial class FormForHeadTeacher : Form
    {

        private string username;
        private string password;

        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);
        public FormForHeadTeacher()
        {
            InitializeComponent();
            
        } 

 

        public void SetUserName(string name)
        {
            username = name;
        }
        public string GetUserName()
        {
            return username;
        }
        public void SetPassword(string pass)
        {
            password = pass;
        }
        public string GetPassword()
        {
            return password;
        }

        private void WorkerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            WorkerPanel.Enabled = true;
            using (var connection = dbConnectionWareHouse())
            {

                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;
                      

                    }
                    connection.Close();
      
            }

        }

        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;
                        

                    }
                    connection.Close();
                

            }
        }

        private void GradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Grades ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();


            }
        }

        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Role ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();


            }
        }

        private void LogInsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            LoginsPanel.Enabled = true;
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  LogIns ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();


            }
        }

        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Salary ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();


            }
        }

        private void ClassTeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  ClassTeacher ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();


            }
        }

        private void DisablePanels()
        {
            WorkerPanel.Enabled = false;
            LoginsPanel.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {

                if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PeselTextBox.Text != "" && RoleTextBox.Text != "")
                {

                    connection.Open();

                    string query = " UPDATE Worker SET RoleId = '" + Int32.Parse(RoleTextBox.Text) + "' WHERE Name = '" + NameTextBox.Text + "' AND Surname = '" + SurnameTextBox.Text + "' AND Pesel = '" + Int32.Parse(PeselTextBox.Text) + "'";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();
                    this.GriedVieverDataBase.Controls.Clear();




                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }
                

            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {

                if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PeselTextBox.Text != "" && RoleTextBox.Text != "")
                {

                    connection.Open();

                    string query = " INSERT INTO  Worker ( Name, Surname, Pesel, RoleId) VALUES  ('"+ NameTextBox.Text +"','"+ SurnameTextBox.Text +"','"+ Int32.Parse(PeselTextBox.Text) +"','"+ Int32.Parse(RoleTextBox.Text)+"')";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();
                    this.GriedVieverDataBase.Controls.Clear();




                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                if (PeselTextBox.Text != "" && RoleTextBox.Text != "" && NameTextBox.Text!="" && SurnameTextBox.Text != "")
                {
                    this.GriedVieverDataBase.Controls.Clear();

                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select Name, Surname, Pesel, RoleId From Worker WHERE Name = '" + NameTextBox.Text + "' OR Surname = '" + SurnameTextBox.Text + "' OR Pesel = '" + Int32.Parse(PeselTextBox.Text) + "' OR RoleId = '" + Int32.Parse(RoleTextBox.Text) + "'", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Pesel i Rola oraz Imie i Nazwisko nie mogą być pustymi polami");
                }
            }
        }

        private void LoginsUpdateButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {

                if (UserPeselTextBox.Text != "" && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
                {

                    connection.Open();

                    string query = " UPDATE LogIns SET UserName = '" + LoginTextBox.Text + "', UserPassword = '"+PasswordTextBox.Text+"' WHERE UserPesel = '" + Int32.Parse(UserPeselTextBox.Text) +"'";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();
                    this.GriedVieverDataBase.Controls.Clear();




                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From LogIns", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }
    }
}
