using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace antiaircraft
{
    public partial class Form1 : Form
    {
        private bool klavyemi_faremi;
        private int skor = 0;
        private bool oyun_bittimi = false;

        public Form1(bool klavyemi_faremi)
        {
            this.klavyemi_faremi = klavyemi_faremi;
            this.CenterToScreen();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (klavyemi_faremi == true)
            {
                oyun_bilgi.Text = "Oyunu başlatmak için ENTER tuşuna basınız"
              + "\nUçaksavarı haraket ettirmek için SAĞ/SOL YÖN TUŞLARINI kullanın"
              + "\nAteş etmek için BOŞLUK tuşuna basınız";
            }
            else if (klavyemi_faremi == false)
            {
                oyun_bilgi.Text = "Oyunu başlatmak için ENTER tuşuna basınız"
              + "\nUçaksavarı haraket ettirmek için FAREYİ kullanın"
              + "\nAteş etmek için FARENİN SAĞ tuşuna basınız";
                this.Cursor = new Cursor(Cursor.Current.Handle);
            }

            this.CenterToScreen();
            gulle_zaman.Start();
            dusman_zaman.Stop();
            patlatma.Stop();
            dusman_haraket.Stop();
            fare_zaman.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (oyun_bittimi == false)
                {
                    gulle_zaman.Start();
                    dusman_zaman.Start();
                    patlatma.Start();
                    dusman_haraket.Start();
                }
                else
                {
                    this.Refresh();
                    Refresh();
                    this.Hide();
                    Form1 ss = new Form1(klavyemi_faremi);
                    ss.Show();
                }
            }

            if (klavyemi_faremi == true)//klavye
            {
                klavye(sender, e);
            }
            else if (klavyemi_faremi == false)
            {
                fare();
            }
        }

        public void klavye(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pb_ucak.Left <= 0)
                        pb_ucak.Left = 0;
                    else
                        pb_ucak.Left -= 30;
                    break;

                case Keys.Right:
                    if (pb_ucak.Left > this.Width - (5 + pb_ucak.Width))
                        pb_ucak.Left = this.Width - pb_ucak.Width - 4;
                    else
                        pb_ucak.Left += 30;
                    break;

                case Keys.Space:
                    if (oyun_bittimi == false)
                        gulle_ekle();
                    break;
            }
        }

        public void fare()
        {
            // Cursor.Hide();
            pb_ucak.Left = Cursor.Position.X - 300;

            if (pb_ucak.Left <= 0)
                pb_ucak.Left = 0;
            if (pb_ucak.Left > this.Width - (5 + pb_ucak.Width))
                pb_ucak.Left = this.Width - pb_ucak.Width - 4;
        }

        private void gulle_ekle()
        {
            PictureBox gulle = new PictureBox();
            gulle.Image = Properties.Resources.gulle1;
            gulle.SizeMode = PictureBoxSizeMode.StretchImage;
            gulle.SetBounds(pb_ucak.Location.X + gulle.Width / 8, pb_ucak.Location.Y - 20, 25, 35);
            this.Controls.Add(gulle);
            gulle.Visible = true;
        }

        private void dusman_ekle()
        {
            Random konum = new Random();
            PictureBox dusman = new PictureBox();
            dusman.Image = Properties.Resources.dusman1;
            int locationX = konum.Next(10, this.Width - 97);
            dusman.SizeMode = PictureBoxSizeMode.StretchImage;
            dusman.SetBounds(locationX, 10, 50, 50);
            this.Controls.Add(dusman);
            dusman.Visible = true;
        }

        private void gulle_zaman_Tick(object sender, EventArgs e)
        {
            foreach (Control gulle_bul in this.Controls)
            {
                if (gulle_bul.GetType() == typeof(PictureBox))
                {
                    PictureBox kontrol_gulle = gulle_bul as PictureBox;
                    if (kontrol_gulle.Height == 35)
                    {
                        if (kontrol_gulle.Location.Y > 0)
                        {
                            kontrol_gulle.Top -= 5;
                        }
                        else
                        {
                            kontrol_gulle.Dispose();
                        }
                    }
                }
            }
        }

        private void dusman_zaman_Tick(object sender, EventArgs e)
        {
            dusman_ekle();
        }

        private void dusman_haraket_Tick(object sender, EventArgs e)
        {
            foreach (Control dusman_bul in this.Controls)
            {
                if (dusman_bul.GetType() == typeof(PictureBox))
                {
                    PictureBox dusman = dusman_bul as PictureBox;
                    if (dusman.Height == 50)
                    {
                        if (dusman.Location.Y >= pb_ucak.Location.Y - 40 && dusman.Location.Y <= pb_ucak.Location.Y + 40)
                        {
                            if (dusman.Location.X >= pb_ucak.Location.X - 55 && dusman.Location.X <= pb_ucak.Location.X + 55)
                            {
                                gulle_zaman.Stop();
                                dusman_zaman.Stop();
                                patlatma.Stop();
                                dusman_haraket.Stop();
                                oyun_bittimi = true;
                            }
                        }

                        if (dusman.Location.Y >= this.Height - 95)
                        {
                            gulle_zaman.Stop();
                            dusman_zaman.Stop();
                            patlatma.Stop();
                            dusman_haraket.Stop();
                            oyun_bittimi = true;
                        }
                        dusman.SetBounds(dusman.Location.X, dusman.Location.Y + 3, 50, 50);
                    }
                }
            }
        }

        private void patlatma_Tick(object sender, EventArgs e)
        {
            patladimi();
        }

        public bool patladimi()
        {
            List<PictureBox> gulle_listesi = new List<PictureBox>();
            List<PictureBox> dusman_listesi = new List<PictureBox>();

            foreach (Control gulle_ve_dusman in this.Controls)
            {
                if (gulle_ve_dusman.GetType() == typeof(PictureBox))
                {
                    if (gulle_ve_dusman.Height == 35)
                    {
                        gulle_listesi.Add((PictureBox)gulle_ve_dusman);
                    }
                    else if (gulle_ve_dusman.Height == 50)
                    {
                        dusman_listesi.Add((PictureBox)gulle_ve_dusman);
                    }
                }
            }
            for (int i = 0; i < dusman_listesi.Count; i++)
            {
                for (int j = 0; j < gulle_listesi.Count; j++)
                {
                    if (patlat(dusman_listesi[i], gulle_listesi[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool patlat(PictureBox dusman, PictureBox mermi)
        {
            try
            {
                if ((mermi.Location.Y >= dusman.Location.Y - 25 && mermi.Location.Y <= dusman.Location.Y + 35) && (mermi.Location.X >= dusman.Location.X - 20 && mermi.Location.X <= dusman.Location.X + 32))
                {
                    mermi.Dispose();
                    dusman.Dispose();
                    skor++;
                    lb_skor.Text = "Skor:" + skor.ToString();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void fare_zaman_Tick(object sender, EventArgs e)
        {
            if (klavyemi_faremi == false)//fare
                fare();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (oyun_bittimi == false)
                if (klavyemi_faremi == false)//fare
                    gulle_ekle();
        }

        private void oyun_bilgi_Click(object sender, EventArgs e)
        {
        }
    }
}