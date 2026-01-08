<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="view_ordered_lap.aspx.cs" Inherits="LSS.view_ordered_lap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="w-100">
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="152px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img1"),0,((byte[])Eval("img1")).Length) %>' Width="170px" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="BRAND"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("brand") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="MODEL NAME"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("modelname") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="MODEL NO"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("modelno") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="QUANTITY"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="TOTAL PRICE"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text='<%# Eval("totalprice") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 27px">
                            <asp:Label ID="Label6" runat="server" Text="STATUS"></asp:Label>
                        </td>
                        <td style="height: 27px"></td>
                        <td style="height: 27px">
                            <asp:Label ID="Label13" runat="server" Text='<%# Eval("bkstatus") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="BOOKING DATE"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text='<%# Eval("bkdate") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

    </div>
</asp:Content>
