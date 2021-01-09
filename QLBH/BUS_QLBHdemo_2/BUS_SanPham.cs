using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBHdemo;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BUS_QLBHdemo_2
{
    public class BUS_SanPham
    {
        DBconnection db = new DBconnection();
        public void LietKeDanhSachSP(DataGridView dtg, TextBox txtMaSP, TextBox txtTenSP, ComboBox cboNSX, ComboBox cboNCC, 
            ComboBox cboLoaiSP, TextBox txtGiaThanh, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.ExcuteQuery("SELECT dbo.SanPham.TenSP, dbo.SanPham.MaNSX, dbo.SanPham.MaLoaiSP, dbo.LoaiSP.TenLoaiSP,  dbo.SanPham.GiaThanh, dbo.NhaCungCap.TenNCC, dbo.NhaSanXuat.TenNSX, dbo.SanPham.MaSP, dbo.SanPham.MaNCC From dbo.SanPham INNER Join dbo.NhaCungCap On dbo.SanPham.MaNCC = dbo.NhaCungCap.MaNCC INNER Join dbo.NhaSanXuat On dbo.SanPham.MaNSX = dbo.NhaSanXuat.MaNSX INNER Join  dbo.LoaiSP ON dbo.SanPham.MaLoaiSP = dbo.LoaiSP.MaLoaiSP");

            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("text", bs, "MaSP", true);

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("text", bs, "TenSP", true);

            cboNSX.DataBindings.Clear();
            cboNSX.DataBindings.Add("text", bs, "TenNSX", true);

            cboNCC.DataBindings.Clear();
            cboNCC.DataBindings.Add("text", bs, "TenNCC", true);

            cboLoaiSP.DataBindings.Clear();
            cboLoaiSP.DataBindings.Add("text", bs, "TenLoaiSP", true);

            txtGiaThanh.DataBindings.Clear();
            txtGiaThanh.DataBindings.Add("text", bs, "GiaThanh", true);

            bn.BindingSource = bs;
            dtg.DataSource = bs;
                
        }

        public void TaoComboBoxNSX(ComboBox cboNSX)
        {
            DataTable dtnsx = db.ExcuteQuery("SELECT * FROM NhaSanXuat");
            cboNSX.DataSource = dtnsx;
            cboNSX.DisplayMember = "TenNSX";//hien thi
            cboNSX.ValueMember = "MaNSX";//gia tri

        }
        public void TaoComboBoxNCC(ComboBox cboNCC)
        {
            DataTable dtncc = db.ExcuteQuery("SELECT * FROM NhaCungCap");
            cboNCC.DataSource = dtncc;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        public void TaoComboBoxLoaiSP(ComboBox cboloaisp)
        {
            DataTable dtlsp = db.ExcuteQuery("SELECT * FROM LoaiSP ");
            cboloaisp.DataSource = dtlsp;
            cboloaisp.DisplayMember = "TenLoaiSP";
            cboloaisp.ValueMember = "MaLoaiSP";
        }
        public int LuuSanPham(TextBox txtMaSP, TextBox txtTenSP, ComboBox cboLoaiSP, 
            ComboBox cboNCC, ComboBox cboNSX, TextBox txtGiaThanh)
        {
            SqlParameter[] insert = new SqlParameter[6];
            insert[0] = new SqlParameter("@MaSP", txtMaSP.Text);
            insert[1] = new SqlParameter("@TenSP", txtTenSP.Text);
            insert[2] = new SqlParameter("@LoaiSP", cboLoaiSP.SelectedValue);
            insert[3] = new SqlParameter("@MaNCC", cboNCC.SelectedValue);
            insert[4] = new SqlParameter("@MaNSX", cboNSX.SelectedValue);
            insert[5] = new SqlParameter("@GiaThanh", txtGiaThanh.Text);

            string sql = "INSERT INTO SanPham (MaSP, TenSP, MaLoaiSP, MaNCC, MaNSX, GiaThanh) VALUES (@MaSP, @TenSP, @LoaiSP, @MaNCC, @MaNSX, @GiaThanh) ";

            return db.ExecuteNonQuery(sql, insert);
        }
        public int TimSanPham(ComboBox cboLoaiSP)
        {
            SqlParameter[] search = new SqlParameter[1];
            search[0] = new SqlParameter("@LoaiSP", cboLoaiSP.Text);

            string sql = "SELECT * FROM SanPham WHERE MaLoaiSP= @LoaiSP";
            return db.ExecuteNonQuery(sql, search);
        }
    }

}
