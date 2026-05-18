using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BoticaJuanaSystem
{
    public partial class Registration : Form
    {
        private Form _loginForm;
        public Registration(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loginForm != null)
            {
                _loginForm.Show();
            }
            this.Close();
        }
        private void BTN_RETURN_Clicked(object sender,EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Dispose();
        }
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            BTN_REGISTRATION = new Button();
            BTN_RETURN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(119, 76);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "ENTER USERNAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(256, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(256, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(119, 133);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "ENTER PASSWORD";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(119, 182);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "CONFIRM PASSWORD";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(256, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(235, 23);
            textBox3.TabIndex = 5;
            // 
            // BTN_REGISTRATION
            // 
            BTN_REGISTRATION.Anchor = AnchorStyles.None;
            BTN_REGISTRATION.Location = new Point(296, 226);
            BTN_REGISTRATION.Name = "BTN_REGISTRATION";
            BTN_REGISTRATION.Size = new Size(124, 35);
            BTN_REGISTRATION.TabIndex = 6;
            BTN_REGISTRATION.Text = "Register Now";
            BTN_REGISTRATION.UseVisualStyleBackColor = true;
            BTN_REGISTRATION.Click += BTN_REGISTRATION_Click;
            // 
            // BTN_RETURN
            // 
            BTN_RETURN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN_RETURN.Location = new Point(671, 24);
            BTN_RETURN.Name = "BTN_RETURN";
            BTN_RETURN.Size = new Size(140, 23);
            BTN_RETURN.TabIndex = 7;
            BTN_RETURN.Text = "RETURN TO LOGIN";
            BTN_RETURN.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            ClientSize = new Size(867, 428);
            Controls.Add(BTN_RETURN);
            Controls.Add(BTN_REGISTRATION);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Registration";
            ResumeLayout(false);
            PerformLayout();

        }

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Button BTN_RETURN;
        private Button BTN_REGISTRATION;
    }
}
