using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antiaircraft
{
    public partial class Secenekler : Form
    {
        private bool klavyemi_faremi;
        public Secenekler()
        {
           this.CenterToScreen();
            InitializeComponent();
        }

        private void Secenekler_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void pb_yon_tuslari_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void pb_fare_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                klavyemi_faremi = true;
            else if (radioButton2.Checked == true)
                klavyemi_faremi = false;

            Form1 f1 = new Form1(klavyemi_faremi);
            f1.Show();
            this.Hide();
          
        }
    }
}
