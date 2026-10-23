namespace WindowsFormsApp1
{
    partial class frmMainMDI
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
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpTầngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpNgangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpDọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.cửaSổToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýBệnhNhânToolStripMenuItem,
            this.quảnLýBácSĩToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // quảnLýBệnhNhânToolStripMenuItem
            // 
            this.quảnLýBệnhNhânToolStripMenuItem.Name = "quảnLýBệnhNhânToolStripMenuItem";
            this.quảnLýBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýBệnhNhânToolStripMenuItem.Text = "Quản lý bệnh nhân";
            this.quảnLýBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBệnhNhânToolStripMenuItem_Click);
            // 
            // quảnLýBácSĩToolStripMenuItem
            // 
            this.quảnLýBácSĩToolStripMenuItem.Name = "quảnLýBácSĩToolStripMenuItem";
            this.quảnLýBácSĩToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýBácSĩToolStripMenuItem.Text = "Quản lý bác sĩ";
            this.quảnLýBácSĩToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBácSĩToolStripMenuItem_Click);
            // 
            // cửaSổToolStripMenuItem
            // 
            this.cửaSổToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xếpTầngToolStripMenuItem,
            this.xếpNgangToolStripMenuItem,
            this.xếpDọcToolStripMenuItem,
            this.đóngTấtCảToolStripMenuItem});
            this.cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            this.cửaSổToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // xếpTầngToolStripMenuItem
            // 
            this.xếpTầngToolStripMenuItem.Name = "xếpTầngToolStripMenuItem";
            this.xếpTầngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xếpTầngToolStripMenuItem.Text = "Xếp tầng";
            this.xếpTầngToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // xếpNgangToolStripMenuItem
            // 
            this.xếpNgangToolStripMenuItem.Name = "xếpNgangToolStripMenuItem";
            this.xếpNgangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xếpNgangToolStripMenuItem.Text = "Xếp ngang";
            this.xếpNgangToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // xếpDọcToolStripMenuItem
            // 
            this.xếpDọcToolStripMenuItem.Name = "xếpDọcToolStripMenuItem";
            this.xếpDọcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xếpDọcToolStripMenuItem.Text = "Xếp dọc";
            this.xếpDọcToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // đóngTấtCảToolStripMenuItem
            // 
            this.đóngTấtCảToolStripMenuItem.Name = "đóngTấtCảToolStripMenuItem";
            this.đóngTấtCảToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đóngTấtCảToolStripMenuItem.Text = "Đóng tất cả";
            this.đóngTấtCảToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // frmMainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMDI";
            this.Text = "frmMainMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBácSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cửaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpTầngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpNgangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpDọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảToolStripMenuItem;
    }
}