using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borderless_windowless
{
    public partial class Main_Form : Form
    {
        static Main_Form _obj;

        public static Main_Form Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Main_Form();
                }
                return _obj;
            }


        }
        public Panel Inner_Body_Panel_Container
        {
            get { return Inner_Body_Panel;}
            set { Inner_Body_Panel = value; }

        }
        public Main_Form()
        {
            InitializeComponent();
        }

        
        

     
        private void Form1_Load(object sender, EventArgs e)
        {

            Date_Label.Text = DateTime.Today.ToString("dd/MM/yyyy");
            Time_Label.Text = DateTime.Now.ToString("h:mmtt");
            _obj = this;
            Main_Control mc = new Main_Control();
            mc.Dock = DockStyle.Fill;
            Main_Form.Instance.Inner_Body_Panel_Container.Controls.Add(mc);
            //Main_Form.Instance.Inner_Body_Panel_Container.Controls["Home_Control"].BringToFront();
            

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Inner_Body_Panel_Container.Controls["Main_Control"].BringToFront();
        }

        private void Shutdown_Button_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
