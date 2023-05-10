namespace SharedParking.GUI
{
    partial class UCSelectedParking
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
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cbOk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodePark = new System.Windows.Forms.TextBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStreet
            // 
            this.txtStreet.ForeColor = System.Drawing.Color.Red;
            this.txtStreet.Location = new System.Drawing.Point(358, 39);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(117, 29);
            this.txtStreet.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Location = new System.Drawing.Point(19, 39);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(73, 29);
            this.txtPrice.TabIndex = 2;
            // 
            // txtSize
            // 
            this.txtSize.ForeColor = System.Drawing.Color.Red;
            this.txtSize.Location = new System.Drawing.Point(117, 39);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(81, 29);
            this.txtSize.TabIndex = 3;
            // 
            // cbOk
            // 
            this.cbOk.AutoSize = true;
            this.cbOk.Location = new System.Drawing.Point(495, 42);
            this.cbOk.Margin = new System.Windows.Forms.Padding(2);
            this.cbOk.Name = "cbOk";
            this.cbOk.Size = new System.Drawing.Size(22, 21);
            this.cbOk.TabIndex = 4;
            this.cbOk.UseVisualStyleBackColor = true;
            this.cbOk.CheckedChanged += new System.EventHandler(this.cbOk_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "רחוב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "מיקום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "גודל";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "מחיר";
            // 
            // txtCodePark
            // 
            this.txtCodePark.ForeColor = System.Drawing.Color.Red;
            this.txtCodePark.Location = new System.Drawing.Point(468, 71);
            this.txtCodePark.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodePark.Name = "txtCodePark";
            this.txtCodePark.Size = new System.Drawing.Size(49, 29);
            this.txtCodePark.TabIndex = 9;
            this.txtCodePark.Visible = false;
            // 
            // txtLoc
            // 
            this.txtLoc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.ForeColor = System.Drawing.Color.Red;
            this.txtLoc.Location = new System.Drawing.Point(223, 39);
            this.txtLoc.Multiline = true;
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(100, 58);
            this.txtLoc.TabIndex = 10;
            // 
            // UCSelectedParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.txtCodePark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOk);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStreet);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCSelectedParking";
            this.Size = new System.Drawing.Size(560, 102);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.CheckBox cbOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodePark;
        private System.Windows.Forms.TextBox txtLoc;
    }
}
