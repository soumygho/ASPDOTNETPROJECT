<%@ Page Title="ADMIN HOME" Language="C#" MasterPageFile="~/homepage1.master" AutoEventWireup="true" CodeFile="adminhome.aspx.cs" Inherits="adminhome"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Assembly="DataPagerRepeater"  Namespace="DataPagerRepeater" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            color: #FFFF00;
            text-align: center;
        }
        .style5
        {
            color: #CCFF66;
            text-align: center;
        }
        .style6
        {
            height: 22px;
        }
        .style7
        {
            color: #3333FF;
            text-align: center;
        }
          #content_data
{
    height:1256px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
#quicklink
{
    display : block;
    text-decoration : 'blink'; 
}
        .style9
        {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content_data">
<center>
    <table style="width: 950px; height: 1256px">
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
            <td style="font-weight: 700; text-align: center">
                ADMIN HOME PAGE</td>
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
            <td style="font-weight: 700; text-align: center">
                WELCOME ADMIN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="userid" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
            </td>
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
            <td style="">
                <asp:Panel ID="Panel2" runat="server"  BorderColor="#990000" 
                    BorderStyle="Solid">
                <div class="style4"><b><span class="style9">PENDING MEMBERS</span><br />
                    </b>
                    <asp:Label ID="Label1" runat="server" style="color: #0000FF; font-weight: 700" 
                        Text="Label"></asp:Label>
                    </div>
                <div style="font-weight: 700">
                <asp:DataPagerRepeater runat="server" ID="data">
                <HeaderTemplate>
                <table>
                <tr>
                <td colspan="2">
                <center>
                ID
                </center>
                </td>
                <td colspan="3">
                <center>
                NAME
                </center>
                </td>
                <td colspan="3">
                <center>
                DATE 
                OF REGISTRATION
                </center>
                </td>
                <td colspan="3">
                <center>
                STATUS
                </center>
                </td>
                <td colspan="2">
                <center>
                LINK
                </center>
                </td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                <td colspan="2">
                <center>
                <%#Eval("id") %>
                </center>
                </td>
                <td colspan="3">
                <center>
                <%#Eval("name") %>
                </center>
                </td>
                <td colspan="3">
                <center>
                <%#Eval("date") %>
                </center>
                </td>
                <td style="text-decoration : 'blink';" colspan="3">
                <center>
                <%#Eval("status") %>
                </center>
                </td>
                <td colspan="2">
                <center>
               <asp:HyperLink runat="server" ID="see" NavigateUrl='<%#String.Format("{0}{1}","adminview.aspx?id=",Eval("id"))%>'>SEE DETAILS</asp:HyperLink>
               </center>
                </td>
                </tr>
                </ItemTemplate>
                <FooterTemplate>
                </table>
                </FooterTemplate>
                </asp:DataPagerRepeater>
                </div>
                <div style="text-align: center">
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="data" 
                        PageSize="6">
                        <Fields>
                            <asp:NextPreviousPagerField />
                        </Fields>
                    </asp:DataPager>
                    </div>
                </asp:Panel>
            </td>
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
                <asp:Panel ID="Panel3" runat="server"  BorderColor="#990000" 
                    BorderStyle="Solid">
                <div class="style5"><b style="color: #00FF00">VALID MEMBERS<br />
                    </b>
                    <asp:Label ID="Label2" runat="server" style="color: #3333FF; font-weight: 700" 
                        Text="Label"></asp:Label>
                    </div>
                <div style="font-weight: 700">
                <asp:DataPagerRepeater runat="server" ID="DataPagerRepeater1">
                <HeaderTemplate>
                <table>
                <tr>
                <td >
                ID
                </td>
                <td>
                NAME
                </td>
                <td colspan="3">
                DATE 
                OF REGISTRATION
                </td>
                <td>
                STATUS
                </td>
                <td>
                LINK
                </td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                <td>
                <%# Eval("id") %>
                </td>
                <td>
                <%#Eval("name") %>
                </td>
                <td colspan="3">
                <center>
                <%#Eval("date") %>
                </center>
                </td>
                <td>
                <%#Eval("status") %>
                </td>
                <td>
               <asp:HyperLink runat="server" ID="see" NavigateUrl='<%# String.Format("{0}{1}", "adminview.aspx?id=", Eval("id")) %>'>SEE DETAILS</asp:HyperLink>
                </td>
                </tr>
                </ItemTemplate>
                <FooterTemplate>
                </table>
                </FooterTemplate>
                </asp:DataPagerRepeater>
                </div>
                <div style="text-align: center; height:200px;">
                    <asp:DataPager ID="DataPager2" runat="server" PagedControlID="DataPagerRepeater1" 
                        PageSize="6">
                        <Fields>
                            <asp:NextPreviousPagerField />
                        </Fields>
                    </asp:DataPager>
                    </div>
                </asp:Panel>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                <asp:Panel ID="Panel4" runat="server"  BorderColor="#990000" 
                    BorderStyle="Solid">
                <div style="font-weight: 700; text-align: center"><span class="style7">INVALID</span><b><span 
                        class="style7"> MEMBERS</span><br />
                    </b>
                    <asp:Label ID="Label3" runat="server" CssClass="style7" 
                        style="font-weight: 700" Text="Label"></asp:Label>
                    </div>
                <div style="font-weight: 700">
                <asp:DataPagerRepeater runat="server" ID="DataPagerRepeater2">
                <HeaderTemplate>
                <table>
                <tr>
                <td >
                ID
                </td>
                <td>
                NAME
                </td>
                <td colspan="3">
                DATE 
                OF REGISTRATION
                </td>
                <td>
                STATUS
                </td>
                <td>
                LINK
                </td>
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                <td>
                <%#Eval("id") %>
                </td>
                <td>
                <%#Eval("name") %>
                </td>
                <td colspan="3">
                <center>
                <%#Eval("date") %>
                </center>
                </td>
                <td>
                <%#Eval("status") %>
                </td>
                <td>
               <asp:HyperLink runat="server" ID="see" NavigateUrl='<%# String.Format("{0}{1}", "adminview.aspx?id=", Eval("id")) %>'>SEE DETAILS</asp:HyperLink>
                </td>
                </tr>
                </ItemTemplate>
                <FooterTemplate>
                </table>
                </FooterTemplate>
                </asp:DataPagerRepeater>
                </div>
                <div style="text-align: center">
                    <asp:DataPager ID="DataPager3" runat="server" PagedControlID="DataPagerRepeater2" 
                        PageSize="6">
                        <Fields>
                            <asp:NextPreviousPagerField />
                        </Fields>
                    </asp:DataPager>
                    </div>
                </asp:Panel>
            </td>
            <td class="style6">
                </td>
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
                <asp:Panel ID="Panel1" runat="server">
                    <fieldset style="height: 135px;">
                        <div>
                            <center>
                                <b>QUICK LINKS</b></center>
                        </div>
                        <div>
                            <ul id="quicklink">
                                <li><a href="Searchadmin.aspx" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">SEARCH A MEMBER</a></li>
                                <li><a href="galleryupload.aspx" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">UPLOAD AN IMAGE</a></li>
                                <li><a href="deletegallery.aspx" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">DELETE AN IMAGE</a></li>
                                        <li><a href="deletemember.aspx" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">DELETE AN MEMBER</a></li>
                                        <li><a href="http://webmail.at8ar.com" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">CHECK EMAIL</a></li>
                                        <li><a href="changeadminpassword.aspx" 
                                        style="text-decoration:'blink'; font-weight: 700; color: #0066FF;">CHANGE PASSWORD</a></li>
                            </ul>
                        </div>
                    </fieldset>
                </asp:Panel>
            </td>
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
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" BackColor="#FFFF99" 
                    Font-Bold="True" ForeColor="Maroon" onclick="LinkButton1_Click">LOGOUT</asp:LinkButton>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </center>
</div>
</asp:Content>

