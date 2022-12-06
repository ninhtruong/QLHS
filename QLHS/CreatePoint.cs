using QLHS.Data;
using QLHS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class CreatePoint : Form
    {
        public List<HocSinh> hs = new List<HocSinh>();
        public CreatePoint()
        {
            InitializeComponent();
            ShowHocKy();
        }

        private void ShowHocKy()
        {
            var sql = "	  SELECT * FROM HOCKY";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListHocKy = new List<int>();
            while (read.Read())
            {
                var mahocky = read["MaHocKy"];
                ListHocKy.Add(Convert.ToInt32(mahocky));
            }
            cbxHocKy.DataSource = ListHocKy;
        }

        private void ShowHocSinh()
        {
            hs.Clear();
            var sql = "SELECT * FROM HOCSINH WHERE MaLopHoc = (SELECT MaLopHoc FROM LOPHOC WHERE TENLH = '"+cbxLopHoc.Text+"')";
            var conn = Connection.GetConnection();
            var read = Connection.GetDataReader(conn, sql, "", "");
            var ListHocSinh = new List<string>();
            while (read.Read())
            {
                var hoten = read["HoTen"];
                ListHocSinh.Add(hoten.ToString());
                hs.Add(new HocSinh { MaHocSinh = Convert.ToInt32(read["MaHocSinh"]), HoTen = hoten.ToString() });
            }
            cbxHocSinh.DataSource = ListHocSinh;
        }

        private void ShowLopHoc()
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
            cbxLopHoc.DataSource = ListLopHoc;
        }
        private void LoadData(int MaHS,int MaKhoi, int HK)
        {
            var sql = "	  SELECT * FROM BAITHI WHERE MaHocSinh = "+MaHS+" AND MaKhoi = "+MaKhoi+" AND MaHocKy = " + HK;
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
            var DTBMN = new DiemMonHoc();
            var DiemTb = Point(ListClass, DTBMN);
            DTBMN.DTB = DiemTb;;
            var ListMH = new List<DiemMonHoc>();
            ListMH.Add(DTBMN);
            dataPoint.DataSource = ListMH;
        }

        public double Point(List<BaiThi>BaiThi, DiemMonHoc dmh)
        {
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
            for ( int i =0; i< BaiThi.Count();i++)
            {
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.Toan))
                {
                    Toan += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountToan += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.ToanHoc = Math.Round(Toan / CountToan);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.NguVan))
                {
                    NguVan += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountNguVan += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.NguVan = Math.Round(NguVan / CountNguVan);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.VatLy))
                {
                    VatLy += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountVatLy += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.VatLy = Math.Round(VatLy / CountVatLy);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.HoaHoc))
                {
                    HoaHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountHoaHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.HoaHoc = Math.Round(HoaHoc / CountHoaHoc);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.SinhHoc))
                {
                    SinhHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountSinhHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.SinhHoc = Math.Round(SinhHoc / CountSinhHoc);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.DiaLy))
                {
                    DiaLy += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountDiaLy += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.DiaLy = Math.Round(DiaLy / CountDiaLy);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.LichSu))
                {
                    LichSu += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountLichSu += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.LichSu = Math.Round(LichSu / CountLichSu);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.NgoaiNgu))
                {
                    NgoaiNgu += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountNgoaiNgu += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.NgoaiNgu = Math.Round(NgoaiNgu / CountNgoaiNgu);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.CongNghe))
                {
                    CongNghe += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountCongNghe += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.CongNghe = Math.Round(CongNghe / CountCongNghe);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.DGCD))
                {
                    GDCD += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountGDCD += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.GiaoDucCongDan = Math.Round(GDCD / CountGDCD);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.TinHoc))
                {
                    TinHoc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountTinHoc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.TinHoc = Math.Round(TinHoc / CountTinHoc);
                }
                if (BaiThi[i].MaMonHoc == ((int)EnumMonHoc.TheDuc))
                {
                    TheDuc += BaiThi[i].Diem * TypePoint(BaiThi[i].MaLoaiBaiThi);
                    CountTheDuc += TypePoint(BaiThi[i].MaLoaiBaiThi);
                    dmh.TheDuc = Math.Round(TheDuc / CountTheDuc);
                }
            }
            txtToan.Text = Math.Round(Toan / CountToan).ToString();
            txtNguVan.Text = Math.Round(NguVan / CountNguVan).ToString();
            txtVatLy.Text = Math.Round(VatLy / CountVatLy).ToString();
            txtHoaHoc.Text = Math.Round(HoaHoc / CountHoaHoc).ToString();
            txtSinhHoc.Text = Math.Round(SinhHoc / CountSinhHoc).ToString();
            txtDiaLy.Text = Math.Round(DiaLy / CountDiaLy).ToString();
            txtLichSu.Text = Math.Round(LichSu / CountLichSu).ToString();
            txtNgoaiNgu.Text = Math.Round(NgoaiNgu / CountNgoaiNgu).ToString();
            txtCongNghe.Text = Math.Round(CongNghe / CountCongNghe).ToString();
            txtGDCD.Text = Math.Round(GDCD / CountGDCD).ToString();
            txtTinHoc.Text = Math.Round(TinHoc / CountTinHoc).ToString();
            txtTheDuc.Text = Math.Round(TheDuc / CountTheDuc).ToString();


            var TongDiem = (Toan * 2) + (NguVan * 2) + VatLy + HoaHoc + SinhHoc + DiaLy + LichSu + NgoaiNgu + CongNghe + GDCD + TinHoc + TheDuc;
            var TongHeSo = (CountToan * 2) + (CountNguVan * 2) + CountVatLy + CountHoaHoc + CountSinhHoc + CountDiaLy + CountLichSu + CountNgoaiNgu + 
                CountCongNghe + CountGDCD + CountTinHoc + CountTheDuc;
            return Math.Round(TongDiem / TongHeSo, 2);

        }

        private int TypePoint(int MaLoaiBaiThi)
        {
            if (MaLoaiBaiThi == 1)
                return 1;
            if (MaLoaiBaiThi == 2)
                return 2;
            return 3;
        }


        private void cbxHocKy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowLopHoc();
        }

        private void cbxLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxHocSinh.Text = null;
            ShowHocSinh();
        }

        private void cbxHocSinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var mahs = hs.Where(c => c.HoTen.Equals(cbxHocSinh.Text)).FirstOrDefault();

            LoadData(mahs.MaHocSinh, GetKhoi(cbxLopHoc.Text), Convert.ToInt32(cbxHocKy.Text));
        }

        private int GetKhoi(string TenLH)
        {
            var sql = "	  SELECT * FROM LOPHOC WHERE TenLH = '" + TenLH +"'";
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
    }
}
