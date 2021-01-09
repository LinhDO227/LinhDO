using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBHdemo_2;
using System.Data.SqlClient;

namespace GUI_QLBHdemo
{
    public partial class FormNhapXuat : Form
    {
        BUS_NhapXuat nhapxuat = new BUS_NhapXuat();
        public FormNhapXuat()
        {
            InitializeComponent();
        }

        private void FormNhapXuat_Load(object sender, EventArgs e)
        {
            nhapxuat.DanhSachPhieuXuat(txtMaPX, cboMaNV, cboMaKH, dtpNX, bnPX);
            nhapxuat.DanhSachCTPhieuXuat(dataGridViewCTPX, cboMaPX, cboMaSP, txtDonGia, txtSoLuong,bnCTPX);
            nhapxuat.TaoComboBoxPhieuNhap(cboMaPX);
            nhapxuat.TaoComboBoxSP(cboMaSP);
        }

        private void txtMaPX_TextChanged(object sender, EventArgs e)
        {

            //nhapxuat.LoadSanPhamTheoPhieu(txtMaPX, dataGridViewCTPX);
                //nhapxuat.DanhSachCTPhieuXuat(dataGridViewCTPX, cboMaPX, cboMaSP, txtDonGia, txtSoLuong, bnCTPX);

            
        }

        
    }
}
