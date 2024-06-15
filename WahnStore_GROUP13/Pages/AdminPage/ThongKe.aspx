<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="ThongKe.aspx.cs" Inherits="WahnStore_GROUP13.ThongKe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container-fluid{
            width:95%;
            padding-left:40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <h1 class="mt-4">Tổng quan</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3 mb-4">
                    <div class="card bg-warning text-white">
                        <div class="card-body">
                            <h3>363</h3>
                            <p>Sản phẩm</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="card bg-success text-white">
                        <div class="card-body">
                            <h3>12</h3>
                            <p>Đơn hàng đã giao</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="card bg-info text-white">
                        <div class="card-body">
                            <h3>5</h3>
                            <p>Đơn hàng chờ xử lý</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 mb-4">
                    <div class="card bg-success text-white">
                        <div class="card-body">
                            <h3>10</h3>
                            <p>Thống kế doanh thu</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card bg-primary text-white">
                        <div class="card-body">
                            <h3>Top 6</h3>
                            <p>Sản phẩm bán chạy</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/Manage_Product/SanPhamBanChay.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card bg-info text-white">
                        <div class="card-body">
                            <h3>Top 6</h3>
                            <p>Sản phẩm không bán được</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/Manage_Product/SanPhamBanChay.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card bg-success text-white">
                        <div class="card-body">
                            <h3>5</h3>
                            <p>Export thống kê ra excel</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
                <div class="col-md-3">
                    <div class="card bg-primary text-white">
                        <div class="card-body">
                            <h3>10</h3>
                            <p>Sản phẩm hót nhất</p>
                        </div>
                        <div class="card-footer text-center">
                            <asp:LinkButton runat="server" PostBackUrl="~/Pages/AdminPage/ProductController.aspx" class="text-white">Chi tiết</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>

</asp:Content>
