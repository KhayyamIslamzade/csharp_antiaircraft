namespace antiaircraft
{
    partial class Secenekler
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pb_fare = new System.Windows.Forms.PictureBox();
            this.pb_yon_tuslari = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yon_tuslari)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(12, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoCheck = false;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(169, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pb_fare
            // 
            this.pb_fare.BackgroundImage = global::antiaircraft.Properties.Resources.pict__computer_mouse_computer_pictograms___vector_stencils_library_png__diagram_flowchart_example;
            this.pb_fare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_fare.Location = new System.Drawing.Point(169, 42);
            this.pb_fare.Name = "pb_fare";
            this.pb_fare.Size = new System.Drawing.Size(107, 84);
            this.pb_fare.TabIndex = 3;
            this.pb_fare.TabStop = false;
            this.pb_fare.Click += new System.EventHandler(this.pb_fare_Click);
            // 
            // pb_yon_tuslari
            // 
            this.pb_yon_tuslari.BackgroundImage = global::antiaircraft.Properties.Resources._264898_200;
            this.pb_yon_tuslari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_yon_tuslari.Location = new System.Drawing.Point(12, 42);
            this.pb_yon_tuslari.Name = "pb_yon_tuslari";
            this.pb_yon_tuslari.Size = new System.Drawing.Size(100, 84);
            this.pb_yon_tuslari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_yon_tuslari.TabIndex = 2;
            this.pb_yon_tuslari.TabStop = false;
            this.pb_yon_tuslari.Click += new System.EventHandler(this.pb_yon_tuslari_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(201, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oyun Kontröl türünü seçiniz";
            // 
            // Secenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_fare);
            this.Controls.Add(this.pb_yon_tuslari);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Secenekler";
            this.Text = "Secenekler";
            this.Load += new System.EventHandler(this.Secenekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yon_tuslari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pb_yon_tuslari;
        private System.Windows.Forms.PictureBox pb_fare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}