using System;
using System.Windows.Forms;
using GUIControls;
using GUIDialogs;

namespace LOSS
{
    public partial class FrmBootstrapper : Form
    {
        private readonly LoginControl _loginControl = new LoginControl();
        private readonly HeaderControl _headerControl = new HeaderControl();

        private FrmExitDialog _frmExitDialog;

       

        public FrmBootstrapper()
        {
            InitializeComponent();
            AddHeader();
           
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
            // Show dialog
            _frmExitDialog = new FrmExitDialog();
            _frmExitDialog.LoginRequestedEvent += FrmExitDialog_LoginRequestedEvent;
            _frmExitDialog.ExitRequestedEvent += FrmExitDialog_ExitRequestedEvent;
        }

        //TODO: Purge Memory
        private void FrmExitDialog_ExitRequestedEvent()
        {
           
            Application.ExitThread();
            Application.Exit();
        }

        private void FrmExitDialog_LoginRequestedEvent()
        {
            AddLoginControl();
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

        //TODO: Change this to a Dialog Form
        private void AddLoginControl()
        {

            btnExit.Enabled = false;
            _loginControl.Left = (Width / 2) - (_loginControl.Width / 2);
            _loginControl.Top = (Height / 2) - (_loginControl.Height / 2);
            Controls.Add(_loginControl);
            Refresh();
        }

        #endregion

        #region Form Helpers

       
        #endregion

        #region Form Events
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddLoginControl();
        }

        private void Form1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control == _loginControl) btnExit.Enabled = true;
        }


        #endregion


        #endregion


    }
}
