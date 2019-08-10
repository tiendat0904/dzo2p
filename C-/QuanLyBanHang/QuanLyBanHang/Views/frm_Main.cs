using System;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private bool CheckExistFrom(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frm_NhanVien"))
            {
                frm_NhanVien frm = new frm_NhanVien();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_NhanVien");
            }
        }
        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frm_MonAn"))
            {
                frm_MonAn frm = new frm_MonAn();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frm_MonAn");
            }
        }
    }
}
