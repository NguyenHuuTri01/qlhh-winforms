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
    public partial class frm_DangNhap : Form
    {
        LopDungChung lopdungchung = new LopDungChung();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int demloi = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string sqlDangNhap = "select count(*) from TAIKHOAN where user_name = '" + txt_username.Text + 
                "' and password = '" + txt_password.Text + "'";
            int ketqua = lopdungchung.Scalar(sqlDangNhap);

            if(ketqua >= 1)
            {
                demloi = 0;
                this.Hide();
                frm_Main frmmain = new frm_Main();
                frmmain.Show();
            }  else
            {
                demloi++;
                if(demloi == 3)
                {
                    MessageBox.Show("Bạn Đã Nhạp Sai 3 Lần, Chương Trình Sẽ Thoát!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                    lbl_Thong_Bao.Text = "Bạn Đã Nhập Sai " + demloi + " Lần, Sai 3 Lần Sẽ Thoát!";
                }
                
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
