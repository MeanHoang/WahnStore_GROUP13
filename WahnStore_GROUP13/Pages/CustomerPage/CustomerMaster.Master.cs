using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WahnStore_GROUP13.Pages.CustomerPage
{
    public partial class CustomerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Kiểm tra xem có Session["Username"] không
                if (Session["Username"] != null)
                {
                    // Người dùng đã đăng nhập, hiển thị nút link đến trang quản lý tài khoản
                    hypManageAccount.Visible = true;
                    hypManageCart.Visible = true;
                    btnLogout.Visible = true;
                }
                else
                {
                    // Người dùng chưa đăng nhập, hiển thị nút link đến trang đăng nhập và đăng ký
                    hypLogin.Visible = true;
                    hypRegister.Visible = true;
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Xóa Session["Username"]
            Session["Username"] = null;

            // Chuyển hướng đến trang chủ hoặc trang đăng nhập
            Response.Redirect("~/Pages/CustomerPage/Home.aspx");
        }
    }
}