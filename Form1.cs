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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new Tovars();
            newForm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            newForm.Show();
            //this.Hide(); // Скрываем текущую форму
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Prixod();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
            //this.Hide(); // Скрываем текущую форму
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Rasxod();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
            //this.Hide(); // Скрываем текущую форму
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Ostatki ();
            ifrm.FormBorderStyle = FormBorderStyle.FixedDialog; // Устанавливаем форму в режим диалогового окна
            ifrm.Show();
            //this.Hide(); // Скрываем текущую форму
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
