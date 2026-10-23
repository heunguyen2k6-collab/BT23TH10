using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Khai báo BindingList và BindingSource chuẩn đề bài
        private BindingList<MemberModel> memberList = new BindingList<MemberModel>();
        private BindingSource bindingSource = new BindingSource();
        private int autoIdCounter = 1;

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupDataBinding();

            // Gán sự kiện cho các nút bấm
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
        }

        // YÊU CẦU 1: Cấu hình DataGridView chuẩn bằng code (AutoGenerateColumns = false)
        private void SetupDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.ReadOnly = true;

            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MemberId", HeaderText = "Mã HV" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Tên hội viên" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "SĐT" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Package", HeaderText = "Gói tập" });
            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StartDate", HeaderText = "Ngày ĐK" });

            // Định dạng Phí dịch vụ dạng số N0
            var feeCol = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fee",
                HeaderText = "Phí dịch vụ"
            };
            feeCol.DefaultCellStyle.Format = "N0";
            dgvMembers.Columns.Add(feeCol);
        }

        // YÊU CẦU 3: Quản lý trạng thái dữ liệu đồng bộ 2 chiều bằng BindingSource
        private void SetupDataBinding()
        {
            bindingSource.DataSource = memberList;
            dgvMembers.DataSource = bindingSource;

            // Xóa sạch các binding cũ
            txtMemberId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            cboPackage.DataBindings.Clear();
            dtpStartDate.DataBindings.Clear();
            txtFree.DataBindings.Clear();

            // Thêm DataBinding chuẩn dùng txtFree
            txtMemberId.DataBindings.Add("Text", bindingSource, "MemberId", true, DataSourceUpdateMode.Never);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPhone.DataBindings.Add("Text", bindingSource, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
            cboPackage.DataBindings.Add("Text", bindingSource, "Package", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpStartDate.DataBindings.Add("Value", bindingSource, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFree.DataBindings.Add("Text", bindingSource, "Fee", true, DataSourceUpdateMode.OnPropertyChanged, "0", "N0");

            GenerateNewId();
        }

        // YÊU CẦU 2: Kiểm tra hợp lệ (ErrorProvider)
        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "Tên hội viên không được để trống!");
                isValid = false;
            }

            if (txtPhone.Text.Trim().Length != 10 || !long.TryParse(txtPhone.Text.Trim(), out _))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại phải đúng 10 chữ số!");
                isValid = false;
            }

            if (!decimal.TryParse(txtFree.Text.Trim(), out decimal fee) || fee <= 0)
            {
                errorProvider1.SetError(txtFree, "Phí dịch vụ phải là số nguyên dương!");
                isValid = false;
            }

            return isValid;
        }

        private void GenerateNewId()
        {
            txtMemberId.Text = $"HV{autoIdCounter:D3}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            var newMember = new MemberModel
            {
                MemberId = txtMemberId.Text,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem != null ? cboPackage.SelectedItem.ToString() : "Theo tháng",
                StartDate = dtpStartDate.Value,
                Fee = decimal.Parse(txtFree.Text.Trim())
            };

            memberList.Add(newMember);
            autoIdCounter++;
            btnClear_Click(null, null);
            MessageBox.Show("Thêm hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;
            if (!ValidateData()) return;

            bindingSource.EndEdit();
            dgvMembers.Refresh();
            MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên này?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            GenerateNewId();
            txtFullName.Clear();
            txtPhone.Clear();
            txtFree.Clear();
            dtpStartDate.Value = DateTime.Now;
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;
        }
    }
}