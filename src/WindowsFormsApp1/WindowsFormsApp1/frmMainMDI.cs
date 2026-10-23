using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMainMDI : Form
    {
        public frmMainMDI()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra Singleton tránh mở trùng Form con
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate();
                    return;
                }
            }

            T newChild = new T();
            newChild.MdiParent = this;
            newChild.Show();
        }

        // 1. Sự kiện mở Form con
        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmPatient>();
        }

        private void quảnLýBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDoctor>();
        }

        // 2. Sự kiện sắp xếp cửa sổ MDI Layout
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
    }
}