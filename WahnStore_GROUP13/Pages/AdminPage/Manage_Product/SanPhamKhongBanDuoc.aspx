<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="SanPhamKhongBanDuoc.aspx.cs" Inherits="WahnStore_GROUP13.SanPhamKhongBanDuoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .product-card {
            margin-bottom: 20px;
        }
        .product-card .card-img-top {
            height: 200px;
            object-fit: cover;
        }
         #scrolling-title {
            white-space: nowrap;
            overflow: hidden;
            display: inline-block;
            animation: scroll 5s linear infinite;
            font-size: 2rem;
            font-weight: bold;
            color:red;
        }

        @keyframes scroll {
            0% {
                transform: translateX(100%);
            }
            100% {
                transform: translateX(-100%);
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
             <h1 id="scrolling-title" class="mb-4">Top 6 sản phẩm không bán được</h1>
            <div class="row">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class='col-lg-4 col-md-6'>
                            <div class='card product-card'>
                                <img src='<%# "/ProductImg/" + Eval("ProductImage") %>' class='card-img-top' alt='Product Image' />
           
                                <div class='card-body'>
                                    <h5 class='card-title'><%# Eval("ProductName") %></h5>
                                    <p class='card-text'><%# Eval("ProductDescription") %></p>
                                    <asp:Button ID="xemChiTiet" Text="Xem chi tiết" class='btn btn-primary' runat="server" CommandName ="xemChiTietSanPham" OnCommand="xemChiTiet_Click" CommandArgument='<%# Bind("ProductId") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</asp:Content>

