
namespace CS464_F_NguyenHuuTri_5264
{
    partial class frm_DanhMucHang
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
            this.datagrid_danhmuchang = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.aa = new System.Windows.Forms.Label();
            this.txt_tennhacungcap = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.asdasd = new System.Windows.Forms.Label();
            this.txt_mahang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nhacc = new System.Windows.Forms.ComboBox();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_danhmuchang)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_danhmuchang
            // 
            this.datagrid_danhmuchang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_danhmuchang.Location = new System.Drawing.Point(66, 286);
            this.datagrid_danhmuchang.Name = "datagrid_danhmuchang";
            this.datagrid_danhmuchang.RowHeadersWidth = 51;
            this.datagrid_danhmuchang.RowTemplate.Height = 24;
            this.datagrid_danhmuchang.Size = new System.Drawing.Size(892, 223);
            this.datagrid_danhmuchang.TabIndex = 25;
            this.datagrid_danhmuchang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagrid_danhmuchang_CellMouseClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(844, 231);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 33);
            this.btn_thoat.TabIndex = 24;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(421, 211);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(114, 33);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(250, 211);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(114, 33);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(66, 211);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(114, 33);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa.Location = new System.Drawing.Point(906, 64);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(84, 18);
            this.aa.TabIndex = 19;
            this.aa.Text = "Đơn Vị Tính";
            // 
            // txt_tennhacungcap
            // 
            this.txt_tennhacungcap.AutoSize = true;
            this.txt_tennhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennhacungcap.Location = new System.Drawing.Point(548, 61);
            this.txt_tennhacungcap.Name = "txt_tennhacungcap";
            this.txt_tennhacungcap.Size = new System.Drawing.Size(134, 18);
            this.txt_tennhacungcap.TabIndex = 18;
            this.txt_tennhacungcap.Text = "Tên Nhà Cung Cấp";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(367, 56);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(146, 22);
            this.txt_tenhang.TabIndex = 16;
            // 
            // asdasd
            // 
            this.asdasd.AutoSize = true;
            this.asdasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdasd.Location = new System.Drawing.Point(271, 57);
            this.asdasd.Name = "asdasd";
            this.asdasd.Size = new System.Drawing.Size(72, 18);
            this.asdasd.TabIndex = 15;
            this.asdasd.Text = "Tên Hàng";
            // 
            // txt_mahang
            // 
            this.txt_mahang.Location = new System.Drawing.Point(101, 53);
            this.txt_mahang.Name = "txt_mahang";
            this.txt_mahang.Size = new System.Drawing.Size(140, 22);
            this.txt_mahang.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Hàng";
            // 
            // cb_nhacc
            // 
            this.cb_nhacc.FormattingEnabled = true;
            this.cb_nhacc.Location = new System.Drawing.Point(709, 60);
            this.cb_nhacc.Name = "cb_nhacc";
            this.cb_nhacc.Size = new System.Drawing.Size(150, 24);
            this.cb_nhacc.TabIndex = 26;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Location = new System.Drawing.Point(1018, 64);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(145, 22);
            this.txt_donvitinh.TabIndex = 27;
            // 
            // frm_DanhMucHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 562);
            this.Controls.Add(this.txt_donvitinh);
            this.Controls.Add(this.cb_nhacc);
            this.Controls.Add(this.datagrid_danhmuchang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.txt_tennhacungcap);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.asdasd);
            this.Controls.Add(this.txt_mahang);
            this.Controls.Add(this.label1);
            this.Name = "frm_DanhMucHang";
            this.Text = "frm_DanhMucHang";
            this.Load += new System.EventHandler(this.frm_DanhMucHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_danhmuchang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_danhmuchang;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.Label txt_tennhacungcap;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label asdasd;
        private System.Windows.Forms.TextBox txt_mahang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nhacc;
        private System.Windows.Forms.TextBox txt_donvitinh;
    }
}