using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI.WebControls;

namespace WahnStore_GROUP13.Classes
{
    public class DataProduct
    {

        SqlConnection con;
        public DataProduct()
        {
            string sqlcon = @"Data Source=MCCOMPUTER\SQLEXPRESS01;Initial Catalog=WahnStore;Persist Security Info=True;User ID=sa;Password=123";
            con = new SqlConnection(sqlcon);
        }

        public List<Product> dsProduct()
        {
            List<Product> ds = new List<Product>();
            string sql = "SELECT *FROM Products";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Product p = new Product();
                p.ProductId = (int)rd["product_id"];
                p.ProductName = (string)rd["product_name"];
                p.ProductDescription = (string)rd["product_des"];
                p.ProductPrice = (decimal)rd["product_price"];
                p.ProductQuantity = (int)rd["product_quantity"];
                p.ProductOrigin = (string)rd["product_origin"];
                p.ProductDiameter = (decimal)rd["product_diameter"];
                p.ProductThickness = (decimal)rd["product_thickness"];
                p.ProductWarrantyPeriod = (string)rd["product_warrantyperiod"];
                p.ProductImage = (string)rd["product_image"];
                p.GenderId = (int)rd["gender_id"];
                p.ProductGlass = (string)rd["product_glass"];
                p.BrandId = (int)rd["brand_id"];
                p.ProductColor = (string)rd["product_color"];
                p.ProductStrap = (string)rd["product_strap"];
                p.ProductCreatedDate = (DateTime)rd["product_createddate"];
                ds.Add(p);
            }
            con.Close();
            return ds;
        }

