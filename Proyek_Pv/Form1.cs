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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Resource1.Be_A_Millioner, 15, 17, 700, 100);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Berhasil");
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard l = new Leaderboard();
            l.Show();
            this.Hide();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PilihPlayer fplihplayer = new PilihPlayer();
            fplihplayer.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            setting fsetting = new setting();
            fsetting.Show();
            this.Hide();
        }
    }
}
