<%@ Page Language="C#" MasterPageFile="~/HPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .product
        {
        	float:left;
        	margin-right:7px;
        	margin-left:7px;
        	margin-top:7px;
        	margin-bottom:7px;
        	border-color:Black;
        	border-width:thin;
        	border-style:solid;
        	box-shadow: 0px 5px 8px Grey;
            border-radius:5px/25px;

        }
        .style8
        {
            width: 868px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style7" style="background-color: #FFFFFF">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                <asp:ImageButton ID="ImageButton4" runat="server" Height="195px" 
                    Width="203px" CssClass="product" />
&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton5" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton6" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton7" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                <asp:ImageButton ID="ImageButton8" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton9" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton10" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton11" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                <asp:ImageButton ID="ImageButton12" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton13" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton14" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton15" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style8">
                <asp:ImageButton ID="ImageButton16" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton17" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton18" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
                <asp:ImageButton ID="ImageButton19" runat="server" CssClass="product" 
                    Height="195px" Width="203px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

