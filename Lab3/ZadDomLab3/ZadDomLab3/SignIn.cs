using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadDomLab3
{
    class SignIn
    {

        //Assigning connection to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);

        //assigning methods of loging in, from with variable it takes and where it puts it's data
        public SqlCommand QuerySql { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        private int Pesel;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public SignIn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Boolean method check if data of loging in are correct with data base
        /// </summary>
        /// <returns></returns>
        public bool SignInSchool()
        {
            int valueResult;
            bool IsTrue = false;
            string query = "Select count(LogIns.UserName) From LogIns WHERE UserName = @Username AND UserPassword = @Password ";
            using (var connection = dbConnectionWareHouse())
            {
                //open connection with data base, and chceck if data input are correct
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int)QuerySql.ExecuteScalar();

                if (valueResult >= 1)
                {
                    IsTrue = true;
                }
    
            }

            return IsTrue;
        }



        public void SetPesel(int number)
        {
            Pesel = number;

        }

        public int GetPesel()
        {
            return Pesel;

        }
    }
}
