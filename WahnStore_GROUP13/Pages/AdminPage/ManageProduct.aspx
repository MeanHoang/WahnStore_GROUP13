<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="WahnStore_GROUP13.Pages.AdminPage.ManageProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <h2>Danh sách sản phẩm</h2>
            <asp:GridView runat="server" ID="tlbProduct" DataKeyNames="ProductId" AutoGenerateColumns="false" OnRowUpdating="tlbProduct_RowUpdating" OnRowDeleting="tlbProduct_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="Hình ảnh">
                        <ItemTemplate>
                            <img src='<%# "/ProductImg/" + Eval("ProductImage") %>' alt='<%# Eval("ProductName") %>' width="100" height="100" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField  DataField="ProductId" HeaderText="Mã sản phẩm" />
                    <asp:BoundField DataField="ProductName" HeaderText="Tên sản phẩm" />
                    <asp:BoundField DataField="ProductPrice" HeaderText="Gía tiền" />
                    <asp:BoundField DataField="ProductQuantity" HeaderText="Số lượng còn lại" />
                    <asp:BoundField DataField="ProductOrigin" HeaderText="Xuất xứ" />
                    <asp:BoundField DataField="ProductDiameter" HeaderText="Đường kính mặt số" />
                    <asp:BoundField DataField="ProductThickness" HeaderText="Bề dày mặt số" />
                    <asp:BoundField DataField="ProductWarrantyPeriod" HeaderText="Thời gian bảo hiểm" />
                    <asp:BoundField DataField="GenderId" HeaderText="Giới tính" />
                    <asp:BoundField DataField="ProductGlass" HeaderText="Loại kính" />
                    <asp:BoundField DataField="BrandId" HeaderText="Tên hãng" />
                    <asp:BoundField DataField="ProductColor" HeaderText="Màu mặt số" />
                    <asp:BoundField DataField="ProductStrap" HeaderText="Chất liệu dây" />
                    <asp:BoundField DataField="ProductCreatedDate" HeaderText="Ngày tạo sản phẩm" />
                    <asp:ButtonField CommandName="Delete" Text="Delete" />
                    <asp:ButtonField CommandName="Update" Text="Update" />
                </Columns>
            </asp:GridView>
            <asp:LinkButton ID="lbAddProduct" runat="server" Text="Add Product" PostBackUrl="~/Pages/AdminPage/AddProduct.aspx"></asp:LinkButton>

</asp:Content>
