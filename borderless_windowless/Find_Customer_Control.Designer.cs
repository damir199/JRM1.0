namespace borderless_windowless
{
    partial class Find_Customer_Control
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search_Label = new System.Windows.Forms.Label();
            this.Search_Repair_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(331, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 47);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Jim, Fields";
            // 
            // Search_Label
            // 
            this.Search_Label.AutoSize = true;
            this.Search_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Label.Location = new System.Drawing.Point(364, 351);
            this.Search_Label.Name = "Search_Label";
            this.Search_Label.Size = new System.Drawing.Size(347, 37);
            this.Search_Label.TabIndex = 7;
            this.Search_Label.Text = "Enter Customer Details";
            // 
            // Search_Repair_Button
            // 
            this.Search_Repair_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Search_Repair_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Repair_Button.ForeColor = System.Drawing.Color.White;
            this.Search_Repair_Button.Location = new System.Drawing.Point(371, 550);
            this.Search_Repair_Button.Name = "Search_Repair_Button";
            this.Search_Repair_Button.Size = new System.Drawing.Size(371, 140);
            this.Search_Repair_Button.TabIndex = 6;
            this.Search_Repair_Button.Text = "Search";
            this.Search_Repair_Button.UseVisualStyleBackColor = false;
            // 
            // Find_User_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search_Label);
            this.Controls.Add(this.Search_Repair_Button);
            this.Name = "Find_User_Control";
            this.Size = new System.Drawing.Size(1093, 1044);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search_Label;
        private System.Windows.Forms.Button Search_Repair_Button;
    }
}
