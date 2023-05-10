namespace SharedParking.GUI
{
    partial class frmCancelOrder
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
            this.grbMyOrders = new System.Windows.Forms.GroupBox();
            this.flpOnceOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpStaticOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.grbMyOrders.SuspendLayout();
            this.flpOnceOrder.SuspendLayout();
            this.flpStaticOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "הקש מספר טלפון כדי שנוכל לזהות אותך:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(37, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 26);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // grbMyOrders
            // 
            this.grbMyOrders.Controls.Add(this.flpOnceOrder);
            this.grbMyOrders.Controls.Add(this.flpStaticOrders);
            this.grbMyOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMyOrders.ForeColor = System.Drawing.Color.Red;
            this.grbMyOrders.Location = new System.Drawing.Point(12, 102);
            this.grbMyOrders.Name = "grbMyOrders";
            this.grbMyOrders.Size = new System.Drawing.Size(1425, 589);
            this.grbMyOrders.TabIndex = 2;
            this.grbMyOrders.TabStop = false;
            this.grbMyOrders.Text = "ההזמנות שלך:";
            this.grbMyOrders.Visible = false;
            // 
            // flpOnceOrder
            // 
            this.flpOnceOrder.AutoScroll = true;
            this.flpOnceOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpOnceOrder.Controls.Add(this.label3);
            this.flpOnceOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpOnceOrder.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOnceOrder.Location = new System.Drawing.Point(3, 31);
            this.flpOnceOrder.Name = "flpOnceOrder";
            this.flpOnceOrder.Size = new System.Drawing.Size(882, 555);
            this.flpOnceOrder.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "הזמנות חד פעמיות";
            // 
            // flpStaticOrders
            // 
            this.flpStaticOrders.AutoScroll = true;
            this.flpStaticOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpStaticOrders.Controls.Add(this.label2);
            this.flpStaticOrders.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpStaticOrders.Location = new System.Drawing.Point(1006, 31);
            this.flpStaticOrders.Name = "flpStaticOrders";
            this.flpStaticOrders.Size = new System.Drawing.Size(416, 555);
            this.flpStaticOrders.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "הזמנות קבועות";
            // 
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 774);
            this.Controls.Add(this.grbMyOrders);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Name = "frmCancelOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ביטול הזמנה";
            this.grbMyOrders.ResumeLayout(false);
            this.flpOnceOrder.ResumeLayout(false);
            this.flpOnceOrder.PerformLayout();
            this.flpStaticOrders.ResumeLayout(false);
            this.flpStaticOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grbMyOrders;
        private System.Windows.Forms.FlowLayoutPanel flpOnceOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpStaticOrders;
        private System.Windows.Forms.Label label2;
    }
}