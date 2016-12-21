<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
        .style5
        {
            height: 46px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
        <tr>
            <td colspan="7">
                <asp:Image ID="Image2" runat="server" Height="400px" 
                    ImageUrl="~/PIC/rally 1.jpg" Width="875px" />
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
                <b>TO BECOME A PARTNER OF GOLDEN JUBILEE CELEBRATION PLEASE ENTER YOUR DETAILS 
                HERE(ONLY FOR EX STUDENTS)</b><asp:ScriptManager ID="ScriptManager1" 
                    runat="server">
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
            <td style="font-weight: 700; text-align: left">
&nbsp;NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="nameText" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="nameText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
            <td style="font-weight: 700; text-align: left">
&nbsp;MOB NO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="mobText" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="mobText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="mobText" ErrorMessage="*NOT A VALID MOB NO" 
                    ValidationExpression="^9\d{9}$"></asp:RegularExpressionValidator>
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
            <td style="font-weight: 700; text-align: left">
&nbsp;EMAIL ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="emailText" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="emailText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="emailText" ErrorMessage="*not a valid email address" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
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
            <td style="font-weight: 700; text-align: left;">
                PRESENT ADDRESS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:TextBox ID="presentText" runat="server" TextMode="MultiLine" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="presentText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
            <td class="style5" style="font-weight: 700">
                <asp:UpdatePanel ID="UpdatePanel1" UpdateMode= "Conditional" runat="server">
         
                    <ContentTemplate>
                        PERMANENT ADDRESS
                        <asp:TextBox ID="permanentText" runat="server" TextMode="MultiLine" 
                            Width="250px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="permanentText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CheckBox ID="checkpar" runat="server" AutoPostBack="True" 
                            oncheckedchanged="checkpar_CheckedChanged" Text="SAME AS PRESENT ADDRESS" />
                    </ContentTemplate>
                    
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="checkpar" EventName="CheckedChanged" />
                    </Triggers>
                    
                </asp:UpdatePanel>
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: left;">
                YEAR OF PASSING&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="year" runat="server">
                    <asp:ListItem>1964</asp:ListItem>
                    <asp:ListItem>1965</asp:ListItem>
                    <asp:ListItem>1966</asp:ListItem>
                    <asp:ListItem>1967</asp:ListItem>
                    <asp:ListItem>1968</asp:ListItem>
                    <asp:ListItem>1969</asp:ListItem>
                    <asp:ListItem>1970</asp:ListItem>
                    <asp:ListItem>1971</asp:ListItem>
                    <asp:ListItem>1972</asp:ListItem>
                    <asp:ListItem>1973</asp:ListItem>
                    <asp:ListItem>1974</asp:ListItem>
                    <asp:ListItem>1975</asp:ListItem>
                    <asp:ListItem>1976</asp:ListItem>
                    <asp:ListItem>1977</asp:ListItem>
                    <asp:ListItem>1978</asp:ListItem>
                    <asp:ListItem>1979</asp:ListItem>
                    <asp:ListItem>1980</asp:ListItem>
                    <asp:ListItem>1981</asp:ListItem>
                    <asp:ListItem>1982</asp:ListItem>
                    <asp:ListItem>1983</asp:ListItem>
                    <asp:ListItem>1984</asp:ListItem>
                    <asp:ListItem>1985</asp:ListItem>
                    <asp:ListItem>1986</asp:ListItem>
                    <asp:ListItem>1987</asp:ListItem>
                    <asp:ListItem>1988</asp:ListItem>
                    <asp:ListItem>1989</asp:ListItem>
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                    <asp:ListItem>1996</asp:ListItem>
                    <asp:ListItem>1997</asp:ListItem>
                    <asp:ListItem>1998</asp:ListItem>
                    <asp:ListItem>1999</asp:ListItem>
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2008</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                </asp:DropDownList>
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
            <td style="font-weight: 700; text-align: left;">
                ATTENDED CLASS DURING PASSING OUT
                <asp:DropDownList ID="classDropdown" runat="server">
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
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
            <td style="font-style: italic; font-weight: 700; text-align: left;">
                &nbsp;OCCUPATION&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="occupationText" runat="server" Width="250px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="occupationText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="text-align: center" Text="SUBMIT" />
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
                <asp:Label ID="Label1" runat="server" ForeColor="#99FF66" Text="Label"></asp:Label>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

