<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="CapNhatProduct.aspx.cs" Inherits="WahnStore_GROUP13.CapNhatProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Cập nhật sản phẩm</h1>

    <div class="panel panel-default">
        <div class="panel-heading">
            <h3 class="panel-title">Thông tin sản phẩm</h3>
        </div>
        <div class="panel-body">
            <div class="form-group">
                <label for="txtMaSanPham">Mã sản phẩm</label>
                <asp:TextBox ID="txtMaSanPham" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtTenSanPham">Tên sản phẩm </label>
                <asp:TextBox ID="txtTenSanPham" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <div>
                    <div>
                        <asp:Image runat="server" ID="image" Width="100" Height="100" />
                    </div>
                </div>
                <div class="input-group">
                    <asp:FileUpload ID="fileHinhAnh" runat="server" />
                </div>
            </div>
            <div class="form-group">
                <label for="txtMoTa">Mô tả</label>
                <asp:TextBox ID="txtMoTa" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtGiaTien">Giá tiền</label>
                <asp:TextBox ID="txtGiaTien" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtSoLuong">Số lượng</label>
                <asp:TextBox ID="txtSoLuong" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtXuatXu">Xuất xứ</label>
                <asp:TextBox ID="txtXuatXu" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDuongKinh">Đường kính mặt số</label>
                <asp:TextBox ID="txtDuongKinh" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtBeDayMatSo">Bề dày mặt số</label>
                <asp:TextBox ID="txtBeDayMatSo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtBaoHiem">Thời gian bảo hiểm</label>
                <asp:TextBox ID="txtBaoHiem" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ddlGioiTinh">Giới tính</label>
                <asp:DropDownList ID="ddlGioiTinh" CssClass="form-control" runat="server">
                    <asp:ListItem Text="---Chọn giới tính---" Value=""></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="ddlThuongHieu">Thương hiệu</label>
                <asp:DropDownList ID="ddlThuongHieu" CssClass="form-control" runat="server">
                    <asp:ListItem Text="---Chọn thương hiệu---" Value=""></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="txtLoaiKinh">Loại kính</label>
                <asp:TextBox ID="txtLoaiKinh" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtMauMatSo">Màu mặt số</label>
                <asp:TextBox ID="txtMauMatSo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtChatLieuDay">Chất liệu dây</label>
                <asp:TextBox ID="txtChatLieuDay" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

        </div>
        <asp:Button runat="server" ID="btnCapNhat" Text="Cập nhật" OnClick="btnCapNhat_Click" />

    </div>
</asp:Content>
