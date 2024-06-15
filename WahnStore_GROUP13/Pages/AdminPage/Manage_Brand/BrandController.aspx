<%@ Page Title="" Language="C#" MasterPageFile="~/Layout_Admin.Master" AutoEventWireup="true" CodeBehind="BrandController.aspx.cs" Inherits="WahnStore_GROUP13.BrandController" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnThemMoi {
            padding: 5px 25px;
            margin-bottom: 15px;
            background-color: green;
            color: white;
        }

        .btn-edit {
            background-color: dodgerblue;
            color: white;
            margin-bottom: 10px;
        }

        .btn-delete {
            background-color: red;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Quản lý thương hiệu</h1>
        <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" CssClass="btnThemMoi" PostBackUrl="~/Pages/AdminPage/Manage_Brand/AddBrand.aspx" />
        <asp:GridView runat="server" ID="tlbBrand"  AutoGenerateColumns="false" CssClass="table" >
            <Columns>
                <asp:BoundField DataField="BrandId" HeaderText="Mã thương hiệu" />
                <asp:BoundField DataField="BrandName" HeaderText="Tên thương hiệu" />
                <asp:BoundField DataField="BrandDescription" HeaderText="Mô tả" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" CssClass="btn btn-edit" OnCommand="btnCapNhat_Click" CommandName="capNhat" CommandArgument='<%# Bind("BrandId") %>' />
                        <asp:Button ID="btnXoa" runat="server" Text="Xóa" CssClass="btn btn-delete" OnCommand="btnXoa_Click" CommandName="xoa" CommandArgument='<%# Bind("BrandId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
