<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="xerox.aspx.cs" Inherits="xerox" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="js/jquery-ui.css"/>
 
<link rel="stylesheet" type="text/css" href="js/autocomplete.css"/>
 
<script type="text/javascript" src="js/jquery.js"></script>
 
<script type="text/javascript" src="js/jquery-ui.min.js" ></script>
 
<script type="text/javascript" src="js/jquery.ui.autocomplete.html.js"></script>
    <style type="text/css">

        .style5
        {
            width: 100%;
            background-color: #CCFFCC;
        }
        .style6
        {
            height: 26px;
        }
        </style>
        <script type="text/javascript">
            window.onload = function() {
                //alert($("#<%=userid.ClientID %>").text());
                var obj;

                $("#<%=TextName.ClientID %>").autocomplete(
        {


            source: function(request, response) {
                $.ajax(
        {

            url: "http://localhost/offsetbillingsystem/nameservice.asmx/getList",
            data: "{'start':'" + $("#<%=TextName.ClientID %>").val() + "'}",
            contentType: "application/json; charset=utf-8",
            type: "POST",
            success: function(data) {

                obj = JSON.parse(data.d);
                var list = [];
                for (var i = 0; i < obj.length; i++) {
                    list.push(obj[i].Suggestion);
                }
                response(list);

            },
            failure: function(errMsg) {
                alert("ERROR OCCURED");
            }
        }
    );
            },
            select: function(event, ui) {
                $("#<%=TextName.ClientID %>").val("");
                for (var i = 0; i < obj.length; i++) {
                    if (ui.item.value == obj[i].Suggestion) {
                        ui.item.value = obj[i].Custname;
                        $("#<%=TextName.ClientID %>").val(obj[i].Custname);
                        $("#<%=userid.ClientID %>").val(obj[i].Custid);
                        $("#<%=TextEmail.ClientID %>").val(obj[i].Custemail);
                        $("#<%=TextMobNo.ClientID %>").val(obj[i].Custmobno);
                        $("#<%=TextAddress.ClientID %>").val(obj[i].Custaddress);
                        alert($("#<%=userid.ClientID %>").val());
                        break;
                    }
                }

            }
        }
    );

            };

    
    
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style5">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; color: #800000; text-align: center">
                XEROX SELL</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                NAME OF THE CUSTOMER</td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
                <asp:CheckBox ID="CheckBox7" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="ONSPOT BILL" AutoPostBack="True" 
                    oncheckedchanged="CheckBox7_CheckedChanged" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                MOBNO</td>
            <td>
                <asp:TextBox ID="TextMobNo" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                EMAIL</td>
            <td>
                <asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                ADDRESS</td>
            <td>
                <asp:TextBox ID="TextAddress" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                USERID</td>
            <td class="style6">
                <asp:TextBox ID="userid" runat="server"></asp:TextBox>
            </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                SELECT PAGE TYPE</td>
            <td>
                <asp:DropDownList ID="pagetype" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                QUANTITY</td>
            <td>
                <asp:TextBox ID="qty" runat="server" ontextchanged="qty_TextChanged"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                XEROX COUNT/UNIT</td>
            <td>
                <asp:TextBox ID="countcopy" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="CheckBox5" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="DELIVERY COST" />
                <br />
                <asp:Panel ID="Panel2" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000">
                    SPECIFY DISTANCE IN KM<br />
                    <asp:TextBox ID="Textdistance" runat="server"></asp:TextBox>
                </asp:Panel>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="CheckBox6" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" Text="PROFIT" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000; background-color: #CCFFCC" 
                    Text="INCLUDE ANOTHER ITEM" onclick="Button1_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" 
                    style="color: #800000; font-weight: 700; font-style: italic; background-color: #CCFFCC" 
                    Text="GENERATE BILL" onclick="Button2_Click"  />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:HiddenField ID="categoryid" runat="server"  Value="7"/>
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" 
                    style="color: #800000; font-weight: 700; font-style: italic; background-color: #CCFFCC" 
                    Text="GENERATE QUOTATION" onclick="Button3_Click" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

