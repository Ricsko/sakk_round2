using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakk
{


    public partial class Form1 : Form
    {

        static PictureBox[,] jatekter = new PictureBox[8, 8];
        static PictureBox aktBabu = new PictureBox();
        static List<string> babukfeher = new List<string>();
        static List<string> babukfekete = new List<string>();
        static int aktSzin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void inditas_Click(object sender, EventArgs e)
        {
            nevellenorzes();
            gofullscreen();
        }

        private void gofullscreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void nevellenorzes()
        {
            /* string nev1 = jatekos1TBOX.Text;
             string nev2 = jatekos2TBOX.Text;

             if(nev1 == "" || nev2 == "")
             {
                 MessageBox.Show("Adja meg a játékosok nevét!");
             }
             else
             {

             }*/

            gombeltuntetes();
            jatektergeneralas();
        }

        private void jatektergeneralas()
        {
            int x = 0;
            int y = 0;
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Size = new Size(800, 800);
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(this.ClientSize.Width / 2 - pictureBox1.Size.Width / 2, this.ClientSize.Height / 2 - pictureBox1.Size.Height / 2);
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BringToFront();
            this.Controls.Add(pictureBox1);


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox palya = new PictureBox();
                    palya.Size = new Size(100, 100);
                    palya.Location = new Point(x, y);
                    palya.Name = $"{i}_{j}";
                    //palya.BackgroundImageLayout = ImageLayout.Zoom;
                    palya.MouseClick += new MouseEventHandler(mozgatasClick);
                    if ((i + j) % 2 == 0)
                    {
                        palya.BackColor = Color.Purple;
                    }
                    else
                    {
                        palya.BackColor = Color.Pink;
                    }
                    pictureBox1.Controls.Add(palya);
                    jatekter[i, j] = palya;

                    x += 100;
                }

                x = 0;
                y += 100;
            }

            whtsurrenderBTN.Visible = true;
            blcksurrenderBTN.Visible = true;


            babuGen();
        }

        private void babuGen()
        {
            //FEHÉR BÁBÚK

            jatekter[0, 0].BackgroundImage = babuk.Images[0];
            jatekter[0, 0].Name += "_0_bastya";
            babukfeher.Add(jatekter[0, 0].Name.Split('_')[3]);

            jatekter[0, 7].BackgroundImage = babuk.Images[0];
            jatekter[0, 7].Name += "_0_bastya";
            babukfeher.Add(jatekter[0, 7].Name.Split('_')[3]);

            jatekter[0, 1].BackgroundImage = babuk.Images[1];
            jatekter[0, 1].Name += "_0_huszar";
            babukfeher.Add(jatekter[0, 1].Name.Split('_')[3]);

            jatekter[0, 6].BackgroundImage = babuk.Images[1];
            jatekter[0, 6].Name += "_0_huszar";
            babukfeher.Add(jatekter[0, 6].Name.Split('_')[3]);

            jatekter[0, 2].BackgroundImage = babuk.Images[2];
            jatekter[0, 2].Name += "_0_futo";
            babukfeher.Add(jatekter[0, 2].Name.Split('_')[3]);

            jatekter[0, 5].BackgroundImage = babuk.Images[2];
            jatekter[0, 5].Name += "_0_futo";
            babukfeher.Add(jatekter[0, 5].Name.Split('_')[3]);

            jatekter[0, 3].BackgroundImage = babuk.Images[4];
            jatekter[0, 3].Name += "_0_kiralyno";
            babukfeher.Add(jatekter[0, 3].Name.Split('_')[3]);

            jatekter[0, 4].BackgroundImage = babuk.Images[3];
            jatekter[0, 4].Name += "_0_kiraly";
            babukfeher.Add(jatekter[0, 4].Name.Split('_')[3]);


            for (int i = 0; i < 8; i++)
            {
                jatekter[1, i].BackgroundImage = babuk.Images[5];
                jatekter[1, i].Name += $"_0_paraszt";
                babukfeher.Add(jatekter[1, i].Name.Split('_')[3]);
            }


            //FEKETE BÁBÚK
            jatekter[7, 0].BackgroundImage = babuk.Images[6];
            jatekter[7, 0].Name += "_1_bastya";
            babukfekete.Add(jatekter[7, 0].Name.Split('_')[3]);

            jatekter[7, 7].BackgroundImage = babuk.Images[6];
            jatekter[7, 7].Name += "_1_bastya";
            babukfekete.Add(jatekter[7, 7].Name.Split('_')[3]);

            jatekter[7, 1].BackgroundImage = babuk.Images[7];
            jatekter[7, 1].Name += "_1_huszar";
            babukfekete.Add(jatekter[7, 1].Name.Split('_')[3]);

            jatekter[7, 6].BackgroundImage = babuk.Images[7];
            jatekter[7, 6].Name += "_1_huszar";
            babukfekete.Add(jatekter[7, 6].Name.Split('_')[3]);

            jatekter[7, 2].BackgroundImage = babuk.Images[8];
            jatekter[7, 2].Name += "_1_futo";
            babukfekete.Add(jatekter[7, 2].Name.Split('_')[3]);

            jatekter[7, 5].BackgroundImage = babuk.Images[8];
            jatekter[7, 5].Name += "_1_futo";
            babukfekete.Add(jatekter[7, 5].Name.Split('_')[3]);

            jatekter[7, 3].BackgroundImage = babuk.Images[10];
            jatekter[7, 3].Name += "_1_kiralyno";
            babukfekete.Add(jatekter[7, 3].Name.Split('_')[3]);

            jatekter[7, 4].BackgroundImage = babuk.Images[9];
            jatekter[7, 4].Name += "_1_kiraly";
            babukfekete.Add(jatekter[7, 4].Name.Split('_')[3]);

            for (int i = 0; i < 8; i++)
            {
                jatekter[6, i].BackgroundImage = babuk.Images[11];
                jatekter[6, i].Name += $"_1_paraszt";
                babukfekete.Add(jatekter[6, i].Name.Split('_')[3]);
            }
        }

        private void mozgatasClick(object sender, EventArgs e)
        {
            PictureBox klikkelt = sender as PictureBox;
            string babuTipus = "";
            int babuSzin = -1;

            if (klikkelt.BackgroundImage != null)
            {
                babuTipus = klikkelt.Name.Split('_')[3];
                babuSzin = Convert.ToInt32(klikkelt.Name.Split('_')[2]);
            }

            switch (babuTipus)
            {
                case "paraszt":
                    lepesParaszt(klikkelt);
                    break;

                case "bastya":
                    lepesBastya(klikkelt);
                    break;
            }

            if (klikkelt.BackColor == Color.Violet && aktBabu.BackgroundImage != null)
            {
                klikkelt.BackgroundImage = aktBabu.BackgroundImage;
                klikkelt.Name += $"_{aktBabu.Name.Split('_')[2]}_{aktBabu.Name.Split('_')[3]}";
                jatekter[Convert.ToInt32(aktBabu.Name.Split('_')[0]), Convert.ToInt32(aktBabu.Name.Split('_')[1])].BackgroundImage = null;
                jatekter[Convert.ToInt32(aktBabu.Name.Split('_')[0]), Convert.ToInt32(aktBabu.Name.Split('_')[1])].Name = $"{aktBabu.Name.Split('_')[0]}_{aktBabu.Name.Split('_')[1]}";

                if ((Convert.ToInt32(klikkelt.Name.Split('_')[0]) + Convert.ToInt32(klikkelt.Name.Split('_')[1])) % 2 == 0)
                {
                    jatekter[Convert.ToInt32(klikkelt.Name.Split('_')[0]), Convert.ToInt32(klikkelt.Name.Split('_')[1])].BackColor = Color.Purple;
                }
                else
                {
                    jatekter[Convert.ToInt32(klikkelt.Name.Split('_')[0]), Convert.ToInt32(klikkelt.Name.Split('_')[1])].BackColor = Color.Pink;
                }

                aktSzin++;
            }

            MessageBox.Show(klikkelt.Name);
        }

        private void lepesBastya(PictureBox klikkelt)
        {
            aktBabu.Name = klikkelt.Name;
            aktBabu.BackgroundImage = klikkelt.BackgroundImage;

            int sor = Convert.ToInt32(aktBabu.Name.Split('_')[0]);
            int oszl = Convert.ToInt32(aktBabu.Name.Split('_')[1]);
            int babuSzin = Convert.ToInt32(aktBabu.Name.Split('_')[2]);
            
            
        }

        private void lepesParaszt(PictureBox klikkelt)
        {
            aktBabu.Name = klikkelt.Name;
            aktBabu.BackgroundImage = klikkelt.BackgroundImage;

            int sor = Convert.ToInt32(aktBabu.Name.Split('_')[0]);
            int oszl = Convert.ToInt32(aktBabu.Name.Split('_')[1]);
            int babuSzin = Convert.ToInt32(aktBabu.Name.Split('_')[2]);
            int segedSzorz = 1;

            if (babuSzin == 1)
            {
                segedSzorz = -segedSzorz;
            }
            else
            {
                segedSzorz = 1;
            }

            if(jatekter[sor + segedSzorz, oszl].BackgroundImage != null)
            {
                MessageBox.Show("A kiválaztott bábu nem képes a lépésre!");
                aktBabu.BackgroundImage = null;
                aktBabu.Name = "";
            }
            else
            {
                jatekter[sor + segedSzorz, oszl].BackColor = Color.Violet;
            }
        }

        private void gombeltuntetes()
        {
            jatekos1.Visible = false;
            jatekos2.Visible = false;
            jatekos1TBOX.Visible = false;
            jatekos2TBOX.Visible = false;
            inditas.Visible = false;
            title.Visible = false;
            szabalyok.Visible = false;
            kep.Visible = false;
            credits.Visible = false;
        }

        private void szabalyok_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Sakk");
        }

        private void újraindításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{jatekos1TBOX.Text} feladta a játékot. A nyertes: {jatekos2TBOX.Text}");
            Application.Restart();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{jatekos2TBOX.Text} feladta a játékot. A nyertes: {jatekos1TBOX.Text}");
            Application.Restart();
        }
    }
}
