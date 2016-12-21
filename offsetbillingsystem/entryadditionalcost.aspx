<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="entryadditionalcost.aspx.cs" Inherits="entryadditionalcost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 100%;
            background-color: #CCFFCC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style5">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2" 
                style="font-weight: 700; font-style: italic; color: #800000; text-align: center">
                ENTRY ADDITIONAL COST(PER UNIT BASIS)</td>
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
                SELECT CATEGORY
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
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
                BINDING COST</td>
            <td>
                <asp:TextBox ID="bindcost" runat="server"></asp:TextBox>
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
                DTP COST</td>
            <td>
                <asp:TextBox ID="dtpcost" runat="server"></asp:TextBox>
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
                DELIVERY COST</td>
            <td>
                <asp:TextBox ID="deliverycost" runat="server"></asp:TextBox>
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
                ADDITIONAL PROFIT(IN %)</td>
            <td>
                <asp:TextBox ID="additionalprofit" runat="server"></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-weight: 700; font-style: italic; color: #800000; background-color: #CCFFCC" 
                    Text="INSERT" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    style="color: #800000; font-style: italic; font-weight: 700; background-color: #CCFFCC" 
                    Text="UPDATE" />
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
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; font-style: italic; color: #FF0000" Text="Label"></asp:Label>
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

