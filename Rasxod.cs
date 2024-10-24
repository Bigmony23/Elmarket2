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
    public partial class Rasxod : Form
    {
        public Rasxod()
        {
            InitializeComponent();
        }

        private void rasxod1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rasxod1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketNewDataSet2);

        }

        private void Rasxod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Tovars". При необходимости она может быть перемещена или удалена.
            this.tovarsTableAdapter.Fill(this.elmarketNewDataSet2.Tovars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Rasxod1". При необходимости она может быть перемещена или удалена.
            this.rasxod1TableAdapter.Fill(this.elmarketNewDataSet2.Rasxod1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           rasxod1BindingSource.Filter = "Data_Prixoda='" + comboBox1.Text + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           rasxod1BindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rasxod1TableAdapter.Update(elmarketNewDataSet2);
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
