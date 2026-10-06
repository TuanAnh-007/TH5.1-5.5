using System;
using System.Windows.Forms;

namespace Bai5_1
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private bool ValidateForm()
    {
        bool isValid = true;
        epCheck.Clear();

        
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            epCheck.SetError(txtUsername, "Ten dang nhap khong duoc de trong!");
            isValid = false;
        }

        
        if (string.IsNullOrWhiteSpace(txtPassword.Text))
        {
            epCheck.SetError(txtPassword, "Mat khau khong duoc de trong!");
            isValid = false;
        }

        
        if (txtConfirmPassword.Text != txtPassword.Text)
        {
            epCheck.SetError(txtConfirmPassword, "Mat khau xac nhan khong khop voi mat khau ban dau!");
            isValid = false;
        }

        
        DateTime today = DateTime.Today;
        int age = today.Year - dtpDob.Value.Year;
        if (dtpDob.Value.Date > today.AddYears(-age))
        {
            age--;
        }

        if (age < 18)
        {
            epCheck.SetError(dtpDob, "Nguoi dung phai tu 18 tuoi tro len!");
            isValid = false;
        }

        
        if (!chkTerms.Checked)
        {
            epCheck.SetError(chkTerms, "Ban phai tich chon dong y Dieu khoan dich vu!");
            isValid = false;
        }

        return isValid;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            MessageBox.Show("Dang ky tai khoan thanh cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtUsername.Clear();
        txtPassword.Clear();
        txtConfirmPassword.Clear();
        dtpDob.Value = DateTime.Now;
        rdbNam.Checked = true;
        chkTerms.Checked = false;
        epCheck.Clear();
        txtUsername.Focus();
    }
}
}