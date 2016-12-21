<%@ Page Title="QUERY HERE" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="query.aspx.cs" Inherits="query"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            background-color: #E6E6FA;
        }
        .style4
        {
            height: 27px;
        }
           #content_data
{
    height:480px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content_data">
<center>
    <table>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: center">
                PLEASE ENTER YOUR NAME AND ID TO QUERY ABOUT YOUR MEMBERSHIP&nbsp;
                <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </cc1:ToolkitScriptManager>
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
            <td style="font-weight: 700; text-align: center">
                ENTER YOUR NAME&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="namequery" runat="server" Width="250px"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="namequery_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="namequery" 
                    WatermarkText="ENTER YOUR NAME">
                </cc1:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="namequery" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
            <td style="font-weight: 700; text-align: center">
                ENTER YOUR ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="idquery" runat="server" Width="250px" 
                    ontextchanged="TextBox2_TextChanged"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="idquery_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="idquery" 
                    WatermarkText="ENTER YOUR ID">
                </cc1:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="idquery" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
            <td style="text-align: center">
                <asp:Button ID="Submit" runat="server" Text="Submit" onclick="Submit_Click" />
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
            <td style="text-align: center">
                <asp:Label ID="Label1" runat="server" style="color: #FF3300" Text="Label"></asp:Label>
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
                <asp:Panel ID="Panel1" runat="server">
                    <table class="style2">
                        <tr>
                            <td colspan="7" style="font-weight: 700; text-align: center">
                                MEMBERSHIP DETAILS</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                NAME</td>
                            <td>
                                <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td colspan="3" rowspan="8">
                                <asp:Image ID="passport" runat="server" Height="213px" 
                                    ImageUrl="~/picture/.jpg" Width="187px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                DOB</td>
                            <td>
                                <asp:Label ID="dob" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                MOBILE NO</td>
                            <td>
                                <asp:Label ID="mobno" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                EMAIL ID</td>
                            <td>
                                <asp:Label ID="email" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                RATION CARD NO/VOTER ID</td>
                            <td>
                                <asp:Label ID="rationcardno" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                </td>
                            <td class="style4">
                                </td>
                            <td style="font-weight: 700" class="style4">
                                PAN</td>
                            <td class="style4">
                                <asp:Label ID="pan" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                STATUS</td>
                            <td>
                                <asp:Label ID="status1" runat="server" Text="Label" style="font-weight: 700"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                DATE OF SUBMISSION</td>
                            <td>
                                <asp:Label ID="date" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td style="font-weight: 700">
                                ID</td>
                            <td>
                                <asp:Label ID="id" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
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
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center; color: #FF0000">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </center></div>
</asp:Content>

