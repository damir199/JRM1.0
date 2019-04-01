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
using Jewellery_Repair_Window_2019.Functional_Classes;

namespace Jewellery_Repair_System
{
    public partial class Find_Rep_Control : UserControl
    {
        public Find_Rep_Control()
        {
            InitializeComponent();
        }

        private void Search_Repair_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Find_Rep_Control"))
            {
                string input = Repair_ID_TB.Text.ToString();
                List<String> Data = Find_Repair.Find_Repair_Query(input);
                

                View_Repair_Control VRC = new View_Repair_Control(Data)
                {
                    Dock = DockStyle.Fill                   
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(VRC);

            }
           Main_Form.Instance.Inner_Body_Panel_Container.Controls["View_Repair_Control"].BringToFront();

         
        }
    }
}
