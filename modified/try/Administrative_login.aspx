<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Administrative_login.aspx.cs" Inherits="Default2" Title="ADMIN LOGIN" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="cc1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css" >
.popup
{
 background-color:Gray;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style=" width:875px;">
        <tr>
            <td colspan="7" style="text-align: center">
                <b style="color: #FFFFFF">ADMINISTRATIVE SECTION</b></td>
        </tr>
        <tr>
            <td>
                    <ContentTemplate>
                        <table class="style1" style="width: 865px">
                            <tr>
                                <td style="text-align: center">
                                <div><center><h1><b>LOGIN</b></h6></center> </div>
                                <center>
                                    <fieldset style="height: 125px; width: 507px; background-color: #CCCCCC; font-weight: 700;">
                                        USERID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="TextBox1" runat="server" Height="24px" ValidationGroup="a" 
                                            Width="274px"></asp:TextBox>
                                        <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                                            runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="USERID">
                                        </cc1:TextBoxWatermarkExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                        <br />
                                        PASSWORD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="TextBox2" runat="server" Height="22px" ValidationGroup="a" 
                                            Width="271px" TextMode="Password"></asp:TextBox>
                                        <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                                            runat="server" Enabled="True" TargetControlID="TextBox2" 
                                            WatermarkText="PASSWORD">
                                        </cc1:TextBoxWatermarkExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                    </fieldset>
                                    </center>
                                    </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="LOGIN" 
                                        style="font-weight: 700" />
                                   
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label1" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    </ContentTemplate>
            </td>
            
        </tr>
        <tr>
            <td colspan="7">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

