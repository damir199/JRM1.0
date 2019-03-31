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

namespace Jewellery_Repair_System
{
    public partial class Main_Control : UserControl
    {
        public Main_Control()
        {
            InitializeComponent();
        }

        //These are the controls on The Main Form For NAvigation around System.
        //They are comprised of Buttons on a Grid Layout with an inner Panel.
        private void Repairs_Button_Click(object sender, EventArgs e)
        {

        }
        private void Customers_Button_Click(object sender, EventArgs e)
        {

        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {
                Login_Control LC = new Login_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(LC);
                

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Login_Control"].BringToFront();
        }
        private void Find_Repair_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Find_Rep_Control FRC = new Find_Rep_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(FRC);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Find_Rep_Control"].BringToFront();
        }
        private void Logout_Button_Click(object sender, EventArgs e)
        {
            /* if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            * {
            *
            *     View_Repair_Control VR = new View_Repair_Control();
            *     VR.Dock = DockStyle.Fill;
           *      Form1.Instance.Body_Panel_Container.Controls.Add(VR);
           *
            * }
            * Form1.Instance.Body_Panel_Container.Controls["View_Repair_Control"].BringToFront();
            * */

            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {
                Logout_Success_Control LC = new Logout_Success_Control()
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(LC);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Logout_Control"].BringToFront();

           /* if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
           *{

           *     View_User_Control VU = new View_User_Control
           *     {
            *        Dock = DockStyle.Fill
            *    };
             *   Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(VU);
*
          *  }
         *   Main_Form.Instance.Inner_Body_Panel_Container.Controls["View_User_Control"].BringToFront();
*/
        }
        private void Create_Customer_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Create_User_Control CU = new Create_User_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CU);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Create_User_Control"].BringToFront();
        }
        private void Find_Customer_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Find_Customer_Control FUC = new Find_Customer_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(FUC);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Find_Customer_Control"].BringToFront();
        }
        private void Create_Repair_Button_Click(object sender, EventArgs e)
        {
            if (!Main_Form.Instance.Inner_Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Create_Repair_Control CR = new Create_Repair_Control
                {
                    Dock = DockStyle.Fill
                };
                Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(CR);

            }
            Main_Form.Instance.Inner_Body_Panel_Container.Controls["Create_Repair_Control"].BringToFront();

        }
    }
}
