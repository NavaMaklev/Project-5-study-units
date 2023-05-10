namespace SharedParking.GUI
{
    partial class frmMainCustomer
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
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.BackgroundImage = global::SharedParking.Properties.Resources.יציאה_חתוך;
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOut.Location = new System.Drawing.Point(243, 57);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(208, 96);
            this.btnOut.TabIndex = 0;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            this.btnOut.MouseHover += new System.EventHandler(this.btnOut_MouseHover);
            this.btnOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOut_MouseMove);
            // 
            // btnIn
            // 
            this.btnIn.BackgroundImage = global::SharedParking.Properties.Resources.כניסה;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIn.Location = new System.Drawing.Point(508, 57);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 97);
            this.btnIn.TabIndex = 1;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            this.btnIn.MouseHover += new System.EventHandler(this.btnIn_MouseHover);
            this.btnIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIn_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::SharedParking.Properties.Resources.איקס1;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Location = new System.Drawing.Point(688, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 97);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseMove);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::SharedParking.Properties.Resources.זכוכית_מגדלת1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(925, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 96);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            this.btnSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseMove);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(964, 94);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 22);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "חפש חניה";
            this.lblSearch.Visible = false;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(287, 94);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(113, 22);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "יציאה מהחניה";
            this.lblOut.Visible = false;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(518, 94);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(101, 22);
            this.lblIn.TabIndex = 6;
            this.lblIn.Text = "כניסה לחניה";
            this.lblIn.Visible = false;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(723, 94);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(90, 22);
            this.lblCancel.TabIndex = 7;
            this.lblCancel.Text = "בטל הזמנה";
            this.lblCancel.Visible = false;
            // 
            // frmMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SharedParking.Properties.Resources.חניות2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 715);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnOut);
            this.Name = "frmMainCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "לקוח";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblCancel;
    }
}