using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBHdemo;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUS_QLBHdemo_2
{
    public class BUS_NhapXuat
    {
        DBconnection db = new DBconnection();

        public void DanhSachCTPhieuXuat(DataGridView dgv, ComboBox cboMaLoaiSP, ComboBox cboMaSP, TextBox txtSoLuong,
            TextBox txtDonGia, BindingNavigator bnctpx)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.ExcuteQuery(" SELECT dbo.CTPhieuXuat.MaPX, dbo.SanPham.TenSP, dbo.CTPhieuXuat.SoLuong, dbo.CTPhieuXuat.DonGia FROM dbo.CTPhieuXuat INNER JOIN dbo.SanPham ON dbo.CTPhieuXuat.MaSP = dbo.SanPham.MaSP");

            cboMaLoaiSP.DataBindings.Clear();
            cboMaLoaiSP.DataBindings.Add("text", bs, "MaPX", true);

            cboMaSP.DataBindings.Clear();
            cboMaSP.DataBindings.Add("text", bs, "TenSP", true);

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("text", bs, "SoLuong", true);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("text", bs, "DonGia", true);

            bnctpx.BindingSource = bs;
            dgv.DataSource = bs;
        }

        public void DanhSachPhieuXuat(TextBox txtMaPX, ComboBox cboMaNV, ComboBox cboMaKH,
            DateTimePicker dtpNX, BindingNavigator bnpx)
        {
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = db.ExcuteQuery("SELECT dbo.PhieuXuat.MaPX, dbo.NhanVien.TenNV, dbo.KhachHang.TenKH, dbo.PhieuXuat.NgayXuat FROM dbo.NhanVien INNER JOIN dbo.PhieuXuat ON dbo.NhanVien.MaNV = dbo.PhieuXuat.MaNV INNER JOIN dbo.KhachHang ON dbo.PhieuXuat.MaKH = dbo.KhachHang.MaKH");

            txtMaPX.DataBindings.Clear();
            txtMaPX.DataBindings.Add("text", bs1, "MaPX", true);

            cboMaNV.DataBindings.Clear();
            cboMaNV.DataBindings.Add("text", bs1, "TenNV", true);

            cboMaKH.DataBindings.Clear();
            cboMaKH.DataBindings.Add("text", bs1, "TenKH", true);

            dtpNX.DataBindings.Clear();
            dtpNX.DataBindings.Add("value", bs1, "NgayXuat", true);

            bnpx.BindingSource = bs1;
        }

        public void TaoComboBoxPhieuNhap(ComboBox cboLoaiSP)
        {
            DataTable dtloaisp = db.ExcuteQuery("SELECT * FROM CTPhieuXuat");
            cboLoaiSP.DataSource = dtloaisp;
            cboLoaiSP.DisplayMember = "MaPX";
            cboLoaiSP.ValueMember = "MaPX";

        }

        public void TaoComboBoxSP(ComboBox cboSP)
        {
            DataTable dtsp = db.ExcuteQuery("SELECT * FROM SanPham");
            cboSP.DataSource = dtsp;
            cboSP.DisplayMember = "TenSP";
            cboSP.ValueMember = "MaSP";
        }

        public void TaoComboBoxNV(ComboBox cboNV)
        {
            DataTable dtsp = db.ExcuteQuery("SELECT * FROM NhanVien");
            cboNV.DataSource = dtsp;
            cboNV.DisplayMember = "TenNV";
            cboNV.ValueMember = "MaNV";
        }

        public void TaoComboBoxKH(ComboBox cboKH)
        {
            DataTable dtsp = db.ExcuteQuery("SELECT * FROM KhachHang");
            cboKH.DataSource = dtsp;
            cboKH.DisplayMember = "TenKH";
            cboKH.ValueMember = "MaKH";
        }

        //public void LoadSanPhamTheoPhieu(TextBox txtmapx, DataGridView dtg)
        //{
        //    string load = "SELECT dbo.PhieuXuat.MaPX, dbo.NhanVien.TenNV, dbo.KhachHang.TenKH, dbo.PhieuXuat.NgayXuat FROM dbo.NhanVien INNER JOIN dbo.PhieuXuat ON dbo.NhanVien.MaNV = dbo.PhieuXuat.MaNV INNER JOIN dbo.KhachHang ON dbo.PhieuXuat.MaKH = dbo.KhachHang.MaKH where dbo.PhieuXuat.MaPX LIKE '%" + txtmapx.Text + "%'";
        //    SqlDataAdapter adapter = new SqlDataAdapter(load,load);
        //    DataTable bang = new DataTable();
        //    adapter.Fill(bang);
        //    dtg.DataSource = bang;

        //}
    }
}
