using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.Data
{
    public class Connection
    {
        /// <summary>
        /// Ham lay ket noi toi csdl
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            try
            {
                string _connString = "Server=DESKTOP-JSBFTOH\\DSG;Database=HOCSINHCAPBA;Trusted_Connection=True;MultipleActiveResultSets=true";
                var conn = new SqlConnection(_connString);
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// close connection
        /// </summary>
        /// <param name="conn"></param>
        public static void CloseConnection(SqlConnection conn)
        {
            try
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch
            {
                //ignored
            }
        }
        /// <summary>
        /// create sql command
        /// </summary>
        /// <param name="whereSql"></param>
        /// <param name="orderBySql"></param>
        /// <returns></returns>
        protected static SqlCommand CreateSqlCommand(string sql, string whereSql = "", string orderBySql = "")
        {
            if (!string.IsNullOrEmpty(whereSql))
            {
                sql += " WHERE " + whereSql;
            }
            if (!string.IsNullOrEmpty(orderBySql))
            {
                sql += " ORDER BY " + orderBySql;
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            return sqlCommand;
        }
        /// <summary>
        /// get data reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <param name="whereSql"></param>
        /// <param name="orderBySql"></param>
        /// <returns></returns>
        public static IDataReader GetDataReader(SqlConnection conn, string sql, string whereSql = "", string orderBySql = "")
        {
            try
            {
                var sqlCommand = CreateSqlCommand(sql, whereSql, orderBySql);
                sqlCommand.Connection = conn;
                var reader = sqlCommand.ExecuteReader();
                return reader;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// execute non query
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlConnection conn, string sql, string whereSql = "", string orderyBySql = "")
        {
            try
            {
                var sqlCommand = CreateSqlCommand(sql, whereSql, orderyBySql);
                sqlCommand.Connection = conn;
                return sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
        }
    }
}
