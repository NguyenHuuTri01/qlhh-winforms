using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464_F_NguyenHuuTri_5264
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!checkEsistForm("frm_NhaCungCap"))
            {
                frm_NhaCungCap frmnhacungcap = new frm_NhaCungCap();
                frmnhacungcap.MdiParent = this;
                frmnhacungcap.Show();
            } else
            {
                activeChildForm("frm_NhaCungCap");
            }
        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkEsistForm("frm_DanhMucHang"))
            {
                frm_DanhMucHang frmdanhmuchang = new frm_DanhMucHang();
                frmdanhmuchang.MdiParent = this;
                frmdanhmuchang.Show();
            }
            else
            {
                activeChildForm("frm_DanhMucHang");
            }
        }
        public bool checkEsistForm(string nameform)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == nameform)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public void activeChildForm(string nameform)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == nameform)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frmdangnhap = new frm_DangNhap();
            frmdangnhap.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
