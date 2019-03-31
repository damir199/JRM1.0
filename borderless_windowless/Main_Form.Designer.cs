namespace borderless_windowless
{
    partial class Main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.SideBar_Panel = new System.Windows.Forms.Panel();
            this.Info_Button = new System.Windows.Forms.Button();
            this.Report_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Shutdown_Button = new System.Windows.Forms.Button();
            this.Body_Panel = new System.Windows.Forms.Panel();
            this.Inner_Body_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Date_Label = new System.Windows.Forms.Label();
            this.JRM_Version_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.User_Label = new System.Windows.Forms.Label();
            this.SideBar_Panel.SuspendLayout();
            this.Body_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar_Panel
            // 
            this.SideBar_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(162)))));
            this.SideBar_Panel.Controls.Add(this.Info_Button);
            this.SideBar_Panel.Controls.Add(this.Report_Button);
            this.SideBar_Panel.Controls.Add(this.Settings_Button);
            this.SideBar_Panel.Controls.Add(this.Shutdown_Button);
            this.SideBar_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SideBar_Panel.Location = new System.Drawing.Point(1093, 0);
            this.SideBar_Panel.Name = "SideBar_Panel";
            this.SideBar_Panel.Size = new System.Drawing.Size(107, 1044);
            this.SideBar_Panel.TabIndex = 0;
            // 
            // Info_Button
            // 
            this.Info_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Info_Button.BackgroundImage")));
            this.Info_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Info_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Info_Button.FlatAppearance.BorderSize = 0;
            this.Info_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_Button.ForeColor = System.Drawing.Color.White;
            this.Info_Button.Location = new System.Drawing.Point(0, 723);
            this.Info_Button.Name = "Info_Button";
            this.Info_Button.Size = new System.Drawing.Size(107, 107);
            this.Info_Button.TabIndex = 3;
            this.Info_Button.UseVisualStyleBackColor = true;
            this.Info_Button.Click += new System.EventHandler(this.Info_Button_Click);
            // 
            // Report_Button
            // 
            this.Report_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Report_Button.BackgroundImage")));
            this.Report_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Report_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Report_Button.FlatAppearance.BorderSize = 0;
            this.Report_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Button.ForeColor = System.Drawing.Color.White;
            this.Report_Button.Location = new System.Drawing.Point(0, 830);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(107, 107);
            this.Report_Button.TabIndex = 2;
            this.Report_Button.UseVisualStyleBackColor = true;
            this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings_Button.BackgroundImage")));
            this.Settings_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.ForeColor = System.Drawing.Color.White;
            this.Settings_Button.Location = new System.Drawing.Point(0, 937);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Size = new System.Drawing.Size(107, 107);
            this.Settings_Button.TabIndex = 1;
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Shutdown_Button
            // 
            this.Shutdown_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Shutdown_Button.BackgroundImage")));
            this.Shutdown_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Shutdown_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Shutdown_Button.FlatAppearance.BorderSize = 0;
            this.Shutdown_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Button.ForeColor = System.Drawing.Color.White;
            this.Shutdown_Button.Location = new System.Drawing.Point(0, 0);
            this.Shutdown_Button.Name = "Shutdown_Button";
            this.Shutdown_Button.Size = new System.Drawing.Size(107, 107);
            this.Shutdown_Button.TabIndex = 0;
            this.Shutdown_Button.UseVisualStyleBackColor = true;
            this.Shutdown_Button.Click += new System.EventHandler(this.Shutdown_Button_Click);
            // 
            // Body_Panel
            // 
            this.Body_Panel.Controls.Add(this.Inner_Body_Panel);
            this.Body_Panel.Controls.Add(this.Header_Panel);
            this.Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body_Panel.Location = new System.Drawing.Point(0, 0);
            this.Body_Panel.Name = "Body_Panel";
            this.Body_Panel.Size = new System.Drawing.Size(1093, 1044);
            this.Body_Panel.TabIndex = 11;
            // 
            // Inner_Body_Panel
            // 
            this.Inner_Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Body_Panel.Location = new System.Drawing.Point(0, 57);
            this.Inner_Body_Panel.Name = "Inner_Body_Panel";
            this.Inner_Body_Panel.Size = new System.Drawing.Size(1093, 987);
            this.Inner_Body_Panel.TabIndex = 19;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.Teal;
            this.Header_Panel.Controls.Add(this.Back_Button);
            this.Header_Panel.Controls.Add(this.Date_Label);
            this.Header_Panel.Controls.Add(this.JRM_Version_Label);
            this.Header_Panel.Controls.Add(this.Time_Label);
            this.Header_Panel.Controls.Add(this.User_Label);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1093, 57);
            this.Header_Panel.TabIndex = 18;
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Button.BackgroundImage")));
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Back_Button.FlatAppearance.BorderSize = 0;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.ForeColor = System.Drawing.Color.White;
            this.Back_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_Button.Location = new System.Drawing.Point(0, 0);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Back_Button.Size = new System.Drawing.Size(97, 57);
            this.Back_Button.TabIndex = 17;
            this.Back_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.ForeColor = System.Drawing.Color.White;
            this.Date_Label.Location = new System.Drawing.Point(668, 9);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(113, 42);
            this.Date_Label.TabIndex = 16;
            this.Date_Label.Text = "DATE";
            // 
            // JRM_Version_Label
            // 
            this.JRM_Version_Label.AutoSize = true;
            this.JRM_Version_Label.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JRM_Version_Label.ForeColor = System.Drawing.Color.White;
            this.JRM_Version_Label.Location = new System.Drawing.Point(129, 6);
            this.JRM_Version_Label.Name = "JRM_Version_Label";
            this.JRM_Version_Label.Size = new System.Drawing.Size(168, 45);
            this.JRM_Version_Label.TabIndex = 13;
            this.JRM_Version_Label.Text = "JRM 1.0";
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_Label.ForeColor = System.Drawing.Color.White;
            this.Time_Label.Location = new System.Drawing.Point(930, 9);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(107, 42);
            this.Time_Label.TabIndex = 15;
            this.Time_Label.Text = "TIME";
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Label.ForeColor = System.Drawing.Color.White;
            this.User_Label.Location = new System.Drawing.Point(433, 9);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(92, 42);
            this.User_Label.TabIndex = 14;
            this.User_Label.Text = "Nick";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1044);
            this.Controls.Add(this.Body_Panel);
            this.Controls.Add(this.SideBar_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar_Panel.ResumeLayout(false);
            this.Body_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar_Panel;
        private System.Windows.Forms.Button Shutdown_Button;
        private System.Windows.Forms.Button Info_Button;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Panel Body_Panel;
        private System.Windows.Forms.Label JRM_Version_Label;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label User_Label;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Panel Inner_Body_Panel;
    }
}