        public Product GetProductById(int productId)
        {
            Product product = null;
            {
                con.Open();
                string query = "SELECT * FROM Products WHERE product_id = @productId";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@productId", productId);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    product = new Product
                    {
                        ProductId = Convert.ToInt32(reader["product_id"]),
                        ProductName = reader["product_name"].ToString(),
                        ProductDescription = reader["product_des"].ToString(),
                        ProductPrice = Convert.ToDecimal(reader["product_price"]),
                        ProductQuantity = Convert.ToInt32(reader["product_quantity"]),
                        ProductOrigin = reader["product_origin"].ToString(),
                        ProductDiameter = Convert.ToDecimal(reader["product_diameter"]),
                        ProductThickness = Convert.ToDecimal(reader["product_thickness"]),
                        ProductWarrantyPeriod = reader["product_warrantyperiod"].ToString(),
                        ProductImage = reader["product_image"].ToString(),
                        BrandId = Convert.ToInt32(reader["brand_id"]),
                        GenderId = Convert.ToInt32(reader["gender_id"]),
                        ProductGlass = reader["product_glass"].ToString(),
                        ProductColor = reader["product_color"].ToString(),
                        ProductStrap = reader["product_strap"].ToString(),
                        ProductCreatedDate = Convert.ToDateTime(reader["product_createddate"])
                    };
                }
            }
            return product;
        }

        public bool AddProduct(Product product)
        {
            try
            {
                con.Open();
                string query = @"INSERT INTO Products 
                                (product_name, product_des, product_price, product_quantity, product_origin, 
                                product_diameter, product_thickness, product_warrantyperiod, product_image, 
                                gender_id, product_glass, brand_id, product_color, product_strap, product_createddate)
                                VALUES 
                                (@ProductName, @ProductDescription, @ProductPrice, @ProductQuantity, @ProductOrigin, 
                                @ProductDiameter, @ProductThickness, @ProductWarrantyPeriod, @ProductImage, 
                                @GenderId, @ProductGlass, @BrandId, @ProductColor, @ProductStrap, @ProductCreatedDate)";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                command.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                command.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
                command.Parameters.AddWithValue("@ProductOrigin", product.ProductOrigin);
                command.Parameters.AddWithValue("@ProductDiameter", product.ProductDiameter);
                command.Parameters.AddWithValue("@ProductThickness", product.ProductThickness);
                command.Parameters.AddWithValue("@ProductWarrantyPeriod", product.ProductWarrantyPeriod);
                command.Parameters.AddWithValue("@ProductImage", product.ProductImage);
                command.Parameters.AddWithValue("@GenderId", product.GenderId);
                command.Parameters.AddWithValue("@ProductGlass", product.ProductGlass);
                command.Parameters.AddWithValue("@BrandId", product.BrandId);
                command.Parameters.AddWithValue("@ProductColor", product.ProductColor);
                command.Parameters.AddWithValue("@ProductStrap", product.ProductStrap);
                command.Parameters.AddWithValue("@ProductCreatedDate", product.ProductCreatedDate);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("Error adding product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string SaveAvatar(FileUpload fileUpload, HttpContext context)
        {
            if (fileUpload.HasFile)
            {
                try
                {
                    string fileName = Path.GetFileName(fileUpload.PostedFile.FileName);
                    string directoryPath = context.Server.MapPath("~/ProductImg/");

                    // Ensure the directory exists
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string filePath = Path.Combine(directoryPath, fileName);
                    fileUpload.SaveAs(filePath);

                    return fileName; // Return the relative path to the file
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    throw new Exception("Error saving image: " + ex.Message);
                }
            }

            return null;
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Products WHERE product_id = @productId";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@productId", productId);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("Error deleting product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                con.Open();
                string query = @"UPDATE Products 
                         SET product_name = @ProductName, 
                             product_des = @ProductDescription, 
                             product_price = @ProductPrice, 
                             product_quantity = @ProductQuantity, 
                             product_origin = @ProductOrigin, 
                             product_diameter = @ProductDiameter, 
                             product_thickness = @ProductThickness, 
                             product_warrantyperiod = @ProductWarrantyPeriod, 
                             product_image = @ProductImage, 
                             gender_id = @GenderId, 
                             product_glass = @ProductGlass, 
                             brand_id = @BrandId, 
                             product_color = @ProductColor, 
                             product_strap = @ProductStrap, 
                             product_createddate = @ProductCreatedDate 
                         WHERE product_id = @ProductId";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                command.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                command.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
                command.Parameters.AddWithValue("@ProductOrigin", product.ProductOrigin);
                command.Parameters.AddWithValue("@ProductDiameter", product.ProductDiameter);
                command.Parameters.AddWithValue("@ProductThickness", product.ProductThickness);
                command.Parameters.AddWithValue("@ProductWarrantyPeriod", product.ProductWarrantyPeriod);
                command.Parameters.AddWithValue("@ProductImage", product.ProductImage);
                command.Parameters.AddWithValue("@GenderId", product.GenderId);
                command.Parameters.AddWithValue("@ProductGlass", product.ProductGlass);
                command.Parameters.AddWithValue("@BrandId", product.BrandId);
                command.Parameters.AddWithValue("@ProductColor", product.ProductColor);
                command.Parameters.AddWithValue("@ProductStrap", product.ProductStrap);
                command.Parameters.AddWithValue("@ProductCreatedDate", product.ProductCreatedDate);
                command.Parameters.AddWithValue("@ProductId", product.ProductId);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                throw new Exception("Error updating product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public string selectBrandName(int id)
        {

            string brandName = null;
            con.Open();
            string queryBrand = "select brand_name from Brands where brand_id=@id";
            SqlCommand cmd = new SqlCommand(queryBrand, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                brandName = (string)rd["brand_name"];
            }
            con.Close();
            return brandName;
        }
        public string selectGenderName(int id)
        {

            string genderName = null;
            con.Open();
            string queryGender = "select gender_name from Genders where gender_id =@id";
            SqlCommand cmd = new SqlCommand(queryGender, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                genderName = (string)rd["gender_name"];
            }
            con.Close();
            return genderName;
        }

        

    }
}