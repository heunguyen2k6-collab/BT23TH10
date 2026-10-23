using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCryptoStockTicker : Form
    {
        private bool _isMonitoring = false;
        private double _lastPrice = 65000.0;
        private int _updateCount = 0;
        private Random _random = new Random();

        public frmCryptoStockTicker()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _isMonitoring = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            // Khởi chạy tiến trình ngầm giám sát liên tục (Background Thread)
            Task.Run(() => StartMonitoringLoop());
        }

        private void StartMonitoringLoop()
        {
            while (_isMonitoring)
            {
                // Định kỳ mỗi 2 giây sinh tỷ giá ngẫu nhiên mới
                Thread.Sleep(2000);

                if (!_isMonitoring) break;

                // Ngẫu nhiên tăng/giảm giá BTC
                double change = (_random.NextDouble() * 1000) - 480;
                double newPrice = Math.Round(_lastPrice + change, 2);
                bool isUp = newPrice >= _lastPrice;

                _lastPrice = newPrice;
                _updateCount++;

                // TUYỆT ĐỐI KHÔNG cập nhật Control trực tiếp từ Thread phụ.
                // Dùng this.Invoke hoặc checking InvokeRequired để đưa về Main UI Thread
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        UpdateUI(newPrice, isUp, _updateCount);
                    }));
                }
                else
                {
                    UpdateUI(newPrice, isUp, _updateCount);
                }
            }
        }

        // Hàm cập nhật giao diện an toàn Thread-Safety
        private void UpdateUI(double price, bool isUp, int count)
        {
            // Update Label hiển thị giá và đổi màu chữ (Xanh khi tăng, Đỏ khi giảm)
            lblBTCPrice.Text = price.ToString("N2") + " USD";
            lblBTCPrice.ForeColor = isUp ? Color.Green : Color.Red;

            // Chèn nhật ký vào DataGridView
            dgvHistoryLog.Rows.Insert(0,
                DateTime.Now.ToString("HH:mm:ss"),
                "BTC/USD",
                price.ToString("N2") + " $",
                isUp ? "▲ Tăng" : "▼ Giảm"
            );

            // Cập nhật thông số ở StatusStrip
            lblLastUpdate.Text = "Cập nhật cuối: " + DateTime.Now.ToString("HH:mm:ss");
            lblCount.Text = "Số lượt đồng bộ: " + count;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _isMonitoring = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void frmCryptoStockTicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isMonitoring = false; // Ngắt vòng lặp ngầm khi người dùng đóng Form
        }
    }
}