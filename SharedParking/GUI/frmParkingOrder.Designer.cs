namespace SharedParking.GUI
{
    partial class frmParkingOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.flpOrderDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSizeParking = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "הקש טלפון לזיהוי:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(42, 112);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 26);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged_1);
    //        this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnBack);
            this.grpDetails.Controls.Add(this.flpOrderDetails);
            this.grpDetails.Controls.Add(this.btnOk);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.txtSizeParking);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.txtCarDetails);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.ForeColor = System.Drawing.Color.Red;
            this.grpDetails.Location = new System.Drawing.Point(32, 172);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDetails.Size = new System.Drawing.Size(814, 504);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "פרטים אישיים";
            this.grpDetails.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(635, 405);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 63);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "חזור";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flpOrderDetails
            // 
            this.flpOrderDetails.AutoScroll = true;
            this.flpOrderDetails.Location = new System.Drawing.Point(65, 158);
            this.flpOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpOrderDetails.Name = "flpOrderDetails";
            this.flpOrderDetails.Size = new System.Drawing.Size(716, 222);
            this.flpOrderDetails.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Red;
            this.btnOk.Location = new System.Drawing.Point(50, 408);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(130, 60);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "לאישור";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "פרטי הזמנה:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(633, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "שם:";
            // 
            // txtSizeParking
            // 
            this.txtSizeParking.Location = new System.Drawing.Point(199, 42);
            this.txtSizeParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSizeParking.Name = "txtSizeParking";
            this.txtSizeParking.Size = new System.Drawing.Size(100, 31);
            this.txtSizeParking.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "פרטי רכב:";
            // 
            // txtCarDetails
            // 
            this.txtCarDetails.Location = new System.Drawing.Point(411, 42);
            this.txtCarDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarDetails.Name = "txtCarDetails";
            this.txtCarDetails.Size = new System.Drawing.Size(100, 31);
            this.txtCarDetails.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "גודל חניה:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "עוד רגע וגומרים...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SharedParking.Properties.Resources.לוגו_לנאוה_1;
            this.pictureBox1.Location = new System.Drawing.Point(940, 544);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmParkingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmParkingOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "הזמנת חניה";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSizeParking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpOrderDetails;
        private System.Windows.Forms.Button btnBack;
    }
}