<%@ Page Language="C#" MasterPageFile="~/HOME.master" AutoEventWireup="true" CodeFile="optional_main.aspx.cs" Inherits="optional_main" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            height: 26px;
        }
        .style4
        {
            color: #000066;
            font-weight: 700;
        }
        .style5
        {
            color: #000099;
        }
        .style6
        {
            height: 23px;
        }
        .style7
        {
            color: #000099;
        }
        .style8
        {
            width: 17px;
        }
        .style9
        {
            height: 37px;
        }
        .style10
        {
            width: 17px;
            height: 37px;
        }
        .style11
        {
            width: 8px;
        }
        .style12
        {
            width: 8px;
            height: 23px;
        }
        .style13
        {
            font-size: large;
            font-weight: bold;
            color: #000099;
        }
        .style14
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style3">
        <tr>
            <td class="style9">
                </td>
            <td class="style9">
                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                </td>
            <td class="style9">
                </td>
            <td style="text-align: center; color: #000099; background-color: #FFFFFF; font-weight: 700;" 
                class="style9">
                <asp:UpdatePanel ID="UpdatePanel7" runat="server">
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                </Triggers>
                    <ContentTemplate>
                        DATE :-&nbsp;
                        <asp:Label ID="Label7" runat="server" 
    style="font-size: large; color: #FF3300" Text="Label"></asp:Label>
                        &nbsp;&nbsp;&nbsp; TIME :-&nbsp;
                        <asp:Label ID="Label8" runat="server" 
    style="color: #FF3300" Text="Label"></asp:Label>
                        &nbsp;&nbsp;
                    </ContentTemplate>
                </asp:UpdatePanel>
                </td>
            <td style="text-align: center; background-color: #FFFFFF" class="style10">
                        <asp:Timer ID="Timer2" Interval="1000" runat="server" ontick="Timer2_Tick">
                        </asp:Timer>
                    </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
            <td class="style9">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center; background-color: #33CCFF" class="style13">
                SELECT QUESTION NO :-</td>
            <td style="text-align: center; background-color: #00FFFF" class="style8">
                        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
                            BackColor="#CCFFCC" Font-Bold="True" Font-Size="Large" 
                            onselectedindexchanged="ListBox1_SelectedIndexChanged" 
                    Width="214px" ForeColor="Maroon">
                        </asp:ListBox>
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
            <td colspan="2" rowspan="12">
                <asp:Panel ID="Panel1" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                            <table runat="server" class="style3">
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td class="style5" 
                                        style="text-align: center; background-color: #00FFFF; font-weight: 700;">
                                        <span class="style14">QUESTION LEFT</span><span class="style14"> :- </span>&nbsp;&nbsp;
                                        <asp:Label ID="Label9" runat="server" 
                                            style="color: #FF3300; font-size: x-large" Text="Label"></asp:Label>
                                    </td>
                                    <td class="style11">
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
                                    <td style="color: #00FFFF">
                                        <table class="style3">
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                                <td style="text-align: center; background-color: #00FFFF">
                                                    &nbsp;<span class="style4">QUESTION NO :-</span> :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                                                        style="color: #000099" Text="Label"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td class="style11">
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
                                    <td style="color: #000066; text-align: center; background-color: #00FFFF">
                                        <b>QUESTION :-&nbsp;</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" 
                                            Text="Label"></asp:Label>
                                    </td>
                                    <td class="style11">
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
                                    <td class="style11">
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
                                    <td style="text-align: center; background-color: #66FFFF;">
                                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                                            GroupName="radio" oncheckedchanged="RadioButton1_CheckedChanged" 
                                            style="font-weight: 700; color: #003399; font-size: large" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                                            GroupName="radio" oncheckedchanged="RadioButton2_CheckedChanged" 
                                            style="font-weight: 700; color: #000099; font-size: large" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" 
                                            GroupName="radio" oncheckedchanged="RadioButton3_CheckedChanged" 
                                            style="font-weight: 700; color: #000099; font-size: large" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" 
                                            GroupName="radio" oncheckedchanged="RadioButton4_CheckedChanged" 
                                            style="font-weight: 700; color: #000099; font-size: large" />
                                    </td>
                                    <td class="style11">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                    </td>
                                    <td class="style12">
                                    </td>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td style="text-align: center">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                                    <td class="style11">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
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
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
            <td style="text-align: center" class="style8">
                                    <asp:Timer ID="Timer1" runat="server" Interval="1000" 
                    ontick="Timer1_Tick">
                                    </asp:Timer>
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
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel4" UpdateMode= "Conditional" runat="server">
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick"/>
                </Triggers>
                    <ContentTemplate>
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" 
                                            ForeColor="#000066" onclick="Button1_Click" 
                            Text="Submit" style="color: #FFFFFF; background-color: #800000" />
                        &nbsp;<asp:Button ID="Button2" runat="server" ForeColor="#000099" 
                            
                            style="font-weight: 700; font-size: large; color: #FFFFFF; background-color: #990000;" Text="Show Result&gt;&gt;" 
                            onclick="Button2_Click" />
                        &nbsp;<asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="True" 
                            Font-Size="Medium" ForeColor="Red"></asp:Label>
                        &nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td class="style8">
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
                    <ContentTemplate>
                        <table class="style3">
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td class="style7">
                                    <b style="text-align: center">YOUR TOTAL TIME LEFT :</b></td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td style="text-align: center">
                                    <asp:Label ID="Label3" runat="server" 
                                        style="font-weight: 700; font-size: large; color: #FF0000" Text="Label"></asp:Label>
                                </td>
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
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
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
            <td style="text-align: center">
                <asp:UpdatePanel ID="UpdatePanel8" runat="server">
                    <ContentTemplate>
                        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                            style="font-size: large; font-weight: 700; color: #FFFFFF; background-color: #990000" 
                            Text="Give Up&gt;&gt;" />
                    </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID = "Timer1"  EventName="Tick"/>
                </Triggers>
                </asp:UpdatePanel>
            </td>
            <td class="style8">
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
                &nbsp;</td>
            <td class="style8">
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
            <td class="style8">
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
            <td class="style8">
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
</asp:Content>

