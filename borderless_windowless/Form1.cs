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
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }


        }
        public Panel Body_Panel_Container
        {
            get { return Body_Panel;}
            set { Body_Panel = value; }

        }
        public Form1()
        {
            InitializeComponent();
        }

        
        

     
        private void Form1_Load(object sender, EventArgs e)
        {

            Date_Label.Text = DateTime.Today.ToString("dd/MM/yyyy");
            Time_Label.Text = DateTime.Now.ToString("hh:mmtt");
            _obj = this;
            Main_Control mc = new Main_Control();
            mc.Dock = DockStyle.Fill;
            Body_Panel_Container.Controls.Add(mc);
            Body_Panel_Container.Controls["Home_Control"].BringToFront();
            

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Body_Panel_Container.Controls["Main_Control"].BringToFront();
        }

        private void Shutdown_Button_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
