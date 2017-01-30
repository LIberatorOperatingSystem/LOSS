using System;
using System.Windows.Forms;

namespace GUIControls
{
    public partial class LoginControl : UserControl
    {

        public delegate void LoginRequestedDelegate(string uname, string pwd, string mword);
        public event LoginRequestedDelegate LoginRequestedEvent;

        public delegate void LoginNotRequestedDelegate();
        public event LoginNotRequestedDelegate LoginNotRequestedEvent;

        public LoginControl()
        {
            InitializeComponent();
            inputValidControl1.False();
            inputValidControl2.False();
            inputValidControl3.False();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginNotRequestedEvent?.Invoke();
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           LoginRequestedEvent?.Invoke(textBox1.Text,textBox2.Text,textBox3.Text); 
        }

        /// <summary>
        /// Username
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Enter(object sender, EventArgs e)
        {
            inputValidControl1.Visible = true;
            if(textBox1.Text.Length > 5) inputValidControl1.True();
            else inputValidControl1.False();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            inputValidControl1.Visible = true;
            if (textBox1.Text.Length > 5) inputValidControl1.True();
            else inputValidControl1.False();

            if (AllValidated())
            {
                btnLogin.Visible = true;
                btnLogin.Enabled = true;
            }

           

        }

        private bool AllValidated()
        {
            if ((bool) inputValidControl1.Tag && (bool) inputValidControl2.Tag && (bool) inputValidControl3.Tag)
                return true;
                      
                return false;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            inputValidControl2.Visible = true;
            if (textBox2.Text.Length > 7) inputValidControl2.True();
            else inputValidControl2.False();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            inputValidControl2.Visible = true;
            if (textBox2.Text.Length > 7) inputValidControl2.True();
            else inputValidControl2.False();

            if (AllValidated())
            {
                btnLogin.Visible = true;
                btnLogin.Enabled = true;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            inputValidControl3.Visible = true;
            if (textBox3.Text.Length > 5) inputValidControl3.True();
            else inputValidControl3.False();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            inputValidControl3.Visible = true;
            if (textBox3.Text.Length > 5) inputValidControl3.True();
            else inputValidControl3.False();

            if (AllValidated())
            {
                btnLogin.Visible = true;
                btnLogin.Enabled = true;
            }
        }

    }
}
