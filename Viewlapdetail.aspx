<%@ Page Title="" Language="C#" MasterPageFile="~/usr.Master" AutoEventWireup="true" CodeBehind="Viewlapdetail.aspx.cs" Inherits="LSS.Viewlapdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


     <div>
                  
                
  
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
              
                             <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
         
             <div class="container text-center">
  <div class="row">
    <div class="col">
          
                            <td>
                            <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="0px" CellPadding="3" CellSpacing="1" HorizontalAlign="Center">
                                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                                <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                                <ItemTemplate>
                                    <table class="w-100">
                                        <tr>
                                            
                                            <td style="width: 135px">
                                                &nbsp;</td>
                                      <td><span>
                                          <asp:Image ID="Image9" runat="server" class="rounded mx-auto d-block" Height="136px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img1"),0,((byte[])Eval("img1")).Length) %>' Width="224px" />
                                          </span></td>
                                        
                                            <td>
                                                &nbsp;</td>
                                           
                                        </tr>
                                        <tr>
                                            <td style="width: 135px">
                                                <asp:Label ID="Label2" runat="server" Text="BRAND"></asp:Label>
                                            </td>
                                             <td>&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("brand") %>'></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 135px; height: 27px">
                                                <asp:Label ID="Label4" runat="server" Text="MODEL NAME"></asp:Label>
                                            </td>
                                             <td style="height: 27px"></td>
                                            <td style="height: 27px">
                                                <asp:Label ID="Label5" runat="server" Text='<%# Eval("modelname") %>'></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 135px">
                                                <asp:Label ID="Label6" runat="server" Text="MODEL NO"></asp:Label>
                                            </td>
                                             <td>&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label7" runat="server" Text='<%# Eval("modelno") %>'></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 135px">
                                                <asp:Label ID="Label8" runat="server" Text="PRICE"></asp:Label>
                                            </td>
                                             <td>&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label9" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 135px">
                                                <asp:Label ID="Label10" runat="server" Text="CATEGORY"></asp:Label>
                                            </td>
                                             <td>&nbsp;</td>
                                            <td>
                                                <asp:Label ID="Label11" runat="server" Text='<%# Eval("cat_type") %>'></asp:Label>
                                            </td>
                                        </tr>
                                         <tr>
                                            <td style="width: 135px">
                                               <div class="text-center">
                                                </div>
                                               </div>
                                            </td>
                                             <td><span>
                                                 <asp:LinkButton ID="LinkButton1" runat="server" class="btn btn-primary" CommandArgument='<%# Eval("lapid") %>'  OnClick="LinkButton1_Click">VIEW</asp:LinkButton>
                                                 </span></td>
                                            <td>
                                               
                                            </td>
                                        </tr>
                                        
                                    </table></div></div>
                                    <asp:MultiView ID="MultiView1" runat="server"></asp:MultiView>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        
                                </ItemTemplate> 
                                <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            </asp:DataList>

                                </td>
                 </div>
           
      


            <%--</asp:Panel>--%>
         </div>
</asp:Content>
