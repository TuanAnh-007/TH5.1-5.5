using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai5_2
{
    public partial class Form1 : Form
    {
        // Lớp biểu diễn từng Dịch vụ
        public class ServiceItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public ServiceItem(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} - {Price:N0} VNĐ";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp danh sách Loại dịch vụ vào ComboBox
            cboCategory.Items.Add("Khám bệnh");
            cboCategory.Items.Add("Xét nghiệm");
            cboCategory.Items.Add("Chụp X-Quang");
            cboCategory.Items.Add("Vắc-xin");

            cboCategory.SelectedIndex = 0;
        }

        // Yêu cầu 1: Load danh sách dịch vụ tương ứng khi đổi ComboBox
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            string selectedCategory = cboCategory.SelectedItem.ToString();

            switch (selectedCategory)
            {
                case "Khám bệnh":
                    lstAvailableServices.Items.Add(new ServiceItem("Khám tổng quát", 150000));
                    lstAvailableServices.Items.Add(new ServiceItem("Khám chuyên khoa", 250000));
                    lstAvailableServices.Items.Add(new ServiceItem("Khám cấp cứu", 500000));
                    break;

                case "Xét nghiệm":
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm máu", 120000));
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm đường huyết", 80000));
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm nước tiểu", 60000));
                    break;

                case "Chụp X-Quang":
                    lstAvailableServices.Items.Add(new ServiceItem("X-Quang ngực thẳng", 150000));
                    lstAvailableServices.Items.Add(new ServiceItem("X-Quang cột sống", 200000));
                    lstAvailableServices.Items.Add(new ServiceItem("X-Quang sọ", 250000));
                    break;

                case "Vắc-xin":
                    lstAvailableServices.Items.Add(new ServiceItem("Vắc-xin Cúm", 300000));
                    lstAvailableServices.Items.Add(new ServiceItem("Vắc-xin Viêm gan B", 250000));
                    lstAvailableServices.Items.Add(new ServiceItem("Vắc-xin Dại", 400000));
                    break;
            }
        }

        // Yêu cầu 2: Chọn dịch vụ (nhấn nút '>' hoặc Double Click)
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                ServiceItem item = (ServiceItem)lstAvailableServices.SelectedItem;

                // Thêm vào danh sách chọn
                lstSelectedServices.Items.Add(item);

                // Tự động tính lại tổng chi phí
                CalculateTotal();
            }
        }

        // Bỏ dịch vụ đã chọn (nhấn nút '<' hoặc Double Click ở list bên phải)
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);

                // Tự động tính lại tổng chi phí
                CalculateTotal();
            }
        }

        // Xóa toàn bộ dịch vụ đã chọn (nhấn nút '<<')
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        // Thay đổi phần trăm chiết khấu
        private void nudDiscount_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        // Yêu cầu 3: Tự động tính tổng chi phí dựa trên các dịch vụ đã chọn
        private void CalculateTotal()
        {
            decimal subTotal = 0;

            foreach (ServiceItem item in lstSelectedServices.Items)
            {
                subTotal += item.Price;
            }

            decimal discountRate = nudDiscount.Value;
            decimal total = subTotal * (1 - (discountRate / 100));

            txtSubTotal.Text = $"{subTotal:N0} VNĐ";
            txtTotal.Text = $"{total:N0} VNĐ";
        }
    }
}