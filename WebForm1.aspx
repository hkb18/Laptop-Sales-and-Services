<%@ Page Title="" Language="C#" MasterPageFile="~/headerdesign.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LSS.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="page-wrapper">

            <div class="row">
                <!-- Page Header -->
               <div class="col-lg-12">
                <center>
                    <h1 class="page-header">LAP DETAILS </h1>
                </center>
            </div>
        </div>



        <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
        </style>

        <script src="js/jquery-1.11.1.min.js" type="text/javascript"></script>
        <script type="text/javascript">    

            function showimagepreview(input) {
              //  alert("hai");
                if (input.files && input.files[0]) {
                    var filerdr = new FileReader();
                    filerdr.onload = function (e) {
                        $('#ContentPlaceHolder1_Image1').attr('src', e.target.result);
                    }
                    filerdr.readAsDataURL(input.files[0]);
                }
            }

            function showimagepreview2(input) {
                //alert("hai");
                if (input.files && input.files[0]) {
                    var filerdr = new FileReader();
                    filerdr.onload = function (e) {
                        $('#ContentPlaceHolder1_Image2').attr('src', e.target.result);
                    }
                    filerdr.readAsDataURL(input.files[0]);
                }
            }

            function showimagepreview3(input) {
                //  alert("hai");
                if (input.files && input.files[0]) {
                    var filerdr = new FileReader();
                    filerdr.onload = function (e) {
                        $('#ContentPlaceHolder1_Image3').attr('src', e.target.result);
                    }
                    filerdr.readAsDataURL(input.files[0]);
                }
            }

           

        </script>


     

        <div>
            <table class="auto-style1">
                <tr>
                    <td>BRAND NAME</td>
                    <td>
                        <asp:TextBox ID="txtbrand" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>MODEL NAME</td>
                    <td>
                        <asp:TextBox ID="txtmodelname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>MODEL NUMBER</td>
                    <td>
                        <asp:TextBox ID="txtmodelno" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>



                <tr>
                    <td>IMG1</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" onchange="showimagepreview(this)" runat="server" />
                        <asp:Image ID="Image1" class="rounded mx-auto d-block"  runat="server"  Height="91px" Width="188px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>IMG2</td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" onchange="showimagepreview2(this)" runat="server" />
                        <asp:Image ID="Image2" class="rounded mx-auto d-block" runat="server"  Height="91px" Width="188px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                <tr>
                    <td>IMG3</td>
                    <td>
                        <asp:FileUpload ID="FileUpload3" onchange="showimagepreview3(this)" runat="server" />
                        <asp:Image ID="Image3" class="rounded mx-auto d-block" runat="server" Height="91px" Width="188px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

          
              <tr>
                    <td>MODEL YEAR</td>
                    <td>
                        <asp:TextBox ID="txtmodelyr" runat="server"></asp:TextBox>cm
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
                    <td>PROCESSOR BRAND</td>
                    <td>
                        <asp:TextBox ID="txtprobrand" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

               
                <tr>
                    <td>PROCESSOR NAME</td>
                    <td>
                        <asp:TextBox ID="txtproname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>PROCESSOR SPEED </td>
                    <td>
                        <asp:TextBox ID="txtprospeed" runat="server"></asp:TextBox>cm
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

             <tr>
                    <td>RAM TECHNOLOGY</td>
                    <td>
                        <asp:TextBox ID="txtramtech" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>RAM SIZE </td>
                    <td>
                        <asp:TextBox ID="txtramsize" runat="server"></asp:TextBox>GB
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>OS </td>
                    <td>
                        <asp:TextBox ID="txtos" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                 <tr>
                    <td>GRAPHICS CARD</td>
                    <td>
                        <asp:TextBox ID="txtgraphicscard" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>BATTERY</td>
                    <td>
                        <asp:TextBox ID="txtbattery" runat="server"></asp:TextBox>GHz
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td>AVG BATTERY LIFE</td>
                    <td>
                        <asp:TextBox ID="txtbatterylife" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
  
                <tr>
                    <td>PRICE</td>
                    <td>
                        <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                <tr>
                    <td>QUANTITY</td>
                    <td>
                        <asp:TextBox ID="txtqty" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                <tr>
                    <td>CATEGORY</td>
                    <td>
                        <asp:DropDownList ID="DropDowncategory" class="btn btn-secondary dropdown-toggle"  runat="server"></asp:DropDownList>              
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <%-- color,no,of port,connectivity --%>
                <%-- reduce processor brand & type to processor --%>


                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="lapdetail" class="btn btn-info" runat="server" Text="SUBMIT" OnClick="lapdetail_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>


                
                



                <tr>
                    <td>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td>
                        <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Height="300px"
                            Style="text-align: right" Width="1000px">
                            <%-- scrollbar above code --%>
                            <asp:Repeater ID="Repeater1" runat="server" >


                                <HeaderTemplate>
                                    <table border="1" class="table">
                                        <tr>
                                            <th>BRAND</th>
                                            <th>MODEL NAME</th>
                                            <th>MODEL NO</th>
                                            <th>IMG1</th>
                                            <th>IMG2</th>
                                            <th>IMG3</th>
                                            <th>MODEL YEAR</th>
                                            <th>PROCESSOR BRAND</th>
                                            <th>PROCESSOR NAME</th>
                                            <th>PROCESSOR SPEED</th>
                                            <th>RAM TECHNOLOGY</th>
                                            <th>RAM SIZE</th>
                                            <th>OS</th>
                                            <th>GRAPHICS CARD</th>
                                             <th>BATTERY</th>
                                             <th>BATTERY LIFE</th>
                                            <th>PRICE</th>
                                            <th>QUANTITY</th>
                                            <th>CATEGORY</th>
                                            <th>EDIT</th>
                                            <th>DELETE</th>
                                            <th>ADD STOCK</th>
                                        </tr>
                                </HeaderTemplate>
                                <ItemTemplate>

                                    <tr>
                                        <td><%# Eval("brand") %></td>
                                        <td><%# Eval("modelname") %></td>
                                        <td><%# Eval("modelno") %></td>
                                        <td>
                                            <asp:Image ID="Image5" runat="server" Height="70px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img1"),0,((byte[])Eval("img1")).Length) %>' Width="124px" /></td>
                                        <td>
                                            <asp:Image ID="Image6" runat="server" Height="70px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img2"),0,((byte[])Eval("img2")).Length) %>' Width="124px" /></td>
                                        <td>
                                            <asp:Image ID="Image7" runat="server" Height="70px" ImageUrl='<%# "data:image/png;base64,"+Convert.ToBase64String((byte[])Eval("img3"),0,((byte[])Eval("img3")).Length) %>' Width="124px" /></td>
                                     
                                       <td><%# Eval("modelyr") %></td>
                                        <td><%# Eval("processor_brand") %></td>
                                        <td><%# Eval("processor_name") %></td>
                                        <td><%# Eval("processor_speed") %></td>
                                         <td><%# Eval("ram_tech") %></td>
                                        <td><%# Eval("ram_size") %></td>
                                        <td><%# Eval("os") %></td>
                                        <td><%# Eval("graphicscard") %></td>
                                        <td><%# Eval("battery") %></td>
                                        <td><%# Eval("batterylife") %></td>
                                        <td><%# Eval("price") %></td>
                                        <td><%# Eval("qty") %></td>
                                        <td><%# Eval("cat_type") %></td>

                                        <td>

                                            <asp:Button ID="btn_edit" class="btn btn-success" OnClick="btn_edit_Click" CommandName='<%# Eval("lapid") %>' runat="server" Text="Edit" /></td>
                                        <td>
                                            <asp:Button ID="btn_delete" class="btn btn-danger" OnClick="btn_delete_Click" CommandName='<%# Eval("lapid") %>' runat="server" Text="Delete" /></td>
                                    <td>
                                            <asp:Button ID="btn_addstock" class="btn btn-info" OnClick="btn_addstock_Click" CommandName='<%# Eval("lapid") %>' runat="server" Text="ADD STOCK" /></td>
                                    </tr>

                                </ItemTemplate>
                                <FooterTemplate>
                                    </table>
                                </FooterTemplate>

                            </asp:Repeater>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>



            </table>
            </asp:Panel>
        
    </div>
        </div>

    </asp:Content>