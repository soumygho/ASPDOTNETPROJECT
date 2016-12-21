<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="administrative_page.aspx.cs" Inherits="administrative_page" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            width: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td colspan="7" style="text-align: center">
            <b><i style="text-align: center">SELECT THE LINK BELOW AND EDIT</i></b></td>
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
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>-SELECT-</asp:ListItem>
                <asp:ListItem>galleryupload</asp:ListItem>
                <asp:ListItem>NEWS</asp:ListItem>
                <asp:ListItem>NOTICES</asp:ListItem>
                <asp:ListItem Value="TEACHER_DETAILS">TEACHER DETAILS</asp:ListItem>
                <asp:ListItem>resultupload</asp:ListItem>
                <asp:ListItem>updateresultstatus</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
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
            <asp:Button ID="Button1" runat="server" Text="GO&gt;&gt;" 
                onclick="Button1_Click" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
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
        <td class="style11">
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
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                style="color: #FF0000">Logout</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="font-weight: 700; text-align: center;">
            <asp:LinkButton ID="LinkButton2" runat="server" 
                PostBackUrl="~/deletegallery.aspx" style="font-weight: 700; color: #FF3300">DELETE 
            GALLERY PHOTO</asp:LinkButton>
&nbsp;||
            <asp:LinkButton ID="LinkButton3" runat="server" style="color: #FF0000" 
                PostBackUrl="~/deletenotice.aspx">DELETE 
            NOTICES</asp:LinkButton>
            ||<asp:LinkButton ID="LinkButton4" runat="server" style="color: #FF0000" 
                PostBackUrl="~/DeleteTeachers.aspx">DELETE 
            TEACHERS</asp:LinkButton>
            ||<asp:HyperLink ID="HyperLink2" runat="server" 
                NavigateUrl="~/viewregistration.aspx" style="color: #FF0000">VIEW REGISTRATION</asp:HyperLink>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
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
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="DOWNLOAD REGISTRATION DETAILS" />
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
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
        <td class="style11">
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
        <td class="style11">
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
        <td class="style11">
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
        <td class="style11">
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
        <td class="style11">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

