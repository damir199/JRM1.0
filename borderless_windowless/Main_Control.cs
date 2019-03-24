using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borderless_windowless
{
    public partial class Main_Control : UserControl
    {
        public Main_Control()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {
                Login_Control LC = new Login_Control();
                LC.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(LC);
                

            }
            Form1.Instance.Body_Panel_Container.Controls["Login_Control"].BringToFront();           
        }

        private void Find_Repair_Button_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Find_Rep_Control FRC = new Find_Rep_Control();
                FRC.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(FRC);

            }
            Form1.Instance.Body_Panel_Container.Controls["Find_Rep_Control"].BringToFront();
        }

        private void Find_Customer_Button_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Find_Customer_Control FUC = new Find_Customer_Control();
                FUC.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(FUC);

            }
            Form1.Instance.Body_Panel_Container.Controls["Find_Customer_Control"].BringToFront();
        }

        private void Create_Repair_Button_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Create_Repair_Control CR = new Create_Repair_Control();
                CR.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(CR);

            }
            Form1.Instance.Body_Panel_Container.Controls["Create_Repair_Control"].BringToFront();

        }

        private void Create_Customer_Button_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
            {

                Create_User_Control CU = new Create_User_Control();
                CU.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(CU);

            }
            Form1.Instance.Body_Panel_Container.Controls["Create_User_Control"].BringToFront();
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

            if (!Form1.Instance.Body_Panel_Container.Controls.ContainsKey("Home_Control"))
                {
                
                View_User_Control VU = new View_User_Control();
                VU.Dock = DockStyle.Fill;
                Form1.Instance.Body_Panel_Container.Controls.Add(VU);
                
                 }
            Form1.Instance.Body_Panel_Container.Controls["View_User_Control"].BringToFront();
            
        }
    }
}
