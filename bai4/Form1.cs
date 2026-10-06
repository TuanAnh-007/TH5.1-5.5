using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai5_4
{
    public partial class Form1 : Form
    {
        // Lớp đối tượng lưu thông tin Sinh viên
        public class Student
        {
            public string StudentID { get; set; }
            public string FullName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Gender { get; set; }
            public string ClassName { get; set; }

            public Student(string id, string name, DateTime dob, string gender, string className)
            {
                StudentID = id;
                FullName = name;
                BirthDate = dob;
                Gender = gender;
                ClassName = className;
            }
        }

        // Danh sách lưu trữ toàn bộ sinh viên trong bộ nhớ
        private List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo cây mẫu: Khoa -> Lớp
            TreeNode rootCNTT = tvKhoaLop.Nodes.Add("Khoa CNTT");
            rootCNTT.Nodes.Add("D18CNTT01");
            rootCNTT.Nodes.Add("D18CNTT02");

            TreeNode rootDien = tvKhoaLop.Nodes.Add("Khoa Điện");
            rootDien.Nodes.Add("D18DIEN01");

            // Dữ liệu sinh viên ban đầu
            studentList.Add(new Student("SV001", "Nguyễn Văn A", new DateTime(2003, 5, 10), "Nam", "D18CNTT01"));
            studentList.Add(new Student("SV002", "Trần Thị B", new DateTime(2003, 8, 15), "Nữ", "D18CNTT01"));
            studentList.Add(new Student("SV003", "Lê Văn C", new DateTime(2002, 12, 1), "Nam", "D18CNTT02"));
            studentList.Add(new Student("SV004", "Phạm Hoàng D", new DateTime(2003, 3, 20), "Nam", "D18DIEN01"));

            tvKhoaLop.ExpandAll();

            // Chọn node đầu tiên
            if (tvKhoaLop.Nodes.Count > 0)
            {
                tvKhoaLop.SelectedNode = tvKhoaLop.Nodes[0];
            }
        }

        // Lọc danh sách sinh viên theo Node đang chọn trên TreeView
        private void tvKhoaLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            string selectedNodeText = e.Node.Text;
            txtLopCurrent.Text = selectedNodeText;

            // Nếu là Node Lớp (Node con - Level 1)
            if (e.Node.Level == 1)
            {
                DisplayStudents(studentList.Where(s => s.ClassName == selectedNodeText).ToList());
            }
            // Nếu là Node Khoa (Node cha - Level 0)
            else if (e.Node.Level == 0)
            {
                List<string> childClasses = new List<string>();
                foreach (TreeNode child in e.Node.Nodes)
                {
                    childClasses.Add(child.Text);
                }
                DisplayStudents(studentList.Where(s => childClasses.Contains(s.ClassName)).ToList());
            }
        }

        // Hiển thị dữ liệu danh sách lên ListView
        private void DisplayStudents(List<Student> list)
        {
            lsvSinhVien.Items.Clear();
            foreach (var s in list)
            {
                ListViewItem item = new ListViewItem(s.StudentID);
                item.SubItems.Add(s.FullName);
                item.SubItems.Add(s.BirthDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(s.Gender);
                item.SubItems.Add(s.ClassName);

                lsvSinhVien.Items.Add(item);
            }
        }

        // Thêm Nút (Khoa hoặc Lớp) vào TreeView
        private void btnThemNode_Click(object sender, EventArgs e)
        {
            TreeNode selected = tvKhoaLop.SelectedNode;

            if (selected == null)
            {
                // Thêm Khoa mới (Level 0)
                string khoaName = PromptDialog("Nhập tên Khoa mới:", "Thêm Khoa");
                if (!string.IsNullOrWhiteSpace(khoaName))
                {
                    tvKhoaLop.Nodes.Add(khoaName.Trim());
                }
            }
            else if (selected.Level == 0)
            {
                // Thêm Lớp vào Khoa đang chọn (Level 1)
                string lopName = PromptDialog($"Nhập tên Lớp mới cho '{selected.Text}':", "Thêm Lớp");
                if (!string.IsNullOrWhiteSpace(lopName))
                {
                    selected.Nodes.Add(lopName.Trim());
                    selected.Expand();
                }
            }
            else
            {
                MessageBox.Show("Chỉ hỗ trợ tạo 2 cấp: Khoa -> Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa Nút trên TreeView
        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            TreeNode selected = tvKhoaLop.SelectedNode;
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn nút cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa '{selected.Text}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Xóa sinh viên thuộc Lớp/Khoa tương ứng
                if (selected.Level == 1)
                {
                    studentList.RemoveAll(s => s.ClassName == selected.Text);
                }
                else if (selected.Level == 0)
                {
                    foreach (TreeNode child in selected.Nodes)
                    {
                        studentList.RemoveAll(s => s.ClassName == child.Text);
                    }
                }

                tvKhoaLop.Nodes.Remove(selected);
                DisplayStudents(new List<Student>());
            }
        }

        // Kiểm tra dữ liệu nhập cho Sinh viên
        private bool ValidateInput(bool isEdit = false)
        {
            bool isValid = true;
            epCheck.Clear();

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                epCheck.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");
                isValid = false;
            }
            else if (!isEdit && studentList.Any(s => s.StudentID.Equals(txtMaSV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                epCheck.SetError(txtMaSV, "Mã sinh viên này đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                epCheck.SetError(txtHoTen, "Vui lòng nhập họ và tên!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLopCurrent.Text) || tvKhoaLop.SelectedNode == null || tvKhoaLop.SelectedNode.Level != 1)
            {
                epCheck.SetError(txtLopCurrent, "Vui lòng chọn 1 Lớp cụ thể trên Cây danh mục!");
                isValid = false;
            }

            return isValid;
        }

        // Thêm Sinh viên mới
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isEdit: false)) return;

            Student newStudent = new Student(
                txtMaSV.Text.Trim(),
                txtHoTen.Text.Trim(),
                dtpNgaySinh.Value,
                rdbNam.Checked ? "Nam" : "Nữ",
                txtLopCurrent.Text.Trim()
            );

            studentList.Add(newStudent);
            tvKhoaLop_AfterSelect(sender, new TreeViewEventArgs(tvKhoaLop.SelectedNode));
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }

        // Sửa thông tin Sinh viên
        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isEdit: true)) return;

            string id = txtMaSV.Text.Trim();
            Student st = studentList.FirstOrDefault(s => s.StudentID == id);
            if (st != null)
            {
                st.FullName = txtHoTen.Text.Trim();
                st.BirthDate = dtpNgaySinh.Value;
                st.Gender = rdbNam.Checked ? "Nam" : "Nữ";

                tvKhoaLop_AfterSelect(sender, new TreeViewEventArgs(tvKhoaLop.SelectedNode));
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Xóa Sinh viên
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên đang chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string id = lsvSinhVien.SelectedItems[0].Text;
                studentList.RemoveAll(s => s.StudentID == id);
                tvKhoaLop_AfterSelect(sender, new TreeViewEventArgs(tvKhoaLop.SelectedNode));
                btnLamMoi_Click(sender, e);
            }
        }

        // Đưa thông tin từ ListView lên TextBox khi chọn dòng
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

                txtLopCurrent.Text = item.SubItems[4].Text;
                txtMaSV.Enabled = false;
            }
        }

        // Làm mới ô nhập
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdbNam.Checked = true;
            txtMaSV.Enabled = true;
            epCheck.Clear();
            txtMaSV.Focus();
        }

        // Hộp thoại nhập tên Nút đơn giản
        private string PromptDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 320,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Label textLabel = new Label() { Left = 20, Top = 15, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 38, Width = 260 };
            Button confirmation = new Button() { Text = "Đồng ý", Left = 180, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}