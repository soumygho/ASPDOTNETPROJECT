<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="dtpsell.aspx.cs" Inherits="dtpsell" %>

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
            color: #800000;
            font-style: italic;
            font-weight: bold;
        }
        .style7
        {
            height: 26px;
            font-weight: 700;
            font-style: italic;
            color: #800000;
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
            <td colspan="7" 
                style="font-weight: 700; font-style: italic; color: #800000; text-align: center">
                **DTP AND OFFSET SELL DATA ENTRY**</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; color: #800000">
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                MOB NO</td>
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; color: #800000">
                USERID</td>
            <td>
                <asp:TextBox ID="userid" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
            </td>
            <td class="style7">
            </td>
            <td class="style7">
                SELECT PAPER TYPE</td>
            <td class="style7">
                <asp:DropDownList ID="pagetype" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="pagetype_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style7">
            </td>
            <td class="style7">
            </td>
            <td class="style7">
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                SELECT PAPERSIZE</td>
            <td class="style7">
                <asp:DropDownList ID="papersize" runat="server" 
                    onselectedindexchanged="papersize_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; color: #800000">
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                NO OF PAGES FOR DTP&nbsp;</td>
            <td>
                <asp:TextBox ID="dtpcount" runat="server"></asp:TextBox>
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
            <td class="style6">
                TICK TO INCLUDE ADDITIONAL CHARGE</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="PRINT COST" AutoPostBack="True" 
                    oncheckedchanged="CheckBox1_CheckedChanged" />
                <asp:DropDownList ID="printingside" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    >
                    <asp:ListItem>SINGLE</asp:ListItem>
                    <asp:ListItem>BOTH</asp:ListItem>
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                **QUICK TIPS**</td>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" Text="DTP COST" />
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                I<i><b>N NAME FIELS JUST TICK NIL TO SELL</b></i></td>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="BINDING COST" />
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                ITEMS WITHOUT FILLING USER DETAILS</td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="TICK IF OFFSET PRINTING" />
                <br />
                <asp:Panel ID="Panel1" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000">
                    <asp:DropDownList ID="color1" runat="server">
                    <asp:ListItem Text="-SELECT-" Value="-SELECT-"></asp:ListItem>
                    <asp:ListItem Text="BLACK" Value="BLACK"></asp:ListItem>
                    </asp:DropDownList>
                    SELECT COLOR1<br />
                    <asp:DropDownList ID="color2" runat="server" 
                        >
                        <asp:ListItem Text="-SELECT-" Value="-SELECT-"></asp:ListItem>
                        <asp:ListItem Text="YELLOW" Value="YELLOW"></asp:ListItem>
                    </asp:DropDownList>
                    SELECT COLOR 2<br />
                    <asp:DropDownList ID="color3" runat="server">
                    <asp:ListItem Text="-SELECT-" Value="-SELECT-"></asp:ListItem>
                    <asp:ListItem Text="GREEN" Value="GREEN"></asp:ListItem>
                    </asp:DropDownList>
                    SELECT COLOR 3<br />
                    <asp:DropDownList ID="color4" runat="server">
                    <asp:ListItem Text="-SELECT-" Value="-SELECT-"></asp:ListItem>
                    <asp:ListItem Text="BLUE" Value="BLUE"></asp:ListItem>
                    </asp:DropDownList>
                    SELECT COLOR 4
                </asp:Panel>
                
                <asp:CheckBox ID="CheckBox8" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="TICK IF DIGITAL PRINTING" />
                
&nbsp;</td>
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                TOTAL COST OF THIS ITEM :<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700; font-style: italic; color: #800000">
                TOTAL COST OF THE BILL:
                <asp:Label ID="Label2" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
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
                <asp:HiddenField ID="categoryid" runat="server"  Value="1"/>
            </td>
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
                <asp:Button ID="Button4" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #800000; background-color: #CCFFCC" 
                    Text="&lt;&lt;CANCEL" />
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
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

