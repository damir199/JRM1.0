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

namespace borderless_windowless
{
    public partial class Create_User_Control : UserControl
    {
        public Create_User_Control()
        {
            InitializeComponent();
        }

        private void confirm_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Customer_Control"))
            {
                Customer_Success_Control CSC = new Customer_Success_Control();
                {
                    Dock = DockStyle.Fill;
                }
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CSC);
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Customer_Success_Control"].BringToFront();
            }
        }
    }
}
