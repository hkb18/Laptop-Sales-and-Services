<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LSS.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!DOCTYPE html>


<head >
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>

     

</head>
<body>
    
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>USERNAME</td>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" class="text-danger" ErrorMessage="Username required!!" ControlToValidate="txtusername"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>PASSWORD</td>
                    <td>
                        <asp:TextBox ID="txtpasswd" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" CssClass="text-danger" runat="server" ErrorMessage="Password required!!" ControlToValidate="txtpasswd"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_login" runat="server" Text="LOGIN" class="btn btn-success" OnClick="btn_login_Click" CommandArgument='<%# Eval("cid") %>' />
                         <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/customer_reg.aspx">REGISTRATION</asp:LinkButton>
                    </td>
                </tr>
                
                 <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                         <asp:Label ID="lblerror" runat="server" class="text-danger"></asp:Label>
                    </td>
                </tr>

                  
                <tr>
                    <td>&nbsp;</td>
                    <td>
                          <asp:CheckBox ID="CheckBox1" runat="server" />
                        <asp:Label ID="Label3" runat="server" class="control-label" Text="Remeber me?"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                                   

            </table>
        </div>

</body>
</html>
</asp:Content>
