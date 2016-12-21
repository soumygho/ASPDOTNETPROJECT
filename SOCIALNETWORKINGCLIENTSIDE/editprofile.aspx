<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editprofile.aspx.cs" Inherits="editprofile" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

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
            height: 23px;
        }
        .style3
        {
            height: 23px;
            font-weight: bold;
            font-style: italic;
            text-decoration: underline;
        }
        .style4
        {
            font-style: italic;
            font-weight: bold;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="6" 
                    style="font-weight: 700; font-style: italic; text-decoration: underline; text-align: center">
                    EDIT USER DETAILS</td>
            </tr>
            <tr>
                <td colspan="6" 
                    style="font-weight: 700; font-style: italic; text-decoration: underline; text-align: center">
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                </td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td class="style2">
                </td>
                <td class="style3">
                    NAME                 </td>
                <td class="style2">
                    <asp:TextBox ID="TextName" runat="server" Width="295px"></asp:TextBox>
                </td>
                <td class="style2">
                </td>
                <td class="style2">
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    DATE OF BIRTH</td>
                <td>
                    <asp:TextBox ID="TextDob" runat="server" ontextchanged="TextBox2_TextChanged" 
                        Width="294px"></asp:TextBox>
                    <asp:CalendarExtender ID="TextDob_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="TextDob">
                    </asp:CalendarExtender>
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
                <td class="style4">
                    ADDRESS
                    </td>
                <td>
                    <asp:TextBox ID="TextAddress" runat="server" Height="91px" TextMode="MultiLine" 
                        Width="294px"></asp:TextBox>
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
                <td class="style4">
                    MOBILE NO
                </td>
                <td>
                    <asp:TextBox ID="TextMob" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    SECONDARY MOBILE NO</td>
                <td>
                    <asp:TextBox ID="TextSecondaryMob" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    SCHOOL NAME</td>
                <td>
                    <asp:TextBox ID="TextSchoolName" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    STUDENT FROM</td>
                <td>
                    <asp:TextBox ID="TextStudentFrom" runat="server" Width="294px"></asp:TextBox>
                    <asp:CalendarExtender ID="TextStudentFrom_CalendarExtender" runat="server" 
                        TargetControlID="TextStudentFrom">
                    </asp:CalendarExtender>
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
                <td class="style4">
                    SCHOOL PASSING YEAR</td>
                <td>
                    <asp:TextBox ID="TextSchoolpassingyear" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    COLLEGE NAME
                </td>
                <td>
                    <asp:TextBox ID="TextCollegeName" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    OCCUPATION
                </td>
                <td>
                    <asp:TextBox ID="TextOccupation" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    WORKS AT</td>
                <td>
                    <asp:TextBox ID="TextWorksAt" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    WORKS FROM
                </td>
                <td>
                    <asp:TextBox ID="TextWorksFrom" runat="server" Width="294px"></asp:TextBox>
                    <asp:CalendarExtender ID="TextWorksFrom_CalendarExtender" runat="server" 
                        Enabled="True" TargetControlID="TextWorksFrom">
                    </asp:CalendarExtender>
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
                <td class="style4">
                    DESIGNATION
                </td>
                <td>
                    <asp:TextBox ID="TextDesignation" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    SPECIALIZATION</td>
                <td>
                    <asp:TextBox ID="TextSpecialization" runat="server" Width="294px"></asp:TextBox>
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
                <td class="style4">
                    GENDER</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" 
                        Text="MALE" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" 
                        Text="FEMALE" />
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
                <td class="style4">
                    ABOUT</td>
                <td>
                    <asp:TextBox ID="TextAbout" runat="server" Height="102px" TextMode="MultiLine" 
                        Width="294px"></asp:TextBox>
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
                <td class="style4">
                    FAVOURITE QUOTE</td>
                <td>
                    <asp:TextBox ID="TextFavouriteQuote" runat="server" Height="101px" 
                        TextMode="MultiLine" Width="294px"></asp:TextBox>
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
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="SAVE" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="CANCEL" />
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
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    </td>
                <td>
                    </td>
                <td>
                    </td>
                <td>
                    </td>
                <td>
                    </td>
                <td>
                    </td>
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
        </table>
    
    </div>
    </form>
</body>
</html>
