<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="noticedetails.aspx.cs" Inherits="noticedetails" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="cc1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            color: #FF0000;
            font-weight: bold;
        }
        .style5
        {
            width: 875px;
            height:575px;
            border-style: solid;
            border-width: 1px;
            background-color: #FFFFFF;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div>
        <center class="style4">
            <table class="style5">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                    <center><b>
            NOTICE DOWNLOAD SECTION</b></center></td>
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
    <asp:Panel ID="Panel1" runat="server" style="font-weight: 700; text-align: center">
        <asp:ListView ID="ListView1" runat="server" style="color: #FFFFFF">
            <ItemTemplate>
                <center>
                    <asp:HyperLink runat="server" Font-Bold="true" ForeColor="Red" 
                NavigateUrl= ' <%#String.Concat("~/Notice_client.aspx?id=",Eval("id"))%>' 
                Text='<%#Eval("sub") %>'></asp:HyperLink>
                </center>
            </ItemTemplate>
            <ItemSeparatorTemplate>
                <asp:Label runat="server" Text="<br/>"></asp:Label>
            </ItemSeparatorTemplate>
            <LayoutTemplate>
                <div runat="server" id="itemplaceholder">
                </div>
            </LayoutTemplate>
        </asp:ListView>
    </asp:Panel>
           
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
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
                    </td>
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

