﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13
{
    public partial class SanPhamBanChay : System.Web.UI.Page
    {
        DataProduct dataProduct = new DataProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> Products = dataProduct.selectTop5BestSellingProduct();
                Repeater1.DataSource = Products;
                Repeater1.DataBind();
            }
        }
        protected void xemChiTiet_Click(object sender, CommandEventArgs e)
        {
            
                int product_id = Convert.ToInt32(e.CommandArgument.ToString());
                Product product = dataProduct.GetProductById(product_id);
                Session["product"] = product;
                Response.Redirect(ResolveUrl("~/Pages/AdminPage/Manage_Product/ChiTietSanPham.aspx"));

        }
    }
}