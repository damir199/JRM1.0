using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jewellery_Repair_Window_2019.Functional_Classes;

namespace Jewellery_Repair_System
{
    public partial class Find_Customer_Control : UserControl
    {
        public Find_Customer_Control()
        {
            InitializeComponent();
        }

        private void Search_Customer_Button_Click(object sender, EventArgs e)
        {

            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Find_Customer_Control"))
            {
                string input = Customer_ID_TB.Text.ToString();
                List<String> Data = Find_Customer.Find_Customer_Query(input);


                
                //{
                //    Dock = DockStyle.Fill
               // };
                //Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(VCC);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["View_Repair_Control"].BringToFront();
        }
    }
}
