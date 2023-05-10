namespace SharedParking.GUI
{
    partial class frmParkOptions
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPreviousRentals = new System.Windows.Forms.Button();
            this.btnAvailabilityUpdate = new System.Windows.Forms.Button();
            this.btnAddPark = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "במה תרצה לטפל??";
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Red;
            this.btnOrders.Location = new System.Drawing.Point(104, 167);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(157, 146);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "הזמנות";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnPreviousRentals
            // 
            this.btnPreviousRentals.BackColor = System.Drawing.Color.White;
            this.btnPreviousRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousRentals.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousRentals.ForeColor = System.Drawing.Color.Red;
            this.btnPreviousRentals.Location = new System.Drawing.Point(379, 167);
            this.btnPreviousRentals.Name = "btnPreviousRentals";
            this.btnPreviousRentals.Size = new System.Drawing.Size(157, 146);
            this.btnPreviousRentals.TabIndex = 2;
            this.btnPreviousRentals.Text = "השכרות";
            this.btnPreviousRentals.UseVisualStyleBackColor = false;
            this.btnPreviousRentals.Click += new System.EventHandler(this.btnPreviousRentals_Click);
            // 
            // btnAvailabilityUpdate
            // 
            this.btnAvailabilityUpdate.BackColor = System.Drawing.Color.White;
            this.btnAvailabilityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailabilityUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailabilityUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnAvailabilityUpdate.Location = new System.Drawing.Point(659, 167);
            this.btnAvailabilityUpdate.Name = "btnAvailabilityUpdate";
            this.btnAvailabilityUpdate.Size = new System.Drawing.Size(157, 146);
            this.btnAvailabilityUpdate.TabIndex = 3;
            this.btnAvailabilityUpdate.Text = "עדכון זמינות";
            this.btnAvailabilityUpdate.UseVisualStyleBackColor = false;
            this.btnAvailabilityUpdate.Click += new System.EventHandler(this.btnAvailabilityUpdate_Click);
            // 
            // btnAddPark
            // 
            this.btnAddPark.BackColor = System.Drawing.Color.White;
            this.btnAddPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPark.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPark.ForeColor = System.Drawing.Color.Red;
            this.btnAddPark.Location = new System.Drawing.Point(235, 394);
            this.btnAddPark.Name = "btnAddPark";
            this.btnAddPark.Size = new System.Drawing.Size(157, 146);
            this.btnAddPark.TabIndex = 5;
            this.btnAddPark.Text = "הוספת חניה";
            this.btnAddPark.UseVisualStyleBackColor = false;
            this.btnAddPark.Click += new System.EventHandler(this.btnAddPark_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(517, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 146);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "מחיקת חניה";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SharedParking.Properties.Resources.לוגו_לנאוה_1;
            this.pictureBox1.Location = new System.Drawing.Point(777, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmParkOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPark);
            this.Controls.Add(this.btnAvailabilityUpdate);
            this.Controls.Add(this.btnPreviousRentals);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.label1);
            this.Name = "frmParkOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "עדכונים";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPreviousRentals;
        private System.Windows.Forms.Button btnAvailabilityUpdate;
        private System.Windows.Forms.Button btnAddPark;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}