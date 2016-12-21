<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="STUDENTS.aspx.cs" Inherits="STUDENTS" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
    {
        text-align: center;
            font-weight: 700;
        }
        .style12
        {
            text-align: center;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="body" 
        style="border: medium solid #000000; background-color: #FFFFFF">
    <tr>
        <td class="style12" colspan="9">
            ADD STUDENT RECORD TO THE DATABASE</td>
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
        <td style="text-align: center">
            <asp:DropDownList ID="DropDownList1" runat="server" style="font-weight: 700">
                <asp:ListItem>-SELECT-</asp:ListItem>
                <asp:ListItem Value="CLASS_5">CLASS 5</asp:ListItem>
                <asp:ListItem Value="CLASS_6">CLASS 6</asp:ListItem>
                <asp:ListItem Value="CLASS_7">CLASS 7</asp:ListItem>
                <asp:ListItem Value="CLASS_8">CLASS 8</asp:ListItem>
                <asp:ListItem Value="CLASS_9">CLASS 9</asp:ListItem>
                <asp:ListItem Value="CLASS_10">CLASS 10</asp:ListItem>
                <asp:ListItem Value="CLASS_11(SC)">CLASS 11(SC)</asp:ListItem>
                <asp:ListItem Value="CLASS_11(ARTS)">CLASS 11(ARTS)</asp:ListItem>
                <asp:ListItem Value="CLASS_12(SCIENCE)">CLASS 12(SCIENCE)</asp:ListItem>
                <asp:ListItem Value="CLASS_12(ARTS)">CLASS 12(ARTS)</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" 
                style="text-align: center; font-weight: 700;">
                <asp:ListItem>-SELECT YEAR-</asp:ListItem>
                <asp:ListItem Value="YEAR2011">2011</asp:ListItem>
                <asp:ListItem Value="YEAR2012">2012</asp:ListItem>
                <asp:ListItem Value="YEAR2013">2013</asp:ListItem>
                <asp:ListItem Value="YEAR2014">2014</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SUBMIT" 
                style="font-weight: 700" />
        </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
        </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Panel ID="Panel2" runat="server" 
                style="font-weight: 700; font-style: italic; text-align: center">
                ENTER THE NO OF SUBJECTS :
                <asp:TextBox ID="TextBox1" runat="server" Width="161px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Submit" 
                    style="font-weight: 700" />
            </asp:Panel>
                                     </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style11">
            <asp:LinkButton ID="LinkButton7" runat="server" PostBackUrl="~/addresult.aspx" 
                style="font-weight: 700">Click here to add student result!!!</asp:LinkButton>
                                     ||<asp:HyperLink ID="HyperLink4" runat="server" 
                NavigateUrl="~/viewResult.aspx">VIEW STUDENT&#39;S RECORD</asp:HyperLink>
                                     </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Label ID="Label2" runat="server" style="font-weight: 700" 
                Text="Label"></asp:Label>
        </td>
        <td>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            YOU ARE LOGGED ON&nbsp;<asp:LinkButton ID="LinkButton6" runat="server" 
                onclick="LinkButton6_Click">LOGOUT</asp:LinkButton>
                            &nbsp;<asp:HyperLink ID="HyperLink3" runat="server" 
                                NavigateUrl="~/administrative_page.aspx">GOTO ADMIN HOMEPAGE</asp:HyperLink>
                        </td>
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

