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
    public partial class Create_Repair_Control : UserControl
    {
        public Create_Repair_Control()
        {
            InitializeComponent();
        }

        private void Add_Repair_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Repair_Control"))
            {
                Repair_Success_Control RS = new Repair_Success_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(RS);
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Repair_Success_Control"].BringToFront();
            }
            

        }
        private void CR_New_Customer_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Repair_Control"))
            {

                CR_Create_Customer CR_CC = new CR_Create_Customer
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CR_CC);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["CR_Create_Customer"].BringToFront();
        }
        private void CR_Add_Outworker_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Repair_Control"))
            {

                CR_Create_Outworker CR_OW = new CR_Create_Outworker
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CR_OW);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["CR_Create_Outworker"].BringToFront();
        }
        private void Cancel_Repair_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Repair_Control"))
            {

                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Main_Control"].BringToFront();

            }
        }

        private void Find_Customer_Button_Click(object sender, EventArgs e)
        {
            if (Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Create_Repair_Control"))
            {
                
                
            
            }

        }

        private void Clear_Outworker_Button_Click(object sender, EventArgs e)
        {
            Outworker_Address_TB.Clear();
            Outworker_Company_TB.Clear();
            Outworker_Name_TB.Clear();
        }
    }
    }
    
   
