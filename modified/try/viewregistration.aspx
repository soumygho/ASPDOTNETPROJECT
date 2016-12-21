<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="viewregistration.aspx.cs" Inherits="viewregistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
        <tr>
            <td style="font-weight: 700; text-align: center">
                REGISTRATION DETAILS</td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:GridView ID="registrationGrid" runat="server" CellPadding="4" 
                    ForeColor="#333333" GridLines="None" style="font-weight: 700" Width = "875px">
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

