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
    public partial class AfterLogInForm : Form
    {

        private string username;
        private string password;

        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);
        public AfterLogInForm()
        {
            InitializeComponent();
            
        } 

        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();

                SqlCommand comand = new SqlCommand("Select * From LogIns Where UserName ='" + GetUserName() + "'AND UserPassword='" + GetPassword() + "'", connection);
                SqlDataReader dataReader = comand.ExecuteReader();
                while(dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(1).ToString());
                }
                connection.Close();

                connection.Open();
                

                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From LogIns Where UserName ='"+GetUserName()+"'AND UserPassword='"+GetPassword()+"'", connection))
                {
                    DataTable table = new DataTable();
                    DataSet setOfDB = new DataSet();

                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;

                }
                    
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
