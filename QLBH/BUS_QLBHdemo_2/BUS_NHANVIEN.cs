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
    public class BUS_NHANVIEN
    {
        DBconnection db = new DBconnection();
        public void LietKeDanhSachNV(DataGridView dtg, TextBox txtMaNV, 
            TextBox txtHoTen, DateTimePicker dtpNTNS, TextBox txtDT, BindingNavigator bn)

        {
            BindingSource bs = new BindingSource();
            bs.DataSource = db.ExcuteQuery("SELECT * FROM NHANVIEN");

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("text", bs, "MaNV", true);

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("text", bs, "TenNV", true);

            dtpNTNS.DataBindings.Clear();
            dtpNTNS.DataBindings.Add("value", bs, "NgaySinh", true);

            txtDT.DataBindings.Clear();
            txtDT.DataBindings.Add("text", bs, "SoDienThoai", true);

            bn.BindingSource = bs;
            dtg.DataSource = bs;
        }

       public int LuuNhanVien(TextBox txtMaNV, TextBox txtHoTen, 
           DateTimePicker dtpNTNS, TextBox txtDT)
        {
            SqlParameter[] insert = new SqlParameter[4];
            insert[0] = new SqlParameter("@MaNV", txtMaNV.Text);
            insert[1] = new SqlParameter("@TenNV", txtHoTen.Text);
            insert[2] = new SqlParameter("@NgaySinh", dtpNTNS.Value);
            insert[3] = new SqlParameter("@SoDienThoai", txtDT.Text);

            string sql = "INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, SoDienThoai) VALUES (@MaNV, @TenNV, @NgaySinh, @SoDienThoai) ";

            return db.ExecuteNonQuery(sql, insert);
        }
        public int SuaDSNV(TextBox txtMaNV, TextBox txtHoTen,
           DateTimePicker dtpNTNS, TextBox txtDT)
        {
            SqlParameter[] update = new SqlParameter[4];
            update[0] = new SqlParameter("@MaNV", txtMaNV.Text);
            update[1] = new SqlParameter("@TenNV", txtHoTen.Text);
            update[2] = new SqlParameter("@NgaySinh", dtpNTNS.Value);
            update[3] = new SqlParameter("@SoDienThoai", txtDT.Text);

            string sql1 = "UPDATE NHANVIEN SET TenNV = @TenNV, NgaySinh = @NgaySinh, SoDienThoai = @SoDienThoai where MaNV = @MaNV";

            return db.ExecuteNonQuery(sql1, update);
        }
        public int XoaNV(TextBox txtMaNV)
        {
            SqlParameter[] delete = new SqlParameter[1];
            delete[0] = new SqlParameter("@MaNV", txtMaNV.Text);


            string sql2 = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";
            return db.ExecuteNonQuery(sql2, delete);
        }

    }
}
