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
using Jewellery_Repair_Window_2019.Controls.Settings_Controls;

namespace Jewellery_Repair_Window_2019.Controls
{
    public partial class Settings_Control : UserControl
    {
        public Settings_Control()
        {
            InitializeComponent();
        }

        private void New_User_Button_Click(object sender, EventArgs e)
        {
         

                New_User_Control NUC = new New_User_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(NUC);

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["New_User_Control"].BringToFront();
        }
    }
}
