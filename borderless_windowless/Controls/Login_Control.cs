using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewellery_Repair_System
{
    public partial class Login_Control : UserControl
    {
        public Login_Control()
        {
            InitializeComponent();
        }


        private void Login_Button_Click(object sender, EventArgs e)
        {
            string user = Username_TB.Text.ToString();
            string pass = Password_TB.Text.ToString();
            if (Functional_Classes.Employee_Login_Val.Employee_Login_Auth(user, pass) == true)
            {
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Main_Control"].BringToFront();
            }
        }
    }
}
