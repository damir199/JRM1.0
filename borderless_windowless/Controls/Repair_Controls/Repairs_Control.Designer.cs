namespace Jewellery_Repair_Window_2019.Controls.Repair_Controls
{
    partial class Repairs_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_GL = new System.Windows.Forms.TableLayoutPanel();
            this.Inner_Panel = new System.Windows.Forms.Panel();
            this.Recent_Repairs_GB = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Last_10_Repairs_LB = new System.Windows.Forms.ListBox();
            this.Active_Repairs_GB = new System.Windows.Forms.GroupBox();
            this.Active_Repairs_LB = new System.Windows.Forms.ListBox();
            this.Completed_Repairs_GB = new System.Windows.Forms.GroupBox();
            this.Completed_Repairs_LB = new System.Windows.Forms.ListBox();
            this.Main_GL.SuspendLayout();
            this.Inner_Panel.SuspendLayout();
            this.Recent_Repairs_GB.SuspendLayout();
            this.Active_Repairs_GB.SuspendLayout();
            this.Completed_Repairs_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_GL
            // 
            this.Main_GL.ColumnCount = 3;
            this.Main_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Main_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_GL.Controls.Add(this.Inner_Panel, 1, 1);
            this.Main_GL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_GL.Location = new System.Drawing.Point(0, 0);
            this.Main_GL.Name = "Main_GL";
            this.Main_GL.RowCount = 3;
            this.Main_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Main_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_GL.Size = new System.Drawing.Size(1150, 1000);
            this.Main_GL.TabIndex = 76;
            // 
            // Inner_Panel
            // 
            this.Inner_Panel.Controls.Add(this.Completed_Repairs_GB);
            this.Inner_Panel.Controls.Add(this.Active_Repairs_GB);
            this.Inner_Panel.Controls.Add(this.Recent_Repairs_GB);
            this.Inner_Panel.Controls.Add(this.groupBox1);
            this.Inner_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Panel.Name = "Inner_Panel";
            this.Inner_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Panel.TabIndex = 0;
            // 
            // Recent_Repairs_GB
            // 
            this.Recent_Repairs_GB.Controls.Add(this.Last_10_Repairs_LB);
            this.Recent_Repairs_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recent_Repairs_GB.Location = new System.Drawing.Point(544, 3);
            this.Recent_Repairs_GB.Name = "Recent_Repairs_GB";
            this.Recent_Repairs_GB.Size = new System.Drawing.Size(467, 328);
            this.Recent_Repairs_GB.TabIndex = 3;
            this.Recent_Repairs_GB.TabStop = false;
            this.Recent_Repairs_GB.Text = "Last 10 Repairs Added";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Last_10_Repairs_LB
            // 
            this.Last_10_Repairs_LB.FormattingEnabled = true;
            this.Last_10_Repairs_LB.ItemHeight = 20;
            this.Last_10_Repairs_LB.Location = new System.Drawing.Point(6, 47);
            this.Last_10_Repairs_LB.Name = "Last_10_Repairs_LB";
            this.Last_10_Repairs_LB.Size = new System.Drawing.Size(447, 264);
            this.Last_10_Repairs_LB.TabIndex = 0;
            // 
            // Active_Repairs_GB
            // 
            this.Active_Repairs_GB.Controls.Add(this.Active_Repairs_LB);
            this.Active_Repairs_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Active_Repairs_GB.Location = new System.Drawing.Point(3, 337);
            this.Active_Repairs_GB.Name = "Active_Repairs_GB";
            this.Active_Repairs_GB.Size = new System.Drawing.Size(535, 203);
            this.Active_Repairs_GB.TabIndex = 3;
            this.Active_Repairs_GB.TabStop = false;
            this.Active_Repairs_GB.Text = "Active Repairs";
            // 
            // Active_Repairs_LB
            // 
            this.Active_Repairs_LB.FormattingEnabled = true;
            this.Active_Repairs_LB.ItemHeight = 20;
            this.Active_Repairs_LB.Location = new System.Drawing.Point(24, 36);
            this.Active_Repairs_LB.Name = "Active_Repairs_LB";
            this.Active_Repairs_LB.Size = new System.Drawing.Size(483, 144);
            this.Active_Repairs_LB.TabIndex = 0;
            // 
            // Completed_Repairs_GB
            // 
            this.Completed_Repairs_GB.Controls.Add(this.Completed_Repairs_LB);
            this.Completed_Repairs_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completed_Repairs_GB.Location = new System.Drawing.Point(544, 337);
            this.Completed_Repairs_GB.Name = "Completed_Repairs_GB";
            this.Completed_Repairs_GB.Size = new System.Drawing.Size(467, 203);
            this.Completed_Repairs_GB.TabIndex = 4;
            this.Completed_Repairs_GB.TabStop = false;
            this.Completed_Repairs_GB.Text = "Completed Repairs";
            // 
            // Completed_Repairs_LB
            // 
            this.Completed_Repairs_LB.FormattingEnabled = true;
            this.Completed_Repairs_LB.ItemHeight = 20;
            this.Completed_Repairs_LB.Location = new System.Drawing.Point(6, 36);
            this.Completed_Repairs_LB.Name = "Completed_Repairs_LB";
            this.Completed_Repairs_LB.Size = new System.Drawing.Size(429, 144);
            this.Completed_Repairs_LB.TabIndex = 0;
            // 
            // Repairs_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_GL);
            this.Name = "Repairs_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.Main_GL.ResumeLayout(false);
            this.Inner_Panel.ResumeLayout(false);
            this.Recent_Repairs_GB.ResumeLayout(false);
            this.Active_Repairs_GB.ResumeLayout(false);
            this.Completed_Repairs_GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_GL;
        private System.Windows.Forms.Panel Inner_Panel;
        private System.Windows.Forms.GroupBox Completed_Repairs_GB;
        private System.Windows.Forms.ListBox Completed_Repairs_LB;
        private System.Windows.Forms.GroupBox Active_Repairs_GB;
        private System.Windows.Forms.ListBox Active_Repairs_LB;
        private System.Windows.Forms.GroupBox Recent_Repairs_GB;
        private System.Windows.Forms.ListBox Last_10_Repairs_LB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
