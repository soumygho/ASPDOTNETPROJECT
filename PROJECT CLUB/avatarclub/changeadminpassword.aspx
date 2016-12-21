<%@ Page Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="changeadminpassword.aspx.cs" Inherits="changeadminpassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>CHANGE PASSWORD</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
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
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="color: #3366FF">
                CHANGE ADMIN PASSWORD FOR CURRENT ADMIN</td>
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
            <td style="color: #3366FF">
            <center>
                <asp:Label ID="msg" runat="server" Text="Label" ForeColor="Red"></asp:Label></center>
                
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
            <center>
                ENTER CURRENT PASSWORD
                <asp:TextBox ID="currentpassword" runat="server" Width="211px"></asp:TextBox>
                </center>
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
            <center>
                ENTER NEW PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="newpassword" runat="server" Width="211px"></asp:TextBox>
                </center>
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
            <center>
                CONFIRM NEW PASSWORD&nbsp;&nbsp;
                <asp:TextBox ID="confirmnewpassword" runat="server" Width="211px"></asp:TextBox>
                </center>
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
            <center>
                <asp:Button ID="submit" runat="server" Text="SUBMIT" onclick="submit_Click" />
                </center>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>
</asp:Content>

