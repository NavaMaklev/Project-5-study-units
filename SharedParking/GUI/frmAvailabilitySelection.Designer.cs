namespace SharedParking.GUI
{
    partial class frmAvailabilitySelection
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
            this.btnOneTimeAvailability = new System.Windows.Forms.Button();
            this.btnPermanentAvailability = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחר זמינות:";
            // 
            // btnOneTimeAvailability
            // 
            this.btnOneTimeAvailability.BackColor = System.Drawing.Color.White;
            this.btnOneTimeAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneTimeAvailability.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneTimeAvailability.ForeColor = System.Drawing.Color.Red;
            this.btnOneTimeAvailability.Location = new System.Drawing.Point(53, 223);
            this.btnOneTimeAvailability.Name = "btnOneTimeAvailability";
            this.btnOneTimeAvailability.Size = new System.Drawing.Size(190, 146);
            this.btnOneTimeAvailability.TabIndex = 1;
            this.btnOneTimeAvailability.Text = "זמינות חד פעמית";
            this.btnOneTimeAvailability.UseVisualStyleBackColor = false;
            this.btnOneTimeAvailability.Click += new System.EventHandler(this.btnOneTimeAvailability_Click);
            // 
            // btnPermanentAvailability
            // 
            this.btnPermanentAvailability.BackColor = System.Drawing.Color.White;
            this.btnPermanentAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermanentAvailability.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanentAvailability.ForeColor = System.Drawing.Color.Red;
            this.btnPermanentAvailability.Location = new System.Drawing.Point(387, 223);
            this.btnPermanentAvailability.Name = "btnPermanentAvailability";
            this.btnPermanentAvailability.Size = new System.Drawing.Size(190, 146);
            this.btnPermanentAvailability.TabIndex = 2;
            this.btnPermanentAvailability.Text = "זמינות קבועה";
            this.btnPermanentAvailability.UseVisualStyleBackColor = false;
            this.btnPermanentAvailability.Click += new System.EventHandler(this.btnPermanentAvailability_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SharedParking.Properties.Resources.לוגו_לנאוה_1;
            this.pictureBox1.Location = new System.Drawing.Point(523, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmAvailabilitySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPermanentAvailability);
            this.Controls.Add(this.btnOneTimeAvailability);
            this.Controls.Add(this.label1);
            this.Name = "frmAvailabilitySelection";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "בחירת זמינות";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOneTimeAvailability;
        private System.Windows.Forms.Button btnPermanentAvailability;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}