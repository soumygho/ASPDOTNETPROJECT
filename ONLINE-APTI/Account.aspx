<%@ Page Language="C#" MasterPageFile="~/HOME.master" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            height: 21px;
            font-weight: bold;
            color: #FF3300;
            font-size: large;
            text-align: center;
            background-color: #FFFFCC;
        }
        .style5
        {
            color: #993300;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style3">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center; font-weight: 700; font-size: x-large">
                <span class="style5">Hi</span>
                <asp:Label ID="Label1" runat="server" Text="Label" style="color: #FF0000"></asp:Label>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    style="font-weight: 700; color: #FFFFFF; background-color: #990000" 
                    Text="SHOW" />
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Select.aspx" 
                    style="font-weight: 700; color: #FF3300">TAKE 
                A TEST</asp:LinkButton>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="background-color: #FFFFFF">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server">
                    <table class="style3">
                        <tr>
                            <td class="style4" colspan="2">
                                RECENT EXAMS AND SCORES</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td style="text-align: center">
                                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                    style="font-weight: 700; color: #FFFFFF; background-color: #990000" 
                                    Text="HIDE THIS" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" 
                                
                                style="font-weight: 700; color: #FF3300; background-color: #FFCC99; text-align: center;">
                                <asp:Repeater ID="Repeater1" runat="server" 
                                    onitemcommand="Repeater1_ItemCommand">
                                    <ItemTemplate>
                                    <h5><b>DATE</b></h5>
                                    <asp:label id="Label1" runat ="server" Text ='<%#Eval("date") %>'></asp:Label>
                                    <h5><b>NO OF RIGHT ANSWER GIVEN:-</b></h5>
                                    <asp:Label ID = "Label2" runat ="server" Text ='<%#Eval("rightans") %>'> </asp:Label>
                                    <h5><b>NO OF WRONG ANSWER GIVEN:-</b></h5>
                                    <asp:Label ID = "Label3" runat ="server" Text ='<%#Eval("wrongans") %>'> </asp:Label>
                                    <h5><b>SCORE:-</b></h5>
                                    <asp:Label ID = "Label4" runat ="server" Text ='<%#Eval("score") %>'> </asp:Label>
                                    <h5><b>TOTAL NO OF QUESTIONS:-</b></h5>
                                    <asp:Label ID = "Label6" runat ="server" Text ='<%#Eval("total") %>'> </asp:Label>
                                    <h5><b>PERCENTAGE:-</b></h5>
                                    <asp:Label ID = "Label7" runat ="server" Text ='<%#Eval("per") %>'> </asp:Label>
                                    <h5><b>TIME TAKEN:-</b></h5>
                                    <asp:Label ID = "Label8" runat ="server" Text ='<%#Eval("time") %>'> </asp:Label>
                                    </ItemTemplate>
                                    <SeparatorTemplate>
                                    <br />-----------------------------------------------------------------------<br />
                                    </SeparatorTemplate>
                                </asp:Repeater>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center; font-weight: 700;">
                <asp:Label ID="Label5" runat="server" style="font-weight: 700; color: #FF3300" 
                    Text="Label"></asp:Label>
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
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
                    style="font-weight: 700; color: #FF3300">LOGOUT&gt;&gt;</asp:LinkButton>
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
    </table>
</asp:Content>

