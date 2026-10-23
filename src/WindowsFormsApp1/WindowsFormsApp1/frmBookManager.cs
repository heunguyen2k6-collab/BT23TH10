using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBookManager : Form
    {
        private BindingList<BookModel> bookList = new BindingList<BookModel>();
        private BindingSource bindingSource = new BindingSource();
        private Timer timer = new Timer();

        public frmBookManager()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupDataBinding();

            // Cấu hình Đồng hồ thời gian thực cho StatusStrip
            timer.Interval = 1000;
            timer.Tick += (s, e) => lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer.Start();

            // Tự động cập nhật StatusStrip mỗi khi danh sách có thay đổi
            bookList.ListChanged += (s, e) => UpdateStatusStrip();

            // Gán sự kiện cho các nút bấm trên Form
            btnBrowseCover.Click += btnBrowseCover_Click;
            btnAddBook.Click += btnAddBook_Click;
            btnDeleteBook.Click += btnDeleteBook_Click;

            // GÁN SỰ KIỆN CHO CÁC NÚT TRÊN MENU STRIP (Sửa lỗi không bấm được menu File)
            lưuFileCSVToolStripMenuItem.Click += lưuFileCSVToolStripMenuItem_Click;
            mởFileCSVToolStripMenuItem.Click += mởFileCSVToolStripMenuItem_Click;
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
        }

        private void SetupDataGridView()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.ReadOnly = true;

            dgvBooks.Columns.Clear();
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BookId", HeaderText = "Mã Sách" });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Tên Sách" });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Author", HeaderText = "Tác Giả" });

            var priceCol = new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Đơn Giá" };
            priceCol.DefaultCellStyle.Format = "N0";
            dgvBooks.Columns.Add(priceCol);

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số Lượng" });
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CoverImagePath", HeaderText = "Ảnh Bìa" });
        }

        private void SetupDataBinding()
        {
            bindingSource.DataSource = bookList;
            dgvBooks.DataSource = bindingSource;

            txtBookId.DataBindings.Clear();
            txtTitle.DataBindings.Clear();
            txtAuthor.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();

            txtBookId.DataBindings.Add("Text", bindingSource, "BookId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTitle.DataBindings.Add("Text", bindingSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAuthor.DataBindings.Add("Text", bindingSource, "Author", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPrice.DataBindings.Add("Text", bindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged, "0", "N0");
            txtQuantity.DataBindings.Add("Text", bindingSource, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);

            // Khi click chọn 1 dòng trên DataGridView -> Tự nạp ảnh lên PictureBox
            bindingSource.CurrentChanged += (s, e) =>
            {
                if (bindingSource.Current is BookModel currentBook && !string.IsNullOrEmpty(currentBook.CoverImagePath) && File.Exists(currentBook.CoverImagePath))
                {
                    picBookCover.ImageLocation = currentBook.CoverImagePath;
                }
                else
                {
                    picBookCover.Image = null;
                }
            };
        }

        // YÊU CẦU 1: TẢI ẢNH BÌA (OpenFileDialog)
        private void btnBrowseCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBookCover.ImageLocation = dlg.FileName;
                }
            }
        }

        // YÊU CẦU 2a: XUẤT FILE CSV (SaveFileDialog)
        private void lưuFileCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "CSV Files (*.csv)|*.csv";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(dlg.FileName))
                    {
                        sw.WriteLine("BookId,Title,Author,Price,Quantity,CoverImagePath");
                        foreach (var b in bookList)
                        {
                            sw.WriteLine($"{b.BookId},{b.Title},{b.Author},{b.Price},{b.Quantity},{b.CoverImagePath}");
                        }
                    }
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // YÊU CẦU 2b: MỞ FILE CSV (OpenFileDialog)
        private void mởFileCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "CSV Files (*.csv)|*.csv";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bookList.Clear();
                    var lines = File.ReadAllLines(dlg.FileName);
                    for (int i = 1; i < lines.Length; i++) // Bỏ qua tiêu đề
                    {
                        var parts = lines[i].Split(',');
                        if (parts.Length >= 6)
                        {
                            bookList.Add(new BookModel
                            {
                                BookId = parts[0],
                                Title = parts[1],
                                Author = parts[2],
                                Price = decimal.Parse(parts[3]),
                                Quantity = int.Parse(parts[4]),
                                CoverImagePath = parts[5]
                            });
                        }
                    }
                    MessageBox.Show("Đọc file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // YÊU CẦU 3: CẬP NHẬT STATUSSTRIP TỰ ĐỘNG
        private void UpdateStatusStrip()
        {
            int totalBooks = bookList.Count;
            decimal totalValue = bookList.Sum(b => b.Price * b.Quantity);
            lblTotalBooks.Text = $"Tổng đầu sách: {totalBooks}";
            lblTotalValue.Text = $"Tổng giá trị kho: {totalValue:N0} VNĐ";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bookList.Add(new BookModel
            {
                BookId = txtBookId.Text,
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Price = decimal.TryParse(txtPrice.Text, out decimal p) ? p : 0,
                Quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 0,
                CoverImagePath = picBookCover.ImageLocation ?? ""
            });
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null) bindingSource.RemoveCurrent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}