using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using borderless_windowless;

namespace Jewellery_Repair_Window_2019.Controls
{
    public partial class Logout_Success_Control : UserControl
    {
        public Logout_Success_Control()
        {
            InitializeComponent();
        }

        private void Home_Timer_Tick(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Logout_Control"))
            {

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Main_Control"].BringToFront();
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Logout_Control"].Dispose();

            }
        }
    }
}
