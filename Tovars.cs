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
    public partial class Tovars : Form
    {
        public Tovars()
        {
            InitializeComponent();
        }

        private void tovarsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovarsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketNewDataSet2);

        }

        private void Tovars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Tovars". При необходимости она может быть перемещена или удалена.
            this.tovarsTableAdapter.Fill(this.elmarketNewDataSet2.Tovars);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovarsBindingSource.Filter = "Product_name='" + comboBox1.Text.ToString() + "'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tovarsBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tovarsTableAdapter.Update(elmarketNewDataSet2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vid_tovara();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Mesto_xraneniya();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
        }
    }
}
