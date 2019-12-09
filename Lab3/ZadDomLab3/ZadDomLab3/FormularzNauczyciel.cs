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
    public partial class TeacherForm : Form
    {
        //variables
        private string username;
        private string password;

        //connector to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        //constructor
        public TeacherForm()
        {
            InitializeComponent();
        }


        #region VariablesMethods
        /// <summary>
        /// Methods to set and get variables
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
        /// Method of radio button event to get all infos from students table from Data Base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();//closing connection to data base


            }
        }

        /// <summary>
        /// Method of event of radio button to get all infos from ClassTeacher Table form Data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassTeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  ClassTeacher ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();//closing connection to data base


            }
        }

        /// <summary>
        /// Method of radio button event to get all infos from Grade table from data base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();
                //opening connection to data base
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Grades ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();//closing connection to data base


            }
        }
        #endregion
    }
}
