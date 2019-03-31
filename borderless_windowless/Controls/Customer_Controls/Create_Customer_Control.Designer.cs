namespace Jewellery_Repair_System
{
    partial class Create_User_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_User_Control));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Inner_Panel = new System.Windows.Forms.Panel();
            this.Contact_Details_GB = new System.Windows.Forms.GroupBox();
            this.Contact_Pref_CB = new System.Windows.Forms.ComboBox();
            this.Phone_TB = new System.Windows.Forms.TextBox();
            this.Contact_Pref_Label = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Mobile_TB = new System.Windows.Forms.TextBox();
            this.Mobile_Label = new System.Windows.Forms.Label();
            this.Customer_Repair_Details_GB = new System.Windows.Forms.GroupBox();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Repairs_Quantity_Label = new System.Windows.Forms.Label();
            this.Repairs_Total_TB = new System.Windows.Forms.TextBox();
            this.Repairs_Ongoing_Label = new System.Windows.Forms.Label();
            this.Repairs_Ongoing_TB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Customer_Details_GB = new System.Windows.Forms.GroupBox();
            this.First_Name_TB = new System.Windows.Forms.TextBox();
            this.Postcode_TB = new System.Windows.Forms.TextBox();
            this.Postcode_Label = new System.Windows.Forms.Label();
            this.Add_Line2_TB = new System.Windows.Forms.TextBox();
            this.Add_Line2_Label = new System.Windows.Forms.Label();
            this.Add_Line1_TB = new System.Windows.Forms.TextBox();
            this.First_Name_Label = new System.Windows.Forms.Label();
            this.Add_Line1_Label = new System.Windows.Forms.Label();
            this.Last_Name_TB = new System.Windows.Forms.TextBox();
            this.Last_Name_Label = new System.Windows.Forms.Label();
            this.Customer_PB = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.Inner_Panel.SuspendLayout();
            this.Contact_Details_GB.SuspendLayout();
            this.Customer_Repair_Details_GB.SuspendLayout();
            this.Customer_Details_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.Inner_Panel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 1000);
            this.tableLayoutPanel1.TabIndex = 74;
            // 
            // Inner_Panel
            // 
            this.Inner_Panel.Controls.Add(this.Contact_Details_GB);
            this.Inner_Panel.Controls.Add(this.Customer_Repair_Details_GB);
            this.Inner_Panel.Controls.Add(this.Customer_Details_GB);
            this.Inner_Panel.Controls.Add(this.Customer_PB);
            this.Inner_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Panel.Name = "Inner_Panel";
            this.Inner_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Panel.TabIndex = 0;
            // 
            // Contact_Details_GB
            // 
            this.Contact_Details_GB.Controls.Add(this.Contact_Pref_CB);
            this.Contact_Details_GB.Controls.Add(this.Phone_TB);
            this.Contact_Details_GB.Controls.Add(this.Contact_Pref_Label);
            this.Contact_Details_GB.Controls.Add(this.Email_TB);
            this.Contact_Details_GB.Controls.Add(this.Phone_Label);
            this.Contact_Details_GB.Controls.Add(this.Email_Label);
            this.Contact_Details_GB.Controls.Add(this.Mobile_TB);
            this.Contact_Details_GB.Controls.Add(this.Mobile_Label);
            this.Contact_Details_GB.Location = new System.Drawing.Point(464, 290);
            this.Contact_Details_GB.Name = "Contact_Details_GB";
            this.Contact_Details_GB.Size = new System.Drawing.Size(412, 246);
            this.Contact_Details_GB.TabIndex = 74;
            this.Contact_Details_GB.TabStop = false;
            this.Contact_Details_GB.Text = "Customer Details";
            // 
            // Contact_Pref_CB
            // 
            this.Contact_Pref_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact_Pref_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Pref_CB.FormattingEnabled = true;
            this.Contact_Pref_CB.Items.AddRange(new object[] {
            "Phone & Email",
            "Letter",
            "Email",
            "All"});
            this.Contact_Pref_CB.Location = new System.Drawing.Point(61, 182);
            this.Contact_Pref_CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contact_Pref_CB.Name = "Contact_Pref_CB";
            this.Contact_Pref_CB.Size = new System.Drawing.Size(263, 28);
            this.Contact_Pref_CB.TabIndex = 65;
            this.Contact_Pref_CB.Text = "Phone & Email";
            // 
            // Phone_TB
            // 
            this.Phone_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_TB.Location = new System.Drawing.Point(141, 45);
            this.Phone_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phone_TB.Name = "Phone_TB";
            this.Phone_TB.Size = new System.Drawing.Size(246, 26);
            this.Phone_TB.TabIndex = 46;
            // 
            // Contact_Pref_Label
            // 
            this.Contact_Pref_Label.AutoSize = true;
            this.Contact_Pref_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Pref_Label.Location = new System.Drawing.Point(97, 157);
            this.Contact_Pref_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Contact_Pref_Label.Name = "Contact_Pref_Label";
            this.Contact_Pref_Label.Size = new System.Drawing.Size(155, 20);
            this.Contact_Pref_Label.TabIndex = 50;
            this.Contact_Pref_Label.Text = "Contact Preferences";
            // 
            // Email_TB
            // 
            this.Email_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TB.Location = new System.Drawing.Point(141, 117);
            this.Email_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(249, 26);
            this.Email_TB.TabIndex = 49;
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Label.Location = new System.Drawing.Point(78, 47);
            this.Phone_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(55, 20);
            this.Phone_Label.TabIndex = 44;
            this.Phone_Label.Text = "Phone";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Label.Location = new System.Drawing.Point(85, 119);
            this.Email_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(48, 20);
            this.Email_Label.TabIndex = 48;
            this.Email_Label.Text = "Email";
            // 
            // Mobile_TB
            // 
            this.Mobile_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mobile_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile_TB.Location = new System.Drawing.Point(141, 81);
            this.Mobile_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mobile_TB.Name = "Mobile_TB";
            this.Mobile_TB.Size = new System.Drawing.Size(249, 26);
            this.Mobile_TB.TabIndex = 47;
            // 
            // Mobile_Label
            // 
            this.Mobile_Label.AutoSize = true;
            this.Mobile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile_Label.Location = new System.Drawing.Point(78, 83);
            this.Mobile_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mobile_Label.Name = "Mobile_Label";
            this.Mobile_Label.Size = new System.Drawing.Size(55, 20);
            this.Mobile_Label.TabIndex = 45;
            this.Mobile_Label.Text = "Mobile";
            // 
            // Customer_Repair_Details_GB
            // 
            this.Customer_Repair_Details_GB.Controls.Add(this.Confirm_Button);
            this.Customer_Repair_Details_GB.Controls.Add(this.Repairs_Quantity_Label);
            this.Customer_Repair_Details_GB.Controls.Add(this.Repairs_Total_TB);
            this.Customer_Repair_Details_GB.Controls.Add(this.Repairs_Ongoing_Label);
            this.Customer_Repair_Details_GB.Controls.Add(this.Repairs_Ongoing_TB);
            this.Customer_Repair_Details_GB.Controls.Add(this.textBox1);
            this.Customer_Repair_Details_GB.Enabled = false;
            this.Customer_Repair_Details_GB.Location = new System.Drawing.Point(224, 289);
            this.Customer_Repair_Details_GB.Name = "Customer_Repair_Details_GB";
            this.Customer_Repair_Details_GB.Size = new System.Drawing.Size(227, 247);
            this.Customer_Repair_Details_GB.TabIndex = 75;
            this.Customer_Repair_Details_GB.TabStop = false;
            this.Customer_Repair_Details_GB.Text = "0";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Confirm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirm_Button.Location = new System.Drawing.Point(6, 141);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(215, 92);
            this.Confirm_Button.TabIndex = 65;
            this.Confirm_Button.Text = "Save";
            this.Confirm_Button.UseVisualStyleBackColor = false;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // Repairs_Quantity_Label
            // 
            this.Repairs_Quantity_Label.AutoSize = true;
            this.Repairs_Quantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Quantity_Label.Location = new System.Drawing.Point(36, 37);
            this.Repairs_Quantity_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Repairs_Quantity_Label.Name = "Repairs_Quantity_Label";
            this.Repairs_Quantity_Label.Size = new System.Drawing.Size(64, 20);
            this.Repairs_Quantity_Label.TabIndex = 57;
            this.Repairs_Quantity_Label.Text = "Repairs";
            // 
            // Repairs_Total_TB
            // 
            this.Repairs_Total_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Repairs_Total_TB.Enabled = false;
            this.Repairs_Total_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Total_TB.Location = new System.Drawing.Point(108, 35);
            this.Repairs_Total_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Repairs_Total_TB.Name = "Repairs_Total_TB";
            this.Repairs_Total_TB.Size = new System.Drawing.Size(98, 26);
            this.Repairs_Total_TB.TabIndex = 58;
            this.Repairs_Total_TB.Text = "0";
            this.Repairs_Total_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Repairs_Ongoing_Label
            // 
            this.Repairs_Ongoing_Label.AutoSize = true;
            this.Repairs_Ongoing_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Ongoing_Label.Location = new System.Drawing.Point(31, 73);
            this.Repairs_Ongoing_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Repairs_Ongoing_Label.Name = "Repairs_Ongoing_Label";
            this.Repairs_Ongoing_Label.Size = new System.Drawing.Size(69, 20);
            this.Repairs_Ongoing_Label.TabIndex = 59;
            this.Repairs_Ongoing_Label.Text = "Ongoing";
            // 
            // Repairs_Ongoing_TB
            // 
            this.Repairs_Ongoing_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Repairs_Ongoing_TB.Enabled = false;
            this.Repairs_Ongoing_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Ongoing_TB.Location = new System.Drawing.Point(108, 71);
            this.Repairs_Ongoing_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Repairs_Ongoing_TB.Name = "Repairs_Ongoing_TB";
            this.Repairs_Ongoing_TB.Size = new System.Drawing.Size(98, 26);
            this.Repairs_Ongoing_TB.TabIndex = 60;
            this.Repairs_Ongoing_TB.Text = "0";
            this.Repairs_Ongoing_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 26);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Customer_Details_GB
            // 
            this.Customer_Details_GB.Controls.Add(this.First_Name_TB);
            this.Customer_Details_GB.Controls.Add(this.Postcode_TB);
            this.Customer_Details_GB.Controls.Add(this.Postcode_Label);
            this.Customer_Details_GB.Controls.Add(this.Add_Line2_TB);
            this.Customer_Details_GB.Controls.Add(this.Add_Line2_Label);
            this.Customer_Details_GB.Controls.Add(this.Add_Line1_TB);
            this.Customer_Details_GB.Controls.Add(this.First_Name_Label);
            this.Customer_Details_GB.Controls.Add(this.Add_Line1_Label);
            this.Customer_Details_GB.Controls.Add(this.Last_Name_TB);
            this.Customer_Details_GB.Controls.Add(this.Last_Name_Label);
            this.Customer_Details_GB.Location = new System.Drawing.Point(464, 35);
            this.Customer_Details_GB.Name = "Customer_Details_GB";
            this.Customer_Details_GB.Size = new System.Drawing.Size(412, 246);
            this.Customer_Details_GB.TabIndex = 73;
            this.Customer_Details_GB.TabStop = false;
            this.Customer_Details_GB.Text = "Customer Details";
            // 
            // First_Name_TB
            // 
            this.First_Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.First_Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_TB.Location = new System.Drawing.Point(141, 45);
            this.First_Name_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.First_Name_TB.Name = "First_Name_TB";
            this.First_Name_TB.Size = new System.Drawing.Size(246, 26);
            this.First_Name_TB.TabIndex = 46;
            // 
            // Postcode_TB
            // 
            this.Postcode_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Postcode_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postcode_TB.Location = new System.Drawing.Point(141, 189);
            this.Postcode_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Postcode_TB.Name = "Postcode_TB";
            this.Postcode_TB.Size = new System.Drawing.Size(249, 26);
            this.Postcode_TB.TabIndex = 54;
            // 
            // Postcode_Label
            // 
            this.Postcode_Label.AutoSize = true;
            this.Postcode_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Postcode_Label.Location = new System.Drawing.Point(57, 191);
            this.Postcode_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Postcode_Label.Name = "Postcode_Label";
            this.Postcode_Label.Size = new System.Drawing.Size(76, 20);
            this.Postcode_Label.TabIndex = 52;
            this.Postcode_Label.Text = "Postcode";
            // 
            // Add_Line2_TB
            // 
            this.Add_Line2_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_Line2_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Line2_TB.Location = new System.Drawing.Point(141, 153);
            this.Add_Line2_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Line2_TB.Name = "Add_Line2_TB";
            this.Add_Line2_TB.Size = new System.Drawing.Size(249, 26);
            this.Add_Line2_TB.TabIndex = 51;
            // 
            // Add_Line2_Label
            // 
            this.Add_Line2_Label.AutoSize = true;
            this.Add_Line2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Line2_Label.Location = new System.Drawing.Point(21, 155);
            this.Add_Line2_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Add_Line2_Label.Name = "Add_Line2_Label";
            this.Add_Line2_Label.Size = new System.Drawing.Size(115, 20);
            this.Add_Line2_Label.TabIndex = 50;
            this.Add_Line2_Label.Text = "Address Line 2";
            // 
            // Add_Line1_TB
            // 
            this.Add_Line1_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_Line1_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Line1_TB.Location = new System.Drawing.Point(141, 117);
            this.Add_Line1_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Line1_TB.Name = "Add_Line1_TB";
            this.Add_Line1_TB.Size = new System.Drawing.Size(249, 26);
            this.Add_Line1_TB.TabIndex = 49;
            // 
            // First_Name_Label
            // 
            this.First_Name_Label.AutoSize = true;
            this.First_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_Label.Location = new System.Drawing.Point(50, 47);
            this.First_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.First_Name_Label.Name = "First_Name_Label";
            this.First_Name_Label.Size = new System.Drawing.Size(86, 20);
            this.First_Name_Label.TabIndex = 44;
            this.First_Name_Label.Text = "First Name";
            // 
            // Add_Line1_Label
            // 
            this.Add_Line1_Label.AutoSize = true;
            this.Add_Line1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Line1_Label.Location = new System.Drawing.Point(21, 119);
            this.Add_Line1_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Add_Line1_Label.Name = "Add_Line1_Label";
            this.Add_Line1_Label.Size = new System.Drawing.Size(115, 20);
            this.Add_Line1_Label.TabIndex = 48;
            this.Add_Line1_Label.Text = "Address Line 1";
            // 
            // Last_Name_TB
            // 
            this.Last_Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Last_Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name_TB.Location = new System.Drawing.Point(141, 81);
            this.Last_Name_TB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Last_Name_TB.Name = "Last_Name_TB";
            this.Last_Name_TB.Size = new System.Drawing.Size(249, 26);
            this.Last_Name_TB.TabIndex = 47;
            // 
            // Last_Name_Label
            // 
            this.Last_Name_Label.AutoSize = true;
            this.Last_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name_Label.Location = new System.Drawing.Point(50, 83);
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
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(164, 21);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 26);
            this.textBox5.TabIndex = 74;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(164, 57);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 26);
            this.textBox6.TabIndex = 77;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(164, 93);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 26);
            this.textBox4.TabIndex = 75;
            // 
            // Create_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Create_User_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Inner_Panel.ResumeLayout(false);
            this.Contact_Details_GB.ResumeLayout(false);
            this.Contact_Details_GB.PerformLayout();
            this.Customer_Repair_Details_GB.ResumeLayout(false);
            this.Customer_Repair_Details_GB.PerformLayout();
            this.Customer_Details_GB.ResumeLayout(false);
            this.Customer_Details_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Inner_Panel;
        
        private System.Windows.Forms.GroupBox Customer_Repair_Details_GB;
        
        private System.Windows.Forms.Label Repairs_Quantity_Label;
        private System.Windows.Forms.TextBox Repairs_Total_TB;
        private System.Windows.Forms.Label Repairs_Ongoing_Label;
        private System.Windows.Forms.TextBox Repairs_Ongoing_TB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Customer_Details_GB;
        private System.Windows.Forms.TextBox First_Name_TB;
        private System.Windows.Forms.TextBox Postcode_TB;
        private System.Windows.Forms.Label Postcode_Label;
        private System.Windows.Forms.TextBox Add_Line2_TB;
        private System.Windows.Forms.Label Add_Line2_Label;
        private System.Windows.Forms.TextBox Add_Line1_TB;
        private System.Windows.Forms.Label First_Name_Label;
        private System.Windows.Forms.Label Add_Line1_Label;
        private System.Windows.Forms.TextBox Last_Name_TB;
        private System.Windows.Forms.Label Last_Name_Label;
        private System.Windows.Forms.PictureBox Customer_PB;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox Contact_Details_GB;
        private System.Windows.Forms.TextBox Phone_TB;
        private System.Windows.Forms.Label Contact_Pref_Label;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.TextBox Mobile_TB;
        private System.Windows.Forms.Label Mobile_Label;
        private System.Windows.Forms.ComboBox Contact_Pref_CB;
        private System.Windows.Forms.Button Confirm_Button;
    }
}
