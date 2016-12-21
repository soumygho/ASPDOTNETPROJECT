<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="teacherdetails.aspx.cs" Inherits="TEACHERS_DETAILS" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>
<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 15px;
        }
        .teacher  li a
        {
  display: block;
  margin: 0 1px 0 0;
 padding: 4px 10px;
 width: 203px;
 background: #5970B2;
 color: #FFF;
 text-align: center;
 text-decoration: none;
        }
        .teacher
        {
        	text-decoration:  none;
        	border-width:medium;
            width: 237px;
            height: 77px;
position:absolute;
left:160px;
list-style-type : none;
border-radius: 3px;
border-width:thin; 
        }
        .style6
        {
            width: 15px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="body" style="width: 875px; ">
        <tr>
            <td class="style4" style="width:130px">
             <div style="width:263px; height: 77px; font-weight: 700;" >
             <ul class="teacher">
             <li><b><a href="teacherdetails.aspx?trade=science">SCIENCE</a></b></li>
             <li><b><a href="teacherdetails.aspx?trade=arts">ARTS</a></b></li>
             <li><b><a href="teacherdetails.aspx?trade=vocational">VOCATIONAL</a></b></li>
             </ul>
             </div>
             </td>
            <td colspan="5" rowspan="12">
                <asp:Panel ID="Panel1" runat="server" BorderColor="#333333" BorderStyle="Solid" 
                    Height="532px" style="font-weight: 700" class="section">
                    <br />
                    &nbsp;<cc1:DataPagerRepeater ID="Repeater1" runat="server">
                    <HeaderTemplate>
                    <center>
                    <asp:Label runat="server" Text=" FACULTY DETAILS " class="section"></asp:Label>
                    </center>
                    </HeaderTemplate>
                    <ItemTemplate>
                    <table style="border-width:thick; border-color:Maroon; font-size: medium; font-family: Aharoni; font-weight: bold; font-style: normal; font-variant: normal; color: #000000;" runat="server">
                    <tr>
                    <td>
                    <asp:Image runat="server" ImageUrl=' <%#String.Concat("~/TEACHER PIC/",Eval("path"))%>' Height ="165px" Width ="150px" />
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                    <asp:Label runat="server" Text ="TRADE :::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                     <asp:Label ID="Label1" runat="server" Text ='<%#Eval("trade") %>'></asp:Label>
                     <br />
                    <asp:Label ID="Label2" runat="server" Text ="NAME :::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                     <asp:Label ID="Label3" runat="server" Text ='<%#Eval("name") %>'></asp:Label>
                      <br />
                     <asp:Label ID="Label4" runat="server" Text ="QUALIFICATION :::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text ='<%#Eval("qualification") %>'></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text ="PATH :::&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text ='<%#Eval("path") %>'></asp:Label>
                    </td>
                    </tr>
                    </table>
                    </ItemTemplate>
                    <SeparatorTemplate>
                    <hr />
                    <hr />
                    </SeparatorTemplate>
                    </cc1:DataPagerRepeater>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                </td>
        </tr>
        <tr>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:DataPager ID="DataPager1" runat="server" PagedControlID="Repeater1" 
                    PageSize="3">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                            ShowNextPageButton="False" ShowPreviousPageButton="False" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                            ShowNextPageButton="False" ShowPreviousPageButton="False" />
                    </Fields>
                </asp:DataPager>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
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

