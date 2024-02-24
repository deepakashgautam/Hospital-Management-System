namespace Hospital_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Doctor = new Button();
            button1 = new Button();
            diagnous = new Button();
            LOGOUT = new Button();
            CrossHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 1;
            label1.Text = "HOME";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(236, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(236, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.UseWaitCursor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(236, 343);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.UseWaitCursor = true;
            // 
            // Doctor
            // 
            Doctor.BackColor = Color.DeepSkyBlue;
            Doctor.Location = new Point(347, 12);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(94, 29);
            Doctor.TabIndex = 8;
            Doctor.Text = "DOCTOR";
            Doctor.UseVisualStyleBackColor = false;
            Doctor.UseWaitCursor = true;
            Doctor.Click += Doctor_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Location = new Point(347, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "PATIENT";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // diagnous
            // 
            diagnous.BackColor = Color.DeepSkyBlue;
            diagnous.Location = new Point(347, 241);
            diagnous.Name = "diagnous";
            diagnous.Size = new Size(94, 29);
            diagnous.TabIndex = 10;
            diagnous.Text = "DIAGNOUS";
            diagnous.UseVisualStyleBackColor = false;
            diagnous.UseWaitCursor = true;
            diagnous.Click += diagnous_Click;
            // 
            // LOGOUT
            // 
            LOGOUT.BackColor = Color.DeepSkyBlue;
            LOGOUT.Location = new Point(347, 343);
            LOGOUT.Name = "LOGOUT";
            LOGOUT.Size = new Size(94, 29);
            LOGOUT.TabIndex = 11;
            LOGOUT.Text = "LOGOUT";
            LOGOUT.UseVisualStyleBackColor = false;
            LOGOUT.UseWaitCursor = true;
            LOGOUT.Click += button3_Click;
            // 
            // CrossHome
            // 
            CrossHome.BackColor = Color.DeepSkyBlue;
            CrossHome.Location = new Point(765, -2);
            CrossHome.Name = "CrossHome";
            CrossHome.Size = new Size(37, 34);
            CrossHome.TabIndex = 12;
            CrossHome.Text = "X";
            CrossHome.UseVisualStyleBackColor = false;
            CrossHome.UseWaitCursor = true;
            CrossHome.Click += CrossHome_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(CrossHome);
            Controls.Add(LOGOUT);
            Controls.Add(diagnous);
            Controls.Add(button1);
            Controls.Add(Doctor);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X";
            UseWaitCursor = true;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button Doctor;
        private Button button1;
        private Button diagnous;
        private Button button3;
        private Button CrossHome;
        private Button LOGOUT;
    }
}