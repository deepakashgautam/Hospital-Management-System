namespace Hospital_Management_System
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            admin.Text = " ";
            password.Text = " ";
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (admin.Text == "" && password.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (admin.Text == "Admin" && password.Text == "Password")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct User Name And Password");
            }
        }
    }
}