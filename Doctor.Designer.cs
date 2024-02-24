namespace Hospital_Management_System
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            homebtn = new Button();
            resetbtn = new Button();
            deletebtn = new Button();
            updatebtn = new Button();
            addbtn = new Button();
            CrossHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 37);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 4;
            label1.Text = "Doctor";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(530, 129);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 5;
            label2.Text = "Y.O.E";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(381, 129);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(178, 129);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 7;
            label4.Text = "Doctor-Name";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 129);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 8;
            label5.Text = "DoctorID";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(633, 129);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 23);
            label6.TabIndex = 9;
            label6.Text = "Licensce ID";
            label6.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(12, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(530, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(178, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(635, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 27);
            textBox4.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.DeepSkyBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Female", "Male", "Others" });
            comboBox2.Location = new Point(381, 174);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(88, 28);
            comboBox2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 230);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.DeepSkyBlue;
            homebtn.Location = new Point(554, 503);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(117, 48);
            homebtn.TabIndex = 18;
            homebtn.Text = "HOME";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.DeepSkyBlue;
            resetbtn.Location = new Point(419, 503);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(118, 48);
            resetbtn.TabIndex = 19;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.DeepSkyBlue;
            deletebtn.Location = new Point(286, 503);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(112, 48);
            deletebtn.TabIndex = 20;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DeepSkyBlue;
            updatebtn.Location = new Point(149, 503);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(116, 48);
            updatebtn.TabIndex = 21;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DeepSkyBlue;
            addbtn.Location = new Point(12, 503);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(114, 48);
            addbtn.TabIndex = 22;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // CrossHome
            // 
            CrossHome.BackColor = Color.DeepSkyBlue;
            CrossHome.Location = new Point(836, 1);
            CrossHome.Name = "CrossHome";
            CrossHome.Size = new Size(37, 34);
            CrossHome.TabIndex = 23;
            CrossHome.Text = "X";
            CrossHome.UseVisualStyleBackColor = false;
            CrossHome.UseWaitCursor = true;
            CrossHome.Click += CrossHome_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(874, 582);
            Controls.Add(CrossHome);
            Controls.Add(addbtn);
            Controls.Add(updatebtn);
            Controls.Add(deletebtn);
            Controls.Add(resetbtn);
            Controls.Add(homebtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Doctor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Button homebtn;
        private Button resetbtn;
        private Button deletebtn;
        private Button updatebtn;
        private Button addbtn;
        private Button CrossHome;
    }
}