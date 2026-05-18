using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BoticaJuanaSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_NOACCOUNT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationForm = new Registration(this);
            registrationForm.Show();
            this.Hide();
        }
        private void LBL_FORGOTPASSWORD_LinkedClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword();
            forgotForm.Show();
            this.Hide();
        }
        private void BTN_RETURNLOGIN_Clicked(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            
            forgot.Show();
            this.Hide();

        }
        private void BTN_RETURN_Clicked(object sender, EventArgs e)
        {
            Registration registration = new Registration(this);
            

            registration.Show();
            this.Hide();
        }
        private void Login_LoginClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        }
    }


