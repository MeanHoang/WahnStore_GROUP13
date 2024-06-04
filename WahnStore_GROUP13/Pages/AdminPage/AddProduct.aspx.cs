using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13.Pages.AdminPage
{
    public partial class AddProduct : System.Web.UI.Page
    {
        DataBrand data1 = new DataBrand();
        DataCustomer data2 = new DataCustomer();
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThiDrop();
        }

        private void HienThiDrop()
        {
            List<Brand> brands = data1.dsBrand();

            ddbrand.DataSource = brands;
            ddbrand.DataTextField = "BrandName";
            ddbrand.DataValueField = "BrandId";
            ddbrand.DataBind();

            List<Gender> gender = data2.dsGender();

            ddgender.DataSource = gender;
            ddgender.DataTextField = "GenderName";
            ddgender.DataValueField = "GenderId";
            ddgender.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
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
                DateTime productCreatedDate = DateTime.Now;

                // Handle file upload for product image
                DataProduct dataProduct = new DataProduct();
                string productImage = dataProduct.SaveAvatar(fuAvatar, HttpContext.Current);

                Product newProduct = new Product
                {
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
                    ProductCreatedDate = productCreatedDate
                };

                bool isAdded = dataProduct.AddProduct(newProduct);

                if (isAdded)
                {
                    // Display success message
                    Response.Write("<script>alert('Product added successfully.');</script>");
                }
                else
                {
                    // Display failure message
                    Response.Write("<script>alert('Failed to add product.');</script>");
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