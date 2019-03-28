namespace Jewellery_Repair_Window_2019.Controls
{
    partial class Customer_Success_Control
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
            this.components = new System.ComponentModel.Container();
            this.Control_GL = new System.Windows.Forms.TableLayoutPanel();
            this.Inner_Body_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Home_Timer = new System.Windows.Forms.Timer(this.components);
            this.Control_GL.SuspendLayout();
            this.Inner_Body_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_GL
            // 
            this.Control_GL.AutoSize = true;
            this.Control_GL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Control_GL.ColumnCount = 3;
            this.Control_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Control_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.Control_GL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Control_GL.Controls.Add(this.Inner_Body_Panel, 1, 1);
            this.Control_GL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control_GL.Location = new System.Drawing.Point(0, 0);
            this.Control_GL.Name = "Control_GL";
            this.Control_GL.RowCount = 3;
            this.Control_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.002501F));
            this.Control_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.04502F));
            this.Control_GL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.952477F));
            this.Control_GL.Size = new System.Drawing.Size(1150, 1000);
            this.Control_GL.TabIndex = 42;
            // 
            // Inner_Body_Panel
            // 
            this.Inner_Body_Panel.Controls.Add(this.label1);
            this.Inner_Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Body_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inner_Body_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Body_Panel.Name = "Inner_Body_Panel";
            this.Inner_Body_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Body_Panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Added Successfully";
            // 
            // Home_Timer
            // 
            this.Home_Timer.Enabled = true;
            this.Home_Timer.Interval = 2000;
            this.Home_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Customer_Success_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Control_GL);
            this.Name = "Customer_Success_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.Control_GL.ResumeLayout(false);
            this.Inner_Body_Panel.ResumeLayout(false);
            this.Inner_Body_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Control_GL;
        private System.Windows.Forms.Panel Inner_Body_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Home_Timer;
    }
}
