<%@ Page Title="A.V.A.T.E.R GALLERY" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery"  %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="cc1"%>
<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            height: 91px;
        }
        .back
        {
            background-color : White;
            border-style : solid;
        }
         #content_data
{
    height:1256px;
    width:875px;
    margin:auto;
    padding:0px;
    margin-top:48px;
    border-radius:5px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content_data">
    <center>
        <table class="style1">
            <tr>
                <td style="font-weight: 700; text-align: center" class="style3">
                    GALLERY<cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </cc1:ToolkitScriptManager>
                </td>
                <td class="style3">
                    </td>
                <td class="style3">
                    </td>
                <td class="style3">
                    </td>
            </tr>
            <tr>
                <td style="text-align: center">
                            <div>    <asp:Panel ID="imagecontainer" runat="server" 
                                    style="text-align: center; margin-bottom: 0px; width:800px;">
                                <cc1:DataPagerRepeater ID="Repeater1" runat="server">
                                    <HeaderTemplate>
                                    <div>
                                    <center>
    <table><tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        
                              <tr>
                                                
                                                 <td> 
                                                    <div>
                                                    <center>
                                                        <asp:Image runat="server" ImageUrl='<%#"GALLERY" +"\\"+Eval("picname") %>' 
                                                            style=" width : 500px; height : 300px; " ID="image" 
                                                          />
                                                        <center>
                                                            <asp:Label runat="server" Text='<%#Eval("description") %>'></asp:Label>
                                                        </center>
                                                        </center>
                                                        
                                                    </div>
                                                   </td> 
                                               </tr> 
                                          
                                    </ItemTemplate>
                                    <FooterTemplate>
                                  </tr></table>
                                        </center>
                                        </div>
                                    </FooterTemplate>
                                </cc1:DataPagerRepeater>
                                </asp:Panel>
                    </div>
</td>
            </tr>
            <tr>
                <td 
                    style="font-weight: 700; text-align: center; color: #990000; background-color: #545d69;">
                    <asp:Panel ID="navigatepanel" runat="server" Width = "800px">
                        <asp:DataPager ID="DataPager1" runat="server" 
    PagedControlID="Repeater1" PageSize="3">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" 
            ShowFirstPageButton="True" ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </asp:Panel>
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

