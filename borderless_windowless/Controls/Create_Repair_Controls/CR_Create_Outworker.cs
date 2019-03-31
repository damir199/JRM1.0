using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jewellery_Repair_System;

namespace Jewellery_Repair_Window_2019.Controls
{
    public partial class CR_Create_Outworker : UserControl
    {
        public CR_Create_Outworker()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("CR_Create_Outworker"))
            {
                Outworker_Success_Control OWS = new Outworker_Success_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(OWS);
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Outworker_Success_Control"].BringToFront();
            }
        }

    }
}
