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
    public partial class FormForStudents : Form
    {
        //variables
        private string username;
        private string password;

        //connector to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        //constructor
        public FormForStudents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method of selecting specific data from data base
        /// </summary>
        public void GetDataFromTable()
        {
            string Grade = "";
           
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();//opening connection to data base

                SqlCommand comand = new SqlCommand("Select * From LogIns INNER JOIN Student ON Student.Pesel = LogIns.UserPesel INNER JOIN Grades ON Student.StudentId = Grades.StudentId  Where LogIns.UserName = '" + GetUserName() + "'AND LogIns.UserPassword = '" + GetPassword() +"'", connection);
                SqlDataReader dataReader = comand.ExecuteReader();
                while (dataReader.Read())
                {
                    

                    Grade = dataReader.GetValue(11).ToString();
                   
                }
                connection.Close();//close connection
                GradeLabelGrade.Text = Grade;
            }
        }

        #region VariablesMethod
        /// <summary>
        /// Methods to get and set variables which are private
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
    }
}
