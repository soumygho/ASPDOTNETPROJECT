<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="postdetails.aspx.cs" Inherits="postdetails" %>


<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-style: italic;
            font-weight: bold;
            text-decoration: underline;
        }
        .style3
        {
            color: #000066;
            background-color: #FFFFFF;
        }
        .style4
        {
            font-style: italic;
            font-weight: bold;
            text-decoration: underline;
            color: #000066;
        }
    .style6
    {
        width: 619px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style6">
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
                <td class="style6">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
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
                <td class="style6">
                            <cc1:DataPagerRepeater ID="DataPagerRepeater1" runat="server" 
                                PersistentDataSource="true" onitemcommand="DataPagerRepeater1_ItemCommand" 
                                onitemdatabound="DataPagerRepeater1_ItemDataBound">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="text-align: center; border: thin solid #000066;background-color :White;">
                                <div>
                                <table>
                                <tr>
                                <td>
                                <asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Imgurl")) %>' />
                    </td>
                    <td>
                                <asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("UserId"))%>' Text='<%#Eval("ProfName") %>' ></asp:HyperLink>
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
                                <div>
                                    <asp:Label ID="CaptionLabel" runat="server" 
                                        Text = '<%#Eval("Postcaption") %>'></asp:Label></div>
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
                        </td>
                <td>
                <div>
                <center class="style4" style="border: thin solid #000000">
                LIKE DETAILS
                </center>
                </div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="Panel1" runat="server"  ScrollBars="Vertical" Width="318px">
                        <cc1:DataPagerRepeater ID="DataPagerRepeater3" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div>
                                <asp:Image ID="Image2" runat="server" Height="30px" Width="30px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Imgurl")) %>' />
                                    <asp:HyperLink ID="HyperLink2" runat="server" Text='<%#Eval("Profname") %>' NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Profid"))%>'></asp:HyperLink>
                                </div>
                                </ItemTemplate>
                                
                                <SeparatorTemplate>
                                <br />
                                </SeparatorTemplate>
                                </cc1:DataPagerRepeater>
                        </asp:Panel>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="padding: inherit; margin: auto; border: thin solid #000000" 
                    class="style6">
                <div>
                <center style="font-weight: 700; font-style: italic; text-decoration: underline; color: #000066">
                COMMENT DETAILS
                </center>
                </div>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick">
                        </asp:Timer>
                        <asp:Panel ID="Panel2" runat="server" ScrollBars="Vertical" Height="280px">
                   <cc1:DataPagerRepeater ID="DataPagerRepeater2" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border-color:Blue;border-style:solid;border-width:thin;">
                                <table>
                                <tr><td><asp:Image ID="Image2" runat="server" Height="30px" Width="30px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Imgurl")) %>' />
                    <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("Profname") %>' NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Profid"))%>'></asp:HyperLink>
                    </td>
                    <td>
                    
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Comment") %>'></asp:Label>
                    </td>
                    <td>
                    </td>
                    </tr>
                    <tr>
                    <td>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Commentdate") %>'></asp:Label>
                    </td>
                    <td>
                    </td>
                    </tr>
                                
                                    
                                    
                                    
                                    </table>
                                    </div>
                                </ItemTemplate>
                                <FooterTemplate>
                                
                                </FooterTemplate>
                                
                                <SeparatorTemplate>
                                <br />
                                </SeparatorTemplate>
                                </cc1:DataPagerRepeater>
                                </asp:Panel>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                    </Triggers>
                                </asp:UpdatePanel>
                                <div>
                                <center class="style2" style="border: thin solid #000000">
                                    <span class="style3">COMMENT HERE
                                </span>
                                </center>
                                </div>
                                <div>
                                
                                    <asp:TextBox ID="TextBox1" runat="server" Height="88px" TextMode="MultiLine" 
                                        Width="511px"></asp:TextBox><asp:Button ID="Button1"
                                        runat="server" Text="SUBMIT" 
                                        style="font-weight: 700; font-style: italic; text-decoration: underline" 
                                        onclick="Button1_Click" />
                                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                </div>
                                </td>
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
                <td class="style6">
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
                <td class="style6">
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
                <td class="style6">
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
                <td class="style6">
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
                <td class="style6">
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
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    
</asp:Content>

    

