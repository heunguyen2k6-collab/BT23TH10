namespace WindowsFormsApp1
{
    partial class frmRevenueAnalytics
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cboBranch;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblBranch;

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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cboBranch = new System.Windows.Forms.ComboBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();

            // lblFrom
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(20, 20);
            this.lblFrom.Text = "Từ ngày:";

            // dtpFrom
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(80, 16);
            this.dtpFrom.Size = new System.Drawing.Size(120, 23);

            // lblTo
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(220, 20);
            this.lblTo.Text = "Đến ngày:";

            // dtpTo
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(290, 16);
            this.dtpTo.Size = new System.Drawing.Size(120, 23);

            // lblBranch
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(430, 20);
            this.lblBranch.Text = "Chi nhánh:";

            // cboBranch
            this.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranch.Location = new System.Drawing.Point(500, 16);
            this.cboBranch.Size = new System.Drawing.Size(150, 23);

            // btnStatistic
            this.btnStatistic.Location = new System.Drawing.Point(80, 55);
            this.btnStatistic.Size = new System.Drawing.Size(150, 32);
            this.btnStatistic.Text = "Thống Kê Doanh Thu";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);

            // btnCancel
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(240, 55);
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.Text = "Hủy Thao Tác";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // pgbLoading
            this.pgbLoading.Location = new System.Drawing.Point(20, 100);
            this.pgbLoading.Size = new System.Drawing.Size(630, 20);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 128);
            this.lblStatus.Text = "Sẵn sàng";

            // dgvRevenue
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Location = new System.Drawing.Point(20, 155);
            this.dgvRevenue.Size = new System.Drawing.Size(630, 250);

            // frmRevenueAnalytics
            this.ClientSize = new System.Drawing.Size(670, 425);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.cboBranch);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvRevenue);
            this.Name = "frmRevenueAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu Multi-Threading";
            this.Load += new System.EventHandler(this.frmRevenueAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}