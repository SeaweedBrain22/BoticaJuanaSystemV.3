namespace BoticaJuanaSystem
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TXTBX_PASSWORD = new TextBox();
            BTN_LOGIN = new Button();
            LBL_FORGOTPASSWORD = new LinkLabel();
            LBL_NOACCOUNT = new LinkLabel();
            TXTBX_USERNAME = new TextBox();
            Username = new Label();
            Password = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TXTBX_PASSWORD
            // 
            TXTBX_PASSWORD.Anchor = AnchorStyles.None;
            TXTBX_PASSWORD.ForeColor = Color.FromArgb(64, 64, 64);
            TXTBX_PASSWORD.Location = new Point(19, 84);
            TXTBX_PASSWORD.Name = "TXTBX_PASSWORD";
            TXTBX_PASSWORD.Size = new Size(281, 23);
            TXTBX_PASSWORD.TabIndex = 6;
            TXTBX_PASSWORD.TextAlign = HorizontalAlignment.Center;
            // 
            // BTN_LOGIN
            // 
            BTN_LOGIN.Anchor = AnchorStyles.None;
            BTN_LOGIN.BackColor = Color.Transparent;
            BTN_LOGIN.Location = new Point(362, 309);
            BTN_LOGIN.Name = "BTN_LOGIN";
            BTN_LOGIN.Size = new Size(125, 43);
            BTN_LOGIN.TabIndex = 7;
            BTN_LOGIN.Text = "LOGIN";
            BTN_LOGIN.UseVisualStyleBackColor = false;
            BTN_LOGIN.Click += button1_Click;
            // 
            // LBL_FORGOTPASSWORD
            // 
            LBL_FORGOTPASSWORD.Anchor = AnchorStyles.None;
            LBL_FORGOTPASSWORD.AutoSize = true;
            LBL_FORGOTPASSWORD.BackColor = SystemColors.HighlightText;
            LBL_FORGOTPASSWORD.Font = new Font("Segoe UI", 8F);
            LBL_FORGOTPASSWORD.LinkColor = Color.DarkViolet;
            LBL_FORGOTPASSWORD.Location = new Point(16, 123);
            LBL_FORGOTPASSWORD.Name = "LBL_FORGOTPASSWORD";
            LBL_FORGOTPASSWORD.Size = new Size(114, 13);
            LBL_FORGOTPASSWORD.TabIndex = 8;
            LBL_FORGOTPASSWORD.TabStop = true;
            LBL_FORGOTPASSWORD.Text = "FORGOT PASSWORD";
            this.LBL_FORGOTPASSWORD.LinkClicked += this.LBL_FORGOTPASSWORD_LinkedClicked;         
          
         

            // 
            // LBL_NOACCOUNT
            // 
            LBL_NOACCOUNT.Anchor = AnchorStyles.None;
            LBL_NOACCOUNT.AutoSize = true;
            LBL_NOACCOUNT.BackColor = SystemColors.HighlightText;
            LBL_NOACCOUNT.Font = new Font("Segoe UI", 8F);
            LBL_NOACCOUNT.LinkColor = Color.DarkViolet;
            LBL_NOACCOUNT.Location = new Point(5, 148);
            LBL_NOACCOUNT.Name = "LBL_NOACCOUNT";
            LBL_NOACCOUNT.Size = new Size(295, 13);
            LBL_NOACCOUNT.TabIndex = 9;
            LBL_NOACCOUNT.TabStop = true;
            LBL_NOACCOUNT.Text = "CLICK HERE TO CREATE A ACCOUNT IF NO ACCOUNT YET";
            LBL_NOACCOUNT.LinkClicked += LBL_NOACCOUNT_LinkClicked;
            // 
            // TXTBX_USERNAME
            // 
            TXTBX_USERNAME.Anchor = AnchorStyles.None;
            TXTBX_USERNAME.Location = new Point(16, 24);
            TXTBX_USERNAME.Name = "TXTBX_USERNAME";
            TXTBX_USERNAME.Size = new Size(281, 23);
            TXTBX_USERNAME.TabIndex = 10;
            TXTBX_USERNAME.TextAlign = HorizontalAlignment.Center;
            TXTBX_USERNAME.TextChanged += textBox2_TextChanged;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(16, 6);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 11;
            Username.Text = "Username";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            Username.Click += label3_Click_1;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.BackColor = Color.Transparent;
            Password.Location = new Point(19, 66);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 12;
            Password.Text = "Password";
            Password.TextAlign = ContentAlignment.MiddleCenter;
            Password.Click += label4_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(5, 168);
            label2.Name = "label2";
            label2.Size = new Size(191, 21);
            label2.TabIndex = 13;
            label2.Text = "Term and condition policy";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 41);
            label1.TabIndex = 14;
            label1.Text = "BOTICA JOANA";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TXTBX_USERNAME);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(LBL_NOACCOUNT);
            panel1.Controls.Add(TXTBX_PASSWORD);
            panel1.Controls.Add(LBL_FORGOTPASSWORD);
            panel1.Location = new Point(276, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 193);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fcf2b81e_14b1_432f_8401_1b9a6fd73b19__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(BTN_LOGIN);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Botica Juana System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        
        private TextBox TXTBX_PASSWORD;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TextBox TXTBX_USERNAME;
        private Label Username;
        private Button BTN_LOGIN;
        private Label Password;
        private LinkLabel LBL_FORGOTPASSWORD;
        private LinkLabel LBL_NOACCOUNT;
        private Label label2;
        private Panel panel1;
    }
}