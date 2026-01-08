<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="viewcart.aspx.cs" Inherits="LSS.viewcart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <asp:DataList ID="DataList1" runat="server" CellPadding="4" CellSpacing="2">
             <ItemTemplate>
                 <table class="w-100">
                     <tr>
                         <td>
                             <asp:Image ID="Image1" runat="server" Height="169px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img1"),0,((byte[])Eval("img1")).Length) %>' Width="199px" />
                         </td>
                         <td>&nbsp;</td>
                         <td>
                             <asp:Label ID="Label1" runat="server" Text='<%# Eval("modelname") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="Label4" runat="server" Text="Model Number"></asp:Label>
                         </td>
                         <td>&nbsp;</td>
                         <td>
                             <asp:Label ID="Label2" runat="server" Text='<%# Eval("modelno") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
                         </td>
                         <td>&nbsp;</td>
                         <td>
                             <asp:Label ID="Label3" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>QUANTITY</td>
                         <td>&nbsp;</td>
                         <td>
                             <asp:Label ID="Label9" runat="server" Text='<%# Eval("qty") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>
                             <asp:Label ID="Label8" runat="server" Text="Total price"></asp:Label>
                         </td>
                         <td>&nbsp;</td>
                         <td>
                             <asp:Label ID="Label10" runat="server" Text='<%# Eval("totalprice") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td>&nbsp;</td>
                         <td>
                             <asp:LinkButton ID="LinkButton1" CssClass="btn btn-danger" runat="server" CommandArgument='<%# Eval("bid") %>' OnClick="LinkButton1_Click">REMOVE</asp:LinkButton>
                         </td>
                         <td>&nbsp;</td>
                     </tr>
                 </table>
             </ItemTemplate>
         </asp:DataList>
    </div>
    <div>

        <asp:Label ID="Label6" runat="server" Text="TOTAL PAYMENT:"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </div>
   
    <div>
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btn_buy" CssClass="btn btn-success" runat="server" Text="PROCEED TO PAY" OnClick="btn_buy_Click" />
   </div>
        </asp:Content>
