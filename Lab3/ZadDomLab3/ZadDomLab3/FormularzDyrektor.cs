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
        //variables
        private string username;
        private string password;

        //connector to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);
        
        //constructor
        public FormForHeadTeacher()
        {
            InitializeComponent();
            
        }


        #region VariablesMethods

        /// <summary>
        /// Methods to set or get private variables
        /// </summary>
        /// <param name="name"></param>
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
        #endregion

        #region radioButtonsToEachTableOfDataBase
        /// <summary>
        /// Method to select all info from worker table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            WorkerPanel.Enabled = true;
            using (var connection = dbConnectionWareHouse())
            {

                this.GriedVieverDataBase.Controls.Clear();
                //using connection to data base
                connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;
                      

                    }
                    connection.Close();
                //closing connection
            }

        }

        /// <summary>
        /// Method to get all info from students table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using connection to data base
                connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;
                        

                    }
                    connection.Close();
                //closing connection

            }
        }

        /// <summary>
        /// Method of radio button event to get all infos from Grades table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using data base connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Grades ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();
                //closing connection

            }
        }

        /// <summary>
        /// Method of radio button event to get all infos from Role table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using db connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Role ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();
                //closing connection

            }
        }

        /// <summary>
        /// Method of radio button event to get all infos form LogIns table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            LoginsPanel.Enabled = true;
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using db Connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  LogIns ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();
                //closing data base connection

            }
        }

        /// <summary>
        /// Method of event from radio button, to get all infos form salary table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Salary ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();
                //closing connection to data base

            }
        }

        /// <summary>
        /// Method of radio button evemt to get all info from ClassTeacher Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassTeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisablePanels();
            using (var connection = dbConnectionWareHouse())
            {


                this.GriedVieverDataBase.Controls.Clear();
                //using data base connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  ClassTeacher ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;


                }
                connection.Close();
                //closing data  base connection

            }
        }

        #endregion

        /// <summary>
        /// Method to disable panels responsible for updating insert and delete rows in Data base
        /// only few redio button events has privilege to use this panels
        /// </summary>
        private void DisablePanels()
        {
            WorkerPanel.Enabled = false;
            LoginsPanel.Enabled = false;
        }

        #region WorkerTablePanelButtons

        /// <summary>
        /// Method of UpdateButton event to update rows in Worker Table in Data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //condition of assertion
                if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PeselTextBox.Text != "" && RoleTextBox.Text != "")
                {
                    //using data base
                    connection.Open();

                    string query = " UPDATE Worker SET RoleId = '" + Int32.Parse(RoleTextBox.Text) + "' WHERE Name = '" + NameTextBox.Text + "' AND Surname = '" + SurnameTextBox.Text + "' AND Pesel = '" + Int32.Parse(PeselTextBox.Text) + "'";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close(); //closing connection
                    this.GriedVieverDataBase.Controls.Clear();



                    //using data base
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//closing connection
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }
                

            }
        }

        /// <summary>
        /// Method of event of InsertButton, to insert dtata into Worker Table in Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //condition of assertion
                if (NameTextBox.Text != "" && SurnameTextBox.Text != "" && PeselTextBox.Text != "" && RoleTextBox.Text != "")
                {
                    //using data base connection
                    connection.Open();

                    string query = " INSERT INTO  Worker ( Name, Surname, Pesel, RoleId) VALUES  ('"+ NameTextBox.Text +"','"+ SurnameTextBox.Text +"','"+ Int32.Parse(PeselTextBox.Text) +"','"+ Int32.Parse(RoleTextBox.Text)+"')";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();//close connection
                    this.GriedVieverDataBase.Controls.Clear();



                    //using data base connection
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//close connection
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }

        /// <summary>
        /// Method of event SelectButton, to select specific row of Worker Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //condition of assertion
                if (PeselTextBox.Text != "" && RoleTextBox.Text != "" && NameTextBox.Text!="" && SurnameTextBox.Text != "")
                {
                    this.GriedVieverDataBase.Controls.Clear();

                    //using connection to data base
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select Name, Surname, Pesel, RoleId From Worker WHERE Name = '" + NameTextBox.Text + "' OR Surname = '" + SurnameTextBox.Text + "' OR Pesel = '" + Int32.Parse(PeselTextBox.Text) + "' OR RoleId = '" + Int32.Parse(RoleTextBox.Text) + "'", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//cose connection
                }
                else
                {
                    MessageBox.Show("Pesel i Rola oraz Imie i Nazwisko nie mogą być pustymi polami");
                }
            }
        }

        #endregion

        #region LogInsTablePanelButtons

        /// <summary>
        /// Method of event of UpdateButton in LogIns Table from DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginsUpdateButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //assertion condition
                if (UserPeselTextBox.Text != "" && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
                {
                    //using connection to data base
                    connection.Open();

                    string query = " UPDATE LogIns SET UserName = '" + LoginTextBox.Text + "', UserPassword = '"+PasswordTextBox.Text+"' WHERE UserPesel = '" + Int32.Parse(UserPeselTextBox.Text) +"'";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();//cloing connection
                    this.GriedVieverDataBase.Controls.Clear();



                    //using connection to data base
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From LogIns", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//closing connection
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }

        /// <summary>
        /// Method of event of insert Button in LogIns Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginsInsertButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //condition of assertion
                if (UserPeselTextBox.Text != "" && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
                {
                    //opening connection to data base
                    connection.Open();

                    string query = " INSERT INTO  LogIns ( UserPesel, UserName, UserPassword) VALUES  ('" + Int32.Parse(UserPeselTextBox.Text) + "','" + LoginTextBox.Text + "','" + PasswordTextBox.Text + "')";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();//close connection
                    this.GriedVieverDataBase.Controls.Clear();



                    //opening conecction to data base
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From LogIns", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//closing connection
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }

        /// <summary>
        /// Method of event of Delete Button from LogIns Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginsDeleteButton_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //assertion condition
                if (UserPeselTextBox.Text != "" && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
                {
                    //opening connection
                    connection.Open();

                    string query = " DELETE FROM  LogIns WHERE UserPesel ='" + Int32.Parse(UserPeselTextBox.Text) + "' AND UserName ='" + LoginTextBox.Text + "' AND UserPassword ='" + PasswordTextBox.Text + "'";
                    SqlCommand update = new SqlCommand(query, connection);
                    update.ExecuteNonQuery();
                    connection.Close();//close connection
                    this.GriedVieverDataBase.Controls.Clear();



                    //opening connection
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From LogIns", connection))
                    {
                        DataTable table = new DataTable();


                        adapter.Fill(table);
                        GriedVieverDataBase.DataSource = table;


                    }
                    connection.Close();//close connection
                }
                else
                {
                    MessageBox.Show("Wprowadz Wszystkie Dane");
                }


            }
        }
        #endregion
    }
}
