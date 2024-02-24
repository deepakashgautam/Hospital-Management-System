using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            displayDoctor();
        }

        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DEEPA\OneDrive\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");

        public void displayDoctor()
        {
            try
            {
                connection.Open();
                string query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            displayDoctor();
        }

        private void CrossHome_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }
                else
                {
                    connection.Open();
                    string query = " insert into Doctor Values('" + textBox1.Text + "', ' " + textBox2.Text + " ', ' " + comboBox2.Text + " ', ' " + textBox3.Text + " ', ' " + textBox4.Text + " ' )";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("DATA SUCCESSFULLY INSERTED");
                    displayDoctor();

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
            comboBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")
                {
                    MessageBox.Show("Enter The Doctor ID");

                }
                else
                {
                    connection.Open();
                    string query = "DELETE FROM Doctor WHERE DocId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Succesfully");
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

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == " " || textBox2.Text == " " || comboBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE Doctor Set DocName =@DocName, DocGen=@DocGen, Experience= @Experience, Licence= @Licence WHERE DocId= @DocId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DocName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@DocGen", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Experience", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Licence", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DocId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record UpDated Successfully");

                    displayDoctor();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

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
