namespace WindowsFormsApp1
{
    partial class frmBookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởFileCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuFileCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTotalBooks = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.btnBrowseCover = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFileCSVToolStripMenuItem,
            this.lưuFileCSVToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mởFileCSVToolStripMenuItem
            // 
            this.mởFileCSVToolStripMenuItem.Name = "mởFileCSVToolStripMenuItem";
            this.mởFileCSVToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.mởFileCSVToolStripMenuItem.Text = "Mở file CSV";
            // 
            // lưuFileCSVToolStripMenuItem
            // 
            this.lưuFileCSVToolStripMenuItem.Name = "lưuFileCSVToolStripMenuItem";
            this.lưuFileCSVToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.lưuFileCSVToolStripMenuItem.Text = "Lưu file CSV";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSáchToolStripMenuItem,
            this.xóaSáchToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // thêmSáchToolStripMenuItem
            // 
            this.thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            this.thêmSáchToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.thêmSáchToolStripMenuItem.Text = "Thêm sách";
            // 
            // xóaSáchToolStripMenuItem
            // 
            this.xóaSáchToolStripMenuItem.Name = "xóaSáchToolStripMenuItem";
            this.xóaSáchToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.xóaSáchToolStripMenuItem.Text = "Xóa sách";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotalBooks,
            this.lblTotalValue,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1012, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(120, 20);
            this.lblTotalBooks.Text = "Tổng đầu sách: 0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(164, 20);
            this.lblTotalValue.Text = "Tổng giá trị kho: 0 VNĐ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 20);
            this.lblTime.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gía bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(139, 43);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(100, 22);
            this.txtBookId.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(139, 76);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(139, 107);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 136);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(139, 171);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "ẢNHHH";
            // 
            // picBookCover
            // 
            this.picBookCover.Location = new System.Drawing.Point(405, 88);
            this.picBookCover.Name = "picBookCover";
            this.picBookCover.Size = new System.Drawing.Size(411, 99);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookCover.TabIndex = 13;
            this.picBookCover.TabStop = false;
            // 
            // btnBrowseCover
            // 
            this.btnBrowseCover.Location = new System.Drawing.Point(405, 209);
            this.btnBrowseCover.Name = "btnBrowseCover";
            this.btnBrowseCover.Size = new System.Drawing.Size(108, 23);
            this.btnBrowseCover.TabIndex = 14;
            this.btnBrowseCover.Text = "Tải ảnh bìa";
            this.btnBrowseCover.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(19, 209);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 15;
            this.btnAddBook.Text = "Thêm mới";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(139, 208);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 16;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(31, 274);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(881, 150);
            this.dgvBooks.TabIndex = 17;
            // 
            // frmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnBrowseCover);
            this.Controls.Add(this.picBookCover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBookManager";
            this.Text = "frmBookManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởFileCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuFileCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSáchToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnBrowseCover;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}