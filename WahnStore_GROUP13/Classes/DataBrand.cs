using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WahnStore_GROUP13.Classes
{
    public class DataBrand
    {
        SqlConnection con;

        public DataBrand()
        {
            string sqlcon = @"Data Source=MCCOMPUTER\SQLEXPRESS01;Initial Catalog=WahnStore;Persist Security Info=True;User ID=sa;Password=123";
            con = new SqlConnection(sqlcon);
        }

        public List<Brand> dsBrand()
        {
            List<Brand> brands = new List<Brand>();
            string sql = "SELECT brand_id, brand_name, brand_des FROM Brands";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Brand brand = new Brand
                {
                    BrandId = (int)rd["brand_id"],
                    BrandName = (string)rd["brand_name"],
                    BrandDescription = rd["brand_des"] != DBNull.Value ? (string)rd["brand_des"] : null
                };
                brands.Add(brand);
            }
            con.Close();
            return brands;
        }

        public string GetBrandNameById(int brandId)
        {
            string brandName = "";
            string sql = "SELECT brand_name FROM Brands WHERE brand_id = @BrandId";

            // Mở kết nối
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BrandId", brandId);
            SqlDataReader rd = cmd.ExecuteReader();

            // Đọc tên thương hiệu từ SqlDataReader
            if (rd.Read())
            {
                brandName = rd["brand_name"].ToString();
            }

            // Đóng kết nối
            con.Close();

            return brandName;
        }
    }
}