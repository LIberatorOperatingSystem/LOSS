using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIControls
{
    public  partial class HeaderControl: UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
           
        }

        private void HeaderControl_ParentChanged(object sender, EventArgs e)
        {
            lblInstructionsText.ForeColor = Parent.ForeColor;
        }
    }
}
