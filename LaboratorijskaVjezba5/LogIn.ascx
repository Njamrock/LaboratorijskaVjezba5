﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LogIn.ascx.cs" Inherits="LaboratorijskaVjezba5.LogIn" %>
<asp:Panel ID="PanelLogIn" runat="server">
    <h1>Welcome!</h1>
    <h2>Please, enter Your username and password to login.</h2>
    <asp:Label ID="Label1" runat="server" Text="Username:" BorderStyle="None"></asp:Label>
    <asp:TextBox ID="Username" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" BorderStyle="None" Text="Password:"></asp:Label>
    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
</asp:Panel>
<asp:Panel ID="PanelError" runat="server" Visible="False">
    <h3>Username or password not valid.</h3>
</asp:Panel>
<asp:Panel ID="PanelDisplay" runat="server" Visible="False">
    <asp:GridView ID="GridViewData" runat="server">
    </asp:GridView>
</asp:Panel>
