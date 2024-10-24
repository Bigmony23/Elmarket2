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
    public partial class Sedbaaar : Form
    {
        public Sedbaaar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Tovars t = new Tovars();
            t.TopLevel = false;
            panel3.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }

        private void Sedbaaar_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Prixod P = new Prixod();
            P.TopLevel = false;
            panel3.Controls.Add(P);
            P.BringToFront();
            P.Show();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Rasxod R = new Rasxod();
            R.TopLevel = false;
            panel3.Controls.Add(R);
            R.BringToFront();
            R.Show();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Ostatki O = new Ostatki();
            O.TopLevel = false;
            panel3.Controls.Add(O);
            O.BringToFront();
            O.Show();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Fakt_ostatkii2 F = new Fakt_ostatkii2();
            F.TopLevel = false;
            panel3.Controls.Add(F);
            F.BringToFront();
            F.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Mesto_xraneniya M = new Mesto_xraneniya();
            M.TopLevel = false;
            panel3.Controls.Add(M);
            M.BringToFront();
            M.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Otcheti O = new Otcheti();
            O.TopLevel = false;
            panel3.Controls.Add(O);
            O.BringToFront();
            O.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            fakt_otchet Ot = new fakt_otchet();
            Ot.TopLevel = false;
            panel3.Controls.Add(Ot);
            Ot.BringToFront();
            Ot.Show();
        }
    }   
}
