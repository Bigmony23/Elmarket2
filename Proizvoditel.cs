using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElmarketApp
{
    public partial class Proizvoditel : Form
    {
        public Proizvoditel()
        {
            InitializeComponent();
        }

        private void proizvoditelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proizvoditelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketNewDataSet2);

        }

        private void Proizvoditel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.elmarketNewDataSet2.Proizvoditel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           proizvoditelBindingSource.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proizvoditelTableAdapter.Update(elmarketNewDataSet2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
