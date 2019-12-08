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
        private string username;
        private string password;

        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        public WoznyForm()
        {
            InitializeComponent();
        }

        public void GetDataFromTable()
        {
            string Grade = "";

            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();

                SqlCommand comand = new SqlCommand("Select * From LogIns INNER JOIN Student ON Student.Pesel = LogIns.UserPesel INNER JOIN Grades ON Student.StudentId = Grades.StudentId  Where LogIns.UserName = '" + GetUserName() + "'AND LogIns.UserPassword = '" + GetPassword() + "'", connection);
                SqlDataReader dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {


                    Grade = dataReader.GetValue(11).ToString();

                }
                connection.Close();
                //  GradeLabelGrade.Text = Grade;
            }
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
    }

}
