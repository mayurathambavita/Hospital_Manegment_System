using Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Manegment_System
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verify the user wants to exit
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to clear all?", "Clear all", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UserNameInput.Clear();
                PasswrdInput.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user Name & Password
            string username = UserNameInput.Text;
            string Password = PasswrdInput.Text;
            //after cliking login Butting what do
            if (username == "Admin" && Password == "Pass@1234")
            {
                //condition true
                MessageBox.Show("Login Success");
                Main_Manue f2 = new Main_Manue();
                f2.Show();
                this.Hide();
            }
            else 
            {
                //condition false
                MessageBox.Show("Try Again");
            }
                
        }
    }
}
