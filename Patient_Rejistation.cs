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
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Hospital_Manegment_System
{
    public partial class Patient_Rejistation : Form
    {
        public Patient_Rejistation()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=DESKTOP-65B58K9\SQLEXPRESS;Initial Catalog=Hospital_Managment_System;Integrated Security=True;");

        private void Displaypatient()
        {
            try
            {
                con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //go to appinment
            Appoinment f4 = new Appoinment();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //go to main manue
            Main_Manue f2 = new Main_Manue();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //clear code
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
        }

        private void Patient_Rejistation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_Managment_SystemDataSet1.Pation' table. You can move, or remove it, as needed.
            this.pationTableAdapter.Fill(this.hospital_Managment_SystemDataSet1.Pation);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "") 
                {
                    MessageBox.Show("Missing Information");
                }
                else
                    {
                        con.Open();
                        string query = "insert into Pation Values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Entered Successfully");
                       // Displaypatient();
                    }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || dateTimePicker1.Text == "" || textBox7.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "update pation set p_Name =@p_Name, p_DOB =@p_DOB, p_Gender =@p_Gender, p_Age =@p_Age, P_Blood =@P_Blood, p_tel =@p_tel, p_Address =@p_Address where p_Id = @p_Id ";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.Parameters.AddWithValue("@p_Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p_DOB", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@p_Gender", textBox7.Text);
                    cmd.Parameters.AddWithValue("@p_Age", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p_Blood", textBox4.Text);
                    cmd.Parameters.AddWithValue("@p_Tel", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p_Address", textBox6.Text);
                    cmd.Parameters.AddWithValue("@p_Id", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully");
                    //Displaypatient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString: @"Data Source=DESKTOP-65B58K9\SQLEXPRESS;Initial Catalog=Hospital_Managment_System;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Pation",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
        }
    }
}
