using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRevenueAnalytics : Form
    {
        private CancellationTokenSource _cts;

        public frmRevenueAnalytics()
        {
            InitializeComponent();
        }

        private void frmRevenueAnalytics_Load(object sender, EventArgs e)
        {
            cboBranch.Items.AddRange(new string[] { "Tất cả chi nhánh", "Hà Nội", "TP. Hồ Chí Minh", "Đà Nẵng" });
            cboBranch.SelectedIndex = 0;
        }

        private async void btnStatistic_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();

            btnStatistic.Enabled = false;
            btnCancel.Enabled = true;
            pgbLoading.Value = 0;
            lblStatus.Text = "Đang kết nối Server và tính toán doanh thu...";

            // Lấy tên chi nhánh trên Main UI Thread trước để tránh lỗi Cross-Thread
            string selectedBranch = cboBranch.SelectedItem != null ? cboBranch.SelectedItem.ToString() : "Tất cả chi nhánh";

            try
            {
                // Đẩy tính toán xuống Background Thread (Task.Run) và truyền selectedBranch vào
                var data = await Task.Run(() => ProcessRevenueData(_cts.Token, selectedBranch), _cts.Token);

                // Cập nhật dữ liệu lên DataGridView khi hoàn tất
                dgvRevenue.DataSource = data;
                lblStatus.Text = "Thống kê hoàn tất!";
                pgbLoading.Value = 100;
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Đã hủy thao tác thống kê!";
                pgbLoading.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
            finally
            {
                btnStatistic.Enabled = true;
                btnCancel.Enabled = false;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private List<object> ProcessRevenueData(CancellationToken token, string branchName)
        {
            // Giả lập tính toán dữ liệu lớn trong 5 giây (50 bước x 100ms)
            for (int i = 1; i <= 50; i++)
            {
                // Kiểm tra nếu người dùng bấm "Hủy Thao Tác"
                token.ThrowIfCancellationRequested();

                Thread.Sleep(100); // Giả lập thời gian xử lý nặng

                // Cập nhật tiến độ ProgressBar về UI Thread bằng this.Invoke
                int progress = i * 2; // Đã sửa phép nhân i * 2
                this.Invoke(new Action(() => pgbLoading.Value = progress));
            }

            // Dữ liệu giả lập sau khi tính xong
            var list = new List<object>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(new
                {
                    MaGiaoDich = "GD00" + i,
                    NgayGiaoDich = DateTime.Now.AddDays(-i).ToString("dd/MM/yyyy"),
                    ChiNhanh = branchName, // Dùng biến branchName truyền từ UI Thread vào
                    DoanhThu = (i * 12500000).ToString("N0") + " VNĐ" // Đã sửa phép nhân i * 12500000
                });
            }
            return list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Gọi hủy tác vụ ngầm
            _cts?.Cancel();
        }
    }
}