<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userwall.aspx.cs" Inherits="userwall" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 141px;
        }
        .style3
        {
            height: 149px;
        }
        .style4
        {
            width: 141px;
            height: 149px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                </td>
                <td class="style2">
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
                <td class="style3">
                </td>
                <td class="style4">
                    <asp:Image ID="Image1" runat="server" Height="174px" Width="136px" 
                        ImageUrl="~/USER/15/image/1.jpg" />
                </td>
                <td class="style3" colspan="4">
                    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
                        Height="136px" Width="904px">
                        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Height="52px" TextMode="MultiLine" 
                                    Width="1076px"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="POST" onclick="Button1_Click" />
                                <br />
                            </ContentTemplate>
                            <HeaderTemplate>
                                ADD NEW POST
                            </HeaderTemplate>
                        </asp:TabPanel>
                        <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                            <ContentTemplate>
                                ENTER CAPTION
                                <asp:TextBox ID="TextBox2" runat="server" Height="32px" TextMode="MultiLine" 
                                    Width="751px"></asp:TextBox>
                                <br />
                                <br />
                                SELECT PICTURE
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <br />
                                &nbsp;<br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="POST" />
                            </ContentTemplate>
                            <HeaderTemplate>
                                ADD NEW PHOTO WITH CAPTION
                            </HeaderTemplate>
                        </asp:TabPanel>
                    </asp:TabContainer>
                    
                </td>
                <td class="style3">
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td colspan="4">
                    
                    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        ScrollBars="Vertical" Width="904px">
                    <div>RECENT POSTS</div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <cc1:DataPagerRepeater ID="DataPagerRepeater1" runat="server" 
                                PersistentDataSource="true" onitemcommand="DataPagerRepeater1_ItemCommand" 
                                onitemdatabound="DataPagerRepeater1_ItemDataBound">
                                <HeaderTemplate>
                                <div style = " background-color : Gray">
                                TODAY'S POST MADE BY ALL YOUR FRIENDS
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="background-color : Aqua">
                                <strong><%#Eval("name") %> SHARES THIS POST</strong>
                                <div>
                                <table>
                                <tr>
                                <td>Date : <%#Eval("posteddate") %></td>
                                <td>Time : <%#Eval("postedtime") %></td>
                                </tr>
                                </table>
                                </div>
                                <table>
                                <tr>
                                <td>
                                    <asp:Image ID="Image2" runat="server" ImageUrl = '<%#Eval("imgUrl") %>' />
                                    </td>
                                    <td>
                                    </td>
                                    </tr>
                                 <tr>
                                 <td>
                                    <asp:Label ID="Label1" runat="server" Text = '<%#Eval("posttext") %>'></asp:Label>
                                    </td>
                                    <td>
                                    </td>
                                    </tr>
                                    <tr>
                                    <td>
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl ='<%#Eval("url") %>' Text='<%#Eval("text") %>'></asp:HyperLink>
                                    </td>
                                    <td>
                                    </td>
                                    </tr>
                                    <tr>
                                    <div>
                                        <asp:Button ID="Button3" runat="server" Text ="LIKE THIS POST" />
                                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("likeCount") %>'></asp:Label>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#Eval("posturl") %>'>SHOW DETAILS</asp:HyperLink>
                                    </div>
                                    </table>
                                </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                
                                </FooterTemplate>
                                <SeparatorTemplate>
                                <div style = " background-color : Gray">
                                <br />
                               
                                </div>
                                </SeparatorTemplate>
                            </cc1:DataPagerRepeater>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    </asp:Panel>
                    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style2">
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
                <td>
                    &nbsp;</td>
                <td class="style2">
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
                <td>
                    &nbsp;</td>
                <td class="style2">
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
    
    </div>
    </form>
</body>
</html>
