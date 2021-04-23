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
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }

        private void Leaderboard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Resource1.Uang,0, 0, 1056, 789);
        }

        private void Leaderboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu fmenu = new Menu();
            fmenu.Show();
            this.Hide();
        }

        private void btnBackLeader_Click(object sender, EventArgs e)
        {
            Menu fmenu = new Menu();
            fmenu.Show();
            this.Hide();
        }
    }
}
