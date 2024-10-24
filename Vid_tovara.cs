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
    public partial class Vid_tovara : Form
    {
        public Vid_tovara()
        {
            InitializeComponent();
        }

        private void vID_TOVARABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vID_TOVARABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketDataSet1);

        }

        private void Vid_tovara_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarket33DataSet.Vid_tovara". При необходимости она может быть перемещена или удалена.
            this.vid_tovaraTableAdapter1.Fill(this.elmarket33DataSet.Vid_tovara);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketDataSet1.VID_TOVARA". При необходимости она может быть перемещена или удалена.
            this.vID_TOVARATableAdapter.Fill(this.elmarketDataSet1.VID_TOVARA);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            vid_tovaraBindingSource1.Filter = "Id_Product='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vid_tovaraBindingSource1.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vid_tovaraTableAdapter1.Update(elmarket33DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
