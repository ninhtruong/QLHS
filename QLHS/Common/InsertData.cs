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
    }
}
