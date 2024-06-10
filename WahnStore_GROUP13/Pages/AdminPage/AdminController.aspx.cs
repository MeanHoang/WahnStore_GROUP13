﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13
{
    public partial class AdminController : System.Web.UI.Page
    {
        DataProduct data = new DataProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThi();
            }
        }
        public void HienThi()
        {
            dsSanPham.DataSource = data.dsProduct();
            dsSanPham.DataBind();
        }

        protected void dsSanPham_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Lấy giá trị brand_id từ dòng dữ liệu hiện tại
                int brandId = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "BrandId"));

                // Gọi phương thức selectBrand để lấy brand_name
                string brandName = data.selectBrandName(brandId);

                // Tìm điều khiển Label trong TemplateField và thiết lập text cho nó
                Label lblTenHang = (Label)e.Row.FindControl("lblTenHang");
                if (lblTenHang != null)
                {
                    lblTenHang.Text = brandName;
                }
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Lấy giá trị gender_id từ dòng dữ liệu hiện tại
                int gender_id = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "GenderId"));

                // Gọi phương thức selectBrand để lấy brand_name
                string genderName = data.selectGenderName(gender_id);

                // Tìm điều khiển Label trong TemplateField và thiết lập text cho nó
                Label lblGioiTinh = (Label)e.Row.FindControl("lblGioiTinh");
                if (lblGioiTinh != null)
                {
                    lblGioiTinh.Text = genderName;
                }
            }
        }

        protected void btnXoa_Click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "xoaSanPham")
            {
                int productId = Convert.ToInt16(e.CommandArgument);
                data.DeleteProduct(productId);
                HienThi();
            }
            
        }
        protected void btnCapNhat_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "capNhat")
            {
                int productId = Convert.ToInt16(e.CommandArgument);
                Product product =  data.GetProductById(productId);
                Session["product"] =product;
                Response.Redirect("~/Manage_Product/CapNhatProduct.aspx");
                HienThi();
            }

        }

    }
}