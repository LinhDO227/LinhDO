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
using GUI_QLBHdemo;
using System.Data.SqlClient;

namespace GUI_QLBHdemo
{
    public partial class SANPHAM : Form
    {
        BUS_SanPham sanpham = new BUS_SanPham();
        public SANPHAM()
        {
            InitializeComponent();
        }

        private void SANPHAM_Load(object sender, EventArgs e)
        {
            sanpham.LietKeDanhSachSP(dataGridViewSP, txtMaSP, txtTenSP, cboNSX, cboNCC, cboLoaiSP, txtGiaThanh, bindingNavigatorSP);
            sanpham.TaoComboBoxNCC(cboNCC);
            sanpham.TaoComboBoxNSX(cboNSX);
            sanpham.TaoComboBoxLoaiSP(cboLoaiSP);
        }

        private void bttTHOAT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bttTIM_Click(object sender, EventArgs e)
        {
            sanpham.TimSanPham(cboLoaiSP);
        }

        private void bttLUU_Click(object sender, EventArgs e)
        {
            sanpham.LuuSanPham(txtMaSP, txtTenSP, cboLoaiSP, cboNCC, cboNSX, txtGiaThanh);
        }

        
    }
}
