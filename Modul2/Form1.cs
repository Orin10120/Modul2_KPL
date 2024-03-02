using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ukuran & letak window
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(480, 240);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //meminta input dari textbox1
            string input = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Menampilkan Inputan nama ke Label setelah tombol submit di tekan.
            this.label1.Text = "Halo " + this.textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
