using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WahnStore_GROUP13.Classes;

namespace WahnStore_GROUP13.Pages.CustomerPage
{
    public partial class Shop : System.Web.UI.Page
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
            List<Product> products = data.dsProduct();
            ListView1.DataSource = products;
            ListView1.DataBind();
        }
    }
}