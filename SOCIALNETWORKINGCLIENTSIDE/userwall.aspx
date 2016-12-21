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
            height: 178px;
        }
        .style4
        {
            width: 141px;
            height: 178px;
        }
        .style5
        {
            width: 44px;
        }
        .style6
        {
            width: 99px;
        }
        .style7
        {
            height: 178px;
            width: 99px;
        }
    </style>
</head>
<body text="#000066">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" style="background-color: #E9EAED">
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                </td>
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
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    
                </td>
                <td>
                    <asp:HyperLink ID="ownLink" runat="server" ></asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="Button" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                </td>
                <td class="style4">
                    <asp:Image ID="Image1" runat="server" Height="174px" Width="215px" />
                </td>
                <td class="style3" colspan="4">
                    <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="1" 
                        Height="136px" Width="1000px">
                        <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="TabPanel1">
                            <ContentTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Height="52px" TextMode="MultiLine" 
                                    Width="848px"></asp:TextBox>
                                <asp:Label ID="LabelMsg" runat="server" Text="Label"></asp:Label>
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
                                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                <br />
                                &nbsp;<br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="POST" onclick="Button2_Click" />
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
                <td class="style6">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Panel ID="Panel3" runat="server" Height="834px">
                        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">EDIT USERDETAILS</asp:LinkButton>
                        <br />
                        <br />
                        <asp:LinkButton ID="LinkButton3" runat="server">VIEW OWN PROFILE</asp:LinkButton>
                        <br />
                        <br />
                        CHANGE PROFILE PIC<br />
                        <asp:FileUpload ID="FileUpload2" runat="server" Height="23px" Width="215px" />
                        <br />
                        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
                            Text="CHANGE PROFILE PIC" />
                        <br />
                        <br />
                        <br />
                        <div>
                        <strong>
                        FRIEND SUGGETION
                        </strong>
                        </div>
                        <div>
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <asp:Panel ID="Panel4" runat="server" Height="300px" ScrollBars="Vertical" 
                                        Width="210px">
                                    <cc1:DataPagerRepeater ID="friendSuggetionRepeater" runat="server" PersistentDataSource="true">
                                    <ItemTemplate>
                                    <div style="border-style:solid;border-width:thin;">
                                    <div>
                                    <asp:Image ID="faceImage" runat ="server" Height="40px" Width="40px" />
                                    </div>
                                    <div>
                                        <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
                                    </div>
                                    
                                    <div>
                                        <asp:Label ID="Label5" runat="server" Text="No of mutual friend :"></asp:Label><asp:Label
                                            ID="Label6" runat="server" Text="Label"></asp:Label>
                                    </div>
                                    
                                    <div>
                                        <asp:LinkButton ID="LinkButton5" runat="server">VIEW DETAILS</asp:LinkButton>
                                    </div>
                                    </div>
                                    </ItemTemplate>
                                    <SeparatorTemplate>
                                    <br />
                                    <br />
                                    </SeparatorTemplate>
                                    </cc1:DataPagerRepeater>
                                    <div><center><b>NEW MESSAGES</b></center></div>
                                     <cc1:DataPagerRepeater ID="DataPagerRepeater4" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Senderprofimgurl")) %>' /></td>
                                <td><asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/chat.aspx?uid={0}",Eval("Senderid"))%>' Text='<%#Eval("SenaderName") %>' ></asp:HyperLink></td>
                                </tr>
                                </table>
                                </div>
                                </ItemTemplate>
                                </cc1:DataPagerRepeater>
                                    </asp:Panel>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </asp:Panel>
                </td>
                <td colspan="4">
                <table>
                <tr>
                <td>
                
                    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        ScrollBars="Vertical" Width="600px" Height="850px">
                    <div><center> <b>POSTS</b></center></div>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                        <asp:Timer ID="Timer1" runat="server" Interval="6000" ontick="Timer1_Tick">
                    </asp:Timer>
                            <cc1:DataPagerRepeater ID="DataPagerRepeater1" runat="server" 
                                PersistentDataSource="true" onitemcommand="DataPagerRepeater1_ItemCommand" 
                                onitemdatabound="DataPagerRepeater1_ItemDataBound">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
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
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    </asp:Panel>
                    
                </td>
                <td class="style5">
                </td>
                <td>
                <table>
                <tr>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Width="333px" Height="244px" 
                        ScrollBars="Vertical">
                    <div>
                    <center><b>YOUR NOTIFICATIONS</b></center>
                    </div>
                    <div>
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Timer ID="Timer4" runat="server" Interval="3000" ontick="Timer4_Tick">
                            </asp:Timer>
                         <asp:Panel ID="Panel7" runat="server" Height="223px" BackColor="White" 
                                BorderColor="#000066" BorderStyle="Solid" BorderWidth="1px">
                          <cc1:DataPagerRepeater ID="DataPagerRepeater5" runat="server" 
                                PersistentDataSource="true" 
                                 onitemdatabound="DataPagerRepeater5_ItemDataBound">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:HyperLink runat="server" ID="profLink"  Text='<%#Eval("Notificationtext") %>' ></asp:HyperLink></td>
                                <td></td>
                                </tr>
                                </table>
                                </div>
                                </ItemTemplate>
                                </cc1:DataPagerRepeater>
                        </asp:Panel>
                        </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="Timer4" EventName="Tick" />
                            </Triggers>
                        </asp:UpdatePanel>
                       
                    </div>
                    </asp:Panel>
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Panel ID="Panel5" runat="server" Height="236px" ScrollBars="Vertical">
                    <div>
                    <div>
                    <center><b>ONLINE FRIENDS</b></center>
                    </div>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                        <asp:Timer ID="Timer3" runat="server">
                                </asp:Timer>
                            <asp:Panel ID="Panel8" runat="server" Height="218px" ScrollBars="Vertical" width="333px"
                                BackColor="White" BorderColor="#000066" BorderStyle="Solid" 
                                BorderWidth="1px" >
                                <cc1:DataPagerRepeater ID="DataPagerRepeater3" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Profimgurl")) %>' /></td>
                                <td><asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/chat.aspx?uid={0}",Eval("Profid"))%>' Text='<%#Eval("Name") %>' ></asp:HyperLink></td>
                                </tr>
                                </table>
                                </div>
                                </ItemTemplate>
                                </cc1:DataPagerRepeater>
                            </asp:Panel>
                        </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    </asp:Panel>
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Panel ID="Panel6" runat="server" Height="350px" Width="333px" 
                        ScrollBars="Vertical">
                    <div>
                    <center>
                    <div>
                        <i><b>FRIEND REQUESTS </b></i>
                    </div>
                        
                        
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <asp:Timer ID="Timer2" runat="server" ontick="Timer2_Tick">
                                </asp:Timer>
                            
                            <asp:Panel ID="Panel9" runat="server" Height="97px" style="height: 240px" 
                                Width="333px" BackColor="White" BorderColor="#000066" BorderStyle="Solid">
                               
                                
                               <cc1:DataPagerRepeater ID="DataPagerRepeater2" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Profimgurl")) %>' /></td>
                                <td><asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Profid"))%>' Text='<%#Eval("Name") %>' ></asp:HyperLink></td>
                                </tr>
                                </table>
                                </div>
                                </ItemTemplate>
                                </cc1:DataPagerRepeater>
                                
                            </asp:Panel>
                            
                            
                        </ContentTemplate>
                        </asp:UpdatePanel>
                        </center>
                    </div>
                    </asp:Panel>
                </td>
                </tr>
                </table>
                </td>
                </tr>
                </table>
                    
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
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
                <td class="style6">
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
                <td class="style6">
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
