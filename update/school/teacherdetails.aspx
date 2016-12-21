<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="teacherdetails.aspx.cs" Inherits="TEACHERS_DETAILS" Title="Untitled Page" %>

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
        	float: left;
        	text-decoration:  none;
        	border-width:medium;
        	display: block;
            width: 237px;
            height: 77px;
        }
        .style6
        {
            width: 15px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; background-color: #FFFFFF;">
        <tr>
            <td class="style4" style="width:130px">
             <div style="width:263px; height: 265px; font-weight: 700;">
             <ul class="teacher">
             <li><b><a href="teacherdetails.aspx?trade=science">SCIENCE</a></b></li>
             <li><b><a href="teacherdetails.aspx?trade=arts">ARTS</a></b></li>
             <li><b><a href="teacherdetails.aspx?trade=vpcational">VOCATIONAL</a></b></li>
             </ul>
             </div>
             </td>
            <td colspan="5" rowspan="12">
                <asp:Panel ID="Panel1" runat="server" BorderColor="#333333" BorderStyle="Solid" 
                    Height="532px">
                    <br />
                    &nbsp;
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

