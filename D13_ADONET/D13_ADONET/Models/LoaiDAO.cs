using ASPCore.ADONETLab.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace D13_ADONET.Models
{
    //Thực hiện thêm/xóa/sửa/lấy loại
    public class LoaiDAO
    {
        public static List<Loai> ToList()
        {
            List<Loai> result = new List<Loai>();

            DataTable dsLoai = DataProvider.SelectData("spLayTatCaLoai", CommandType.StoredProcedure, null);
            //convert datatable --> List<Loai>
            foreach(DataRow dr in dsLoai.Rows)
            {
                result.Add(new Loai {
                    MaLoai = Convert.ToInt32(dr["MaLoai"]),
                    TenLoai = dr["TenLoai"].ToString(),
                    MoTa = dr["MoTa"].ToString(),
                    Hinh = dr["Hinh"].ToString()
                });
            }
            return result;
        }

        /// <summary>
        /// Hàm thêm mới loại
        /// </summary>
        /// <param name="lo">loại cần thêm</param>
        /// <returns>mã loại vừa thêm, 0: không thành công</returns>
        public static int AddLoai(Loai lo)
        {
            try
            {
                SqlParameter[] pa = new SqlParameter[4];
                pa[0] = new SqlParameter("MaLoai", SqlDbType.Int);
                pa[0].Direction = ParameterDirection.Output;
                pa[1] = new SqlParameter("TenLoai", lo.TenLoai);
                pa[2] = new SqlParameter("MoTa", lo.MoTa);
                pa[3] = new SqlParameter("Hinh", lo.Hinh);

                DataProvider.ExcuteNonQuery("spThemLoai", CommandType.StoredProcedure, pa);
                return Convert.ToInt32(pa[0].Value);
            }catch(Exception ex)
            {
                return 0;
            }
        }

        public static bool UpdateLoai(Loai lo)
        {
            try
            {
                SqlParameter[] pa = new SqlParameter[4];
                pa[0] = new SqlParameter("MaLoai", lo.MaLoai);
                pa[1] = new SqlParameter("TenLoai", lo.TenLoai);
                pa[2] = new SqlParameter("MoTa", lo.MoTa);
                pa[3] = new SqlParameter("Hinh", lo.Hinh);

                DataProvider.ExcuteNonQuery("spSuaLoai", CommandType.StoredProcedure, pa);
                return true;
            }
            catch { return false; }
        }

        public static bool DeleteLoai(int? id)
        {
            if (!id.HasValue) return false;
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            try
            {
                DataProvider.ExcuteNonQuery("spXoaLoai", CommandType.StoredProcedure, pa);
                return true;
            }
            catch { return false; }
        }

        public static Loai GetLoai(int? id)
        {
            if (!id.HasValue) return null;
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("MaLoai", id);
            DataTable dtLoai = DataProvider.SelectData("spLayLoai",
           CommandType.StoredProcedure, pa);
            if (dtLoai.Rows.Count > 0)
            {
                var row = dtLoai.Rows[0];
                return new Loai()
                {
                    MaLoai = Convert.ToInt32(row["MaLoai"]),
                    TenLoai = row["TenLoai"].ToString(),
                    MoTa = row["MoTa"].ToString(),
                    Hinh = row["Hinh"].ToString()
                };
            }
            return null;
        }
    }
}
