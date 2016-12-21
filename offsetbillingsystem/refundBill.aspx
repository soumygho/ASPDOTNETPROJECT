<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="refundBill.aspx.cs" Inherits="refundBill" %>

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
            background-color: #CCFF99;
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

            url: "http://localhost:12943/offsetbillingsystem/nameservice.asmx/getList",
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; text-align: center">
                **REFUND BILL**</td>
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
                ENTER CUSTOMER NAME</td>
            <td>
                <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
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
                CUSTOMER ID</td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="GET BILL LIST" 
                    onclick="Button1_Click" />
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
                BILL LIST</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
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
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="REFUND" onclick="Button2_Click" />
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
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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

