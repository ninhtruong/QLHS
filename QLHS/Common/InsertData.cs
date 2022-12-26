using QLHS.Data;
using QLHS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Common
{

    public static class InsertData
    {

        public static int InsertHS(HocSinh hs)
        {
            var sql = "INSERT INTO [dbo].[HOCSINH] ([MaLopHoc],[HoTen],[NgaySinh],[GioiTinh],[DiaChi],[Email],[NgayTao],[NguoiTao],[NgaySua],[NguoiSua]) VALUES (@MaLopHoc,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@Email,@NgayTao,@NguoiTao,@NgaySua,@NguoiSua)";
            var conn = Connection.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql,conn);
            sqlCommand.Parameters.AddWithValue("@MaLopHoc",hs.MaLopHoc);
            sqlCommand.Parameters.AddWithValue("@HoTen",hs.HoTen);
            sqlCommand.Parameters.AddWithValue("@NgaySinh",hs.NgaySinh);
            sqlCommand.Parameters.AddWithValue("GioiTinh",hs.GioiTinh);
            sqlCommand.Parameters.AddWithValue("@DiaChi",hs.DiaChi);
            sqlCommand.Parameters.AddWithValue("@Email",hs.Email);
            sqlCommand.Parameters.AddWithValue("@NgayTao",DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@NguoiTao",1);
            sqlCommand.Parameters.AddWithValue("@NgaySua",DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@NguoiSua", 1);

            return sqlCommand.ExecuteNonQuery();
        }

        public static int InsertLH(LopHoc lh)
        {
            var sql = "INSERT INTO [dbo].[LOPHOC] ([MaKhoi],[TenLH],[SiSoToiDa]) VALUES (@MaKhoi,@TenLH,@SiSoToiDa)";
            var conn = Connection.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("@MaKhoi", lh.MaKhoi);
            sqlCommand.Parameters.AddWithValue("@TenLH", lh.TenLH);
            sqlCommand.Parameters.AddWithValue("@SiSoToiDa",lh.SiSoToiDa);

            return sqlCommand.ExecuteNonQuery();
        }

        public static int InsertBaiThi(BaiThi bt)
        {
            var sql = "INSERT INTO [dbo].[BAITHI]([MaHocSinh],[MaKhoi],[MaHocKy],[MaLoaiBaiThi],[MaMonHoc],[Diem],[NgayTao],[NguoiTao],[NgaySua],[NguoiSua]) VALUES (@MaHocSinh, @MaKhoi, @MaHocKy, @MaLoaiBaiThi, @MaMonHoc, @Diem, @NgayTao, @NguoiTao, @NgaySua, @NguoiSua)";
            var conn = Connection.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("@MaHocSinh", bt.MaHocSinh);
            sqlCommand.Parameters.AddWithValue("@MaKhoi", bt.MaKhoi);
            sqlCommand.Parameters.AddWithValue("@MaHocKy", bt.MaHocKy);
            sqlCommand.Parameters.AddWithValue("@MaLoaiBaiThi", bt.MaLoaiBaiThi);
            sqlCommand.Parameters.AddWithValue("@MaMonHoc", bt.MaMonHoc);
            sqlCommand.Parameters.AddWithValue("@Diem", bt.Diem);
            sqlCommand.Parameters.AddWithValue("@NgayTao", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@NguoiTao", 1);
            sqlCommand.Parameters.AddWithValue("@NgaySua", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@NguoiSua",1);

            return sqlCommand.ExecuteNonQuery();
        }

        public static int InsertGiaoVien(LopHoc lh)
        {
            var sql = "INSERT INTO [dbo].[GIAOVIEN]([MaGiaoVien],[TaiKhoan],[MatKhau],[HoTen],[GioiTinh],[NgaySinh],[MaMonHoc],[MaGVCN]) VALUES (@MaGiaoVien, @TaiKhoan, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, @MaMonHoc, @MaGVCN)";
            var conn = Connection.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("@MaGiaoVien", lh.MaKhoi);
            sqlCommand.Parameters.AddWithValue("@TaiKhoan", lh.TenLH);
            sqlCommand.Parameters.AddWithValue("@MatKhau", lh.SiSoToiDa);
            sqlCommand.Parameters.AddWithValue("@HoTen", lh.MaKhoi);
            sqlCommand.Parameters.AddWithValue("@GioiTinh", lh.TenLH);
            sqlCommand.Parameters.AddWithValue("@NgaySinh", lh.SiSoToiDa);
            sqlCommand.Parameters.AddWithValue("@MaMonHoc", lh.MaKhoi);
            sqlCommand.Parameters.AddWithValue("@MaGVCN", lh.TenLH);

            return sqlCommand.ExecuteNonQuery();
        }
    }
}
