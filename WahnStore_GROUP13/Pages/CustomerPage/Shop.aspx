<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/CustomerPage/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WahnStore_GROUP13.Pages.CustomerPage.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Cửa hàng</title>
         <style>
        .product-item {
            float: left;
            width: 200px;
            margin: 10px;
            padding: 10px;
            border: 1px solid #ccc;
            text-align: center;
        }
        .product-item img {
            width: 150px;
            height: 150px;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

             <div>
     <h1>Cửa hàng</h1>
     <asp:ListView ID="ListView1" runat="server">
         <ItemTemplate>
             <div class="product-item">
                 <a href='<%# "ProductDetails.aspx?productId=" + Eval("ProductId") %>'>
                     <img src='<%# "/ProductImg/" + Eval("ProductImage") %>' alt='<%# Eval("ProductName") %>' />
                 </a>
                 <br />
                 <a href='<%# "ProductDetails.aspx?productId=" + Eval("ProductId") %>'>
                     <asp:Label runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                 </a>
                 <br />
                 <asp:Label runat="server" Text='<%# string.Format("{0:N0} VND", Eval("ProductPrice")) %>'></asp:Label>
             </div>
         </ItemTemplate>
     </asp:ListView>
 </div>

</asp:Content>
