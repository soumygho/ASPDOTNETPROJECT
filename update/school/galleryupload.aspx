<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="galleryupload.aspx.cs" Inherits="galleryupload" Title="Untitled Page" %>

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
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
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
</asp:Content>

