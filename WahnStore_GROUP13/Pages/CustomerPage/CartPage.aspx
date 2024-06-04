<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/CustomerPage/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="WahnStore_GROUP13.Pages.CustomerPage.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>Giỏ hàng của bạn</title>
    <style>
        /* CSS cho trang giỏ hàng */
        /* Định dạng cho các dòng trong bảng */
        .cart-table tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        /* Định dạng cho tiêu đề bảng */
        .cart-table th {
            background-color: #4CAF50;
            color: white;
            padding: 8px;
        }

        /* Định dạng cho ô trong bảng */
        .cart-table td {
            padding: 8px;
        }

        /* Định dạng cho nút */
        .checkout-btn {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
        }

        /* Định dạng cho nút khi rê chuột qua */
        .checkout-btn:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Giỏ hàng của bạn</h1>
    <div>
        <h1>Cart Items</h1>
<asp:GridView ID="CartGridView" runat="server" AutoGenerateColumns="False" 
    OnRowDeleting="CartGridView_RowDeleting" OnRowCommand="CartGridView_RowCommand" DataKeyNames="CartItemId">            
    <Columns>         
                <asp:BoundField DataField="CartItemId" HeaderText="CartItem ID" />
                <asp:BoundField DataField="ProductId" HeaderText="Product ID" />
                <asp:TemplateField HeaderText="Giảm">
                    <ItemTemplate>
                        <asp:Button ID="DecreaseButton" runat="server" Text="-" CommandName="Decrease" CommandArgument='<%# Eval("CartItemId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:TemplateField HeaderText="Tăng">
                    <ItemTemplate>
                        <asp:Button ID="IncreaseButton" runat="server" Text="+" CommandName="Increase" CommandArgument='<%# Eval("CartItemId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Price" HeaderText="Đơn giá" />
                <asp:TemplateField HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("CartItemId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
