namespace Bai5_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstAvailableServices = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lstSelectedServices = new System.Windows.Forms.ListBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Chọn loại dịch vụ:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(120, 17);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(180, 21);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(20, 55);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(106, 13);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Danh sách dịch vụ:";
            // 
            // lstAvailableServices
            // 
            this.lstAvailableServices.FormattingEnabled = true;
            this.lstAvailableServices.Location = new System.Drawing.Point(20, 75);
            this.lstAvailableServices.Name = "lstAvailableServices";
            this.lstAvailableServices.Size = new System.Drawing.Size(220, 160);
            this.lstAvailableServices.TabIndex = 3;
            this.lstAvailableServices.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(252, 90);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 30);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(252, 135);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 30);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(252, 180);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(50, 30);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "<<";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(310, 55);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(123, 13);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "Dịch vụ đã chọn:";
            // 
            // lstSelectedServices
            // 
            this.lstSelectedServices.FormattingEnabled = true;
            this.lstSelectedServices.Location = new System.Drawing.Point(310, 75);
            this.lstSelectedServices.Name = "lstSelectedServices";
            this.lstSelectedServices.Size = new System.Drawing.Size(220, 160);
            this.lstSelectedServices.TabIndex = 8;
            this.lstSelectedServices.DoubleClick += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.txtTotal);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.nudDiscount);
            this.grpPayment.Controls.Add(this.lblDiscount);
            this.grpPayment.Controls.Add(this.txtSubTotal);
            this.grpPayment.Controls.Add(this.lblSubTotal);
            this.grpPayment.Location = new System.Drawing.Point(20, 250);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(510, 130);
            this.grpPayment.TabIndex = 9;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Thanh toán";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(20, 30);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(120, 13);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Tổng tiền chưa giảm:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(160, 27);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(320, 20);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.Text = "0 VNĐ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(20, 62);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(107, 13);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Tỷ lệ chiết khấu (%):";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(160, 60);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(120, 20);
            this.nudDiscount.TabIndex = 3;
            this.nudDiscount.ValueChanged += new System.EventHandler(this.nudDiscount_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(133, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Thành tiền thanh toán:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(160, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(320, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.Text = "0 VNĐ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 395);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.lstSelectedServices);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstAvailableServices);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tiền Dịch Vụ - Bài 5.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstAvailableServices;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListBox lstSelectedServices;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}