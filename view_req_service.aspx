<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="view_req_service.aspx.cs" Inherits="LSS.view_req_service" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" HorizontalAlign="Center" RepeatDirection="Horizontal">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <ItemTemplate>
                <table class="w-100">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="CID"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("cid") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="CUSTOMER REASON"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("customer_reason") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="C_DATE"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text='<%# Eval("c_date") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 27px">
                            <asp:Label ID="Label4" runat="server" Text="STATUS"></asp:Label>
                        </td>
                        <td style="height: 27px"></td>
                        <td style="height: 27px">
                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("status") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="LAPTOP MODEL"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text='<%# Eval("lap_model") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="LAPTOP MODEL NAME"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label13" runat="server" Text='<%# Eval("lap_modelname") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="SERIAL NUMBER"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text='<%# Eval("serialno") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-success" CommandArgument='<%# Eval("sid") %>' OnClick="LinkButton1_Click">ACCEPT</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-danger" CommandArgument='<%# Eval("sid") %>' OnClick="LinkButton2_Click">REMOVE</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>
    </div>
</asp:Content>
