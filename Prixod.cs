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
    public partial class Prixod : Form
    {
        public Prixod()
        {
            InitializeComponent();
        }

        private void prixodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prixodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketNewDataSet2);

        }

        private void Prixod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Prixod". При необходимости она может быть перемещена или удалена.
            this.prixodTableAdapter.Fill(this.elmarketNewDataSet2.Prixod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prixodBindingSource.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            prixodTableAdapter.Update(elmarketNewDataSet2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           prixodBindingSource.Filter = "";
        }
    }
}
