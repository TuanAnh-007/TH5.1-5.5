namespace Bai5_4
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
            this.components = new System.ComponentModel.Container();
            this.lblTree = new System.Windows.Forms.Label();
            this.tvKhoaLop = new System.Windows.Forms.TreeView();
            this.btnThemNode = new System.Windows.Forms.Button();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtLopCurrent = new System.Windows.Forms.TextBox();
            this.lblLopCurrent = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTree
            // 
            this.lblTree.AutoSize = true;
            this.lblTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTree.Location = new System.Drawing.Point(12, 12);
            this.lblTree.Name = "lblTree";
            this.lblTree.Size = new System.Drawing.Size(126, 13);
            this.lblTree.TabIndex = 0;
            this.lblTree.Text = "Cấu trúc Khoa - Lớp:";
            // 
            // tvKhoaLop
            // 
            this.tvKhoaLop.Location = new System.Drawing.Point(15, 30);
            this.tvKhoaLop.Name = "tvKhoaLop";
            this.tvKhoaLop.Size = new System.Drawing.Size(210, 360);
            this.tvKhoaLop.TabIndex = 1;
            this.tvKhoaLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoaLop_AfterSelect);
            // 
            // btnThemNode
            // 
            this.btnThemNode.Location = new System.Drawing.Point(15, 400);
            this.btnThemNode.Name = "btnThemNode";
            this.btnThemNode.Size = new System.Drawing.Size(100, 28);
            this.btnThemNode.TabIndex = 2;
            this.btnThemNode.Text = "+ Thêm Nut";
            this.btnThemNode.UseVisualStyleBackColor = true;
            this.btnThemNode.Click += new System.EventHandler(this.btnThemNode_Click);
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.Location = new System.Drawing.Point(125, 400);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(100, 28);
            this.btnXoaNode.TabIndex = 3;
            this.btnXoaNode.Text = "- Xóa Nút";
            this.btnXoaNode.UseVisualStyleBackColor = true;
            this.btnXoaNode.Click += new System.EventHandler(this.btnXoaNode_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtLopCurrent);
            this.grpThongTin.Controls.Add(this.lblLopCurrent);
            this.grpThongTin.Controls.Add(this.rdbNu);
            this.grpThongTin.Controls.Add(this.rdbNam);
            this.grpThongTin.Controls.Add(this.lblGioiTinh);
            this.grpThongTin.Controls.Add(this.dtpNgaySinh);
            this.grpThongTin.Controls.Add(this.lblNgaySinh);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Location = new System.Drawing.Point(240, 25);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(530, 120);
            this.grpThongTin.TabIndex = 4;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin sinh viên";
            // 
            // txtLopCurrent
            // 
            this.txtLopCurrent.Location = new System.Drawing.Point(350, 57);
            this.txtLopCurrent.Name = "txtLopCurrent";
            this.txtLopCurrent.ReadOnly = true;
            this.txtLopCurrent.Size = new System.Drawing.Size(160, 20);
            this.txtLopCurrent.TabIndex = 10;
            // 
            // lblLopCurrent
            // 
            this.lblLopCurrent.AutoSize = true;
            this.lblLopCurrent.Location = new System.Drawing.Point(280, 60);
            this.lblLopCurrent.Name = "lblLopCurrent";
            this.lblLopCurrent.Size = new System.Drawing.Size(56, 13);
            this.lblLopCurrent.TabIndex = 9;
            this.lblLopCurrent.Text = "Lớp/Khoa:";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(420, 26);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(350, 26);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(280, 28);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 13);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(90, 87);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(160, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 90);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(15, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(90, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(160, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(15, 28);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(70, 13);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên:";
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(240, 155);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(80, 28);
            this.btnThemSV.TabIndex = 5;
            this.btnThemSV.Text = "Thêm SV";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Location = new System.Drawing.Point(330, 155);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(80, 28);
            this.btnSuaSV.TabIndex = 6;
            this.btnSuaSV.Text = "Sửa SV";
            this.btnSuaSV.UseVisualStyleBackColor = true;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(420, 155);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(80, 28);
            this.btnXoaSV.TabIndex = 7;
            this.btnXoaSV.Text = "Xóa SV";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(510, 155);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 28);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colHoTen,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colLop});
            this.lsvSinhVien.FullRowSelect = true;
            this.lsvSinhVien.GridLines = true;
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(240, 195);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(530, 233);
            this.lsvSinhVien.TabIndex = 9;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            this.lsvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lsvSinhVien_SelectedIndexChanged);
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 85;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ và tên";
            this.colHoTen.Width = 140;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 95;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp/Khoa";
            this.colLop.Width = 120;
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 440);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnXoaNode);
            this.Controls.Add(this.btnThemNode);
            this.Controls.Add(this.tvKhoaLop);
            this.Controls.Add(this.lblTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa - Lớp - Sinh Viên (TreeView & ListView) - Bài 5.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTree;
        private System.Windows.Forms.TreeView tvKhoaLop;
        private System.Windows.Forms.Button btnThemNode;
        private System.Windows.Forms.Button btnXoaNode;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label lblLopCurrent;
        private System.Windows.Forms.TextBox txtLopCurrent;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}