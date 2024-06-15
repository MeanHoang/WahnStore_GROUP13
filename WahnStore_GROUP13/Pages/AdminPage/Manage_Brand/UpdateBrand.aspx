<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="UpdateBrand.aspx.cs" Inherits="WahnStore_GROUP13.UpdateBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Cập nhật thương hiệu</h1>

    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Cập nhật thương hiệu</h3>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="txtMaThuongHieu">Mã thương hiệu</label>
                <asp:TextBox ID="txtMaThuongHieu" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtTenThuongHieu">Tên thương hiệu </label>
                <asp:TextBox ID="txtTenThuongHieu" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtMoTa">Mô tả</label>
                <asp:TextBox ID="txtMoTa" CssClass="form-control" runat="server"></asp:TextBox>
            </div>       
            <asp:Button runat="server" ID="btnCapNhat" Text="Cập nhật" OnClick="btnCapNhat_Click" />
            </div>
    </div>
</asp:Content>

