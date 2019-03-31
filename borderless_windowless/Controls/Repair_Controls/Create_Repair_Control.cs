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
    public partial class Create_Repair_Control : UserControl
    {
        public Create_Repair_Control()
        {
            InitializeComponent();
        }



        private void Add_Repair_Button_Click(object sender, EventArgs e)
        {
            //Validation of Text Boxes to see if they are not empty.
            if (Item_Notes_TB.Text.Length != 0 && Work_Required_TB.Text.Length != 0 && Condition_CB.Text.Length != 0 && Condition_CB.Text.Length != 0 ) {
                string Category = Categories_CB.SelectedItem.ToString();
                string Condition = Condition_CB.SelectedItem.ToString();
                string Work_Required = Work_Required_TB.Text.ToString();
                string Notes = Item_Notes_TB.Text.ToString();

                if (Create_Repair.Create_Repair_Func(Category, Condition, Work_Required, Notes) == true) {
                    Repair_Success_Control CR_SC = new Repair_Success_Control
                    {
                        Dock = DockStyle.Fill
                    };
                    Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CR_SC);
                    Main_Form.Instance.Inner_Body_Panel_Container.Controls["Repair_Success_Control"].BringToFront();

                } else {
                    MessageBox.Show("There's Been An Error Creating Your Repair.");

                };
            }
            else
            {
                MessageBox.Show("Please Fill In All The Fields Before Proceeding!");
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
    
   
