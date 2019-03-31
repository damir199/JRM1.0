namespace Jewellery_Repair_System
{
    partial class Create_Repair_Control
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
            this.Add_Repair_Button = new System.Windows.Forms.Button();
            this.Category_Label = new System.Windows.Forms.Label();
            this.Categories_CB = new System.Windows.Forms.ComboBox();
            this.Work_Needed_Label = new System.Windows.Forms.Label();
            this.Work_Required_TB = new System.Windows.Forms.TextBox();
            this.Item_Condition_Label = new System.Windows.Forms.Label();
            this.Cost_Label = new System.Windows.Forms.Label();
            this.VAT_Label = new System.Windows.Forms.Label();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Cost_TB = new System.Windows.Forms.TextBox();
            this.Total_TB = new System.Windows.Forms.TextBox();
            this.VAT_ComboBox = new System.Windows.Forms.ComboBox();
            this.Deposit_Amount_Label = new System.Windows.Forms.Label();
            this.Deposit_AV_Label = new System.Windows.Forms.Label();
            this.Deposit_Ref_Label = new System.Windows.Forms.Label();
            this.Deposit_Amount_TB = new System.Windows.Forms.TextBox();
            this.Deposit_AV_TB = new System.Windows.Forms.TextBox();
            this.Deposit_Ref_TB = new System.Windows.Forms.TextBox();
            this.Estimate_Required_Button = new System.Windows.Forms.Button();
            this.Item_Notes_TB = new System.Windows.Forms.TextBox();
            this.ITem_Notes_Label = new System.Windows.Forms.Label();
            this.Condition_CB = new System.Windows.Forms.ComboBox();
            this.Control_GL = new System.Windows.Forms.TableLayoutPanel();
            this.Inner_Body_Panel = new System.Windows.Forms.Panel();
            this.Cancel_Repair_Button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CR_New_Customer = new System.Windows.Forms.Button();
            this.Find_Customer_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Repairs_Ongoing_TB = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Repairs_Ongoing_Label = new System.Windows.Forms.Label();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.Repairs_Total_TB = new System.Windows.Forms.TextBox();
            this.Repairs_Quantity_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Outworker_Name_TB = new System.Windows.Forms.TextBox();
            this.Clear_Outworker_Button = new System.Windows.Forms.Button();
            this.CR_Add_Outworker = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Outworker_Address_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Outworker_Company_TB = new System.Windows.Forms.TextBox();
            this.Control_GL.SuspendLayout();
            this.Inner_Body_Panel.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Repair_Button
            // 
            this.Add_Repair_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Add_Repair_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Repair_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Add_Repair_Button.Location = new System.Drawing.Point(15, 410);
            this.Add_Repair_Button.Name = "Add_Repair_Button";
            this.Add_Repair_Button.Size = new System.Drawing.Size(141, 81);
            this.Add_Repair_Button.TabIndex = 0;
            this.Add_Repair_Button.Text = "Add Repair";
            this.Add_Repair_Button.UseVisualStyleBackColor = false;
            this.Add_Repair_Button.Click += new System.EventHandler(this.Add_Repair_Button_Click);
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_Label.Location = new System.Drawing.Point(11, 27);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(73, 20);
            this.Category_Label.TabIndex = 1;
            this.Category_Label.Text = "Category";
            // 
            // Categories_CB
            // 
            this.Categories_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_CB.FormattingEnabled = true;
            this.Categories_CB.Items.AddRange(new object[] {
            "Watch",
            "Bracelet",
            "Ring",
            "Bangel",
            "Chain",
            "Pendant"});
            this.Categories_CB.Location = new System.Drawing.Point(15, 50);
            this.Categories_CB.Name = "Categories_CB";
            this.Categories_CB.Size = new System.Drawing.Size(189, 28);
            this.Categories_CB.TabIndex = 2;
            this.Categories_CB.Text = "Select";
            // 
            // Work_Needed_Label
            // 
            this.Work_Needed_Label.AutoSize = true;
            this.Work_Needed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work_Needed_Label.Location = new System.Drawing.Point(12, 81);
            this.Work_Needed_Label.Name = "Work_Needed_Label";
            this.Work_Needed_Label.Size = new System.Drawing.Size(115, 20);
            this.Work_Needed_Label.TabIndex = 3;
            this.Work_Needed_Label.Text = "Work Required";
            // 
            // Work_Required_TB
            // 
            this.Work_Required_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Work_Required_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work_Required_TB.Location = new System.Drawing.Point(15, 101);
            this.Work_Required_TB.Multiline = true;
            this.Work_Required_TB.Name = "Work_Required_TB";
            this.Work_Required_TB.Size = new System.Drawing.Size(419, 48);
            this.Work_Required_TB.TabIndex = 4;
            // 
            // Item_Condition_Label
            // 
            this.Item_Condition_Label.AutoSize = true;
            this.Item_Condition_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Condition_Label.Location = new System.Drawing.Point(206, 27);
            this.Item_Condition_Label.Name = "Item_Condition_Label";
            this.Item_Condition_Label.Size = new System.Drawing.Size(112, 20);
            this.Item_Condition_Label.TabIndex = 5;
            this.Item_Condition_Label.Text = "Item Condition";
            // 
            // Cost_Label
            // 
            this.Cost_Label.AutoSize = true;
            this.Cost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_Label.Location = new System.Drawing.Point(24, 33);
            this.Cost_Label.Name = "Cost_Label";
            this.Cost_Label.Size = new System.Drawing.Size(42, 20);
            this.Cost_Label.TabIndex = 8;
            this.Cost_Label.Text = "Cost";
            // 
            // VAT_Label
            // 
            this.VAT_Label.AutoSize = true;
            this.VAT_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAT_Label.Location = new System.Drawing.Point(-2, 69);
            this.VAT_Label.Name = "VAT_Label";
            this.VAT_Label.Size = new System.Drawing.Size(68, 20);
            this.VAT_Label.TabIndex = 9;
            this.VAT_Label.Text = "VAT (%)";
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Location = new System.Drawing.Point(22, 106);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(44, 20);
            this.Total_Label.TabIndex = 10;
            this.Total_Label.Text = "Total";
            // 
            // Cost_TB
            // 
            this.Cost_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cost_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost_TB.Location = new System.Drawing.Point(72, 31);
            this.Cost_TB.Name = "Cost_TB";
            this.Cost_TB.Size = new System.Drawing.Size(93, 26);
            this.Cost_TB.TabIndex = 11;
            // 
            // Total_TB
            // 
            this.Total_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total_TB.Enabled = false;
            this.Total_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_TB.Location = new System.Drawing.Point(72, 104);
            this.Total_TB.Name = "Total_TB";
            this.Total_TB.Size = new System.Drawing.Size(93, 26);
            this.Total_TB.TabIndex = 13;
            // 
            // VAT_ComboBox
            // 
            this.VAT_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VAT_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VAT_ComboBox.FormattingEnabled = true;
            this.VAT_ComboBox.Items.AddRange(new object[] {
            "17.5",
            "10",
            "5"});
            this.VAT_ComboBox.Location = new System.Drawing.Point(72, 66);
            this.VAT_ComboBox.Name = "VAT_ComboBox";
            this.VAT_ComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VAT_ComboBox.Size = new System.Drawing.Size(93, 28);
            this.VAT_ComboBox.TabIndex = 14;
            this.VAT_ComboBox.Text = "20";
            // 
            // Deposit_Amount_Label
            // 
            this.Deposit_Amount_Label.AutoSize = true;
            this.Deposit_Amount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_Amount_Label.Location = new System.Drawing.Point(26, 59);
            this.Deposit_Amount_Label.Name = "Deposit_Amount_Label";
            this.Deposit_Amount_Label.Size = new System.Drawing.Size(65, 20);
            this.Deposit_Amount_Label.TabIndex = 16;
            this.Deposit_Amount_Label.Text = "Amount";
            // 
            // Deposit_AV_Label
            // 
            this.Deposit_AV_Label.AutoSize = true;
            this.Deposit_AV_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_AV_Label.Location = new System.Drawing.Point(56, 91);
            this.Deposit_AV_Label.Name = "Deposit_AV_Label";
            this.Deposit_AV_Label.Size = new System.Drawing.Size(35, 20);
            this.Deposit_AV_Label.TabIndex = 17;
            this.Deposit_AV_Label.Text = "A/V";
            // 
            // Deposit_Ref_Label
            // 
            this.Deposit_Ref_Label.AutoSize = true;
            this.Deposit_Ref_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_Ref_Label.Location = new System.Drawing.Point(7, 27);
            this.Deposit_Ref_Label.Name = "Deposit_Ref_Label";
            this.Deposit_Ref_Label.Size = new System.Drawing.Size(84, 20);
            this.Deposit_Ref_Label.TabIndex = 18;
            this.Deposit_Ref_Label.Text = "Reference";
            // 
            // Deposit_Amount_TB
            // 
            this.Deposit_Amount_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deposit_Amount_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_Amount_TB.Location = new System.Drawing.Point(97, 57);
            this.Deposit_Amount_TB.Name = "Deposit_Amount_TB";
            this.Deposit_Amount_TB.Size = new System.Drawing.Size(80, 26);
            this.Deposit_Amount_TB.TabIndex = 19;
            // 
            // Deposit_AV_TB
            // 
            this.Deposit_AV_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deposit_AV_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_AV_TB.Location = new System.Drawing.Point(97, 89);
            this.Deposit_AV_TB.Name = "Deposit_AV_TB";
            this.Deposit_AV_TB.Size = new System.Drawing.Size(80, 26);
            this.Deposit_AV_TB.TabIndex = 20;
            // 
            // Deposit_Ref_TB
            // 
            this.Deposit_Ref_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Deposit_Ref_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit_Ref_TB.Location = new System.Drawing.Point(97, 25);
            this.Deposit_Ref_TB.Name = "Deposit_Ref_TB";
            this.Deposit_Ref_TB.Size = new System.Drawing.Size(136, 26);
            this.Deposit_Ref_TB.TabIndex = 21;
            // 
            // Estimate_Required_Button
            // 
            this.Estimate_Required_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Estimate_Required_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estimate_Required_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estimate_Required_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Estimate_Required_Button.Location = new System.Drawing.Point(162, 410);
            this.Estimate_Required_Button.Name = "Estimate_Required_Button";
            this.Estimate_Required_Button.Size = new System.Drawing.Size(141, 81);
            this.Estimate_Required_Button.TabIndex = 22;
            this.Estimate_Required_Button.Text = "Estimate Required";
            this.Estimate_Required_Button.UseVisualStyleBackColor = false;
            // 
            // Item_Notes_TB
            // 
            this.Item_Notes_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item_Notes_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Notes_TB.Location = new System.Drawing.Point(15, 175);
            this.Item_Notes_TB.Multiline = true;
            this.Item_Notes_TB.Name = "Item_Notes_TB";
            this.Item_Notes_TB.Size = new System.Drawing.Size(419, 77);
            this.Item_Notes_TB.TabIndex = 24;
            // 
            // ITem_Notes_Label
            // 
            this.ITem_Notes_Label.AutoSize = true;
            this.ITem_Notes_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITem_Notes_Label.Location = new System.Drawing.Point(15, 152);
            this.ITem_Notes_Label.Name = "ITem_Notes_Label";
            this.ITem_Notes_Label.Size = new System.Drawing.Size(51, 20);
            this.ITem_Notes_Label.TabIndex = 23;
            this.ITem_Notes_Label.Text = "Notes";
            // 
            // Condition_CB
            // 
            this.Condition_CB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Condition_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition_CB.FormattingEnabled = true;
            this.Condition_CB.Items.AddRange(new object[] {
            "Very Worn",
            "Worn",
            "OK",
            "Good",
            "Very Good",
            "Like New"});
            this.Condition_CB.Location = new System.Drawing.Point(210, 50);
            this.Condition_CB.Name = "Condition_CB";
            this.Condition_CB.Size = new System.Drawing.Size(189, 28);
            this.Condition_CB.TabIndex = 25;
            this.Condition_CB.Text = "Select";
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
            this.Control_GL.TabIndex = 40;
            // 
            // Inner_Body_Panel
            // 
            this.Inner_Body_Panel.Controls.Add(this.Cancel_Repair_Button);
            this.Inner_Body_Panel.Controls.Add(this.groupBox5);
            this.Inner_Body_Panel.Controls.Add(this.groupBox4);
            this.Inner_Body_Panel.Controls.Add(this.groupBox3);
            this.Inner_Body_Panel.Controls.Add(this.groupBox2);
            this.Inner_Body_Panel.Controls.Add(this.groupBox1);
            this.Inner_Body_Panel.Controls.Add(this.Add_Repair_Button);
            this.Inner_Body_Panel.Controls.Add(this.Estimate_Required_Button);
            this.Inner_Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inner_Body_Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inner_Body_Panel.Location = new System.Drawing.Point(60, 53);
            this.Inner_Body_Panel.Name = "Inner_Body_Panel";
            this.Inner_Body_Panel.Size = new System.Drawing.Size(1029, 894);
            this.Inner_Body_Panel.TabIndex = 0;
            // 
            // Cancel_Repair_Button
            // 
            this.Cancel_Repair_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Cancel_Repair_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Repair_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_Repair_Button.Location = new System.Drawing.Point(309, 410);
            this.Cancel_Repair_Button.Name = "Cancel_Repair_Button";
            this.Cancel_Repair_Button.Size = new System.Drawing.Size(141, 81);
            this.Cancel_Repair_Button.TabIndex = 86;
            this.Cancel_Repair_Button.Text = "Cancel Repair";
            this.Cancel_Repair_Button.UseVisualStyleBackColor = false;
            this.Cancel_Repair_Button.Click += new System.EventHandler(this.Cancel_Repair_Button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Work_Required_TB);
            this.groupBox5.Controls.Add(this.ITem_Notes_Label);
            this.groupBox5.Controls.Add(this.Item_Notes_TB);
            this.groupBox5.Controls.Add(this.Condition_CB);
            this.groupBox5.Controls.Add(this.Work_Needed_Label);
            this.groupBox5.Controls.Add(this.Item_Condition_Label);
            this.groupBox5.Controls.Add(this.Categories_CB);
            this.groupBox5.Controls.Add(this.Category_Label);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 264);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Repair Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Deposit_Ref_TB);
            this.groupBox4.Controls.Add(this.Deposit_AV_Label);
            this.groupBox4.Controls.Add(this.Deposit_AV_TB);
            this.groupBox4.Controls.Add(this.Deposit_Amount_TB);
            this.groupBox4.Controls.Add(this.Deposit_Ref_Label);
            this.groupBox4.Controls.Add(this.Deposit_Amount_Label);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(223, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 134);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deposit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VAT_ComboBox);
            this.groupBox3.Controls.Add(this.Total_TB);
            this.groupBox3.Controls.Add(this.Cost_Label);
            this.groupBox3.Controls.Add(this.Cost_TB);
            this.groupBox3.Controls.Add(this.Total_Label);
            this.groupBox3.Controls.Add(this.VAT_Label);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 134);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charges";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CR_New_Customer);
            this.groupBox2.Controls.Add(this.Find_Customer_Button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.Repairs_Ongoing_TB);
            this.groupBox2.Controls.Add(this.Address_Label);
            this.groupBox2.Controls.Add(this.Repairs_Ongoing_Label);
            this.groupBox2.Controls.Add(this.Address_TB);
            this.groupBox2.Controls.Add(this.Repairs_Total_TB);
            this.groupBox2.Controls.Add(this.Repairs_Quantity_Label);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 240);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // CR_New_Customer
            // 
            this.CR_New_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.CR_New_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CR_New_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CR_New_Customer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CR_New_Customer.Location = new System.Drawing.Point(296, 146);
            this.CR_New_Customer.Name = "CR_New_Customer";
            this.CR_New_Customer.Size = new System.Drawing.Size(116, 76);
            this.CR_New_Customer.TabIndex = 70;
            this.CR_New_Customer.Text = "New Customer";
            this.CR_New_Customer.UseVisualStyleBackColor = false;
            this.CR_New_Customer.Click += new System.EventHandler(this.CR_New_Customer_Click);
            // 
            // Find_Customer_Button
            // 
            this.Find_Customer_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Find_Customer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_Customer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_Customer_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Find_Customer_Button.Location = new System.Drawing.Point(418, 146);
            this.Find_Customer_Button.Name = "Find_Customer_Button";
            this.Find_Customer_Button.Size = new System.Drawing.Size(116, 76);
            this.Find_Customer_Button.TabIndex = 71;
            this.Find_Customer_Button.Text = "Find Customer";
            this.Find_Customer_Button.UseVisualStyleBackColor = false;
            this.Find_Customer_Button.Click += new System.EventHandler(this.Find_Customer_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(418, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 29);
            this.textBox3.TabIndex = 69;
            this.textBox3.Text = "2";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(102, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 26);
            this.textBox2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Completed";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 31;
            // 
            // Repairs_Ongoing_TB
            // 
            this.Repairs_Ongoing_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Repairs_Ongoing_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Ongoing_TB.Location = new System.Drawing.Point(418, 66);
            this.Repairs_Ongoing_TB.Name = "Repairs_Ongoing_TB";
            this.Repairs_Ongoing_TB.Size = new System.Drawing.Size(66, 29);
            this.Repairs_Ongoing_TB.TabIndex = 67;
            this.Repairs_Ongoing_TB.Text = "3";
            this.Repairs_Ongoing_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.Location = new System.Drawing.Point(28, 106);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(68, 20);
            this.Address_Label.TabIndex = 32;
            this.Address_Label.Text = "Address";
            // 
            // Repairs_Ongoing_Label
            // 
            this.Repairs_Ongoing_Label.AutoSize = true;
            this.Repairs_Ongoing_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Ongoing_Label.Location = new System.Drawing.Point(343, 71);
            this.Repairs_Ongoing_Label.Name = "Repairs_Ongoing_Label";
            this.Repairs_Ongoing_Label.Size = new System.Drawing.Size(69, 20);
            this.Repairs_Ongoing_Label.TabIndex = 66;
            this.Repairs_Ongoing_Label.Text = "Ongoing";
            // 
            // Address_TB
            // 
            this.Address_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_TB.Location = new System.Drawing.Point(102, 111);
            this.Address_TB.Multiline = true;
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(175, 111);
            this.Address_TB.TabIndex = 33;
            // 
            // Repairs_Total_TB
            // 
            this.Repairs_Total_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Repairs_Total_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Total_TB.Location = new System.Drawing.Point(418, 31);
            this.Repairs_Total_TB.Name = "Repairs_Total_TB";
            this.Repairs_Total_TB.Size = new System.Drawing.Size(66, 29);
            this.Repairs_Total_TB.TabIndex = 65;
            this.Repairs_Total_TB.Text = "5";
            this.Repairs_Total_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Repairs_Quantity_Label
            // 
            this.Repairs_Quantity_Label.AutoSize = true;
            this.Repairs_Quantity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repairs_Quantity_Label.Location = new System.Drawing.Point(348, 36);
            this.Repairs_Quantity_Label.Name = "Repairs_Quantity_Label";
            this.Repairs_Quantity_Label.Size = new System.Drawing.Size(64, 20);
            this.Repairs_Quantity_Label.TabIndex = 64;
            this.Repairs_Quantity_Label.Text = "Repairs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Outworker_Name_TB);
            this.groupBox1.Controls.Add(this.Clear_Outworker_Button);
            this.groupBox1.Controls.Add(this.CR_Add_Outworker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Outworker_Address_TB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Outworker_Company_TB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(470, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 242);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outworker Details";
            // 
            // Outworker_Name_TB
            // 
            this.Outworker_Name_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outworker_Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outworker_Name_TB.Location = new System.Drawing.Point(113, 30);
            this.Outworker_Name_TB.Name = "Outworker_Name_TB";
            this.Outworker_Name_TB.Size = new System.Drawing.Size(223, 26);
            this.Outworker_Name_TB.TabIndex = 75;
            // 
            // Clear_Outworker_Button
            // 
            this.Clear_Outworker_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.Clear_Outworker_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Outworker_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Outworker_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear_Outworker_Button.Location = new System.Drawing.Point(359, 127);
            this.Clear_Outworker_Button.Name = "Clear_Outworker_Button";
            this.Clear_Outworker_Button.Size = new System.Drawing.Size(141, 81);
            this.Clear_Outworker_Button.TabIndex = 80;
            this.Clear_Outworker_Button.Text = "Clear Outworker";
            this.Clear_Outworker_Button.UseVisualStyleBackColor = false;
            this.Clear_Outworker_Button.Click += new System.EventHandler(this.Clear_Outworker_Button_Click);
            // 
            // CR_Add_Outworker
            // 
            this.CR_Add_Outworker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.CR_Add_Outworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CR_Add_Outworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CR_Add_Outworker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CR_Add_Outworker.Location = new System.Drawing.Point(359, 40);
            this.CR_Add_Outworker.Name = "CR_Add_Outworker";
            this.CR_Add_Outworker.Size = new System.Drawing.Size(141, 81);
            this.CR_Add_Outworker.TabIndex = 72;
            this.CR_Add_Outworker.Text = "Add Outworker";
            this.CR_Add_Outworker.UseVisualStyleBackColor = false;
            this.CR_Add_Outworker.Click += new System.EventHandler(this.CR_Add_Outworker_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 73;
            this.label7.Text = "Name";
            // 
            // Outworker_Address_TB
            // 
            this.Outworker_Address_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outworker_Address_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outworker_Address_TB.Location = new System.Drawing.Point(113, 107);
            this.Outworker_Address_TB.Multiline = true;
            this.Outworker_Address_TB.Name = "Outworker_Address_TB";
            this.Outworker_Address_TB.Size = new System.Drawing.Size(223, 101);
            this.Outworker_Address_TB.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Address";
            // 
            // Outworker_Company_TB
            // 
            this.Outworker_Company_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outworker_Company_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outworker_Company_TB.Location = new System.Drawing.Point(113, 65);
            this.Outworker_Company_TB.Name = "Outworker_Company_TB";
            this.Outworker_Company_TB.Size = new System.Drawing.Size(223, 26);
            this.Outworker_Company_TB.TabIndex = 76;
            // 
            // Create_Repair_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Control_GL);
            this.Name = "Create_Repair_Control";
            this.Size = new System.Drawing.Size(1150, 1000);
            this.Control_GL.ResumeLayout(false);
            this.Inner_Body_Panel.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Repair_Button;
        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.ComboBox Categories_CB;
        private System.Windows.Forms.Label Work_Needed_Label;
        private System.Windows.Forms.TextBox Work_Required_TB;
        private System.Windows.Forms.Label Item_Condition_Label;
        private System.Windows.Forms.Label Cost_Label;
        private System.Windows.Forms.Label VAT_Label;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.TextBox Cost_TB;
        private System.Windows.Forms.TextBox Total_TB;
        private System.Windows.Forms.ComboBox VAT_ComboBox;
        private System.Windows.Forms.Label Deposit_Amount_Label;
        private System.Windows.Forms.Label Deposit_AV_Label;
        private System.Windows.Forms.Label Deposit_Ref_Label;
        private System.Windows.Forms.TextBox Deposit_Amount_TB;
        private System.Windows.Forms.TextBox Deposit_AV_TB;
        private System.Windows.Forms.TextBox Deposit_Ref_TB;
        private System.Windows.Forms.Button Estimate_Required_Button;
        private System.Windows.Forms.TextBox Item_Notes_TB;
        private System.Windows.Forms.Label ITem_Notes_Label;
        private System.Windows.Forms.ComboBox Condition_CB;
        
        
        private System.Windows.Forms.TableLayoutPanel Control_GL;
        private System.Windows.Forms.Panel Inner_Body_Panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address_TB;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Repairs_Ongoing_TB;
        private System.Windows.Forms.Label Repairs_Ongoing_Label;
        private System.Windows.Forms.TextBox Repairs_Total_TB;
        private System.Windows.Forms.Label Repairs_Quantity_Label;
        private System.Windows.Forms.Button Find_Customer_Button;
        private System.Windows.Forms.Button CR_New_Customer;
        private System.Windows.Forms.Button CR_Add_Outworker;
        private System.Windows.Forms.Button Clear_Outworker_Button;
        private System.Windows.Forms.TextBox Outworker_Address_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Outworker_Company_TB;
        private System.Windows.Forms.TextBox Outworker_Name_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Cancel_Repair_Button;
    }
}
