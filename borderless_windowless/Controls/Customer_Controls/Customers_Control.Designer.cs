namespace Jewellery_Repair_Window_2019.Controls.Customer_Controls
{
    partial class Customers_Control
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Recent_customers_GB = new System.Windows.Forms.GroupBox();
            this.Main_GL.SuspendLayout();
            this.Inner_Panel.SuspendLayout();
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
            this.Main_GL.TabIndex = 75;
            // 
            // Inner_Panel
            // 
            this.Inner_Panel.Controls.Add(this.groupBox2);
            this.Inner_Panel.Controls.Add(this.Recent_customers_GB);
            this.Inner_Panel.Controls.Add(this.groupBox1);
            this.Inner_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Panel.Name = "Inner_Panel";
            this.Inner_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(32, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Recent_customers_GB
            // 
            this.Recent_customers_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recent_customers_GB.Location = new System.Drawing.Point(573, 17);
            this.Recent_customers_GB.Name = "Recent_customers_GB";
            this.Recent_customers_GB.Size = new System.Drawing.Size(453, 328);
            this.Recent_customers_GB.TabIndex = 1;
            this.Recent_customers_GB.TabStop = false;
            this.Recent_customers_GB.Text = "Last 10 Customers";
            // 
            // Customers_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_GL);
            this.Name = "Customers_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.Main_GL.ResumeLayout(false);
            this.Inner_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_GL;
        private System.Windows.Forms.Panel Inner_Panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Recent_customers_GB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
