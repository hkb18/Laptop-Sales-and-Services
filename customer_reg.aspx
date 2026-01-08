<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="customer_reg.aspx.cs" Inherits="LSS.customer_reg" %>
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
                    <td>NAME</td>    
                    <td>
                        <asp:TextBox ID="txtname"  runat="server" class="form-label" placeholder=" NAME"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>ADDRESSS</td>
                    <td>
                        <asp:TextBox ID="txtaddr" runat="server" TextMode="MultiLine" class="form-label" placeholder=" ADDRESS" Height="57px" Width="288px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>PHONE NUMBER</td>
                    <td>
                        <asp:TextBox ID="txtphno" runat="server" class="form-label" placeholder=" PHONE NUMBER"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>USERNAME</td>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server" class="form-label" placeholder=" USERNAME"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>PASSWORD</td>
                    <td>
                        <asp:TextBox ID="txtpasswd" runat="server" TextMode="Password" class="form-label" placeholder=" PASSWORD"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>CONFIRM PASSWORD</td>
                    <td>
                        <asp:TextBox ID="txtconfirmpasswd" runat="server" TextMode="Password" class="form-label" placeholder="CONFIRM PASSWORD"></asp:TextBox>
                    </td>
                </tr>
              
                
                 <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="registeration" runat="server" Text="REGISTER" class="btn btn-info" OnClick="registeration_Click" />
                        <asp:Label ID="lblmsg" runat="server"></asp:Label>
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
