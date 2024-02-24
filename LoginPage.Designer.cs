namespace Hospital_Management_System
{
    partial class LOGIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            admn = new Label();
            admin = new RichTextBox();
            password = new RichTextBox();
            pswd = new Label();
            loginBtn = new Button();
            clrBtn = new Button();
            crossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 27);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 23);
            label1.TabIndex = 0;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(438, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // admn
            // 
            admn.AutoSize = true;
            admn.Location = new Point(218, 289);
            admn.Margin = new Padding(5, 0, 5, 0);
            admn.Name = "admn";
            admn.Size = new Size(75, 23);
            admn.TabIndex = 2;
            admn.Text = "ADMIN";
            // 
            // admin
            // 
            admin.BackColor = Color.DeepSkyBlue;
            admin.Location = new Point(400, 286);
            admin.Name = "admin";
            admin.Size = new Size(353, 42);
            admin.TabIndex = 3;
            admin.Text = "";
            admin.TextChanged += richTextBox1_TextChanged;
            // 
            // password
            // 
            password.BackColor = Color.DeepSkyBlue;
            password.Location = new Point(400, 360);
            password.Name = "password";
            password.Size = new Size(353, 42);
            password.TabIndex = 4;
            password.Text = "";
            // 
            // pswd
            // 
            pswd.AutoSize = true;
            pswd.Location = new Point(218, 363);
            pswd.Margin = new Padding(5, 0, 5, 0);
            pswd.Name = "pswd";
            pswd.Size = new Size(114, 23);
            pswd.TabIndex = 6;
            pswd.Text = "PASSWORD";
            pswd.Click += password_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.DeepSkyBlue;
            loginBtn.Location = new Point(515, 444);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(131, 50);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.DeepSkyBlue;
            clrBtn.Location = new Point(515, 520);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(131, 50);
            clrBtn.TabIndex = 8;
            clrBtn.Text = "CLEAR";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // crossBtn
            // 
            crossBtn.BackColor = Color.DeepSkyBlue;
            crossBtn.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            crossBtn.Location = new Point(1126, 0);
            crossBtn.Name = "crossBtn";
            crossBtn.Size = new Size(59, 50);
            crossBtn.TabIndex = 9;
            crossBtn.Text = "X";
            crossBtn.UseVisualStyleBackColor = false;
            crossBtn.Click += crossBtn_Click;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1184, 649);
            Controls.Add(crossBtn);
            Controls.Add(clrBtn);
            Controls.Add(loginBtn);
            Controls.Add(pswd);
            Controls.Add(password);
            Controls.Add(admin);
            Controls.Add(admn);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "LOGIN";
            Text = "LOGIN";
            Load += LOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label admn;
        private RichTextBox admin;
        private RichTextBox password;
        private Label pswd;
        private Button loginBtn;
        private Button clrBtn;
        private Button crossBtn;
    }
}