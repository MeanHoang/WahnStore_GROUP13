<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="AdminController.aspx.cs" Inherits="WahnStore_GROUP13.AdminController" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn {
            padding: 5px 10px;
            margin-bottom: 15px;
            background-color:blue;
            color:white;
        }

        .btn-edit {
            background-color: green;
            color: white;
        }

        .btn-delete {
            background-color: red;
            color: white;
        }

        .btn-detail {
            background-color: blue;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Quản lý sản phẩm</h2>
    <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" CssClass="btn" PostBackUrl="~/Manage_Product/ThemMoiProduct.aspx" />
    <asp:GridView ID="dsSanPham" runat="server" AutoGenerateColumns="false" OnRowDataBound="dsSanPham_RowDataBound" CssClass="table" >
        <Columns>

            <asp:BoundField DataField="ProductId" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="ProductName" HeaderText="Tên sản phẩm" />
            <asp:TemplateField HeaderText="Hình ảnh">
                <ItemTemplate>
                    <img src='<%# "/ProductImg/" + Eval("ProductImage") %>'  width="100" height="100" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductPrice" HeaderText="Giá tiền" />
            <asp:BoundField DataField="ProductQuantity" HeaderText="Số lượng" />
            <asp:BoundField DataField="ProductOrigin" HeaderText="Xuất xứ" />
            <asp:BoundField DataField="ProductDiameter" HeaderText="Đường kính mặt số" />
            <asp:BoundField DataField="ProductThickness" HeaderText="Bề dày mặt số" />
            <%--<asp:BoundField DataField="ProductWarrantyPeriod" HeaderText="Thời gian bảo hiểm" />--%>
            <%--<asp:BoundField DataField="GenderId" HeaderText="Giới tính" />--%>
            <asp:TemplateField HeaderText="Giới tính">
                <ItemTemplate>
                    <asp:Label ID="lblGioiTinh" runat="server" Text='<%# Bind("GenderId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductGlass" HeaderText="Loại kính" />
            <%--<asp:BoundField DataField="BrandId" HeaderText="Tên hãng" />--%>
            <asp:TemplateField HeaderText="Tên hãng">
                <ItemTemplate>
                    <asp:Label ID="lblTenHang" runat="server" Text='<%# Bind("BrandId") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ProductColor" HeaderText="Màu mặt số" />
            <asp:BoundField DataField="ProductStrap" HeaderText="Chất liệu dây" />
            <asp:TemplateField >
                <ItemTemplate>
                    <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" CssClass="btn btn-delete" OnCommand="btnCapNhat_Click" CommandName="capNhat" CommandArgument='<%# Bind("ProductId") %>'  />
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" CssClass="btn btn-delete" OnCommand="btnXoa_Click" CommandName="xoaSanPham" CommandArgument='<%# Bind("ProductId") %>'  />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>