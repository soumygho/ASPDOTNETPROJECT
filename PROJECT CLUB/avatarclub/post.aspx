<%@ Page Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="post.aspx.cs" Inherits="ARTICLE" Title="EMAIL US" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="cc1"%>
<%@ Register Assembly="DataPagerRepeater"  Namespace="DataPagerRepeater"  TagPrefix="cc1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 100%;
        }
        .style6
        {
            height: 31px;
        }
        .style7
        {
            height: 22px;
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
    <table class="style4">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: center; color: #000099; background-color: #FFFFCC">
                EMAIL YOUR QUERY HERE</td>
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
            <td rowspan="17" style="font-weight: 700; text-align: center">
                
                <table class="style5">
                    <tr>
                        <td colspan="3">
                            EMAIL&nbsp; US :</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            ENTER YOUR NAME:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="275px"></asp:TextBox>
                            <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                                runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="NAME">
                            </cc1:TextBoxWatermarkExtender>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
                            ENTER YOUR EMAIL ADDRESS:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="274px"></asp:TextBox>
                            <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                                runat="server" Enabled="True" TargetControlID="TextBox2" 
                                WatermarkText="EMAIL ADDRESS">
                            </cc1:TextBoxWatermarkExtender>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="TextBox2" ErrorMessage="*enter valid address" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            ENTER YOUR QUERY:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Height="117px" TextMode="MultiLine" 
                                Width="270px"></asp:TextBox>
                            <cc1:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" 
                                runat="server" Enabled="True" TargetControlID="TextBox3" 
                                WatermarkText="ENTER YOUR QUIERY">
                            </cc1:TextBoxWatermarkExtender>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="TextBox3" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                        </td>
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
                            <asp:Button ID="Button1" runat="server" style="font-weight: 700" Text="EMAIL US" 
                                onclick="Button1_Click" />
                        </td>
                        <td class="style6">
                            </td>
                        <td class="style6">
                            </td>
                        <td class="style6">
                            </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            </td>
                        <td class="style7">
                            <asp:Label ID="warning" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                        </td>
                        <td class="style7">
                            </td>
                    </tr>
                    </table>
                
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
        </tr>
        <tr>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
        </tr>
        </table>
        </center>
</div>
</asp:Content>

