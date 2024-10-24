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
    public partial class Ostatki : Form
    {
        public Ostatki()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Fakt_ostatkii2();
            ifrm.ShowDialog();
        }

        private void tek_OstatkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tek_OstatkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elmarket33DataSet1);

        }

        private void Ostatki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet2.Tek_Ostatki". При необходимости она может быть перемещена или удалена.
            this.tek_OstatkiTableAdapter2.Fill(this.elmarketNewDataSet2.Tek_Ostatki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarketNewDataSet1.Tek_Ostatki". При необходимости она может быть перемещена или удалена.
            this.tek_OstatkiTableAdapter1.Fill(this.elmarketNewDataSet1.Tek_Ostatki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "elmarket33DataSet1.Tek_Ostatki". При необходимости она может быть перемещена или удалена.
           

        }

        private void tek_OstatkiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Otcheti();
            ifrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tek_OstatkiTableAdapter2.Update(elmarketNewDataSet2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
