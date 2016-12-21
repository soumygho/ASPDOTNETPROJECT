<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="printbill.aspx.cs" Inherits="printbill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 100%;
            background-color: #CCFFCC;
        }
        .style6
        {
            font-weight: bold;
            font-style: italic;
            font-family: "Adobe Song Std L";
        }
        .style7
        {
            font-family: "Adobe Song Std L";
        }
    </style>
    <script>
        function printDiv(divName) {
            var printContents = document.getElementById(divName).innerHTML;
            var originalContents = document.body.innerHTML;

            document.body.innerHTML = printContents;

            window.print();

            document.body.innerHTML = originalContents;
            return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="printablearea">

    <table class="style5">
        <tr>
            <td colspan="7" style="text-align: center; font-family: 'Adobe Arabic';">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; font-style: italic; text-align: center" 
                    Text="FIRHIM ENTERPRISE" CssClass="style7"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="7" 
                style="text-align: center; font-family: 'Adobe Arabic'; font-weight: 700; font-style: italic;">
                <asp:Label ID="Label2" runat="server" 
                    Text="BELDA(DANTAN ROAD)   MOBILE : 9475253895" CssClass="style7"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="7" style="text-align: left" class="style7">
                <span class="style6">BILL NO : </span>
                <asp:Label ID="lblbillid" runat="server" CssClass="style6" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic" class="style7">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic">
                <span class="style7">NAME :
                </span>
                <asp:Label ID="lblname" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <span class="style7">ADDRESS :
                </span>
                <asp:Label ID="lblAddress" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
            <td style="font-weight: 700; font-style: italic">
                <span class="style7">MOB NO :
                </span>
                <asp:Label ID="lblMob" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; text-align: center" 
                class="style7">
                ORDER DETAILS</td>
            <td class="style7">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7" style="text-align: center">
                <asp:GridView ID="GridView1" runat="server" 
                    style="font-weight: 700; font-style: italic">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="7" style="font-weight: 700; font-style: italic">
                <span class="style7">TOTAL :                 </span>                 
                <asp:Label ID="lblTotal" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="7" style="font-weight: 700; font-style: italic">
                <span class="style7">CONS :
                </span>
                <asp:Label ID="lblCons" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="7" style="font-weight: 700; font-style: italic">
                <span class="style7">FINAL :
                </span>
                <asp:Label ID="lblFinal" runat="server" Text="Label" CssClass="style7"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    <div style="text-align: center">
        <input id="Button1" type="button" value="PRINT" onclick="printDiv('printablearea');" />
    </div>
</asp:Content>

