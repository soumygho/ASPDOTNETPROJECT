<%@ Page Language="C#" MasterPageFile="~/HOME.master" AutoEventWireup="true" CodeFile="ONLINETEST.aspx.cs" Inherits="ONLINETEST" Title="Untitled Page" %>

<%@ Register assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            color: #000099;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" bgcolor="White">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="font-weight: 700; text-align: center" bgcolor="#66FFFF">
            QUESTION NO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#0000CC" 
                style="font-size: x-large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td bgcolor="#FF66FF">
            <asp:Timer ID="Timer1" OnTick="Timer1_Tick" runat="server" Interval="1000">
            </asp:Timer>
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
            &nbsp;</td>
        <td bgcolor="#66FFFF">
            &nbsp;</td>
        <td style="text-align: center" bgcolor="#FF66CC">
            <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional" runat="server">
            <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
                <ContentTemplate>
                    <asp:Label ID="Label7" runat="server" 
                        style="font-weight: 700; font-size: x-large" Text="TIME :"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" 
                        style="font-weight: 700; font-size: x-large" Text="Label"></asp:Label>
                    &nbsp;<asp:Label ID="Label8" runat="server" 
                        style="font-weight: 700; font-size: large" Text="Sec"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
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
            &nbsp;</td>
        <td style="font-weight: 700; text-align: center" bgcolor="#66FFFF">
            <asp:Label ID="Label6" runat="server" ForeColor="#000066" Text="Label"></asp:Label>
&nbsp;:
            <asp:Label ID="Label4" runat="server" Text="Label" ForeColor="#CC0099" 
                style="font-size: large"></asp:Label>
        </td>
        <td style="font-weight: 700; text-align: center" bgcolor="#FF33CC">
            <asp:Label ID="Label9" runat="server" ForeColor="#000099" 
                Text="QUESTION LEFT&nbsp;&nbsp;"></asp:Label>
            <span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;
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
            &nbsp;</td>
        <td style="text-align: center" bgcolor="#66FFFF">
            <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" 
                style="font-weight: 700" GroupName="answer" ValidationGroup="ans" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="Red" 
                style="font-weight: 700" GroupName="answer" ValidationGroup="ans" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton3" runat="server" ForeColor="Red" 
                style="font-weight: 700" GroupName="answer" ValidationGroup="ans" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" ForeColor="Red" 
                style="font-weight: 700" GroupName="answer" ValidationGroup="ans" />
        </td>
        <td style="text-align: center" bgcolor="Fuchsia">
            <asp:Label ID="Label3" runat="server" Text="Label" 
                style="font-weight: 700; font-size: x-large"></asp:Label>
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
            &nbsp;</td>
        <td bgcolor="Aqua">
            &nbsp;</td>
        <td bgcolor="#FF0066" style="text-align: center">
            <asp:Label ID="Label10" runat="server" 
                style="font-weight: 700; font-size: large" Text="YOUR TOTAL TIME LEFT :"></asp:Label>
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
            &nbsp;</td>
        <td bgcolor="Aqua">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:UpdatePanel 
                ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1"  EventName="Tick"/>
                </Triggers>
                <ContentTemplate>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                        ID="Button1" runat="server" 
                        Text="Submit" ForeColor="Maroon" 
                        style="font-weight: 700; font-size: large" onclick="Button1_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Skip" ForeColor="#990000" 
                        onclick="Button2_Click" style="font-weight: 700; font-size: large" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                        style="font-weight: 700; font-size: medium; color: #800000" 
                        Text="UNATTEMPTED" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label13" runat="server" ForeColor="Red" 
                        Text="YOU WILL NOT BE ABLE TO SKIP THIS LAST QUESTION "></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td bgcolor="#CC0066" style="text-align: center">
            &nbsp;<asp:UpdatePanel ID="UpdatePanel3" UpdateMode = "Conditional" runat="server">
            <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
                <ContentTemplate>
                    <asp:Label ID="Label11" runat="server" ForeColor="Maroon" 
    style="text-align: center; font-weight: 700; font-size: x-large" Text="Label"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label12" runat="server" ForeColor="#000066" 
                        style="font-weight: 700; font-size: x-large" Text="Sec"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
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
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
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
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
                    <asp:ScriptManager ID="ScriptManager2" EnablePageMethods="true" runat="server">
                    </asp:ScriptManager>
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
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td style="text-align: center">
            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
                PostBackUrl="~/HOMEPAGE.aspx">LOG 
            OUT</asp:LinkButton>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

