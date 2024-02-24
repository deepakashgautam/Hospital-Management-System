using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Management_System
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();

        }
        readonly SqlConnection connection = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DEEPA\OneDrive\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");

        public void displayDiagnosis()
        {
            try
            {
                connection.Open();
                string query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];
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


        void displayPatientId()
        {
            string sql = "Select * from Patient";
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader rdr;

            try
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox.ValueMember = "PId";
                comboBox.DataSource = dt;
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



        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }
                else
                {
                    connection.Open();
                    string query = " insert into Diagnosis Values('" + textBox1.Text + "', '" + comboBox.Text + "', '" + textBox2.Text + " ', '" + textBox3.Text + "', '" + textBox4.Text + "',  '" + textBox5.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("DATA SUCCESSFULLY INSERTED");
                    displayDiagnosis();

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
                if (textBox1.Text == " " || comboBox.Text == " " || textBox2.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("ENTER THE DATA");
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE Diagnosis Set PatientId =@PatientId, PatientName=@PatientName, Symptoms= @Symptoms, DiagnosisTest= @DiagnosisTest, Medicines=@Medicines WHERE DId= @DId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox.Text);
                    cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Diagnosis", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Medicine", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record UpDated Successfully");

                    displayDiagnosis();

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
                    MessageBox.Show("Enter The DIAGNOSIS ID");

                }
                else
                {
                    connection.Open();
                    string query = "DELETE FROM Diagnosis WHERE DId='" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Succesfully");
                    displayDiagnosis();
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";

        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                comboBox.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();

                //To show the summary of the Patient

                label1.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                label2.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                label3.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                label4.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();

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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            displayPatientId();
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            displayPatientName();
        }

        string pname;

        void displayPatientName()
        {
            try
            {
                connection.Open();
                string ss = " select * from patient WHERE PId =" + comboBox.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(ss, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter();
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["pname"].ToString();
                    textBox2.Text = pname;
                }

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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPatientName();

        }

        private void CrossHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}