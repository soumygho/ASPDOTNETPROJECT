
<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="chat.aspx.cs" Inherits="chat" %>

<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
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
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td>
                    <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Height="466px" 
                        Width="580px">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick" Interval="2000">
                                </asp:Timer>
                                <asp:Panel ID="Panel2" runat="server" style="font-weight: 700">
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
                                                        <td>
                                                            <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Senderprofimgurl")) %>' Width="60px" />
                    <asp:HyperLink ID="profLink" runat="server" 
                                                                NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Senderid"))%>' 
                                                                Text='<%#Eval("SenaderName") %>'></asp:HyperLink>
                                                        </td>
                                                        <td>
                                                            
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                    <td>
                                                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Message") %>'></asp:Label>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    </tr>
                                                    <tr>
                                                    <td>
                                                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Chatdate") %>'></asp:Label>
                                                    </td>
                                                    <td>
                                                    </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </ItemTemplate>
                                    </cc1:DataPagerRepeater>
                                </asp:Panel>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </asp:Panel>
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
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="54px" TextMode="MultiLine" 
                        Width="587px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SEND" />
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
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>

</asp:Content>




