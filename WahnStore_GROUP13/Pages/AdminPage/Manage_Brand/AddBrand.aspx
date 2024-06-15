<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="AddBrand.aspx.cs" Inherits="WahnStore_GROUP13.AddBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Thêm mới thương hiệu</h1>

    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Thông tin thương hiệu</h3>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="txtTenThuongHieu">Tên thương hiệu</label>
                <asp:TextBox ID="txtTenThuongHieu" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtMoTa">Mô tả</label>
                <asp:TextBox ID="txtMoTa" CssClass="form-control" runat="server"></asp:TextBox>
            </div>        
        </div>
        <asp:Button runat="server" ID="btnThemMoi" Text="Thêm thương hiệu mới" OnClick="btnThemMoi_Click" />       
    </div>
</asp:Content>
