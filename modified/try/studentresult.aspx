<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="studentresult.aspx.cs" Inherits="studentresult" Title="RESULT PAGE" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Label ID="Label1" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
                <div style="border: medium solid #000000; font-weight: 700; text-align: center">
                
                PLEASE ENTER DETAILS TO GET YOUR RESULT<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                        runat="server" ControlToValidate="name" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ROLL NO&nbsp;&nbsp;
                <asp:TextBox ID="rollText" runat="server" Width="133px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="rollText" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                YEAR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="year" runat="server" Height="18px" Width="158px">
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                    <asp:ListItem>2019</asp:ListItem>
                    <asp:ListItem>2020</asp:ListItem>
                </asp:DropDownList>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                CLASS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="cls" runat="server" Height="24px" Width="159px">
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                EXAM NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="examname" runat="server" Height="25px" Width="167px">
                    <asp:ListItem>INTERNAL</asp:ListItem>
                    <asp:ListItem>FINAL</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;
                <asp:Button ID="submit" runat="server" Text="SUBMIT" onclick="submit_Click1" 
                    style="font-weight: 700" />
                &nbsp;&nbsp;&nbsp;
                            
                </div></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td rowspan="5">
                <asp:Panel ID="Panel1" runat="server" style="text-align: center" 
                    BorderColor="#999999" BorderStyle="Solid" BackColor="White">
                    <b>YOUR RESULT IS AS FOLLOWS :</b><br />
                    <b>TUTRANGA ANCHAL SIKSHANIKETAN<br />
                    </b>
                    <div>
                    <center>
                    <asp:DetailsView ID="result" runat="server" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" Height="50px" Width="284px">
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:DetailsView>
                    </center>
                    </div>
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

