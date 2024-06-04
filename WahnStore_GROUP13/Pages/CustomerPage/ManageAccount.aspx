<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/CustomerPage/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="ManageAccount.aspx.cs" Inherits="WahnStore_GROUP13.Pages.CustomerPage.YourAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Manage Your Account</h1>
<div>
    <!-- Hiển thị ảnh khách hàng -->
    <asp:Image ID="imgAvatar" runat="server" Width="150px" Height="150px" />
</div>
<div>
    <label>Fullname:</label>
    <asp:Label ID="lblFullname" runat="server" Text=""></asp:Label>
</div>

<div>
    <label>Email:</label>
    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
</div>

<div>
    <label>Phone:</label>
    <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label>
</div>

 <div>
    <label>Username:</label>
    <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
</div>


<div>
    <label>Address:</label>
    <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>
</div>

<div>
    <label>Gender:</label>
    <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
</div>
</asp:Content>
