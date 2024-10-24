using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElmarketApp
{
    public partial class fakt_otchet : Form

    {
        private Button buttonFilter;
        private DataGridView dataGridView;
        private string connectionString = "Data Source=USER-PC\\MSSQLSERVER11;Initial Catalog=ElmarketNew;Integrated Security=True";
        public fakt_otchet()
        {
            InitializeComponent();
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
                string query = " SELECT f.id_fakt_ostatki as 'Идентификатор', f.Datanum as 'Дата', f.Sena_prodaji as 'Цена продажи', f.kolichestvo as 'Количество', p.Product_name as 'Наимевание' FROM Fakt_Ostatki f JOIN Tovars p ON f.Id_Product = p.Id_Product WHERE f.Datanum >= @StartDate AND f.Datanum <= @EndDate"; ;
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
       
