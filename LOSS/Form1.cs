using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUIControls;

namespace LOSS
{
    public partial class Form1 : Form
    {
        private readonly LoginControl _loginControl = new LoginControl();
        private readonly HeaderControl _headerControl = new HeaderControl();

        private int _clientTop = 0;
        private int _clientBottom = 0;
        private int _clientLeft = 0;
        private int _clientRight = 0;

        public Form1()
        {
            InitializeComponent();
            AddHeader();
            SetClientArea();
#if DEBUG
            btnExit.Visible = true;
#endif

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _loginControl.LoginRequestedEvent += _loginControl_LoginRequestedEvent;
            _loginControl.LoginNotRequestedEvent += _loginControl_LoginNotRequestedEvent;

        }

        private void _loginControl_LoginNotRequestedEvent()
        {
           // Show dialog - then exit.
            Application.ExitThread();
            Application.Exit();

        }

        private void _loginControl_LoginRequestedEvent(string uname, string pwd, string mword)
        {
            // See if new user (Create user) or
            // existing user (log user in) or
            // panicing user (destroy data)
        }

        #region Main Form

        #region Form GUI Controls Add

        private void AddHeader()
        {

            _headerControl.Dock = DockStyle.Top;
            Controls.Add(_headerControl);
            Refresh();

        }

        #endregion

        #region Form Helpers

        private void SetClientArea()
        {
            _clientTop = _headerControl.Bottom + 20;
            _clientBottom = Bottom - 20;
            _clientLeft = Left + 20;
            _clientRight = Right - 20;
        }

        #endregion

        #region Form Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetClientArea();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExit.Enabled = false;
            _loginControl.Left = (Width / 2) - (_loginControl.Width / 2);
            _loginControl.Top = (Height / 2) - (_loginControl.Height / 2);
            Controls.Add(_loginControl);
            Refresh();
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control == _loginControl) btnExit.Enabled = true;
        }


        #endregion


        #endregion


    }
}
