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
        private string username;
        private string password;

        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);


        public TeacherForm()
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

        private void StudentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Student ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();


            }
        }

        private void ClassTeacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  ClassTeacher ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();


            }
        }

        private void GradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {


                this.TeacherTableDataGridViever.Controls.Clear();

                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Grades ", connection))
                {
                    DataTable table = new DataTable();


                    adapter.Fill(table);
                    TeacherTableDataGridViever.DataSource = table;


                }
                connection.Close();


            }
        }
    }
}
