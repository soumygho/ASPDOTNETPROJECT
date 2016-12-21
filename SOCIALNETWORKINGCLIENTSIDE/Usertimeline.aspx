<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="Usertimeline.aspx.cs" Inherits="Usertimeline" %>
<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 207px;
        }
        .style2
        {
            width: 163px;
            text-align: right;
        }
        .style4
        {
            font-weight: bold;
            font-style: italic;
            color: #000066;
        }
        .style5
        {
            color: #000066;
        }
        .style12
        {
            width: 603px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style12">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
            </tr>
            <tr>
                <td class="style12">
                </td>
            </tr>
            <tr>
                <td class="style12">
                    
                        <table class="style1">
                            <tr>
                                <td>
                                                       <asp:Image ID="Image1" runat="server" 
    Height="185px" style="margin-left: 54px" 
                                        Width="161px" />
                
                                    &nbsp;<asp:HyperLink ID="HyperLink1" runat="server">VIEW DETAILS</asp:HyperLink>
                                &nbsp;&nbsp;&nbsp;
                                                       <asp:LinkButton ID="LinkButton9" runat="server">VIEW FRIEND LIST</asp:LinkButton>
                                </td>
                                <td rowspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="style5"><i><b>&nbsp;&nbsp;<asp:Button ID="addfriend" runat="server" 
                                        CssClass="style4" onclick="Button1_Click" Text="ADD FRIEND" />
                                    &nbsp;&nbsp; </b></i></span>
                                    <asp:Button ID="unfriend" runat="server" Text="UNFRIEND" CssClass="style4" 
                                        onclick="Button2_Click" />
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="message" runat="server" 
                                        style="font-weight: 700; font-style: italic; color: #000066" 
                                        Text="MESSAGE" onclick="message_Click" />
                                    &nbsp;&nbsp;<asp:Button ID="ignore" runat="server" 
                                        style="font-weight: 700; font-style: italic; color: #000066" 
                                        Text="IGNORE REQUEST" onclick="ignore_Click" />
                                </td>
                            </tr>
                        </table>
                  
                </td>
            </tr>
            <tr>
                <td class="style12">
                    <asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        ScrollBars="Vertical" Width="600px" Height="850px">
                    <div><center> <b style="font-family: 'Adobe Caslon Pro Bold'">POSTS</b></center></div>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Timer runat="server" ontick="Unnamed1_Tick" ID="timer1">
                            </asp:Timer>
                            <asp:Panel ID="Panel" runat="server">
                            <cc1:DataPagerRepeater ID="DataPagerRepeater1" runat="server" 
                                PersistentDataSource="true" onitemcommand="DataPagerRepeater1_ItemCommand" 
                                onitemdatabound="DataPagerRepeater1_ItemDataBound">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style=" border: thin solid #000066;background-color :White;">
                                <div>
                                <table>
                                <tr>
                                <td>
                                <asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Imgurl")) %>' />
                    <asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("UserId"))%>' Text='<%#Eval("ProfName") %>' ></asp:HyperLink>
                               
                    </td>
                    <td>
                              </td>   
                                <td>
                                <strong>SHARES THIS POST</strong>
                                 </td>
                                </tr>
                                </table>
                                <div>
                                <table>
                                <tr>
                                <td>Date : <%#Eval("PostDate") %></td>
                                <td>Time : </td>
                                </tr>
                                </table>
                                </div>
                                <div><asp:Label ID="CaptionLabel" runat="server" Text = '<%#Eval("Postcaption") %>'></asp:Label></div>
                                <div>
                                    <asp:Image ID="postImage" runat="server" ImageUrl = '<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Postimageurl")) %>'  Width="550px" Height="250px"/>
                                 </div>
                                    
                                    <div>
                                    
                                    <asp:HyperLink ID="postLink" runat="server" NavigateUrl ='<%#Eval("Postlink") %>'>GOOGLE</asp:HyperLink>
                                    </div>
                                    <div>
                                       <asp:LinkButton ID="LinkButton6" runat="server" CommandName="like">LIKE</asp:LinkButton>&nbsp;&nbsp;
                                        <asp:LinkButton ID="LinkButton7" runat="server" CommandName="share">SHARE</asp:LinkButton>&nbsp;&nbsp;
                                        <asp:LinkButton ID="LinkButton8" runat="server" CommandName = "comment">COMMENT</asp:LinkButton>
                                        
                                        </div>
                                        <div>
                                        <b>
                                        <asp:Label ID="likeCountLabel" runat="server" Text='<%#Eval("Nooflikes") %>'></asp:Label>
                                        <asp:Label ID="Label1" runat="server" Text="People like this"></asp:Label>
                                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Noofcomments") %>'></asp:Label>
                                        <asp:Label ID="Label4" runat="server" Text="People commented on this"></asp:Label>
                                        </b>
                                        </div>
                                        <div>
                                        <asp:HyperLink ID="showDetailsLink" runat="server" NavigateUrl='<%#string.Format("~/postdetails.aspx?pid={0}&uid={1}",Eval("Postid"),Eval("UserId"))%>'>SHOW DETAILS</asp:HyperLink>
                                         <asp:HiddenField ID="postid" runat="server" Value='<%#Eval("Postid") %>' />
                                            <asp:HiddenField ID="userid" runat="server" Value='<%#Eval("UserId") %>' />
                                    </div>
                                </div>
                                </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                
                                </FooterTemplate>
                                <SeparatorTemplate>
                                <div >
                                <br />
                               
                                </div>
                                </SeparatorTemplate>
                            </cc1:DataPagerRepeater>
                            </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>
                    
                </td>
            </tr>
            <tr>
                <td class="style12">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>

</asp:Content>



