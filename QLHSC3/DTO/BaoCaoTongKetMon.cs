﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSC3.DTO
{
    public class BaoCaoTongKetMon
    {
        private int stt;

        public int Stt
        {
            get { return stt; }
            set { stt = value; }
        }
        private string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        private int siSo;

        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }
        private int soLuongDat;

        public int SoLuongDat
        {
            get { return soLuongDat; }
            set { soLuongDat = value; }
        }
        private string tiLe;

        public string TiLe
        {
            get { return tiLe; }
            set { tiLe = value; }
        }
    }
}
