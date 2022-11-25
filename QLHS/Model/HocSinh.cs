using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Model
{
    public class HocSinh
    {
        public int MaHocSinh { get; set; }
        public int MaLopHoc { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public float TBHK1 { get; set; }
        public float TBHK2 { get; set; }
    }
}
