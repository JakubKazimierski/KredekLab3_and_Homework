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

namespace KazimierskiLab3
{
    public partial class FormWarehouse : Form
    {
        //assigned connection with data base
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);
        
        //constructor
        public FormWarehouse()
        {
            InitializeComponent();
            GetDataFromTable();
        }

        /// <summary>
        /// Method to extract data from dataBase into grid viever
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionWareHouse())
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From UserLogin", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataBaseGridView.DataSource = table;
                }
            }
        }

        /// <summary>
        /// Method of buuton, to extract special data from data Base into gried viever
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFiltr_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                //Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserLogin WHERE UserName = 'Adam' ", connection))
                {
                    ///Wynik zapytania do tabeli.
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    /// Do datagridview dodano powyższą tabelę
                    DataBaseGridView.DataSource = table;
                }
            }
        }
    }
}
