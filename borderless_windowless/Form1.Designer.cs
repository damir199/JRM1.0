namespace borderless_windowless
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SideBar_Panel = new System.Windows.Forms.Panel();
            this.Info_Button = new System.Windows.Forms.Button();
            this.Report_Button = new System.Windows.Forms.Button();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Shutdown_Button = new System.Windows.Forms.Button();
            this.Body_Panel = new System.Windows.Forms.Panel();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SideBar_Panel.SuspendLayout();
            this.Body_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Shutdown_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Body_Panel
            // 
            this.Body_Panel.Controls.Add(this.Header_Panel);
            this.Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body_Panel.Location = new System.Drawing.Point(0, 0);
            this.Body_Panel.Name = "Body_Panel";
            this.Body_Panel.Size = new System.Drawing.Size(1093, 1044);
            this.Body_Panel.TabIndex = 11;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.Teal;
            this.Header_Panel.Controls.Add(this.pictureBox1);
            this.Header_Panel.Controls.Add(this.label4);
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.label3);
            this.Header_Panel.Controls.Add(this.label2);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1093, 86);
            this.Header_Panel.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(877, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 78);
            this.label4.TabIndex = 16;
            this.label4.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 78);
            this.label1.TabIndex = 13;
            this.label1.Text = "JRM 2.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(692, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 78);
            this.label3.TabIndex = 15;
            this.label3.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 78);
            this.label2.TabIndex = 14;
            this.label2.Text = "USER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1044);
            this.Controls.Add(this.Body_Panel);
            this.Controls.Add(this.SideBar_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar_Panel.ResumeLayout(false);
            this.Body_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar_Panel;
        private System.Windows.Forms.Button Shutdown_Button;
        private System.Windows.Forms.Button Info_Button;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Panel Body_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

