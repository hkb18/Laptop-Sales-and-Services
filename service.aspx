<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="service.aspx.cs" Inherits="LSS.service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>




    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>





    <div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>LAPTOP MODEL NUMBER</td>
                <td>
                    <asp:TextBox ID="txtmodel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>LAPTOP MODEL NAME</td>
                <td>
                    <asp:TextBox ID="txtmodelname" runat="server"> </asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>LAPTOP SERIAL NUMBER</td>
                <td>
                    <asp:TextBox ID="txtserialno" runat="server"> </asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>REASON</td>
                <td>
                    <asp:TextBox ID="txtreason" runat="server" TextMode="MultiLine" Height="65px" Width="299px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="c_service" CssClass="btn btn-success" runat="server" Text="SUBMIT" OnClick="c_service_Click" />
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>






</asp:Content>
