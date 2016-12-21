<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="formprocess" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 100%;
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
                    &nbsp;</td>
                <td>
                    &nbsp;</t&nbsp;</td>
                <td>
                <center>
                    <h1>
                        LOGIN OR SIGNUP</h1></center>
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
                  <center> <i><b>LOGIN HERE :</b></i></center> </td>
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
                <td style="font-weight: 700; font-style: italic">
                    USERNAME&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Width="228px"></asp:TextBox>
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
                <td style="font-weight: 700; font-style: italic">
                    PASSWORD&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Width="225px"></asp:TextBox>
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
                <td style="font-weight: 700; font-style: italic">
                    <asp:Button ID="Button1" runat="server" Text="LOGIN" />
&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="CANCEL" />
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
                <td style="font-weight: 700; font-style: italic">
                <center>
                    SIGNUP HERE<asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    </center></td>
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
                <td style="font-weight: 700; font-style: italic">
                    USERNAME&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Width="228px"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
                <td style="font-weight: 700; font-style: italic">
                    PASSWORD&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Width="225px"></asp:TextBox>
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
                <td style="font-weight: 700; font-style: italic">
                    PASSWORD&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" Width="225px"></asp:TextBox>
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
                <td style="font-weight: 700; font-style: italic">
                    <asp:Button ID="Button3" runat="server" Text="SIGNUP" onclick="Button3_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="CANCEL" />
                </td>
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
