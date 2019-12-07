using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazimierskiLab3
{

    class SignIn
    {
        //Assigning connection to data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);

        //assigning methods of loging in, from with variable it takes and where it puts it's data
        public SqlCommand QuerySql { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

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
        public bool SignInWarehouse()
        {
            int valueResult;
            bool IsTrue = false;
            string query = "Select count(UserLogin.UserName) From UserLogin WHERE UserName = @Username AND Password = @Password ";
            using(var connection = dbConnectionWareHouse())
            {
                //open connection with data base, and chceck if data input are correct
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username",Username));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int) QuerySql.ExecuteScalar();
                
                if(valueResult >= 1)
                {
                    IsTrue = true;
                }
            }

            return IsTrue;
        }

    }
}
