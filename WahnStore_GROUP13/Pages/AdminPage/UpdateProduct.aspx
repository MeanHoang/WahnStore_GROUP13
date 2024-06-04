<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/AdminPage/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="WahnStore_GROUP13.Pages.AdminPage.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Cập nhập sản phẩm</h2>        
    <asp:Table ID="updatePro" runat="server">
                <asp:TableRow>
                    <asp:TableCell>Tên sản phẩm</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtproductname" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Mô tả:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtdes" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Giá</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Số lượng còn lại</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtquantity" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Xuất xứ</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtorigin" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Đường kính mặt số</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtdiameter" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Bề dày mặt số</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtthickness" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Thời gian bảo hành</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtwarrantyperiod" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Ảnh</asp:TableCell>
                    <asp:TableCell>
                        <asp:FileUpload ID="fuAvatar" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Giới tính</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddgender" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Loại kính</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtglass" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Thương hiệu</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddbrand" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Màu mặt số</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtcolor" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>Chất liệu dây</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtstrap" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Button ID ="btnUpdate" runat="server" Text="Cập nhật sản phẩm" OnClick="btnUpdate_Click" /> 
        </div>

</asp:Content>
