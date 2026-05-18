using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace BoticaJuanaSystem
{
    public partial class ForgotPassword : Form
    {
        private Form _loginForm;
        public ForgotPassword()
        {
            InitializeComponent();
            _loginForm = new Form();

        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
        private void BTN_FORGOTPASSWORD_Clicked(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loginForm != null)
            {
                _loginForm.Show();

            }

        }

        private void BTN_RETURNLOGIN_Click(object sender, EventArgs e)
        {

        }
    }
}
