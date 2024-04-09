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
    public partial class frm_NhaCungCap : Form
    {
        LopDungChung lopdungchung = new LopDungChung();
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string sqlData = "select * from NHACUNGCAP";
            datagrid_nhacungcap.DataSource = lopdungchung.LoadData(sqlData);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sqlThem = "insert into NHACUNGCAP values ('" + txt_manhacungcap.Text + "',N'" + txt_tennhacungcap.Text + "',N'" +
                txt_diachi.Text + "','" + txt_sodt.Text + "')";
            lopdungchung.Nonquery(sqlThem);
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "update NHACUNGCAP set ten_nhacc = N'" + txt_tennhacungcap.Text +
                "',dia_chi = N'" + txt_diachi.Text + "',so_dien_thoai = '" + txt_sodt.Text + 
                "' where ma_nhacc = '"+txt_manhacungcap.Text+"'";
            lopdungchung.Nonquery(sqlSua);
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "delete NHACUNGCAP where ma_nhacc = '" + txt_manhacungcap.Text + "'";
            lopdungchung.Nonquery(sqlXoa);
            LoadData();
        }

        private void datagrid_nhacungcap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = datagrid_nhacungcap.Rows[e.RowIndex];

                txt_manhacungcap.Text = row.Cells[0].Value.ToString();
                txt_tennhacungcap.Text = row.Cells[1].Value.ToString();
                txt_diachi.Text = row.Cells[2].Value.ToString();
                txt_sodt.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
