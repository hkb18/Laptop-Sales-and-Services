<%@ Page Title="" Language="C#" MasterPageFile="~/headerdesign.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="LSS.category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div id="page-wrapper">

        <div class="row">
            <!-- Page Header -->
            <div class="col-lg-12">
                <center>
                    <h1 class="page-header">LAP CATEGORY </h1>
                </center>
            </div>
        </div>

    <div>
            <table class="auto-style1">
                <tr>
                    <td style="height: 20px">CATEGORY NAME</td>
                    <td style="height: 20px">
                        <asp:TextBox ID="txtcategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                

                 <tr>
                    <td style="height: 42px"></td>
                    <td style="height: 42px">
                        
                        <asp:Button ID="category_btn" runat="server" Text="SUBMIT" OnClick="category_btn_Click"  />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </div>

</asp:Content>

