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
    public partial class CR_Create_Customer : UserControl
    {
        public CR_Create_Customer()
        {
            InitializeComponent();
            
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
             if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("CR_Create_Customer"))
            {
                Customer_Success_Control CSC = new Customer_Success_Control();
                {
                    Dock = DockStyle.Fill;
                }
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CSC);
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Customer_Success_Control"].BringToFront();
            

            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("CR_Create_Customer"))
            {

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Create_Repair_Control"].BringToFront();

            }
            

        }
    }
}
