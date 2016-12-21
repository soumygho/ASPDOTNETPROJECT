<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="flex.aspx.cs" Inherits="flex" %>

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
            <td colspan="7" 
                style="font-weight: 700; font-style: italic; color: #800000; text-align: center">
&nbsp;FLEX DETAILS</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; color: #800000">
                rate per square ft**</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
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
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-weight: 700; font-style: italic; color: #800000" Text="INSERT" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    style="font-weight: 700; font-style: italic; color: #800000" Text="UPDATE" />
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
    </table>
</asp:Content>

