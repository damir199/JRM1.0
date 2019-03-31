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
using Jewellery_Repair_System;

namespace Jewellery_Repair_Window_2019.Controls
{
    public partial class Create_Outworker_Control : UserControl
    {
        public Create_Outworker_Control()
        {
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if (Outworker_Name_TB.Text.Length != 0 && Outworker_Company_TB.Text.Length != 0 && Outworker_Add1_TB.Text.Length != 0 && Outworker_Postcode_TB.Text.Length != 0 && Outworker_Phone_TB.Text.Length != 0 && Outworker_Mobile_TB.Text.Length != 0 && Outworker_Email_TB.Text.Length != 0 && Outworker_Status_CB.Text.Length != 0) 
                {
                    string O_Name = Outworker_Name_TB.Text.ToString();
                    string O_Company = Outworker_Company_TB.Text.ToString();
                    string O_Add1 = Outworker_Add1_TB.Text.ToString();
                    string O_Add2 = Outworker_Add2_TB.Text.ToString();
                    string O_Postcode = Outworker_Postcode_TB.Text.ToString();
                    string O_Phone = Outworker_Phone_TB.Text.ToString();
                    string O_Mobile = Outworker_Mobile_TB.Text.ToString();
                    string O_Email = Outworker_Email_TB.Text.ToString();
                    string O_Status = Outworker_Status_CB.SelectedItem.ToString();

                    if (Create_Outworker.Create_Outworker_Func(O_Name, O_Company, O_Add1, O_Add2, O_Postcode, O_Phone, O_Mobile, O_Email, O_Status) == true){
                        Outworker_Success_Control OS = new Outworker_Success_Control
                        {
                            Dock = DockStyle.Fill
                        };
                        Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(OS);
                        Main_Form.Instance.Inner_Body_Panel_Container.Controls["Outworker_Success_Control"].BringToFront();

                    }
                    
                }else{
                MessageBox.Show("There's Been An Error Creating The Outworker.");
            }
                

            }
        }
    }

