<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/CustomerPage/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="WahnStore_GROUP13.Pages.CustomerPage.ProductDeatails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Chi tiết sản phẩm</title>
            <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 1200px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }

        .product-details {
            display: flex;
            flex-wrap: wrap;
        }

        .product-details img {
            max-width: 100%;
            border-radius: 8px;
        }

        .product-image {
            flex: 1;
            min-width: 300px;
            padding: 20px;
        }

        .product-info {
            flex: 2;
            padding: 20px;
        }

        .product-info h1 {
            margin-top: 0;
            color: #333;
        }

        .product-info p {
            margin: 10px 0;
            color: #666;
        }

        .product-info .price {
            font-size: 24px;
            color: #e67e22;
            margin: 20px 0;
        }

        .product-info .details {
            list-style: none;
            padding: 0;
        }

        .product-info .details li {
            margin: 10px 0;
            color: #666;
        }

        .add-to-cart-btn {
            display: inline-block;
            padding: 10px 20px;
            background-color: #e67e22;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            margin-top: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Thông tin chi tiết sản phẩm</h1>
<div class="container">
<div class="product-details">
    <div class="product-image">
        <img id="ProductImage" runat="server" alt="Product Image" />
    </div>
    <div class="product-info">
        <h1><asp:Label ID="ProductName" runat="server" Text=""></asp:Label></h1>
        <p><asp:Label ID="ProductDescription" runat="server" Text=""></asp:Label></p>
        <p class="price"><asp:Label ID="ProductPrice" runat="server" Text=""></asp:Label></p>
        <ul class="details">
            <li><asp:Label ID="ProductQuantity" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductOrigin" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductDiameter" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductThickness" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductWarrantyPeriod" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductGender" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductBrand" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductGlass" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductColor" runat="server" Text=""></asp:Label></li>
            <li><asp:Label ID="ProductStrap" runat="server" Text=""></asp:Label></li>
        </ul>
        <asp:HiddenField ID="ProductIdHidden" runat="server" />
        <asp:Button ID="AddToCartButton" runat="server" Text="Thêm vào giỏ hàng" CssClass="add-to-cart-btn" OnClick="AddToCartButton_Click" />
    </div>
    </div>
    </div>
</asp:Content>
