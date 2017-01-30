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
    public partial class InputValidControl : UserControl
    {
        public InputValidControl()
        {
            InitializeComponent();
        }

        public void True()
        {
            pbValidationdisplay.Image = Properties.Resources.Alarm_Tick_icon;
            pbValidationdisplay.Tag = (bool)true;
            pbValidationdisplay.Refresh();
        }

        public void False()
        {
            pbValidationdisplay.Image = Properties.Resources.Close_icon;
            pbValidationdisplay.Tag = (bool)false;
            pbValidationdisplay.Refresh();
        }
        
    }
}
