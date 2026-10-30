using Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hospital_Manegment_System
{
    public partial class Doctor_Rejistation : Form
    {
        public Doctor_Rejistation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear code
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Refresh();
            radioButton2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //go to main manue
            Main_Manue f2 = new Main_Manue();
            f2.Show();
            this.Hide();
        }

        private void GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
