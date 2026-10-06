namespace Bai5_1
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
        this.grpAccountInfo = new System.Windows.Forms.GroupBox();
        this.lblUsername = new System.Windows.Forms.Label();
        this.txtUsername = new System.Windows.Forms.TextBox();
        this.lblPassword = new System.Windows.Forms.Label();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.lblConfirmPassword = new System.Windows.Forms.Label();
        this.txtConfirmPassword = new System.Windows.Forms.TextBox();
        this.grpAdditionalInfo = new System.Windows.Forms.GroupBox();
        this.lblDob = new System.Windows.Forms.Label();
        this.dtpDob = new System.Windows.Forms.DateTimePicker();
        this.lblGender = new System.Windows.Forms.Label();
        this.rdbNam = new System.Windows.Forms.RadioButton();
        this.rdbNu = new System.Windows.Forms.RadioButton();
        this.chkTerms = new System.Windows.Forms.CheckBox();
        this.btnRegister = new System.Windows.Forms.Button();
        this.btnReset = new System.Windows.Forms.Button();
        this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
        this.grpAccountInfo.SuspendLayout();
        this.grpAdditionalInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
        this.SuspendLayout();
        // 
        // grpAccountInfo
        // 
        this.grpAccountInfo.Controls.Add(this.txtConfirmPassword);
        this.grpAccountInfo.Controls.Add(this.lblConfirmPassword);
        this.grpAccountInfo.Controls.Add(this.txtPassword);
        this.grpAccountInfo.Controls.Add(this.lblPassword);
        this.grpAccountInfo.Controls.Add(this.txtUsername);
        this.grpAccountInfo.Controls.Add(this.lblUsername);
        this.grpAccountInfo.Location = new System.Drawing.Point(20, 20);
        this.grpAccountInfo.Name = "grpAccountInfo";
        this.grpAccountInfo.Size = new System.Drawing.Size(390, 150);
        this.grpAccountInfo.TabIndex = 0;
        this.grpAccountInfo.TabStop = false;
        this.grpAccountInfo.Text = "Thong tin tai khoan";
        // 
        // lblUsername
        // 
        this.lblUsername.AutoSize = true;
        this.lblUsername.Location = new System.Drawing.Point(20, 30);
        this.lblUsername.Name = "lblUsername";
        this.lblUsername.Size = new System.Drawing.Size(84, 13);
        this.lblUsername.TabIndex = 0;
        this.lblUsername.Text = "Ten dang nhap:";
        // 
        // txtUsername
        // 
        this.txtUsername.Location = new System.Drawing.Point(140, 27);
        this.txtUsername.Name = "txtUsername";
        this.txtUsername.Size = new System.Drawing.Size(210, 20);
        this.txtUsername.TabIndex = 1;
        // 
        // lblPassword
        // 
        this.lblPassword.AutoSize = true;
        this.lblPassword.Location = new System.Drawing.Point(20, 70);
        this.lblPassword.Name = "lblPassword";
        this.lblPassword.Size = new System.Drawing.Size(55, 13);
        this.lblPassword.TabIndex = 2;
        this.lblPassword.Text = "Mat khau:";
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(140, 67);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(210, 20);
        this.txtPassword.TabIndex = 3;
        this.txtPassword.UseSystemPasswordChar = true;
        // 
        // lblConfirmPassword
        // 
        this.lblConfirmPassword.AutoSize = true;
        this.lblConfirmPassword.Location = new System.Drawing.Point(20, 110);
        this.lblConfirmPassword.Name = "lblConfirmPassword";
        this.lblConfirmPassword.Size = new System.Drawing.Size(103, 13);
        this.lblConfirmPassword.TabIndex = 4;
        this.lblConfirmPassword.Text = "Xac nhan mat khau:";
        // 
        // txtConfirmPassword
        // 
        this.txtConfirmPassword.Location = new System.Drawing.Point(140, 107);
        this.txtConfirmPassword.Name = "txtConfirmPassword";
        this.txtConfirmPassword.Size = new System.Drawing.Size(210, 20);
        this.txtConfirmPassword.TabIndex = 5;
        this.txtConfirmPassword.UseSystemPasswordChar = true;
        // 
        // grpAdditionalInfo
        // 
        this.grpAdditionalInfo.Controls.Add(this.chkTerms);
        this.grpAdditionalInfo.Controls.Add(this.rdbNu);
        this.grpAdditionalInfo.Controls.Add(this.rdbNam);
        this.grpAdditionalInfo.Controls.Add(this.lblGender);
        this.grpAdditionalInfo.Controls.Add(this.dtpDob);
        this.grpAdditionalInfo.Controls.Add(this.lblDob);
        this.grpAdditionalInfo.Location = new System.Drawing.Point(20, 185);
        this.grpAdditionalInfo.Name = "grpAdditionalInfo";
        this.grpAdditionalInfo.Size = new System.Drawing.Size(390, 150);
        this.grpAdditionalInfo.TabIndex = 1;
        this.grpAdditionalInfo.TabStop = false;
        this.grpAdditionalInfo.Text = "Thong tin bo sung";
        // 
        // lblDob
        // 
        this.lblDob.AutoSize = true;
        this.lblDob.Location = new System.Drawing.Point(20, 30);
        this.lblDob.Name = "lblDob";
        this.lblDob.Size = new System.Drawing.Size(57, 13);
        this.lblDob.TabIndex = 0;
        this.lblDob.Text = "Ngay sinh:";
        // 
        // dtpDob
        // 
        this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpDob.Location = new System.Drawing.Point(140, 27);
        this.dtpDob.Name = "dtpDob";
        this.dtpDob.Size = new System.Drawing.Size(210, 20);
        this.dtpDob.TabIndex = 1;
        // 
        // lblGender
        // 
        this.lblGender.AutoSize = true;
        this.lblGender.Location = new System.Drawing.Point(20, 70);
        this.lblGender.Name = "lblGender";
        this.lblGender.Size = new System.Drawing.Size(50, 13);
        this.lblGender.TabIndex = 2;
        this.lblGender.Text = "Gioi tinh:";
        // 
        // rdbNam
        // 
        this.rdbNam.AutoSize = true;
        this.rdbNam.Checked = true;
        this.rdbNam.Location = new System.Drawing.Point(140, 68);
        this.rdbNam.Name = "rdbNam";
        this.rdbNam.Size = new System.Drawing.Size(47, 17);
        this.rdbNam.TabIndex = 3;
        this.rdbNam.TabStop = true;
        this.rdbNam.Text = "Nam";
        this.rdbNam.UseVisualStyleBackColor = true;
        // 
        // rdbNu
        // 
        this.rdbNu.AutoSize = true;
        this.rdbNu.Location = new System.Drawing.Point(210, 68);
        this.rdbNu.Name = "rdbNu";
        this.rdbNu.Size = new System.Drawing.Size(39, 17);
        this.rdbNu.TabIndex = 4;
        this.rdbNu.Text = "Nu";
        this.rdbNu.UseVisualStyleBackColor = true;
        // 
        // chkTerms
        // 
        this.chkTerms.AutoSize = true;
        this.chkTerms.Location = new System.Drawing.Point(140, 108);
        this.chkTerms.Name = "chkTerms";
        this.chkTerms.Size = new System.Drawing.Size(166, 17);
        this.chkTerms.TabIndex = 5;
        this.chkTerms.Text = "Dong y dieu khoan dich vu";
        this.chkTerms.UseVisualStyleBackColor = true;
        // 
        // btnRegister
        // 
        this.btnRegister.Location = new System.Drawing.Point(100, 355);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(100, 32);
        this.btnRegister.TabIndex = 2;
        this.btnRegister.Text = "Dang Ky";
        this.btnRegister.UseVisualStyleBackColor = true;
        this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
        // 
        // btnReset
        // 
        this.btnReset.Location = new System.Drawing.Point(230, 355);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(100, 32);
        this.btnReset.TabIndex = 3;
        this.btnReset.Text = "Lam Moi";
        this.btnReset.UseVisualStyleBackColor = true;
        this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        // 
        // epCheck
        // 
        this.epCheck.ContainerControl = this;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(434, 406);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.btnRegister);
        this.Controls.Add(this.grpAdditionalInfo);
        this.Controls.Add(this.grpAccountInfo);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Dang Ky Tai Khoan - Bai 5.1";
        this.grpAccountInfo.ResumeLayout(false);
        this.grpAccountInfo.PerformLayout();
        this.grpAdditionalInfo.ResumeLayout(false);
        this.grpAdditionalInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grpAccountInfo;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.GroupBox grpAdditionalInfo;
    private System.Windows.Forms.Label lblDob;
    private System.Windows.Forms.DateTimePicker dtpDob;
    private System.Windows.Forms.Label lblGender;
    private System.Windows.Forms.RadioButton rdbNam;
    private System.Windows.Forms.RadioButton rdbNu;
    private System.Windows.Forms.CheckBox chkTerms;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.ErrorProvider epCheck;
}
}