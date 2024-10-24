using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElmarketApp
{
    public partial class Mesto_xraneniya : Form
    {
        public Mesto_xraneniya()
        {
            InitializeComponent();
        }

        private void mesto_xraneniyaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mesto_xraneniyaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarketNewDataSet2);

        }

        private void Mesto_xraneniya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Mesto_xraneniya". При необходимости она может быть перемещена или удалена.
            this.mesto_xraneniyaTableAdapter.Fill(this.elmarketNewDataSet2.Mesto_xraneniya);

        }





        private void button5_Click(object sender, EventArgs e)
        {
            mesto_xraneniyaTableAdapter.Update(elmarketNewDataSet2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
        

