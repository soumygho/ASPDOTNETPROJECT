<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 3px solid #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    YOUR NAME:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ForeColor="Lime" Height="21px" 
                        Width="243px"></asp:TextBox>
                    <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox1" 
                        WatermarkText="ENTER YOUR NAME">
                    </cc1:TextBoxWatermarkExtender>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    NO OF TIMES VISITED:
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
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
                    SUBJECT:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" ForeColor="Lime" Height="22px" 
                        Width="242px"></asp:TextBox>
                    <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox2" 
                        WatermarkText="ADD SUBJECT">
                    </cc1:TextBoxWatermarkExtender>
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
                    YOUR MESSAGE:</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" ForeColor="Lime" Height="94px" 
                        TextMode="MultiLine" Width="252px"></asp:TextBox>
                    <cc1:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox3" 
                        WatermarkText="YOUR MESSAGE HERE">
                    </cc1:TextBoxWatermarkExtender>
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
                    <asp:Button ID="Button1" runat="server" Height="27px" onclick="Button1_Click" 
                        Text="POST" Width="105px" />
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
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                &nbsp;আমার বাবার নাম সুজিত কুমার ঘোষ
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
                    COMMENT SECTION</td>
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
                <td colspan="2" rowspan="11">
                    <asp:Repeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                    <table style="background-color: Transparent; border-width:thin; border-color: Red; border-style: solid; color:Blue" width="1300px">
                    <tr>
                    <td colspan="6">COMMENT:</td>
                    <td></td>
                    </tr>
                    <tr></tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                    <table width="400px" style="background-color:White; border-color: Red; border-style:solid; border-width: thin;">
                    <tr>
                    <td><b>SUBJECT:</b></td>
                    <td colspan="4"><asp:Label ID="label1" runat="server" Font-Bold="true" ForeColor="Brown" Text='<%#Eval("SUB") %>'></asp:Label></td>
                    </tr>
                    <tr>
                    <td><b>BODY:</b></td>
                    <td colspan="4"><asp:Label ID="label2" runat="server" Font-Bold="true" ForeColor="Brown" Text='<%#Eval("MESSAGE") %>'></asp:Label></td>
                    </tr>
                    <tr>
                    <td><b>POSTED BY:</b></td>
                    <td colspan="4"><asp:Label ID="label3" runat="server" Font-Bold="true" ForeColor="Brown" Text='<%#Eval("NAME") %>'></asp:Label></td>
                    </tr>
                    <tr></tr>
                    <tr>
                    <td>
                    <b>DATE POSTED:</b>
                    </td>
                    <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="true" ForeColor="Brown" Text='<%#Eval("DATE") %>'></asp:Label>
                    </td>
                    </tr>
                    <tr></tr>
                    </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                    <hr />
                    </SeparatorTemplate>
                    <FooterTemplate>
                    </table>
                    </FooterTemplate>
                    </asp:Repeater>
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
            <tr>
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
