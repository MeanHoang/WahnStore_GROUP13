using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13.Pages.CustomerPage
{
    public partial class ProductDeatails : System.Web.UI.Page
    {
        DataProduct data = new DataProduct();
        DataCustomer data1 = new DataCustomer();
        DataBrand data2 = new DataBrand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThi();
            }
        }

        private void HienThi()
        {
            int productId;
            if (int.TryParse(Request.QueryString["productId"], out productId))
            {
                Product product = data.GetProductById(productId);

                if (product != null)
                {
                    ProductImage.Src = "/ProductImg/" + product.ProductImage;
                    ProductName.Text = product.ProductName;
                    ProductDescription.Text = product.ProductDescription;
                    ProductPrice.Text = string.Format("{0:N0} VND", product.ProductPrice);
                    ProductQuantity.Text = "Quantity: " + product.ProductQuantity;
                    ProductOrigin.Text = "Origin: " + product.ProductOrigin;
                    ProductDiameter.Text = "Diameter: " + product.ProductDiameter + " mm";
                    ProductThickness.Text = "Thickness: " + product.ProductThickness + " mm";
                    ProductWarrantyPeriod.Text = "Warranty Period: " + product.ProductWarrantyPeriod;
                    ProductGender.Text = "Giới tính: " + data1.GetGenderNameById(product.GenderId);
                    ProductBrand.Text = "Hãng: " + data2.GetBrandNameById(product.GenderId);
                    ProductGlass.Text = "Glass: " + product.ProductGlass;
                    ProductColor.Text = "Color: " + product.ProductColor;
                    ProductStrap.Text = "Strap: " + product.ProductStrap;
                }
                else
                {
                    // Handle product not found scenario
                    ProductName.Text = "Product not found.";
                }
            }
            else
            {
                // Handle invalid productId scenario
                ProductName.Text = "Invalid product ID.";
            }
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            // Lấy productId từ HiddenField
            int productId;
            if (int.TryParse(Request.QueryString["productId"], out productId))
            {
                DataCustomer data = new DataCustomer();
                // Lấy customerId từ session (giả sử session đã được thiết lập)
                int customerId = data.GetCustomerIdByUsername(Session["Username"].ToString());

                // Kiểm tra nếu customerId hợp lệ
                if (customerId != -1)
                {
                    // Thêm sản phẩm vào giỏ hàng
                    DataCart cartData = new DataCart();
                    DataProduct data1 = new DataProduct();
                    int cartId = cartData.GetCartIdByCustomerId(customerId);
                    if (cartId == -1)
                    {
                        // Nếu customerId chưa có giỏ hàng, tạo một giỏ hàng mới
                        cartId = cartData.CreateCart(customerId);
                    }

                    int quantity = 1; // Số lượng mặc định khi thêm vào giỏ hàng
                    decimal price = data1.GetProductById(productId).ProductPrice; // Giá của sản phẩm
                    cartData.AddToCart(cartId, productId, quantity, price);

                    // Chuyển hướng người dùng đến trang giỏ hàng
                    Response.Redirect("~/Pages/CustomerPage/CartPage.aspx");
                }
                else
                {
                    // Xử lý trường hợp session không chứa customerId hoặc customerId không hợp lệ
                    // Ví dụ: Hiển thị thông báo lỗi
                    // Response.Write("<script>alert('Không thể thêm sản phẩm vào giỏ hàng.');</script>");
                }
            }
            else
            {
                // Xử lý trường hợp productId không hợp lệ
                // Ví dụ: Hiển thị thông báo lỗi
                // Response.Write("<script>alert('ID sản phẩm không hợp lệ.');</script>");
            }
        }



    }
}
