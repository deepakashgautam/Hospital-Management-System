using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            displayPatient();
        }

        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DEEPA\OneDrive\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");

        public void displayPatient()
        {
            try
            {
                connection.Open();
                string query = "select * from Patient";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox5.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }
                else
                {
                    connection.Open();
                    string query = " insert into Patient Values('" + textBox1.Text + "', ' " + textBox2.Text + " ', ' " + textBox3.Text + " ', ' " + textBox4.Text + " ', ' " + comboBox1.Text + " ', ' " + comboBox2.Text + " ',  ' " + textBox5.Text + " ',  ' " + textBox6.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("DATA SUCCESSFULLY INSERTED");
                    displayPatient();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CrossHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " || textBox5.Text == " " || textBox6.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }

                else
                {
                    connection.Open();
                    string query = "UPDATE patient Set PName =@PName, PAddress=@PAddress, PAge= @PAge, PPhone= @PPhone, PGen=@PGen, BloodGroup=@BloodGroup, Disease=@Disease WHERE PId= @PId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@PAddress", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PAge", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PPhone", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PGen", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Disease", textBox6.Text);
                    cmd.Parameters.AddWithValue("@PId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record UpDated Successfully");

                    displayPatient();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter The PATIENT ID");

                }
                else
                {
                    connection.Open();
                    string query = "DELETE FROM Patient WHERE PId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Succesfully");
                    displayPatient();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();

            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                comboBox2.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }
    }
}

