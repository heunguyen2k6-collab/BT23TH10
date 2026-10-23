using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
            this.Text = "Quản lý Bệnh nhân";
            LoadData();
        }

        private void LoadData()
        {
            // Tạo danh sách bệnh nhân mẫu
            var list = new List<object>
            {
                new { MaBN = "BN001", HoTen = "Nguyễn Văn An", Tuoi = 35, GioiTinh = "Nam", ChuanDoan = "Viêm họng cấp" },
                new { MaBN = "BN002", HoTen = "Trần Thị Bình", Tuoi = 28, GioiTinh = "Nữ", ChuanDoan = "Sốt siêu vi" },
                new { MaBN = "BN003", HoTen = "Lê Hoàng Cường", Tuoi = 50, GioiTinh = "Nam", ChuanDoan = "Tăng huyết áp" }
            };

            // Gán dữ liệu vào DataGridView
            dgvPatient.DataSource = list;
            dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}