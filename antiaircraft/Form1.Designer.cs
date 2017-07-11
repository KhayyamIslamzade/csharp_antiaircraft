namespace antiaircraft
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.konum = new System.Windows.Forms.Label();
            this.dusman_zaman = new System.Windows.Forms.Timer(this.components);
            this.gulle_zaman = new System.Windows.Forms.Timer(this.components);
            this.dusman_haraket = new System.Windows.Forms.Timer(this.components);
            this.patlatma = new System.Windows.Forms.Timer(this.components);
            this.pb_ucak = new System.Windows.Forms.PictureBox();
            this.fare_zaman = new System.Windows.Forms.Timer(this.components);
            this.oyun_bilgi = new System.Windows.Forms.Label();
            this.lb_skor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ucak)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // konum
            // 
            this.konum.Location = new System.Drawing.Point(0, 0);
            this.konum.Name = "konum";
            this.konum.Size = new System.Drawing.Size(100, 23);
            this.konum.TabIndex = 5;
            // 
            // dusman_zaman
            // 
            this.dusman_zaman.Interval = 700;
            this.dusman_zaman.Tick += new System.EventHandler(this.dusman_zaman_Tick);
            // 
            // gulle_zaman
            // 
            this.gulle_zaman.Interval = 1;
            this.gulle_zaman.Tick += new System.EventHandler(this.gulle_zaman_Tick);
            // 
            // dusman_haraket
            // 
            this.dusman_haraket.Interval = 30;
            this.dusman_haraket.Tick += new System.EventHandler(this.dusman_haraket_Tick);
            // 
            // patlatma
            // 
            this.patlatma.Interval = 10;
            this.patlatma.Tick += new System.EventHandler(this.patlatma_Tick);
            // 
            // pb_ucak
            // 
            this.pb_ucak.Image = global::antiaircraft.Properties.Resources.ucak3;
            this.pb_ucak.Location = new System.Drawing.Point(378, 441);
            this.pb_ucak.Name = "pb_ucak";
            this.pb_ucak.Size = new System.Drawing.Size(45, 60);
            this.pb_ucak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ucak.TabIndex = 0;
            this.pb_ucak.TabStop = false;
            // 
            // fare_zaman
            // 
            this.fare_zaman.Interval = 10;
            this.fare_zaman.Tick += new System.EventHandler(this.fare_zaman_Tick);
            // 
            // oyun_bilgi
            // 
            this.oyun_bilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.oyun_bilgi.AutoSize = true;
            this.oyun_bilgi.BackColor = System.Drawing.Color.Transparent;
            this.oyun_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyun_bilgi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.oyun_bilgi.Location = new System.Drawing.Point(3, 0);
            this.oyun_bilgi.Name = "oyun_bilgi";
            this.oyun_bilgi.Size = new System.Drawing.Size(59, 15);
            this.oyun_bilgi.TabIndex = 3;
            this.oyun_bilgi.Text = "oyun bilgi";
            this.oyun_bilgi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.oyun_bilgi.Click += new System.EventHandler(this.oyun_bilgi_Click);
            // 
            // lb_skor
            // 
            this.lb_skor.AutoSize = true;
            this.lb_skor.ForeColor = System.Drawing.Color.Red;
            this.lb_skor.Location = new System.Drawing.Point(723, 9);
            this.lb_skor.Name = "lb_skor";
            this.lb_skor.Size = new System.Drawing.Size(32, 13);
            this.lb_skor.TabIndex = 4;
            this.lb_skor.Text = "Skor:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.oyun_bilgi);
            this.panel1.Controls.Add(this.lb_skor);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 61);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.konum);
            this.Controls.Add(this.pb_ucak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ucak)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ucak;
        private System.Windows.Forms.Label konum;
        private System.Windows.Forms.Timer dusman_zaman;
        private System.Windows.Forms.Timer gulle_zaman;
        private System.Windows.Forms.Timer dusman_haraket;
        private System.Windows.Forms.Timer patlatma;
        private System.Windows.Forms.Timer fare_zaman;
        private System.Windows.Forms.Label oyun_bilgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_skor;
    }
}

