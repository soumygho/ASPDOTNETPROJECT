<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="sellreport.aspx.cs" Inherits="sellreport" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

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
            width: 12px;
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
                style="font-weight: 700; font-style: italic; text-align: center">
                SELL REPORT</td>
        </tr>
        <tr>
            <td colspan="7" 
                style="font-weight: 700; font-style: italic; text-align: center">
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                SEARCH BY YEAR :</td>
            <td style="font-weight: 700; font-style: italic">
                SEARCH BY USER :</td>
            <td style="font-weight: 700; font-style: italic">
                SEARCH BY MONTH:</td>
            <td style="font-weight: 700; font-style: italic">
                SEARCH BY DATE :</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                    <asp:ListItem>2021</asp:ListItem>
                    <asp:ListItem>2022</asp:ListItem>
                    <asp:ListItem>2023</asp:ListItem>
                    <asp:ListItem>2024</asp:ListItem>
                    <asp:ListItem>2025</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="TextBox2">
                </asp:CalendarExtender>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:TextBox ID="userid" runat="server"></asp:TextBox>
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button5" runat="server" Text="SEARCH" onclick="Button5_Click" />
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SERACH" />
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button3" runat="server" Text="SEARCH" onclick="Button3_Click" />
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button4" runat="server" Text="SEARCH" onclick="Button4_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7" 
                style="font-weight: 700; font-style: italic; text-align: center; color: #800000">
                **ONSPOT BILLING DETAILS**</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" 
                    onpageindexchanging="GridView1_PageIndexChanging" 
                    style="color: #800000">
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <asp:AnimationExtender ID="GridView1_AnimationExtender" runat="server" 
                    Enabled="True" TargetControlID="GridView1">
                </asp:AnimationExtender>
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic" colspan="2">
                **NON ONSPOT BILLING DETAILS**</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic" colspan="2">
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                ENTER BILL ID</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="GET DETAILS" />
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                    style="font-weight: 700; font-style: italic; color: #800000" 
                    Text="PRINT CURRENT REPORT" />
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style6">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <asp:Label ID="LabelError" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
            </td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

