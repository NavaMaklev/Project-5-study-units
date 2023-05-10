namespace SharedParking.GUI
{
    partial class frmMain
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnParkingOwner = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnCustomer.Location = new System.Drawing.Point(573, 151);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(172, 117);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "לקוח?";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnParkingOwner
            // 
            this.btnParkingOwner.BackColor = System.Drawing.Color.White;
            this.btnParkingOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingOwner.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingOwner.ForeColor = System.Drawing.Color.Red;
            this.btnParkingOwner.Location = new System.Drawing.Point(573, 334);
            this.btnParkingOwner.Name = "btnParkingOwner";
            this.btnParkingOwner.Size = new System.Drawing.Size(172, 123);
            this.btnParkingOwner.TabIndex = 3;
            this.btnParkingOwner.Text = "בעל חניה?";
            this.btnParkingOwner.UseVisualStyleBackColor = false;
            this.btnParkingOwner.Click += new System.EventHandler(this.btnParkingOwner_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.AutoSize = true;
            this.btnManagement.BackColor = System.Drawing.Color.White;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.Red;
            this.btnManagement.Location = new System.Drawing.Point(751, 12);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(109, 49);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "ניהול";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SharedParking.Properties.Resources.top_view_car_with_destination_mark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnParkingOwner);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnManagement);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "טופס ראשי";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnParkingOwner;
    }
}