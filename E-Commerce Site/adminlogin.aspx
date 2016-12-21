<%@ Page Language="C#" MasterPageFile="~/another.master" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="border: medium solid #800000">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style2">
            <b>LOGIN</b></td>
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
        <td class="style2">
            ADMIN USERID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="236px"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                runat="server" Enabled="True" TargetControlID="TextBox2" 
                WatermarkText="ENTER USERID">
            </cc1:TextBoxWatermarkExtender>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
        </td>
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
        <td class="style2">
            ADMIN PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="21px" TextMode="Password" 
                Width="233px"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" 
                runat="server" Enabled="True" TargetControlID="TextBox3" 
                WatermarkText="***************">
            </cc1:TextBoxWatermarkExtender>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="*Required"></asp:RequiredFieldValidator>
        </td>
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
        <td class="style2">
            <asp:Button ID="Button2" runat="server" Text="LOGIN" onclick="Button2_Click" />
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

