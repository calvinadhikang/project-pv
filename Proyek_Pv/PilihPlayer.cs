using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_Pv
{
    public partial class PilihPlayer : Form
    {
        public PilihPlayer()
        {
            InitializeComponent();
        }

        int jumlah = -1;
        List<string> namaplayer = new List<string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            namaplayer.Add(textBox1.Text);
            namaplayer.Add(textBox2.Text);
            if (jumlah == 3)
            {
                namaplayer.Add(textBox3.Text);
            }

            Map fmap = new Map(jumlah, namaplayer);
            fmap.Show();
            this.Hide();
        }

        private void PilihPlayer_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jumlah = 3;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jumlah = 2;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;

            label1.Visible = true;
            label3.Visible = true;
            label2.Visible = false;

            button1.Enabled = true;
        }

        private void btnBackPlayer_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            form1.Show();
            this.Hide();
        }
    }
}
