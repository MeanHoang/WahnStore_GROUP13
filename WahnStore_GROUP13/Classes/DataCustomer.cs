using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WahnStore_GROUP13.Classes
{
    public class DataCustomer
    {
        SqlConnection con;
        public DataCustomer()
        {
            string sqlcon = @"Data Source=DESKTOP-NGDEMD4\SQLEXPRESS;Initial Catalog=WahnStore;Integrated Security=True";
            con = new SqlConnection(sqlcon);
        }

        public List<Gender> dsGender()
        {
            List<Gender> ds = new List<Gender>();
            string sql = "SELECT *FROM Genders";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Gender g = new Gender();
                g.GenderId = (int)rd["gender_id"];
                g.GenderName = (string)rd["gender_name"];
                ds.Add(g);
            }
            con.Close();
            return ds;
        }
        public List<Customer> dsCustomer()
        {
            List<Customer> ds = new List<Customer>();
            string sql = "SELECT *FROM Customers";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Customer c = new Customer();
                c.CustomerID = (int)rd["customer_id"];
                c.FullName = (string)rd["customer_fullname"];
                c.Email = (string)rd["customer_email"];
                c.Phone = (string)rd["customer_phone"];
                c.Username = (string)rd["customer_username"];
                c.Password = (string)rd["customer_password"];
                c.Address = (string)rd["customer_address"];
                c.GenderId = (int)rd["gender_id"];
                c.Avatar = (string)rd["customer_avata"];
                c.CreatedDate = (DateTime)rd["customer_createddate"];
                ds.Add(c);
            }
            con.Close();
            return ds;
        }

        public bool AuthenticateUser(string username, string password)
        {
            string sql = "SELECT COUNT(*) FROM Customers WHERE customer_username = @Username AND customer_password = @Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public string SaveAvatar(HttpPostedFile file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string directoryPath = HttpContext.Current.Server.MapPath("~/Avatar/");

                // Ensure that the directory exists
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string filePath = Path.Combine(directoryPath, fileName);
                file.SaveAs(filePath);
                return fileName;
            }
            return null;
        }


        public bool AddCustomer(Customer customer)
        {
            string sql = @"INSERT INTO Customers (customer_fullname, customer_email, customer_phone, customer_username, customer_password, customer_address, gender_id, customer_avatar, customer_createddate) 
                   VALUES (@FullName, @Email, @Phone, @Username, @Password, @Address, @GenderId, @Avatar, @CreatedDate)";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@FullName", customer.FullName);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Username", customer.Username);
                cmd.Parameters.AddWithValue("@Password", customer.Password);  // Remember to hash the password
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@GenderId", (object)customer.GenderId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Avatar", (object)customer.Avatar ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedDate", customer.CreatedDate);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (SqlException)
                {
                    // Handle specific SQL exceptions
                    // Log the exception or return false
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public Customer GetCustomerByUsername(string username)
        {
            string sql = "SELECT * FROM Customers WHERE customer_username = @Username";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        Customer customer = new Customer();
                        customer.CustomerID = (int)rd["customer_id"];
                        customer.FullName = (string)rd["customer_fullname"];
                        customer.Email = (string)rd["customer_email"];
                        customer.Phone = (string)rd["customer_phone"];
                        customer.Username = (string)rd["customer_username"];
                        customer.Password = (string)rd["customer_password"];
                        customer.Address = (string)rd["customer_address"];
                        customer.GenderId = (int)rd["gender_id"];
                        customer.Avatar = (string)rd["customer_avatar"];
                        customer.CreatedDate = (DateTime)rd["customer_createddate"];
                        return customer;
                    }
                    else
                    {
                        // Không tìm thấy người dùng với tên người dùng được cung cấp
                        return null;
                    }
                }
                catch (SqlException)
                {
                    // Xử lý các trường hợp ngoại lệ khi thực thi câu lệnh SQL
                    // Log lỗi hoặc trả về null nếu có lỗi xảy ra
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public int GetCustomerIdByUsername(string username)
        {
            int customerId = -1;
            string query = "SELECT customer_id FROM Customers WHERE customer_username = @Username";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    customerId = Convert.ToInt32(reader["customer_id"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            con.Close();
            return customerId;
        }
        public string GetGenderNameById(int genderId)
        {
            string genderName = "";
            string sql = "SELECT gender_name FROM Genders WHERE gender_id = @GenderId";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@GenderId", genderId);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        genderName = result.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý ngoại lệ nếu cần
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return genderName;
        }
    }
}