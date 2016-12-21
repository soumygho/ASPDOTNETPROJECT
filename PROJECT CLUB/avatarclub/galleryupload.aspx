<%@ Page Title="UPLOAD IMAGE" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="galleryupload.aspx.cs" Inherits="galleryupload"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style4
    {
        width: 100%;
        background-color: #FFFFFF;
    }
    .style5
    {
        height: 23px;
        font-weight: 700;
            text-align: center;
        }
        .style6
        {
            height: 25px;
            font-weight: 700;
            text-align: center;
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
    <table style="width: 950px; height: 480px">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="font-weight: 700; text-align: center">
            UPLOAD GALLERY IMAGE</td>
        <td>
            &nbsp;</td>
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
        <td class="style5">
        </td>
        <td class="style5">
            IMAGE TITLE :
            <asp:TextBox ID="TextBox1" runat="server" Width="221px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
        </td>
        <td class="style5">
        </td>
        <td class="style5">
        </td>
        <td class="style5">
        </td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            IMAGE DESCRIPTION :
            <asp:TextBox ID="TextBox2" runat="server" Height="28px" style="width: 128px" 
                TextMode="MultiLine" Width="216px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
        </td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            UPLOAD :
            <asp:FileUpload ID="FileUpload1" runat="server" style="font-weight: 700" />
        </td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                style="font-weight: 700" Text="UPLOAD" />
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/adminhome.aspx" style="color: #800000">GOTO ADMIN HOMEPAGE</asp:HyperLink>
        </td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
        <td class="style5">
            &nbsp;</td>
    </tr>
    </table>
</center></div>
</asp:Content>

