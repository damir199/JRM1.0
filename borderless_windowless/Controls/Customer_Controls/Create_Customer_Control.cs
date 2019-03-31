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
    public partial class Create_User_Control : UserControl
    {
        public Create_User_Control()
        {
            InitializeComponent();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            string Fname = First_Name_TB.Text.ToString();
            string Lname = Last_Name_TB.Text.ToString();
            string Addres1 = Add_Line1_TB.Text.ToString();
            string Addres2 = Add_Line2_TB.Text.ToString();
            string Postcode = Postcode_TB.Text.ToString();
            string Phone = Phone_TB.Text.ToString();
            string Mobile = Mobile_TB.Text.ToString();
            string Email = Email_TB.Text.ToString();
            string Contact_Pref = Contact_Pref_CB.Text.ToString();

            if (Create_Customer.Create_Customer_Func(Fname, Lname, Addres1, Addres2, Postcode, Phone, Mobile, Email, Contact_Pref) == true)
            {
                Customer_Success_Control CC = new Customer_Success_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CC);
                Main_Form.Instance.Inner_Body_Panel_Container.Controls["Customer_Success_Control"].BringToFront();

            }
            else
            {
                MessageBox.Show("There's Been An Error Creating Your Repair.");

            };
        }
    }
}
