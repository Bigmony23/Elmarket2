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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection;
using System.Web.UI.WebControls;


namespace ElmarketApp
{
    public partial class Fakt_ostatkii2 : Form
    {
        public Fakt_ostatkii2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=USER-PC\\MSSQLSERVER11;Initial Catalog=ElmarketNew;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
string query = @"
BEGIN
                -- Проверка таблицы факт остатки муществует ли данные
    IF NOT EXISTS(
        SELECT 1
        FROM Fakt_Ostatki AS f
        WHERE f.Id_Product IN(SELECT Id_Product FROM Tek_Ostatki) AND f.Datanum IN(SELECT Datanum FROM Tek_Ostatki)
    )
    BEGIN
        -- Insert data into Fakt_Ostatki
        INSERT INTO Fakt_Ostatki(
            Id_Product,
            Sena_prodaji,
            kolichestvo,
            Datanum
        )
        SELECT
            r.Id_Product,
            r.Sena_prodaji,
            t.kolichestvo - r.Kolichestvo,
            t.Datanum
        FROM
            Rasxod1 AS r
        INNER JOIN
            Tek_Ostatki AS t
        ON
            r.Id_Product = t.Id_Product;
                END
            END";

                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    try
                    {
                        // Execute the query and check the result
                        object result = command.ExecuteScalar();

                        if (result != null && ((string)result) == "DataAlreadyExists")
                        {
                            MessageBox.Show("Данные уже существуют на сегодняшний день.");
                        }
                        else
                        {
                            // Check for negative balance after insertion
                            string checkNegativeBalanceQuery = @"
SELECT COUNT(*)
FROM Tek_Ostatki
WHERE kolichestvo < 0";

                            using (SqlCommand checkCommand = new SqlCommand(checkNegativeBalanceQuery, connection, transaction))
                            {
                                int negativeBalanceCount = (int)checkCommand.ExecuteScalar();
                                if (negativeBalanceCount > 0)
                                {
                                    MessageBox.Show("Обнаружен негативный остаток в таблице Tek_Ostatki.");
                                }
                            }

                            // Commit the transaction regardless of negative balance
                            transaction.Commit();
                            MessageBox.Show("Данные добавлены.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Rollback the transaction in case of an error
                        transaction.Rollback();
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }

            private void Fakt_ostatkii2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Fakt_Ostatki". При необходимости она может быть перемещена или удалена.
            this.fakt_OstatkiTableAdapter3.Fill(this.elmarketNewDataSet2.Fakt_Ostatki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet1.Fakt_Ostatki". При необходимости она может быть перемещена или удалена.
            this.fakt_OstatkiTableAdapter2.Fill(this.elmarketNewDataSet1.Fakt_Ostatki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarket33DataSet1.Fakt_Ostatki". При необходимости она может быть перемещена или удалена.
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarket33DataSet.Fakt_Ostatki". При необходимости она может быть перемещена или удалена.
            

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            fakt_OstatkiBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ifrm = new fakt_otchet();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }
    }
}
