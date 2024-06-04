using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13.Pages.AdminPage
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        DataProduct data = new DataProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HienThi();
            }
        }

        private void HienThi()
        {
            tlbProduct.DataSource = data.dsProduct();
            DataBind();
        }

        protected void tlbProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(tlbProduct.DataKeys[e.RowIndex].Values["ProductId"]);
            if (data.DeleteProduct(productId))
            {
                // Reload gridview after successful deletion
                HienThi();
            }
            else
            {
                // Handle deletion failure
                // For example, display an error message
                // Response.Write("Delete failed");
            }
        }


        protected void tlbProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int productId = Convert.ToInt32(tlbProduct.DataKeys[e.RowIndex].Values["ProductId"]);
            Response.Redirect("~/Pages/AdminPage/UpdateProduct.aspx?ProductId=" + productId);
        }


    }
}