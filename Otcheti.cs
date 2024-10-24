using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace ElmarketApp
{
    public partial class Otcheti : Form
    {
        
        private Button buttonFilter;
        private DataGridView dataGridView;
        private string connectionString = "Data Source=USER-PC\\MSSQLSERVER11;Initial Catalog=ElmarketNew;Integrated Security=True"; // Replac
        public Otcheti()
        {
            InitializeComponent();
            

        }

        private void Отчеты_Load(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            // Query the database and update the DataGridView
            LoadData(startDate, endDate);
        }
        private void LoadData(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = " SELECT t.*, p.Product_name FROM Tek_Ostatki t JOIN Tovars p ON t.Id_Product = p.Id_Product WHERE t.Datanum >= @StartDate AND t.Datanum <= @EndDate"; ;
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


