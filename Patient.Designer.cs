namespace Hospital_Management_System
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            resetbtn = new Button();
            homebtn = new Button();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox1 = new PictureBox();
            CrossHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(503, 306);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 9;
            label5.Text = "PHONE_No.";
            label5.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(503, 377);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 10;
            label1.Text = "DISEASE";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(503, 239);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 11;
            label2.Text = "BLOODGROUP";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(503, 170);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 12;
            label3.Text = "GENDER";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 170);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 13;
            label4.Text = "PATIENT ID";
            label4.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 377);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 23);
            label6.TabIndex = 14;
            label6.Text = "PATIENT AGE";
            label6.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 306);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 15;
            label7.Text = "ADDRESS";
            label7.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 239);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(166, 23);
            label8.TabIndex = 16;
            label8.Text = "PATIENT NAME";
            label8.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DeepSkyBlue;
            textBox4.Location = new Point(206, 378);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 27);
            textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DeepSkyBlue;
            textBox3.Location = new Point(206, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DeepSkyBlue;
            textBox2.Location = new Point(206, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DeepSkyBlue;
            textBox1.Location = new Point(206, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DeepSkyBlue;
            textBox5.Location = new Point(660, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DeepSkyBlue;
            textBox6.Location = new Point(660, 373);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 22;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.DeepSkyBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B+", "O+", "A-", "B-", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(660, 235);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(114, 28);
            comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.DeepSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female", "Male", "Others" });
            comboBox1.Location = new Point(660, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 28);
            comboBox1.TabIndex = 24;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DeepSkyBlue;
            addbtn.Location = new Point(963, 411);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(114, 48);
            addbtn.TabIndex = 25;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.DeepSkyBlue;
            updatebtn.Location = new Point(963, 465);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(114, 48);
            updatebtn.TabIndex = 26;
            updatebtn.Text = "UPDATE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.DeepSkyBlue;
            deletebtn.Location = new Point(963, 519);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(116, 48);
            deletebtn.TabIndex = 27;
            deletebtn.Text = "DELETE";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.DeepSkyBlue;
            resetbtn.Location = new Point(963, 573);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(114, 48);
            resetbtn.TabIndex = 28;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.DeepSkyBlue;
            homebtn.Location = new Point(963, 627);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(112, 48);
            homebtn.TabIndex = 29;
            homebtn.Text = "HOME";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(146, 59);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 23);
            label9.TabIndex = 30;
            label9.Text = "PATIENT";
            label9.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.DeepSkyBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 411);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(945, 300);
            dataGridView2.TabIndex = 31;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(841, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // CrossHome
            // 
            CrossHome.BackColor = Color.DeepSkyBlue;
            CrossHome.Location = new Point(1052, 0);
            CrossHome.Name = "CrossHome";
            CrossHome.Size = new Size(37, 34);
            CrossHome.TabIndex = 33;
            CrossHome.Text = "X";
            CrossHome.UseVisualStyleBackColor = false;
            CrossHome.UseWaitCursor = true;
            CrossHome.Click += CrossHome_Click;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1089, 723);
            Controls.Add(CrossHome);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView2);
            Controls.Add(label9);
            Controls.Add(homebtn);
            Controls.Add(resetbtn);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(addbtn);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button resetbtn;
        private Button homebtn;
        private Label label9;
        private DataGridView dataGridView2;
        private PictureBox pictureBox1;
        private Button CrossHome;
    }
}