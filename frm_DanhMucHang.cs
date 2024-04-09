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
    public partial class frm_DanhMucHang : Form
    {
        LopDungChung lopdungchung = new LopDungChung();
        public frm_DanhMucHang()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sqlData = "select * from DANHMUCHANG";
            datagrid_danhmuchang.DataSource = lopdungchung.LoadData(sqlData);
        }
        public void LoadCB()
        {
            string sqlLoadCB_Nhacc = "select * from NHACUNGCAP";
            cb_nhacc.DataSource = lopdungchung.LoadData(sqlLoadCB_Nhacc);
            cb_nhacc.DisplayMember = "ten_nhacc";
            cb_nhacc.ValueMember = "ma_nhacc";
        }
        private void frm_DanhMucHang_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCB();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into DANHMUCHANG values('" + txt_mahang.Text + "','" +
                txt_tenhang.Text + "','" + cb_nhacc.SelectedValue + "','" + txt_donvitinh.Text + "')";
            lopdungchung.Nonquery(sqlThem);
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete DANHMUCHANG where ma_hang = '" + txt_mahang.Text + "'";
            lopdungchung.Nonquery(sqlXoa);
            LoadData();
        }

        private void datagrid_danhmuchang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = datagrid_danhmuchang.Rows[e.RowIndex];

                txt_mahang.Text = row.Cells[0].Value.ToString();
                txt_tenhang.Text = row.Cells[1].Value.ToString();
                cb_nhacc.SelectedValue = row.Cells[2].Value.ToString();
                txt_donvitinh.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update DANHMUCHANG set ten_hang = N'" + txt_tenhang.Text + "',ma_nhacc = '" + 
                            cb_nhacc.SelectedValue + "',don_vi_tinh = N'" + txt_donvitinh.Text +
                            "' where ma_hang = '"+txt_mahang.Text+"'";
            lopdungchung.Nonquery(sqlSua);
            LoadData();
        }
    }
}
