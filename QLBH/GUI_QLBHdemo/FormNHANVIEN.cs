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


namespace GUI_QLBHdemo
{
    public partial class FormNHANVIEN : Form
    {
        BUS_NHANVIEN nhanvien = new BUS_NHANVIEN();
        
        public FormNHANVIEN()
        {
            InitializeComponent();

        }

        private void FormNHANVIEN_Load(object sender, EventArgs e)
        {
            nhanvien.LietKeDanhSachNV(dataGridViewNV, txtMANV, txtHOTEN, dtbNGAYSINH,txtDIENTHOAI,bindingNavigatorNV);
           

        }
        
        
        

        private void bttTHOAT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void bttLUU_Click(object sender, EventArgs e)
        {
            if (nhanvien.LuuNhanVien(txtMANV, txtHOTEN, dtbNGAYSINH, txtDIENTHOAI) != 0)
            {
                MessageBox.Show("LƯU THÀNH CÔNG");
                nhanvien.LietKeDanhSachNV(dataGridViewNV, txtMANV, txtHOTEN, dtbNGAYSINH, txtDIENTHOAI, bindingNavigatorNV);
            }
            else
            {
                MessageBox.Show("LỖI KHÔNG THỂ LƯU DỮ LIỆU");
            }
        }

        private void bttSUA_Click(object sender, EventArgs e)
        {
            if(nhanvien.SuaDSNV(txtMANV, txtHOTEN, dtbNGAYSINH, txtDIENTHOAI) != 0)
            {
                MessageBox.Show("SỬA THÀNH CÔNG");
                nhanvien.LietKeDanhSachNV(dataGridViewNV, txtMANV, txtHOTEN, dtbNGAYSINH, txtDIENTHOAI, bindingNavigatorNV);
            }
            else
            {
                MessageBox.Show("LỖI KHÔNG THỂ SỬA DỮ LIỆU");
            }
        }

        private void bttXOA_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắc xóa nhân viên này ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nhanvien.XoaNV(txtMANV) != 0)
                {
                    MessageBox.Show("ĐÃ XÓA NHÂN VIÊN ĐƯỢC CHỌN");
                    nhanvien.LietKeDanhSachNV(dataGridViewNV, txtMANV, txtHOTEN, dtbNGAYSINH, txtDIENTHOAI, bindingNavigatorNV);
                }
                else
                {
                    MessageBox.Show("LỖI KHÔNG THỂ XÓA");
                }
            }
            else
            {
                MessageBox.Show("THAO TÁC ĐÃ ĐƯỢC HỦY");
            }
      
        }
    }
}
