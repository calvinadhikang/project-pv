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
    public partial class Map : Form
    {
        public Map(int jumlahplayer, List<string> namaplayer)
        {
            InitializeComponent();
            jumlah_player = jumlahplayer;
            temp = namaplayer;
        }
        public struct Daerah {
            public string nama_daerah;
            public int x_daerah;
            public int y_daerah;
            public int pemilik; //index pemilik => -1 blum punya || pemilik => -2 bukan untuk dibeli
            public int harga;
        }

        public struct Player {
            public string nama;
            public int duit;
            public int player_move;
        }
        //diisi dengan jumlah player saat mau start
        int jumlah_player;

        void isilistplayer()// untuk isi data pemain...
        {
            for (int i = 0; i < jumlah_player; i++)
            {
                listpemain[i].nama = temp[i];
                listpemain[i].duit = 500;
                listpemain[i].player_move = 0;
            }
        }

        List<string> temp;
        Player[] listpemain = new Player[3]; //untuk tampung pemain
        Daerah[] arr_daerah = new Daerah[20];

        List<Label> labelpemain = new List<Label>();
        List<Label> bg_bannerpemain = new List<Label>();

        void isidatadearah()
        {
            //perbedaan = 150
            //jarak x dengan tepi = 25
            //jarak y dengan tepi = 25

            //=====================================================
            //ini data batas kirii..
            arr_daerah[5].nama_daerah = "Penjara -> Hanya Lewat";
            arr_daerah[5].x_daerah = 25;
            arr_daerah[5].y_daerah = 25 + 0;
            arr_daerah[5].harga = 0;

            arr_daerah[4].nama_daerah = "Raja Ampat";
            arr_daerah[4].x_daerah = 25;
            arr_daerah[4].y_daerah = 25 + 150;
            arr_daerah[4].harga = 45;

            arr_daerah[3].nama_daerah = "Semarang";
            arr_daerah[3].x_daerah = 25;
            arr_daerah[3].y_daerah = 25 + 300;
            arr_daerah[3].harga = 40;

            arr_daerah[2].nama_daerah = "Bank";
            arr_daerah[2].x_daerah = 25;
            arr_daerah[2].y_daerah = 25 + 450;
            arr_daerah[2].harga = 30;

            arr_daerah[1].nama_daerah = "Surabaya";
            arr_daerah[1].x_daerah = 25;
            arr_daerah[1].y_daerah = 25 + 600;
            arr_daerah[1].harga = 40;

            arr_daerah[0].nama_daerah = "Start";
            arr_daerah[0].x_daerah = 25;
            arr_daerah[0].y_daerah = 25 + 750;
            arr_daerah[0].harga = 100;

            //=====================================================
            // ini data batas atas...
            arr_daerah[6].nama_daerah = "Padang";
            arr_daerah[6].x_daerah = 25 + 150;
            arr_daerah[6].y_daerah = 25;
            arr_daerah[6].harga = 50;

            arr_daerah[7].nama_daerah = "Manado";
            arr_daerah[7].x_daerah = 25 + 300;
            arr_daerah[7].y_daerah = 25;
            arr_daerah[7].harga = 55;

            arr_daerah[8].nama_daerah = "Bayar Pajak";
            arr_daerah[8].x_daerah = 25 + 450;
            arr_daerah[8].y_daerah = 25;
            arr_daerah[8].harga = 20;

            arr_daerah[9].nama_daerah = "Malang";
            arr_daerah[9].x_daerah = 25 + 600;
            arr_daerah[9].y_daerah = 25;
            arr_daerah[9].harga = 60;

            arr_daerah[10].nama_daerah = "Free Parking";
            arr_daerah[10].x_daerah = 25 + 750;
            arr_daerah[10].y_daerah = 25;
            arr_daerah[10].harga = 0;

            //=====================================================
            // ini data batas kanan...
            arr_daerah[11].nama_daerah = "Gresik";
            arr_daerah[11].x_daerah = 25 + 750;
            arr_daerah[11].y_daerah = 25 + 150;
            arr_daerah[11].harga = 60;

            arr_daerah[12].nama_daerah = "Bank";
            arr_daerah[12].x_daerah = 25 + 750;
            arr_daerah[12].y_daerah = 25 + 300;
            arr_daerah[12].harga = 30;

            arr_daerah[13].nama_daerah = "Kediri";
            arr_daerah[13].x_daerah = 25 + 750;
            arr_daerah[13].y_daerah = 25 + 450;
            arr_daerah[13].harga = 65;

            arr_daerah[14].nama_daerah = "Yogyakarta";
            arr_daerah[14].x_daerah = 25 + 750;
            arr_daerah[14].y_daerah = 25 + 600;
            arr_daerah[14].harga = 70;

            arr_daerah[15].nama_daerah = "Masuk Penjara";
            arr_daerah[15].x_daerah = 25 + 750;
            arr_daerah[15].y_daerah = 25 + 750;
            arr_daerah[15].harga = 0;

            //=====================================================
            // ini data batas bawah...
            arr_daerah[16].nama_daerah = "Bandung";
            arr_daerah[16].x_daerah = 25 + 600;
            arr_daerah[16].y_daerah = 25 + 750;
            arr_daerah[16].harga = 80;

            arr_daerah[17].nama_daerah = "Bali";
            arr_daerah[17].x_daerah = 25 + 450;
            arr_daerah[17].y_daerah = 25 + 750;
            arr_daerah[17].harga = 80;

            arr_daerah[18].nama_daerah = "Bayar Pajak";
            arr_daerah[18].x_daerah = 25 + 300;
            arr_daerah[18].y_daerah = 25 + 750;
            arr_daerah[18].harga = 20;

            arr_daerah[19].nama_daerah = "Jakarta";
            arr_daerah[19].x_daerah = 25 + 150;
            arr_daerah[19].y_daerah = 25 + 750;
            arr_daerah[19].harga = 100;

            //mengisi nilai default setiap daerah tidak ada yang punya
            for (int i = 0; i < 20; i++)
            {
                if (i != 2 || i != 5 || i != 0 ||
                    i != 8 || i != 10 ||
                    i != 12 || i != 15 ||
                    i != 18)
                {
                    arr_daerah[i].pemilik = -1;
                }
                else {
                    arr_daerah[i].pemilik = -2;
                }
            }
        }

        private void panelDice_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(Resource1._6, 67, 45, 60, 60);

            if (dadu == 1)
            {
                g.DrawImage(Resource1._0, 67, 45, 60, 60);
            }
            else if (dadu == 2)
            {
                g.DrawImage(Resource1._1, 67, 45, 60, 60);
            }
            else if (dadu == 3)
            {
                g.DrawImage(Resource1._2, 67, 45, 60, 60);
            }
            else if (dadu == 4)
            {
                g.DrawImage(Resource1._3, 67, 45, 60, 60);
            }
            else if (dadu == 5)
            {
                g.DrawImage(Resource1._4, 67, 45, 60, 60);
            }
            else if (dadu == 6)
            {
                g.DrawImage(Resource1._5, 67, 45, 60, 60);
            }
        }

        int dadu;
        Random rnd = new Random();
        
        int urutan_player = 0; //urutan pemain yang mulai duluan !

        private void button1_Click(object sender, EventArgs e)
        {
            //this => buttonRoll
            dadu = rnd.Next(1, 7);

            moveplayer(dadu); //pindahkan player
            cekposisibuy(); //aktifkan button buy / tidak
            showasset();// isikan aset pemain yg aktif

            panelDice.Invalidate();
            

            buttonRoll.Enabled = false;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            isidatadearah();
            isilistplayer();
            buatplayerdimap();
            buatbannerplayer();
            showasset(); //tampilkan asset
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            ///////////
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(w, h);
        }

        void buatplayerdimap()//untuk tampilkan player sebagai label
        {
            for (int i = 0; i < jumlah_player; i++)
            {
                Label lb = new Label();
                if (i == 0)
                {
                    lb.BackColor = Color.Aqua;
                }
                else if (i == 1)
                {
                    lb.BackColor = Color.Yellow;
                }
                else if (i == 2)
                {
                    lb.BackColor = Color.Tomato;
                }
                lb.Text = listpemain[i].nama;
                lb.Size = new Size(100, 100);
                lb.Location = new Point(arr_daerah[listpemain[i].player_move].x_daerah, arr_daerah[listpemain[i].player_move].y_daerah);

                labelpemain.Add(lb);
                panelMaps.Controls.Add(lb);
            }
        }

        void moveplayer(int dadu) {
            int movepemain = listpemain[urutan_player].player_move += dadu; //tambahkan dahulu movenya
            if (movepemain >= 20) { // apabila move lebih dari 20 maka -20
                listpemain[urutan_player].player_move -= 20;
            }
            int xtobe = arr_daerah[listpemain[urutan_player].player_move].x_daerah;
            int ytobe = arr_daerah[listpemain[urutan_player].player_move].y_daerah;
            
            labelpemain[urutan_player].Location = new Point(xtobe, ytobe);
            
        }

        void buatbannerplayer() {
            int x = 0, y = 0;

            for (int i = 0; i < jumlah_player; i++)
            {
                Label bg = new Label();
                bg.Size = new Size(300, 200);
                bg.Location = new Point(x, y);
                if (i == urutan_player) { bg.BackColor = Color.Aqua; }
                else { bg.BackColor = Color.White; }

                Label nama = new Label();
                nama.Size = new Size(160,40);
                nama.Location = new Point(bg.Location.X + 20, bg.Location.Y + 40);
                //nama.BackColor = bg.BackColor;
                nama.Text = listpemain[i].nama;

                Label harga = new Label();
                harga.Size = new Size(160, 40);
                harga.Location = new Point(nama.Location.X, nama.Location.Y + 60);
                harga.Text = "$ " + listpemain[i].duit.ToString();

                bg_bannerpemain.Add(bg);

                panelbanner.Controls.Add(nama);
                panelbanner.Controls.Add(harga);
                panelbanner.Controls.Add(bg);

                y += 220; 
            }
        }

        private void btn_endturn_Click(object sender, EventArgs e)
        {
            urutan_player += 1;
            if (urutan_player >= jumlah_player) //apabila urutannya udah maks.. maka dikembalikan ke player urutan ke 0
            {
                urutan_player = 0;
            }

            for (int i = 0; i < bg_bannerpemain.Count; i++) //untuk ganti banner background color.. menunjukan mana player yang aktif
            {
                if (i == urutan_player)
                {
                    bg_bannerpemain[i].BackColor = Color.Aqua;
                }
                else
                {
                    bg_bannerpemain[i].BackColor = Color.White;
                }
            }

            buttonRoll.Enabled = true;
            showasset();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int playerposition = listpemain[urutan_player].player_move;

            //ini data daerah
            string namad = arr_daerah[playerposition].nama_daerah;
            int price = arr_daerah[playerposition].harga;

            //ini data user
            string namau = listpemain[urutan_player].nama;
            int money = listpemain[urutan_player].duit;
            
            //ask user
            DialogResult result = MessageBox.Show("Do you want to buy " + namad + " for $" + price, "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (arr_daerah[playerposition].pemilik == urutan_player)
                {
                    MessageBox.Show("Sudah Dimiliki !");
                    return;
                }
                if (money >= price)
                {
                    arr_daerah[playerposition].pemilik = urutan_player;
                    MessageBox.Show("Asset "+ namad + " has been added to " + namau);
                    listpemain[urutan_player].duit -= price;
                    //belum bisa tampilkan perubahan duit..
                    panelbanner.Controls.Clear();
                    buatbannerplayer();
                    showasset();
                }
                else
                {
                    MessageBox.Show("Insufficient Money !");
                }
            }
        }

        void cekposisibuy() {
            int playerposition = listpemain[urutan_player].player_move;

            if (playerposition == 0 || playerposition == 2 || playerposition == 5 ||
                playerposition == 8 || playerposition == 10 || playerposition == 12 || playerposition == 15 ||
                playerposition == 18)
            { 
                MessageBox.Show("Tak bisa buy" + playerposition);
                buttonBuy.Enabled = false;
            }
            else
            {
                buttonBuy.Enabled = true;
            }
        }

        private void buttonAsset_Click(object sender, EventArgs e)
        {
            //tampilkan asset suatu pemain
        }


        void showasset() {
            listBox1.Items.Clear();

            groupBox1.Text = listpemain[urutan_player].nama + "'s Assets";
            for (int i = 0; i < arr_daerah.Length; i++)
            {
                if (arr_daerah[i].pemilik == urutan_player)
                {
                    string sum = arr_daerah[i].nama_daerah + " -  $" + arr_daerah[i].harga;
                    listBox1.Items.Add(sum);
                }
            }
        }

        private void btn_sellasset_Click(object sender, EventArgs e)
        {

        }
        //FUNGSI KURANG
        // tampilkan asset user saat ini
        // bikin user free park saat sampai 'free park'
        // ban user yg sampai ke penjara
        // tambahkan dan kurangi uang user saat ini yg lewat start,bank,bayar pajak
        // denda user yang sampe ke asset user lain
    }
}
