﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSC3.DTO
{
    public class BangDiemMon
    {
        int maBangDiemMon;

        public int MaBangDiemMon
        {
            get { return maBangDiemMon; }
            set { maBangDiemMon = value; }
        }
        int maHocSinh;

        public int MaHocSinh
        {
            get { return maHocSinh; }
            set { maHocSinh = value; }
        }
        int maMonHoc;

        public int MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }
        int maDiem;

        public int MaDiem
        {
            get { return maDiem; }
            set { maDiem = value; }
        }
    }
}
