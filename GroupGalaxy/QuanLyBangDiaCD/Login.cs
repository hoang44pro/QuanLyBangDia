﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    public class Login
    {
        private String tenDN;
        private String matKhau;

        public Login(string tenDN, string matKhau)
        {
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
        }

        public string TenDN { get => tenDN; set => tenDN = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
