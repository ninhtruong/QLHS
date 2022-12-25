using QLHS.Data;
using QLHS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Common
{
    public static class ShowData
    {

        public static int ShowIDHocSinh()
        {
            var sql = "SELECT TOP 1 * FROM HOCSINH ORDER BY MaHocSinh DESC";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var HocSinh = new List<int>();
            while (read.Read())
            {
                var mahocsinh = read["MaHocSinh"];
                HocSinh.Add(Convert.ToInt32(mahocsinh) + 1);
            }
            return HocSinh.FirstOrDefault();
        }

        public static int ShowIDLOP()
        {
            var sql = "SELECT TOP 1 * FROM LOPHOC ORDER BY MaLopHoc DESC";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var HocSinh = new List<int>();
            while (read.Read())
            {
                var mahocsinh = read["MaLopHoc"];
                HocSinh.Add(Convert.ToInt32(mahocsinh) + 1);
            }
            return HocSinh.FirstOrDefault();
        }

        public static int ShowIDLopHoc(string LopHoc)
        {
            var sql = "SELECT * FROM LOPHOC WHERE TenLH = '"+ LopHoc + "'";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var LH = new List<int>();
            while (read.Read())
            {
                var malophoc = read["MaLopHoc"];
                LH.Add(Convert.ToInt32(malophoc));
            }
            return LH.FirstOrDefault();
        }
        public static List<int> ShowHocKy()
        {
            var sql = "SELECT * FROM HOCKY";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListHocKy = new List<int>();
            while (read.Read())
            {
                var mahocky = read["MaHocKy"];
                ListHocKy.Add(Convert.ToInt32(mahocky));
            }
            return ListHocKy;
        }

        public static List<string> ListLopHoc()
        {
            var sql = "SELECT * FROM LOPHOC";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLopHoc = new List<string>();
            while (read.Read())
            {
                var tenlophoc = read["TenLH"];
                ListLopHoc.Add(tenlophoc.ToString());
            }
            return ListLopHoc;
        }

        public static int CountLopHoc(string TenLH)
        {
            var sql = "SELECT COUNT(*) FROM HOCSINH WHERE MaLopHoc = (SELECT MaLopHoc FROM LOPHOC WHERE TenLH = '" + TenLH + "')";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var Count = new List<int>();
            while (read.Read())
            {
                var tenlophoc = read[""];
                Count.Add(Convert.ToInt32(tenlophoc));
            }
            return Count.FirstOrDefault();
        }


        public static List<DiemMonHoc> ShowLopHoc(string TenLH, string HocKy)
        {
            var sql = "SELECT * FROM HOCSINH WHERE MaLopHoc = (SELECT MaLopHoc FROM LOPHOC WHERE TenLH = '" + TenLH + "')";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLopHoc = new List<DiemMonHoc>();
            while (read.Read())
            {
                var mahocsinh = read["MaHocSinh"];
                var tenhocsinh = read["HoTen"];
                var pointstudent = LoadPointStudent(Convert.ToInt32(mahocsinh), GetKhoi(TenLH), Convert.ToInt32(HocKy), tenhocsinh.ToString());
                ListLopHoc.Add(pointstudent);
            }
            return ListLopHoc;
        }

        public static List<HocSinh> ShowHocSinh(string TenLH)
        {
            var sql = "SELECT * FROM HOCSINH WHERE MaLopHoc = (SELECT MaLopHoc FROM LOPHOC WHERE TenLH = '" + TenLH + "')";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListHocSinh = new List<HocSinh>();
            while (read.Read())
            {
                var mahocsinh = read["MaHocSinh"];
                var tenhocsinh = read["HoTen"];
                var ngaysinh = read["NgaySinh"];
                var gioitinh = read["GioiTinh"];
                var diachi = read["DiaChi"];
                var email = read["Email"];
                var boolgioitinh = Convert.ToBoolean(gioitinh) == true ? "Nam" : "Nữ";
                ListHocSinh.Add(new HocSinh { MaHocSinh = Convert.ToInt32(mahocsinh), HoTen = tenhocsinh.ToString(), NgaySinh = Convert.ToDateTime(ngaysinh), GioiTinh = boolgioitinh, DiaChi = diachi.ToString(), Email = email.ToString() });
            }
            return ListHocSinh;
        }



        private static int GetKhoi(string TenLH)
        {
            var sql = "	  SELECT * FROM LOPHOC WHERE TenLH = '" + TenLH + "'";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListLopHoc = new List<int>();
            while (read.Read())
            {
                var malop = read["MaKhoi"];
                ListLopHoc.Add(Convert.ToInt32(malop));
            }
            return ListLopHoc.FirstOrDefault();
        }

        private static DiemMonHoc LoadPointStudent(int MaHS, int MaKhoi, int HK, string TenHocSinh)
        {
            var sql = "	  SELECT * FROM BAITHI WHERE MaHocSinh = " + MaHS + " AND MaKhoi = " + MaKhoi + " AND MaHocKy = " + HK;
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListClass = new List<BaiThi>();
            while (read.Read())
            {
                var mabaithi = read["MaBaiThi"];
                var mahocsinh = read["MaHocSinh"];
                var makhoi = read["MaKhoi"];
                var mahocky = read["MaHocKy"];
                var maloaibaithi = read["MaLoaiBaiThi"];
                var mamonhoc = read["MaMonHoc"];
                var diem = read["Diem"];

                ListClass.Add(new BaiThi
                {
                    MaBaiThi = Convert.ToInt32(mabaithi),
                    MaHocSinh = Convert.ToInt32(mahocsinh),
                    MaKhoi = Convert.ToInt32(makhoi),
                    MaHocKy = Convert.ToInt32(mahocky),
                    MaLoaiBaiThi = Convert.ToInt32(maloaibaithi),
                    MaMonHoc = Convert.ToInt32(mamonhoc),
                    Diem = Convert.ToInt32(diem)
                });
            }
            return Point(MaHS, ListClass, TenHocSinh);
        }

        public static DiemMonHoc Point(int MaHocSinh, List<BaiThi> BaiThi, string TenHocSinh)
        {
            DiemMonHoc dmh = new DiemMonHoc();
            float Toan = 0;
            float NguVan = 0;
            float VatLy = 0;
            float HoaHoc = 0;
            float SinhHoc = 0;
            float DiaLy = 0;
            float LichSu = 0;
            float NgoaiNgu = 0;
            float CongNghe = 0;
            float GDCD = 0;
            float TinHoc = 0;
            float TheDuc = 0;
            int CountToan = 0;
            int CountNguVan = 0;
            int CountVatLy = 0;
            int CountHoaHoc = 0;
            int CountSinhHoc = 0;
            int CountDiaLy = 0;
            int CountLichSu = 0;
            int CountNgoaiNgu = 0;
            int CountCongNghe = 0;
            int CountGDCD = 0;
            int CountTinHoc = 0;
            int CountTheDuc = 0;
            for (int i = 0; i < BaiThi.Count(); i++)
            {
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.Toan))
                {
                    Toan += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountToan += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.NguVan))
                {
                    NguVan += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountNguVan += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.VatLy))
                {
                    VatLy += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountVatLy += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.HoaHoc))
                {
                    HoaHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountHoaHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.SinhHoc))
                {
                    SinhHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountSinhHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.DiaLy))
                {
                    DiaLy += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountDiaLy += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.LichSu))
                {
                    LichSu += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountLichSu += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.NgoaiNgu))
                {
                    NgoaiNgu += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountNgoaiNgu += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.CongNghe))
                {
                    CongNghe += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountCongNghe += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.DGCD))
                {
                    GDCD += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountGDCD += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.TinHoc))
                {
                    TinHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountTinHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.TheDuc))
                {
                    TheDuc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountTheDuc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                }
            }
            dmh.ToanHoc = Math.Round(Toan / CountToan);
            dmh.NguVan = Math.Round(NguVan / CountNguVan);
            dmh.VatLy = Math.Round(VatLy / CountVatLy);
            dmh.HoaHoc = Math.Round(HoaHoc / CountHoaHoc);
            dmh.SinhHoc = Math.Round(SinhHoc / CountSinhHoc);
            dmh.DiaLy = Math.Round(DiaLy / CountDiaLy);
            dmh.LichSu = Math.Round(LichSu / CountLichSu);
            dmh.NgoaiNgu = Math.Round(NgoaiNgu / CountNgoaiNgu);
            dmh.CongNghe = Math.Round(CongNghe / CountCongNghe);
            dmh.GiaoDucCongDan = Math.Round(GDCD / CountGDCD);
            dmh.TinHoc = Math.Round(TinHoc / CountTinHoc);
            dmh.TheDuc = Math.Round(TheDuc / CountTheDuc);
            dmh.MaHocSinh = MaHocSinh;
            dmh.TenHocSinh = TenHocSinh;
            var TongDiem = (Toan * 2) + (NguVan * 2) + VatLy + HoaHoc + SinhHoc + DiaLy + LichSu + NgoaiNgu + CongNghe + GDCD + TinHoc + TheDuc;
            var TongHeSo = (CountToan * 2) + (CountNguVan * 2) + CountVatLy + CountHoaHoc + CountSinhHoc + CountDiaLy + CountLichSu + CountNgoaiNgu +
                CountCongNghe + CountGDCD + CountTinHoc + CountTheDuc;
            dmh.DTB = Math.Round(TongDiem / TongHeSo, 2);
            return dmh;

        }

        private static int TypePoint(int MaLoaiBaiThi)
        {
            if (MaLoaiBaiThi == 1)
                return 1;
            if (MaLoaiBaiThi == 2)
                return 2;
            return 3;
        }
    }
}
