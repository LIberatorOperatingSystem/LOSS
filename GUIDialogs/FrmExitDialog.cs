using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDialogs
{
    public partial class FrmExitDialog : Form
    {

        public delegate void LoginRequestedDelegate();
        public event LoginRequestedDelegate LoginRequestedEvent;
        public delegate void ExitRequestedDelegate();
        public event ExitRequestedDelegate ExitRequestedEvent;

        public FrmExitDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginRequestedEvent?.Invoke();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ExitRequestedEvent?.Invoke();            
        }
    }
}
