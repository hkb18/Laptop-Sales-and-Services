<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="cus_service_viewnpay.aspx.cs" Inherits="LSS.cus_service_viewnpay" %>
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
                            <asp:Image ID="Image1" runat="server" Height="111px" Width="153px" />
                        </td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="CUSTOMER REASON"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="C_DATE"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="LAPTOP MODEL"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="LAPTOP MODEL NAME"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="SERIAL NUMBER"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-success" runat="server">PAY</asp:LinkButton>
                        </td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" CssClass="btn btn-danger" runat="server">CANCEL</asp:LinkButton>
                        </td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td style="width: 6px">&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

    </div>
</asp:Content>
