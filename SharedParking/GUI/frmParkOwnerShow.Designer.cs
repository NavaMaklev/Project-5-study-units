namespace SharedParking.GUI
{
    partial class frmParkOwnerShow
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
            this.dgvParkOwner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParkOwner
            // 
            this.dgvParkOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParkOwner.Location = new System.Drawing.Point(71, 105);
            this.dgvParkOwner.Name = "dgvParkOwner";
            this.dgvParkOwner.RowTemplate.Height = 28;
            this.dgvParkOwner.Size = new System.Drawing.Size(684, 332);
            this.dgvParkOwner.TabIndex = 0;
            this.dgvParkOwner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParkOwner_CellContentClick);
            // 
            // frmParkOwnerShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 507);
            this.Controls.Add(this.dgvParkOwner);
            this.Name = "frmParkOwnerShow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "בעלי חניות";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParkOwner;
    }
}