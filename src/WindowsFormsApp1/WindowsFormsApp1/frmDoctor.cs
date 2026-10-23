using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
            this.Text = "Quản lý Bác sĩ";
            LoadData();
        }

        private void LoadData()
        {
            // Tạo danh sách bác sĩ mẫu
            var list = new List<object>
            {
                new { MaBS = "BS001", HoTen = "BS. Phạm Văn Tâm", ChuyenKhoa = "Nội tổng quát", SoDienThai = "0901234567" },
                new { MaBS = "BS002", HoTen = "BS. Lê Thị Mai", ChuyenKhoa = "Nhi khoa", SoDienThai = "0912345678" },
                new { MaBS = "BS003", HoTen = "BS. Trần Quốc Dung", ChuyenKhoa = "Tim mạch", SoDienThai = "0987654321" }
            };

            // Gán dữ liệu vào DataGridView
            dgvDoctor.DataSource = list;
            dgvDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}