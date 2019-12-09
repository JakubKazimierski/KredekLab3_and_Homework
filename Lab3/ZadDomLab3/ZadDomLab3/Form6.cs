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
    public partial class WoznyForm : Form
    {
        //variables
        private string username;
        private string password;

        //connector to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        //constructor
        public WoznyForm()
        {
            InitializeComponent();
        }


        #region VariablesMethods
        /// <summary>
        /// Methods to get and set private variables
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

        #region RadioButtonsRegion
        /// <summary>
        /// Method of radio buttton event to get all info from Worker Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Worker ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of radio button event to get all info from students table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of Radio Button event to get all info from Grades Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Grades ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of radio button event to get All info from Role Table from Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Role ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// 
        ///Method of radio button event to get all info from LogIns Table from Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  LogIns ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of Radio Button event to get all info from salary table from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Salary ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of radio button event to get all info from CassTeacher Table from Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassTeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.WoznyGridView.Controls.Clear();
                //opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  ClassTeacher ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    WoznyGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }
        #endregion
    }

}
