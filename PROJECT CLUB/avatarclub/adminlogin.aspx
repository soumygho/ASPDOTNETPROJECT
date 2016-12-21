<%@ Page Title="A.V.A.T.E.R ADMIN LOGIN" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="adminlogin"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            background-color: #A9A9A9;
        }
        .style4
        {
            height: 22px;
        }
        .style5
        {
            height: 30px;
        }
          #content_data
{
    height:480px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content_data">
<center>
    <table>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
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
        <tr>
            <td colspan="7" style="font-weight: 700; text-align: center">
                A.V.A.T.A.R ADMIN SECTION</td>
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
            <td colspan="3" rowspan="8">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: center" colspan="2" rowspan="5">
            
                <div style=" border: thin solid #800000">
                <div><center>ADMIN LOGIN</center></div>
                USERNAME
                <asp:TextBox ID="username" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="*Required" ControlToValidate="username"></asp:RequiredFieldValidator>
                <cc1:TextBoxWatermarkExtender ID="username_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="username" 
                    WatermarkText="USERNAME">
                </cc1:TextBoxWatermarkExtender>
                    <br />
                    PASSWORD<asp:TextBox ID="password" runat="server" TextMode="Password" Width="250px"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="password_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="password" 
                    WatermarkText="PASSWORD">
                </cc1:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="*Required" ControlToValidate="password"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                <asp:Button ID="Submit" runat="server" onclick="Submit_Click" 
                    style="font-weight: 700" Text="Submit" />
                    <br />
                    <br />
                <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #FF0000" 
                    Text="Label"></asp:Label>
                    <br />
                    <br />
                </div></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style4">
            </td>
        </tr>
        <tr>
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
        </center>
</div>
</asp:Content>

