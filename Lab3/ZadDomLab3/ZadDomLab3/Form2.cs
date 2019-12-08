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
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Lab3"].ConnectionString);
        public AfterLogInForm()
        {
            InitializeComponent();
            GetDataFromTable();
        }

        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From Worker", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    GriedVieverDataBase.DataSource = table;
                }
            }
        }

    }
}
