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
    public partial class Outworker_Success_Control : UserControl
    {
        public Outworker_Success_Control()
        {
            InitializeComponent();
        }

        private void Home_Control_Timer_Tick(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Outworker_Success_Control"))
            {

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Create_Repair_Control"].BringToFront();
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Outworker_Success_Control"].Dispose();

            }
        }
    }
}
