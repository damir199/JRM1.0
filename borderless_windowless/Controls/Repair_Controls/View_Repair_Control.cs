using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewellery_Repair_System
{
    public partial class View_Repair_Control : UserControl
    {
        public View_Repair_Control(List<String> vs)
        {
            List<String> res1 = new List<string>();
            res1 = vs;
            InitializeComponent();
            string RepNo = res1[0];
            string RepCat = res1[1];
            string RepCond = res1[2];
            string RepWork = res1[3];
            string RepNotes = res1[4];
            
            Repair_No_TB.Text = RepNo;
            Repair_Category_TB.Text = RepCat;
            Item_Condition_TB.Text = RepCond;
            Work_Required_TB.Text = RepWork;
            Item_Notes_TB.Text = RepNotes;
        }

        
    }
}
