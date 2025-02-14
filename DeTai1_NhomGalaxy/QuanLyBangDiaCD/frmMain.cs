﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangDiaCD
{
    public partial class frmMain : Form
    {
        public static string quyen;
        public frmMain(Login user)
        {
            InitializeComponent();
            this.Text = "Bạn đã đăng nhập tên " + user.TenDN + " mật khẩu là " + user.MatKhau;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(quyen == "khachhang")
            {
                mnuChucNang.Visible = false;
                mnuSapXep.Visible = false;
                mnuChucNangTimKiemKhachHang.Visible = false;
            }
        }

        private void mnuChucNangQLBD_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmBangDia") == false)
            {
                frmBangDia frm = new frmBangDia();
                frm.MdiParent = this;
                frm.Name = "frmBangDia";
                frm.Show();
            }
        }
        private bool kiemTraTonTaiForm(String tenForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(tenForm))
                {
                    frm.Activate();
                    return true;
                }

            }
            return false;
        }

        private void mnuChucNangQLNV_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmNhanVien") == false)
            {
                frmNhanVien frm = new frmNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmNhanVien";
                frm.Show();
            }
        }

        private void mnuChucNangQuanLyPhieuThue_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmPhieuThue") == false)
            {
                frmPhieuThue frm = new frmPhieuThue();
                frm.MdiParent = this;
                frm.Name = "frmPhieuThue";
                frm.Show();
            }
        }

        private void mnuTimKiemBD_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmTimKiemBangDia") == false)
            {
                frmTimKiemBangDia frm = new frmTimKiemBangDia();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemBangDia";
                frm.Show();
            }
        }

        private void mnuChucNangTimKiemKhachHang_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmTimKiemKhachHang") == false)
            {
                frmTimKiemKhachHang frm = new frmTimKiemKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemKhachHang";
                frm.Show();
            }
        }

        private void mnuChucNangSapXepKhachHang_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmHonloanKhachHang") == false)
            {
                frmHonloanKhachHang frm = new frmHonloanKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmHonloanKhachHang";
                frm.Show();
            }
        }

        private void mnuChucNangSapXepNhanVien_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmHonLoannhanvien") == false)
            {
                frmHonLoannhanvien frm = new frmHonLoannhanvien();
                frm.MdiParent = this;
                frm.Name = "frmHonLoannhanvien";
                frm.Show();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHƯƠNG TRÌNH QUẢN LÝ BĂNG ĐĨA" + System.Environment.NewLine + "Nhóm thực hiện: Galaxy" + System.Environment.NewLine + "Email: " + System.Environment.NewLine + "SDT: "+System.Environment.NewLine+ "Cảm ơn đã sử dụng ứng dụng của chúng tôi!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

