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
    public partial class SecretariatForm : Form
    {
        //variables
        private string username;
        private string password;

        //connector to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        //constructor
        public SecretariatForm()
        {
            InitializeComponent();
        }


        #region VariablesMethod
        /// <summary>
        /// Methods to set and get variables which are private
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

        #region RadioButtonsMethods
        /// <summary>
        /// Method of radio button event to get all infos from Salary Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.SecretariatGridView.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Salary ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    SecretariatGridView.DataSource = table;


                }
                connection.Close();//closing connection to data base


            }
        }

        /// <summary>
        /// Method of event of radio button to get all  infos from Worker Table from Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.SecretariatGridView.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Worker ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    SecretariatGridView.DataSource = table;


                }
                connection.Close();//closing connection to data base


            }
        }

        /// <summary>
        /// Method of radio button evemt to get all infos from Role Table From data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.SecretariatGridView.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Role ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    SecretariatGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }

        /// <summary>
        /// Method of radio button event to get all infos from Students Table form Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.SecretariatGridView.Controls.Clear();
                //Opening connection
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    SecretariatGridView.DataSource = table;


                }
                connection.Close();//closing connection


            }
        }
        #endregion
    }


}
