<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="view_fulldetail1.aspx.cs" Inherits="LSS.view_fulldetail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Image ID="Image1" runat="server" height="250px" width="250px"/>

    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Label">Name</asp:Label>
    &nbsp;
    <asp:TextBox ID="name" runat="server" ReadOnly="True"></asp:TextBox>

    <br />

    <asp:Label ID="Label2" runat="server" Text="Label">Price</asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="price" runat="server" ReadOnly="True"></asp:TextBox>

    <br />

    <asp:Label ID="Label3" runat="server" Text="Label">Quantity</asp:Label>
    <asp:TextBox ID="quantity" runat="server"></asp:TextBox>

    &nbsp;
    <asp:Button ID="calc" runat="server" OnClick="calc_Click" Text="Check Price" CssClass="btn btn-secondary" />
    <br />

    <asp:Label ID="Label4" runat="server" Text="Label">Total Price</asp:Label>
    <asp:TextBox ID="tot_amt" runat="server" ReadOnly="True"></asp:TextBox>
           
    <br />
    <br />
           
    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-success" CommandArgument='<%# Eval("lapid") %>' OnClick="LinkButton2_Click" >BUY NOW</asp:LinkButton>
&nbsp;
    <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary" CommandArgument='<%# Eval("lapid") %>' runat="server" OnClick="LinkButton1_Click">ADD TO CART</asp:LinkButton>
</asp:Content>
