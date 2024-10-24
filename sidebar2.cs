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
    public partial class sidebar2 : Form
    {
        public sidebar2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tovars t = new Tovars();
            t.TopLevel = false;
            panel3.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prixod P = new Prixod();
            P.TopLevel = false;
            panel3.Controls.Add(P);
            P.BringToFront();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rasxod R = new Rasxod();
            R.TopLevel = false;
            panel3.Controls.Add(R);
            R.BringToFront();
            R.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ostatki O = new Ostatki();
            O.TopLevel = false;
            panel3.Controls.Add(O);
            O.BringToFront();
            O.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fakt_ostatkii2 F = new Fakt_ostatkii2();
            F.TopLevel = false;
            panel3.Controls.Add(F);
            F.BringToFront();
            F.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mesto_xraneniya M = new Mesto_xraneniya();
            M.TopLevel = false;
            panel3.Controls.Add(M);
            M.BringToFront();
            M.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Otcheti O = new Otcheti();
            O.TopLevel = false;
            panel3.Controls.Add(O);
            O.BringToFront();
            O.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fakt_otchet Ot = new fakt_otchet();
            Ot.TopLevel = false;
            panel3.Controls.Add(Ot);
            Ot.BringToFront();
            Ot.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
