namespace Jewellery_Repair_System
{
    partial class Main_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Control));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_Controller_Inner = new System.Windows.Forms.Panel();
            this.FO_Button = new System.Windows.Forms.Button();
            this.CO_Button = new System.Windows.Forms.Button();
            this.Find_Repair_Button = new System.Windows.Forms.Button();
            this.Create_Customer_Button = new System.Windows.Forms.Button();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.Find_Customer_Button = new System.Windows.Forms.Button();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Create_Repair_Button = new System.Windows.Forms.Button();
            this.Repairs_Button = new System.Windows.Forms.Button();
            this.Customers_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_Controller_Inner.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.Panel_Controller_Inner, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 1000);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // Panel_Controller_Inner
            // 
            this.Panel_Controller_Inner.Controls.Add(this.FO_Button);
            this.Panel_Controller_Inner.Controls.Add(this.CO_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Find_Repair_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Create_Customer_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Logout_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Find_Customer_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Login_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Create_Repair_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Repairs_Button);
            this.Panel_Controller_Inner.Controls.Add(this.Customers_Button);
            this.Panel_Controller_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Controller_Inner.Location = new System.Drawing.Point(60, 53);
            this.Panel_Controller_Inner.Name = "Panel_Controller_Inner";
            this.Panel_Controller_Inner.Size = new System.Drawing.Size(1029, 894);
            this.Panel_Controller_Inner.TabIndex = 0;
            // 
            // FO_Button
            // 
            this.FO_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.FO_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FO_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FO_Button.ForeColor = System.Drawing.Color.White;
            this.FO_Button.Image = ((System.Drawing.Image)(resources.GetObject("FO_Button.Image")));
            this.FO_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FO_Button.Location = new System.Drawing.Point(459, 469);
            this.FO_Button.Name = "FO_Button";
            this.FO_Button.Size = new System.Drawing.Size(312, 121);
            this.FO_Button.TabIndex = 30;
            this.FO_Button.Text = "Find Outworker";
            this.FO_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FO_Button.UseVisualStyleBackColor = false;
            this.FO_Button.Click += new System.EventHandler(this.FO_Button_Click);
            // 
            // CO_Button
            // 
            this.CO_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.CO_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CO_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CO_Button.ForeColor = System.Drawing.Color.White;
            this.CO_Button.Image = ((System.Drawing.Image)(resources.GetObject("CO_Button.Image")));
            this.CO_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CO_Button.Location = new System.Drawing.Point(141, 469);
            this.CO_Button.Name = "CO_Button";
            this.CO_Button.Size = new System.Drawing.Size(312, 121);
            this.CO_Button.TabIndex = 29;
            this.CO_Button.Text = "Create Outworker";
            this.CO_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CO_Button.UseVisualStyleBackColor = false;
            this.CO_Button.Click += new System.EventHandler(this.CO_Button_Click);
            // 
            // Find_Repair_Button
            // 
            this.Find_Repair_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Find_Repair_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Find_Repair_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_Repair_Button.ForeColor = System.Drawing.Color.White;
            this.Find_Repair_Button.Image = ((System.Drawing.Image)(resources.GetObject("Find_Repair_Button.Image")));
            this.Find_Repair_Button.Location = new System.Drawing.Point(141, 175);
            this.Find_Repair_Button.Name = "Find_Repair_Button";
            this.Find_Repair_Button.Size = new System.Drawing.Size(153, 288);
            this.Find_Repair_Button.TabIndex = 28;
            this.Find_Repair_Button.Text = "Find Repair";
            this.Find_Repair_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Find_Repair_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Find_Repair_Button.UseVisualStyleBackColor = false;
            this.Find_Repair_Button.Click += new System.EventHandler(this.Find_Repair_Button_Click);
            // 
            // Create_Customer_Button
            // 
            this.Create_Customer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Create_Customer_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Create_Customer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Customer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Customer_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Customer_Button.Image = ((System.Drawing.Image)(resources.GetObject("Create_Customer_Button.Image")));
            this.Create_Customer_Button.Location = new System.Drawing.Point(618, 175);
            this.Create_Customer_Button.Name = "Create_Customer_Button";
            this.Create_Customer_Button.Size = new System.Drawing.Size(153, 288);
            this.Create_Customer_Button.TabIndex = 27;
            this.Create_Customer_Button.Text = "Create Customer";
            this.Create_Customer_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Create_Customer_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Create_Customer_Button.UseVisualStyleBackColor = false;
            this.Create_Customer_Button.Click += new System.EventHandler(this.Create_Customer_Button_Click);
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Logout_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logout_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Button.ForeColor = System.Drawing.Color.White;
            this.Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("Logout_Button.Image")));
            this.Logout_Button.Location = new System.Drawing.Point(777, 323);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(132, 267);
            this.Logout_Button.TabIndex = 25;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Logout_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Find_Customer_Button
            // 
            this.Find_Customer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Find_Customer_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Find_Customer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_Customer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_Customer_Button.ForeColor = System.Drawing.Color.White;
            this.Find_Customer_Button.Image = ((System.Drawing.Image)(resources.GetObject("Find_Customer_Button.Image")));
            this.Find_Customer_Button.Location = new System.Drawing.Point(459, 175);
            this.Find_Customer_Button.Name = "Find_Customer_Button";
            this.Find_Customer_Button.Size = new System.Drawing.Size(153, 288);
            this.Find_Customer_Button.TabIndex = 26;
            this.Find_Customer_Button.Text = "Find Customer";
            this.Find_Customer_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Find_Customer_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Find_Customer_Button.UseVisualStyleBackColor = false;
            this.Find_Customer_Button.Click += new System.EventHandler(this.Find_Customer_Button_Click);
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Login_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.Image = ((System.Drawing.Image)(resources.GetObject("Login_Button.Image")));
            this.Login_Button.Location = new System.Drawing.Point(777, 50);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(132, 265);
            this.Login_Button.TabIndex = 23;
            this.Login_Button.Text = "Login";
            this.Login_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Login_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Create_Repair_Button
            // 
            this.Create_Repair_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Create_Repair_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Create_Repair_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Repair_Button.ForeColor = System.Drawing.Color.White;
            this.Create_Repair_Button.Image = ((System.Drawing.Image)(resources.GetObject("Create_Repair_Button.Image")));
            this.Create_Repair_Button.Location = new System.Drawing.Point(300, 176);
            this.Create_Repair_Button.Name = "Create_Repair_Button";
            this.Create_Repair_Button.Size = new System.Drawing.Size(153, 287);
            this.Create_Repair_Button.TabIndex = 24;
            this.Create_Repair_Button.Text = "Create Repair";
            this.Create_Repair_Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Create_Repair_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Create_Repair_Button.UseVisualStyleBackColor = false;
            this.Create_Repair_Button.Click += new System.EventHandler(this.Create_Repair_Button_Click);
            // 
            // Repairs_Button
            // 
            this.Repairs_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Repairs_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Repairs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repairs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Button.ForeColor = System.Drawing.Color.White;
            this.Repairs_Button.Image = ((System.Drawing.Image)(resources.GetObject("Repairs_Button.Image")));
            this.Repairs_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Repairs_Button.Location = new System.Drawing.Point(141, 50);
            this.Repairs_Button.Name = "Repairs_Button";
            this.Repairs_Button.Size = new System.Drawing.Size(312, 119);
            this.Repairs_Button.TabIndex = 21;
            this.Repairs_Button.Text = "Repairs";
            this.Repairs_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Repairs_Button.UseVisualStyleBackColor = false;
            this.Repairs_Button.Click += new System.EventHandler(this.Repairs_Button_Click);
            // 
            // Customers_Button
            // 
            this.Customers_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(185)))), ((int)(((byte)(170)))));
            this.Customers_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Customers_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers_Button.ForeColor = System.Drawing.Color.White;
            this.Customers_Button.Image = ((System.Drawing.Image)(resources.GetObject("Customers_Button.Image")));
            this.Customers_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Customers_Button.Location = new System.Drawing.Point(459, 50);
            this.Customers_Button.Name = "Customers_Button";
            this.Customers_Button.Size = new System.Drawing.Size(312, 119);
            this.Customers_Button.TabIndex = 22;
            this.Customers_Button.Text = "Customers";
            this.Customers_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customers_Button.UseVisualStyleBackColor = false;
            this.Customers_Button.Click += new System.EventHandler(this.Customers_Button_Click);
            // 
            // Main_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_Controller_Inner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Panel_Controller_Inner;
        private System.Windows.Forms.Button Find_Repair_Button;
        private System.Windows.Forms.Button Create_Customer_Button;
        private System.Windows.Forms.Button Logout_Button;
        private System.Windows.Forms.Button Find_Customer_Button;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Create_Repair_Button;
        private System.Windows.Forms.Button Repairs_Button;
        private System.Windows.Forms.Button Customers_Button;
        private System.Windows.Forms.Button FO_Button;
        private System.Windows.Forms.Button CO_Button;
    }
}
