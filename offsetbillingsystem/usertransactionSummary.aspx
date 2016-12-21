<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="usertransactionSummary.aspx.cs" Inherits="usertransactionSummary" %>

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
            font-weight: 700;
            font-style: italic;
            color: #800000;
        }
        .style6
        {
            height: 23px;
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
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td style="font-weight: 700; font-style: italic; text-align: center" 
                class="style6">
                USER TRANSACTION SUMMARY</td>
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
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; text-align: center">
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
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
                ENTER THE NAME :
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
&nbsp;USERID :<asp:TextBox ID="userid" runat="server" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;
                <asp:Button ID="Button1" runat="server" Text="SHOW ALL TRANSACTION" 
                    onclick="Button1_Click" 
                    style="font-weight: 700; font-style: italic; color: #800000" />
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
                FILTER BY MONTH
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
&nbsp;<asp:Button ID="Button2" runat="server" Text="FILTER" onclick="Button2_Click" />
&nbsp;&nbsp;&nbsp; FILTER BY YEAR :<asp:DropDownList ID="DropDownList2" runat="server">
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
&nbsp;<asp:Button ID="Button3" runat="server" Text="FILTER" onclick="Button3_Click" />
&nbsp;
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
                FILTER BY DATE :                 <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="TextBox3">
                </asp:CalendarExtender>
&nbsp;<asp:Button ID="Button4" runat="server" Text="FILTER" onclick="Button4_Click" />
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
            <td style="text-align: center">
                **ACCOUNT TRANSACTION DETAILS**</td>
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
                <asp:GridView ID="GridView1" runat="server" 
                    style="font-weight: 700; font-style: italic">
                </asp:GridView>
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
            <td style="font-weight: 700; font-style: italic">
                TOTAL OUTSTANDING :&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
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

