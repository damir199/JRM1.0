namespace Jewellery_Repair_Window_2019.Controls.Settings_Controls
{
    partial class New_User_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_User_Control));
            this.Main_GL = new System.Windows.Forms.TableLayoutPanel();
            this.Inner_Panel = new System.Windows.Forms.Panel();
            this.Contact_Details_GB = new System.Windows.Forms.GroupBox();
            this.Customer_Repair_Details_GB = new System.Windows.Forms.GroupBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.User_Details_GB = new System.Windows.Forms.GroupBox();
            this.First_Name_TB = new System.Windows.Forms.TextBox();
            this.Employee_ID_TB = new System.Windows.Forms.TextBox();
            this.PEmployee_ID_Label = new System.Windows.Forms.Label();
            this.First_Name_Label = new System.Windows.Forms.Label();
            this.Last_Name_TB = new System.Windows.Forms.TextBox();
            this.Last_Name_Label = new System.Windows.Forms.Label();
            this.Customer_PB = new System.Windows.Forms.PictureBox();
            this.Main_GL.SuspendLayout();
            this.Inner_Panel.SuspendLayout();
            this.Contact_Details_GB.SuspendLayout();
            this.User_Details_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_PB)).BeginInit();
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
            this.Inner_Panel.Controls.Add(this.Contact_Details_GB);
            this.Inner_Panel.Controls.Add(this.Customer_Repair_Details_GB);
            this.Inner_Panel.Controls.Add(this.User_Details_GB);
            this.Inner_Panel.Controls.Add(this.Customer_PB);
            this.Inner_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Panel.Name = "Inner_Panel";
            this.Inner_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Panel.TabIndex = 0;
            // 
            // Contact_Details_GB
            // 
            this.Contact_Details_GB.Controls.Add(this.Confirm_Button);
            this.Contact_Details_GB.Location = new System.Drawing.Point(464, 290);
            this.Contact_Details_GB.Name = "Contact_Details_GB";
            this.Contact_Details_GB.Size = new System.Drawing.Size(412, 246);
            this.Contact_Details_GB.TabIndex = 74;
            this.Contact_Details_GB.TabStop = false;
            this.Contact_Details_GB.Text = "Customer Details";
            // 
            // Customer_Repair_Details_GB
            // 
            this.Customer_Repair_Details_GB.Enabled = false;
            this.Customer_Repair_Details_GB.Location = new System.Drawing.Point(224, 289);
            this.Customer_Repair_Details_GB.Name = "Customer_Repair_Details_GB";
            this.Customer_Repair_Details_GB.Size = new System.Drawing.Size(227, 247);
            this.Customer_Repair_Details_GB.TabIndex = 75;
            this.Customer_Repair_Details_GB.TabStop = false;
            this.Customer_Repair_Details_GB.Text = "Test";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirm_Button.Location = new System.Drawing.Point(113, 32);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(215, 92);
            this.Confirm_Button.TabIndex = 65;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = false;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // User_Details_GB
            // 
            this.User_Details_GB.Controls.Add(this.First_Name_TB);
            this.User_Details_GB.Controls.Add(this.Employee_ID_TB);
            this.User_Details_GB.Controls.Add(this.PEmployee_ID_Label);
            this.User_Details_GB.Controls.Add(this.First_Name_Label);
            this.User_Details_GB.Controls.Add(this.Last_Name_TB);
            this.User_Details_GB.Controls.Add(this.Last_Name_Label);
            this.User_Details_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Details_GB.Location = new System.Drawing.Point(464, 35);
            this.User_Details_GB.Name = "User_Details_GB";
            this.User_Details_GB.Size = new System.Drawing.Size(412, 246);
            this.User_Details_GB.TabIndex = 73;
            this.User_Details_GB.TabStop = false;
            this.User_Details_GB.Text = "User Details";
            // 
            // First_Name_TB
            // 
            this.First_Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_TB.Location = new System.Drawing.Point(150, 101);
            this.First_Name_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.First_Name_TB.Name = "First_Name_TB";
            this.First_Name_TB.Size = new System.Drawing.Size(222, 26);
            this.First_Name_TB.TabIndex = 2;
            // 
            // Employee_ID_TB
            // 
            this.Employee_ID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employee_ID_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID_TB.Location = new System.Drawing.Point(150, 65);
            this.Employee_ID_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Employee_ID_TB.Name = "Employee_ID_TB";
            this.Employee_ID_TB.Size = new System.Drawing.Size(222, 26);
            this.Employee_ID_TB.TabIndex = 1;
            // 
            // PEmployee_ID_Label
            // 
            this.PEmployee_ID_Label.AutoSize = true;
            this.PEmployee_ID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PEmployee_ID_Label.Location = new System.Drawing.Point(42, 67);
            this.PEmployee_ID_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PEmployee_ID_Label.Name = "PEmployee_ID_Label";
            this.PEmployee_ID_Label.Size = new System.Drawing.Size(100, 20);
            this.PEmployee_ID_Label.TabIndex = 52;
            this.PEmployee_ID_Label.Text = "Employee ID";
            // 
            // First_Name_Label
            // 
            this.First_Name_Label.AutoSize = true;
            this.First_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_Label.Location = new System.Drawing.Point(56, 103);
            this.First_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.First_Name_Label.Name = "First_Name_Label";
            this.First_Name_Label.Size = new System.Drawing.Size(86, 20);
            this.First_Name_Label.TabIndex = 44;
            this.First_Name_Label.Text = "First Name";
            // 
            // Last_Name_TB
            // 
            this.Last_Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Last_Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name_TB.Location = new System.Drawing.Point(150, 137);
            this.Last_Name_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Last_Name_TB.Name = "Last_Name_TB";
            this.Last_Name_TB.Size = new System.Drawing.Size(222, 26);
            this.Last_Name_TB.TabIndex = 3;
            // 
            // Last_Name_Label
            // 
            this.Last_Name_Label.AutoSize = true;
            this.Last_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name_Label.Location = new System.Drawing.Point(56, 139);
            this.Last_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Last_Name_Label.Name = "Last_Name_Label";
            this.Last_Name_Label.Size = new System.Drawing.Size(86, 20);
            this.Last_Name_Label.TabIndex = 45;
            this.Last_Name_Label.Text = "Last Name";
            // 
            // Customer_PB
            // 
            this.Customer_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Customer_PB.BackgroundImage")));
            this.Customer_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Customer_PB.Location = new System.Drawing.Point(224, 35);
            this.Customer_PB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customer_PB.Name = "Customer_PB";
            this.Customer_PB.Size = new System.Drawing.Size(233, 246);
            this.Customer_PB.TabIndex = 72;
            this.Customer_PB.TabStop = false;
            // 
            // New_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_GL);
            this.Name = "New_User_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.Main_GL.ResumeLayout(false);
            this.Inner_Panel.ResumeLayout(false);
            this.Contact_Details_GB.ResumeLayout(false);
            this.User_Details_GB.ResumeLayout(false);
            this.User_Details_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_GL;
        private System.Windows.Forms.Panel Inner_Panel;
        private System.Windows.Forms.GroupBox Contact_Details_GB;
        private System.Windows.Forms.GroupBox Customer_Repair_Details_GB;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.GroupBox User_Details_GB;
        private System.Windows.Forms.TextBox First_Name_TB;
        private System.Windows.Forms.TextBox Employee_ID_TB;
        private System.Windows.Forms.Label PEmployee_ID_Label;
        private System.Windows.Forms.Label First_Name_Label;
        private System.Windows.Forms.TextBox Last_Name_TB;
        private System.Windows.Forms.Label Last_Name_Label;
        private System.Windows.Forms.PictureBox Customer_PB;
    }
}
