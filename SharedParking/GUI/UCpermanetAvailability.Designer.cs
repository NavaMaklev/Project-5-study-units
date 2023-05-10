namespace SharedParking.GUI
{
    partial class UCpermanetAvailability
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFromHour = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToHour = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "יום:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(536, 26);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(55, 21);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "משעה:";
            // 
            // lblFromHour
            // 
            this.lblFromHour.AutoSize = true;
            this.lblFromHour.Location = new System.Drawing.Point(348, 26);
            this.lblFromHour.Name = "lblFromHour";
            this.lblFromHour.Size = new System.Drawing.Size(55, 21);
            this.lblFromHour.TabIndex = 3;
            this.lblFromHour.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "עד שעה:";
            // 
            // lblToHour
            // 
            this.lblToHour.AutoSize = true;
            this.lblToHour.Location = new System.Drawing.Point(176, 26);
            this.lblToHour.Name = "lblToHour";
            this.lblToHour.Size = new System.Drawing.Size(55, 21);
            this.lblToHour.TabIndex = 5;
            this.lblToHour.Text = "label6";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(26, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCpermanetAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblToHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFromHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "UCpermanetAvailability";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(633, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFromHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToHour;
        private System.Windows.Forms.Button btnDelete;
    }
}
