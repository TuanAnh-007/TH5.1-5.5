using System;
using System.Windows.Forms;

namespace Bai5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp danh sách Lớp/Khoa
            cboLop.Items.Add("Công nghệ thông tin 1");
            cboLop.Items.Add("Công nghệ thông tin 2");
            cboLop.Items.Add("Kỹ thuật phần mềm");
            cboLop.Items.Add("Hệ thống thông tin");
            cboLop.SelectedIndex = 0;

            // Nạp các chế độ hiển thị cho ListView
            cboView.Items.Add(View.Details);
            cboView.Items.Add(View.LargeIcon);
            cboView.Items.Add(View.SmallIcon);
            cboView.Items.Add(View.List);
            cboView.Items.Add(View.Tile);
            cboView.SelectedItem = View.Details;
        }

        // Thay đổi chế độ xem hiển thị của ListView
        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboView.SelectedItem != null)
            {
                lsvSinhVien.View = (View)cboView.SelectedItem;
            }
        }

        // Kiểm tra dữ liệu nhập (Validation)
        private bool ValidateInput(bool isEdit = false)
        {
            bool isValid = true;
            epCheck.Clear();

            // 1. Kiểm tra Mã SV
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                epCheck.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");
                isValid = false;
            }
            else if (!isEdit)
            {
                // Kiểm tra trùng mã khi thêm mới
                foreach (ListViewItem item in lsvSinhVien.Items)
                {
                    if (item.Text.Equals(txtMaSV.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        epCheck.SetError(txtMaSV, "Mã sinh viên này đã tồn tại!");
                        isValid = false;
                        break;
                    }
                }
            }

            // 2. Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                epCheck.SetError(txtHoTen, "Vui lòng nhập họ và tên!");
                isValid = false;
            }

            return isValid;
        }

        // Chức năng THÊM sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isEdit: false)) return;

            ListViewItem item = new ListViewItem(txtMaSV.Text.Trim());
            item.SubItems.Add(txtHoTen.Text.Trim());
            item.SubItems.Add(dtpNgaySinh.Value.ToString("dd/MM/yyyy"));
            item.SubItems.Add(rdbNam.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(cboLop.SelectedItem.ToString());

            lsvSinhVien.Items.Add(item);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }

        // Chức năng SỬA sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isEdit: true)) return;

            ListViewItem selectedItem = lsvSinhVien.SelectedItems[0];
            selectedItem.SubItems[1].Text = txtHoTen.Text.Trim();
            selectedItem.SubItems[2].Text = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            selectedItem.SubItems[3].Text = rdbNam.Checked ? "Nam" : "Nữ";
            selectedItem.SubItems[4].Text = cboLop.SelectedItem.ToString();

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chức năng XÓA sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đang chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                foreach (ListViewItem item in lsvSinhVien.SelectedItems)
                {
                    lsvSinhVien.Items.Remove(item);
                }
                btnLamMoi_Click(sender, e);
            }
        }

        // Khi chọn một dòng trong ListView thì đưa thông tin lên các Controls
        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvSinhVien.SelectedItems[0];
                txtMaSV.Text = item.Text;
                txtHoTen.Text = item.SubItems[1].Text;

                if (DateTime.TryParseExact(item.SubItems[2].Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dt))
                {
                    dtpNgaySinh.Value = dt;
                }

                if (item.SubItems[3].Text == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;

                cboLop.SelectedItem = item.SubItems[4].Text;
                txtMaSV.Enabled = false; // Khóa trường Mã SV khi đang chọn sửa
            }
        }

        // Nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
            if (cboLop.Items.Count > 0) cboLop.SelectedIndex = 0;
            txtMaSV.Enabled = true;
            epCheck.Clear();
            txtMaSV.Focus();
        }
    }
}