﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace FaceAPI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.ShowDialog();
            this.Show();
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            DanhSachSV m = new DanhSachSV();
            m.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            QlTaiKhoan m = new QlTaiKhoan();
            m.ShowDialog();
            this.Show();
        }
        string taiKhoan = "";
        private void Menu_Load(object sender, EventArgs e)
        {
            taiKhoan = DangNhap.taiKhoan;
            lblTenTK.Text = taiKhoan;
            if(lblTenTK.Text == "admin")
            {
                btnTaiKhoan.Enabled = true;
            }
            else
            {
                btnTaiKhoan.Enabled = false;
            }
        }
    }
}
