namespace SharedParking.GUI
{
    partial class frmLookingForParking
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
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnOnce = new System.Windows.Forms.Button();
            this.grpStatic = new System.Windows.Forms.GroupBox();
            this.btnSearchStaticParking = new System.Windows.Forms.Button();
            this.dtpToStatic = new System.Windows.Forms.DateTimePicker();
            this.dtpFromStatic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOnce = new System.Windows.Forms.GroupBox();
            this.btnSearchOnceParking = new System.Windows.Forms.Button();
            this.dtpToOnce = new System.Windows.Forms.DateTimePicker();
            this.dtpFromOnce = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDest = new System.Windows.Forms.ComboBox();
            this.chekStreet = new System.Windows.Forms.CheckBox();
            this.flpSelectedParking = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpStatic.SuspendLayout();
            this.grpOnce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.BackColor = System.Drawing.Color.White;
            this.btnStatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatic.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatic.ForeColor = System.Drawing.Color.Red;
            this.btnStatic.Location = new System.Drawing.Point(851, 106);
            this.btnStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(241, 52);
            this.btnStatic.TabIndex = 0;
            this.btnStatic.Text = "חניה קבועה?";
            this.btnStatic.UseVisualStyleBackColor = false;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnOnce
            // 
            this.btnOnce.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnce.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnce.ForeColor = System.Drawing.Color.Red;
            this.btnOnce.Location = new System.Drawing.Point(562, 106);
            this.btnOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(253, 52);
            this.btnOnce.TabIndex = 1;
            this.btnOnce.Text = "חניה חד פעמית?";
            this.btnOnce.UseVisualStyleBackColor = false;
            this.btnOnce.Click += new System.EventHandler(this.btnOnce_Click);
            // 
            // grpStatic
            // 
            this.grpStatic.Controls.Add(this.btnSearchStaticParking);
            this.grpStatic.Controls.Add(this.dtpToStatic);
            this.grpStatic.Controls.Add(this.dtpFromStatic);
            this.grpStatic.Controls.Add(this.label3);
            this.grpStatic.Controls.Add(this.label2);
            this.grpStatic.Controls.Add(this.cmbDay);
            this.grpStatic.Controls.Add(this.label1);
            this.grpStatic.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatic.ForeColor = System.Drawing.Color.Red;
            this.grpStatic.Location = new System.Drawing.Point(819, 179);
            this.grpStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStatic.Name = "grpStatic";
            this.grpStatic.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStatic.Size = new System.Drawing.Size(302, 215);
            this.grpStatic.TabIndex = 2;
            this.grpStatic.TabStop = false;
            this.grpStatic.Visible = false;
            // 
            // btnSearchStaticParking
            // 
            this.btnSearchStaticParking.BackColor = System.Drawing.Color.White;
            this.btnSearchStaticParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaticParking.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaticParking.Location = new System.Drawing.Point(44, 151);
            this.btnSearchStaticParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchStaticParking.Name = "btnSearchStaticParking";
            this.btnSearchStaticParking.Size = new System.Drawing.Size(252, 44);
            this.btnSearchStaticParking.TabIndex = 15;
            this.btnSearchStaticParking.Text = "חפש חניה";
            this.btnSearchStaticParking.UseVisualStyleBackColor = false;
            this.btnSearchStaticParking.Click += new System.EventHandler(this.btnSearchStaticParking_Click);
            // 
            // dtpToStatic
            // 
            this.dtpToStatic.Location = new System.Drawing.Point(44, 106);
            this.dtpToStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToStatic.Name = "dtpToStatic";
            this.dtpToStatic.Size = new System.Drawing.Size(124, 34);
            this.dtpToStatic.TabIndex = 7;
            // 
            // dtpFromStatic
            // 
            this.dtpFromStatic.Location = new System.Drawing.Point(44, 68);
            this.dtpFromStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromStatic.Name = "dtpFromStatic";
            this.dtpFromStatic.Size = new System.Drawing.Size(126, 34);
            this.dtpFromStatic.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "עד שעה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "משעה";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.cmbDay.Location = new System.Drawing.Point(44, 25);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(126, 35);
            this.cmbDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "יום בשבוע";
            // 
            // grpOnce
            // 
            this.grpOnce.Controls.Add(this.btnSearchOnceParking);
            this.grpOnce.Controls.Add(this.dtpToOnce);
            this.grpOnce.Controls.Add(this.dtpFromOnce);
            this.grpOnce.Controls.Add(this.label5);
            this.grpOnce.Controls.Add(this.label6);
            this.grpOnce.Controls.Add(this.label4);
            this.grpOnce.Controls.Add(this.dtpDate);
            this.grpOnce.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOnce.ForeColor = System.Drawing.Color.Red;
            this.grpOnce.Location = new System.Drawing.Point(506, 179);
            this.grpOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOnce.Name = "grpOnce";
            this.grpOnce.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOnce.Size = new System.Drawing.Size(333, 215);
            this.grpOnce.TabIndex = 0;
            this.grpOnce.TabStop = false;
            this.grpOnce.Visible = false;
          //  this.grpOnce.Enter += new System.EventHandler(this.grpOnce_Enter);
            // 
            // btnSearchOnceParking
            // 
            this.btnSearchOnceParking.BackColor = System.Drawing.Color.White;
            this.btnSearchOnceParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchOnceParking.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOnceParking.Location = new System.Drawing.Point(24, 151);
            this.btnSearchOnceParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchOnceParking.Name = "btnSearchOnceParking";
            this.btnSearchOnceParking.Size = new System.Drawing.Size(292, 48);
            this.btnSearchOnceParking.TabIndex = 14;
            this.btnSearchOnceParking.Text = "חפש חניה";
            this.btnSearchOnceParking.UseVisualStyleBackColor = false;
            this.btnSearchOnceParking.Click += new System.EventHandler(this.btnSearchOnceParking_Click_1);
            // 
            // dtpToOnce
            // 
            this.dtpToOnce.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpToOnce.Location = new System.Drawing.Point(66, 108);
            this.dtpToOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToOnce.Name = "dtpToOnce";
            this.dtpToOnce.Size = new System.Drawing.Size(142, 34);
            this.dtpToOnce.TabIndex = 8;
            // 
            // dtpFromOnce
            // 
            this.dtpFromOnce.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpFromOnce.Location = new System.Drawing.Point(66, 68);
            this.dtpFromOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromOnce.Name = "dtpFromOnce";
            this.dtpFromOnce.Size = new System.Drawing.Size(142, 34);
            this.dtpFromOnce.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "עד שעה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "משעה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "תאריך";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(66, 29);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(142, 34);
            this.dtpDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1058, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "יעד";
            // 
            // cmbDest
            // 
            this.cmbDest.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDest.ForeColor = System.Drawing.Color.Red;
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.Location = new System.Drawing.Point(933, 39);
            this.cmbDest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(121, 35);
            this.cmbDest.TabIndex = 9;
           // this.cmbDest.SelectedIndexChanged += new System.EventHandler(this.cmbDest_SelectedIndexChanged);
            // 
            // chekStreet
            // 
            this.chekStreet.AutoSize = true;
            this.chekStreet.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekStreet.ForeColor = System.Drawing.Color.Red;
            this.chekStreet.Location = new System.Drawing.Point(683, 39);
            this.chekStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chekStreet.Name = "chekStreet";
            this.chekStreet.Size = new System.Drawing.Size(186, 31);
            this.chekStreet.TabIndex = 10;
            this.chekStreet.Text = "הצג רק ברחוב זה";
            this.chekStreet.UseVisualStyleBackColor = true;
            // 
            // flpSelectedParking
            // 
            this.flpSelectedParking.AutoScroll = true;
            this.flpSelectedParking.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSelectedParking.ForeColor = System.Drawing.Color.Red;
            this.flpSelectedParking.Location = new System.Drawing.Point(253, 415);
            this.flpSelectedParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSelectedParking.Name = "flpSelectedParking";
            this.flpSelectedParking.Size = new System.Drawing.Size(987, 352);
            this.flpSelectedParking.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SharedParking.Properties.Resources.לוגו_לנאוה_1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 616);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmLookingForParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1310, 906);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpSelectedParking);
            this.Controls.Add(this.chekStreet);
            this.Controls.Add(this.cmbDest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grpOnce);
            this.Controls.Add(this.grpStatic);
            this.Controls.Add(this.btnOnce);
            this.Controls.Add(this.btnStatic);
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLookingForParking";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpStatic.ResumeLayout(false);
            this.grpStatic.PerformLayout();
            this.grpOnce.ResumeLayout(false);
            this.grpOnce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.GroupBox grpStatic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOnce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDest;
        private System.Windows.Forms.CheckBox chekStreet;
        private System.Windows.Forms.FlowLayoutPanel flpSelectedParking;
        private System.Windows.Forms.DateTimePicker dtpFromStatic;
        private System.Windows.Forms.DateTimePicker dtpToStatic;
        private System.Windows.Forms.DateTimePicker dtpToOnce;
        private System.Windows.Forms.DateTimePicker dtpFromOnce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchOnceParking;
        private System.Windows.Forms.Button btnSearchStaticParking;
    }
}