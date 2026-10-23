namespace WindowsFormsApp1
{
    partial class frmCryptoStockTicker
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.DataGridView dgvHistoryLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblLastUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPair;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBTCPrice = new System.Windows.Forms.Label();
            this.dgvHistoryLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(20, 20);
            this.btnStart.Size = new System.Drawing.Size(140, 35);
            this.btnStart.Text = "Bắt đầu Giám sát";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnStop
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(170, 20);
            this.btnStop.Size = new System.Drawing.Size(120, 35);
            this.btnStop.Text = "Tạm dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 70);
            this.lblTitle.Text = "Tỷ giá BTC/USD Thời Gian Thực:";

            // lblBTCPrice
            this.lblBTCPrice.AutoSize = true;
            this.lblBTCPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBTCPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBTCPrice.Location = new System.Drawing.Point(20, 95);
            this.lblBTCPrice.Text = "65,000.00 USD";

            // dgvHistoryLog
            this.dgvHistoryLog.AllowUserToAddRows = false;
            this.dgvHistoryLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime, this.colPair, this.colPrice, this.colStatus});
            this.dgvHistoryLog.Location = new System.Drawing.Point(20, 150);
            this.dgvHistoryLog.Size = new System.Drawing.Size(560, 220);

            // Columns
            this.colTime.HeaderText = "Thời Gian";
            this.colPair.HeaderText = "Cặp Giao Dịch";
            this.colPrice.HeaderText = "Giá Cập Nhật";
            this.colStatus.HeaderText = "Biến Động";

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLastUpdate, this.lblCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);

            // lblLastUpdate
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(250, 17);
            this.lblLastUpdate.Text = "Cập nhật cuối: Chờ bắt đầu...";

            // lblCount
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(180, 17);
            this.lblCount.Text = "Số lượt đồng bộ: 0";

            // frmCryptoStockTicker
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBTCPrice);
            this.Controls.Add(this.dgvHistoryLog);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCryptoStockTicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô Phỏng Giám Sát Tỷ Giá Thời Gian Thực";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCryptoStockTicker_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}