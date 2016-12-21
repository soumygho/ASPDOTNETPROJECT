<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="noticedetails.aspx.cs" Inherits="noticedetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            color: #FF0000;
            font-weight: bold;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div>
        <center class="style4">
            NOTICE DOWNLOAD SECTION</center>
        </div>     
    <asp:Panel ID="Panel1" runat="server" style="font-weight: 700; text-align: center">
        <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
        <center>
        <asp:HyperLink runat="server" Font-Bold="true" ForeColor="Red" NavigateUrl= ' <%#String.Concat("~/Notice_client.aspx?id=",Eval("id"))%>' Text='<%#Eval("sub") %>'></asp:HyperLink>
  </center>
        </ItemTemplate>
        <ItemSeparatorTemplate>
        <asp:Label runat="server" Text="<br/>"></asp:Label>
        </ItemSeparatorTemplate>
        <LayoutTemplate>
        <div runat="server" id="itemplaceholder"></div>
        </LayoutTemplate>
        </asp:ListView>
        <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    </asp:Panel>
           
</asp:Content>

