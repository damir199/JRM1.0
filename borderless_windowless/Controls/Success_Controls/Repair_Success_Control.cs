using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jewellery_Repair_Window_2019.Controls;
using Jewellery_Repair_System;

namespace Jewellery_Repair_Window_2019.Controls
{
    public partial class Repair_Success_Control : UserControl
    {
        public Repair_Success_Control()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Repair_Success_Control"))
            {

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Main_Control"].BringToFront();
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Repair_Success_Control"].Dispose();


            }
        }
    }
}
