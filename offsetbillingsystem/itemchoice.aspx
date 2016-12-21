<%@ Page Title="" Language="C#" MasterPageFile="~/content.master" AutoEventWireup="true" CodeFile="itemchoice.aspx.cs" Inherits="itemchoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 100%;
            background-color: #CCFF99;
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
            <td>
                &nbsp;</td>
            <td style="text-align: center; font-weight: 700; font-style: italic">
                SELECT ITEM</td>
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
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    style="font-weight: 700; font-style: italic">
                    <asp:ListItem>OFFSET OR DIGITAL PRINTING</asp:ListItem>
                    <asp:ListItem>FLEX PRINTING</asp:ListItem>
                    <asp:ListItem>SCHOOL PHOTO IDENTITY CARD</asp:ListItem>
                    <asp:ListItem>RUBBER STAMP</asp:ListItem>
                    <asp:ListItem>PASSPORT SIZE PHOTO</asp:ListItem>
                    <asp:ListItem>XEROX</asp:ListItem>
                    <asp:ListItem>COLOR XEROX</asp:ListItem>
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
            <td style="text-align: center">
                <asp:Button ID="Button1" runat="server" 
                    style="font-weight: 700; font-style: italic" Text="GO&gt;&gt;&gt;" 
                    onclick="Button1_Click" />
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

