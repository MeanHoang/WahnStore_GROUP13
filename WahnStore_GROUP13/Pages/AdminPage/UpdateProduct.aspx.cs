using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13.Pages.AdminPage
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        DataBrand data1 = new DataBrand();
        DataProduct dataProduct = new DataProduct();
        DataCustomer customer = new DataCustomer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Hiển thị dữ liệu sản phẩm cần cập nhật
                int productId = Convert.ToInt32(Request.QueryString["productId"]);
                LoadProductDetails(productId);

                // Hiển thị danh sách thương hiệu và giới tính
                HienThiDrop();
            }
        }

        private void LoadProductDetails(int productId)
        {
            Product product = dataProduct.GetProductById(productId);
            if (product != null)
            {
                txtproductname.Text = product.ProductName;
                txtdes.Text = product.ProductDescription;
                txtprice.Text = product.ProductPrice.ToString();
                txtquantity.Text = product.ProductQuantity.ToString();
                txtorigin.Text = product.ProductOrigin;
                txtdiameter.Text = product.ProductDiameter.ToString();
                txtthickness.Text = product.ProductThickness.ToString();
                txtwarrantyperiod.Text = product.ProductWarrantyPeriod;
                txtglass.Text = product.ProductGlass;
                txtcolor.Text = product.ProductColor;
                txtstrap.Text = product.ProductStrap;
            }
        }

        private void HienThiDrop()
        {
            // Hiển thị danh sách thương hiệu
            ddbrand.DataSource = data1.dsBrand();
            ddbrand.DataTextField = "BrandName";
            ddbrand.DataValueField = "BrandId";
            ddbrand.DataBind();

            // Hiển thị danh sách giới tính
            ddgender.DataSource = customer.dsGender();
            ddgender.DataTextField = "GenderName";
            ddgender.DataValueField = "GenderId";
            ddgender.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["productId"] != null)
                {
                    int productId = Convert.ToInt32(Request.QueryString["productId"]);
                    string productName = txtproductname.Text.Trim();
                    string productDescription = txtdes.Text.Trim();
                    decimal productPrice = decimal.Parse(txtprice.Text.Trim());
                    int productQuantity = int.Parse(txtquantity.Text.Trim());
                    string productOrigin = txtorigin.Text.Trim();
                    decimal productDiameter = decimal.Parse(txtdiameter.Text.Trim());
                    decimal productThickness = decimal.Parse(txtthickness.Text.Trim());
                    string productWarrantyPeriod = txtwarrantyperiod.Text.Trim();
                    string productGlass = txtglass.Text.Trim();
                    int genderId = int.Parse(ddgender.SelectedValue);
                    int brandId = int.Parse(ddbrand.SelectedValue);
                    string productColor = txtcolor.Text.Trim();
                    string productStrap = txtstrap.Text.Trim();

                    // Handle file upload for product image
                    string productImage = dataProduct.SaveAvatar(fuAvatar, HttpContext.Current);

                    Product updatedProduct = new Product
                    {
                        ProductId = productId,
                        ProductName = productName,
                        ProductDescription = productDescription,
                        ProductPrice = productPrice,
                        ProductQuantity = productQuantity,
                        ProductOrigin = productOrigin,
                        ProductDiameter = productDiameter,
                        ProductThickness = productThickness,
                        ProductWarrantyPeriod = productWarrantyPeriod,
                        ProductImage = productImage,
                        GenderId = genderId,
                        ProductGlass = productGlass,
                        BrandId = brandId,
                        ProductColor = productColor,
                        ProductStrap = productStrap,
                        ProductCreatedDate = DateTime.Now // You may choose not to update the creation date
                    };

                    bool isUpdated = dataProduct.UpdateProduct(updatedProduct);

                    if (isUpdated)
                    {
                        // Display success message
                        Response.Redirect("ManageProduct.aspx");
                        Response.Write("<script>alert('Product updated successfully.');</script>");
                    }
                    else
                    {
                        // Display failure message
                        Response.Write("<script>alert('Failed to update product.');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }
    }
}