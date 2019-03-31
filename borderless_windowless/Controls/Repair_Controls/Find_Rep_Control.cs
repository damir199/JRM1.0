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
            Results_TB.Clear();
            string input = Repair_ID_TB.Text.ToString();
           List<String> Data = Find_Repair.Find_Repair_Query(input);
            foreach (var item in Data) {
                Results_TB.AppendText(item + Environment.NewLine);
            }

          
        }
    }
}
