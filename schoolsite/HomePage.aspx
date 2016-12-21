<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 865px;
        }
        .style5
        {
            width: 213px;
        }
        .style7
        {
            width: 106px;
            font-weight: 700;
            font-family: Aharoni;
        }
        .img
        {
        	float:left;
        }
    .style10
    {
        height: 23px;
        text-align: center;
        width: 137px;
    }
    .style11
    {
        width: 137px;
        text-decoration: "blink";
    }
        .style14
        {
            height: 17px;
        }
        .style15
        {
            width: 14px;
        }
        .style16
        {
            height: 23px;
            text-align: center;
            width: 14px;
        }
        .style17
        {
            height: 17px;
            width: 14px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4" style="background-color: #FFFFFF">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td class="style5" rowspan="11">
                                &nbsp;<asp:Image ID="Image5" runat="server" Height="200px" 
                    Width="546px" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" />
                <cc1:SlideShowExtender ID="Image5_SlideShowExtender" runat="server" 
                    Enabled="True" SlideShowServicePath="" TargetControlID="Image5" 
                    SlideShowServiceMethod="GetSlides" UseContextKey="True" Loop="true" AutoPlay="True" PlayInterval="1000">
                </cc1:SlideShowExtender>
                <br />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td style="border: thin solid #000000; text-align: center; background-color: #333333; font-style: normal; color: #FFFFFF; font-size: medium;" 
                class="style11">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp;NOTICES</b></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td rowspan="11" class="style11">
               <fieldset style="border: thin solid #000000; height:200px;">
               <marquee direction="up" onmouseover="this.stop()" onmouseout="this.start()" 
                       style="height: 200px; width: 234px;">
                   <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                   <br />
                   <asp:HyperLink ID="HyperLink2" runat="server">HyperLink</asp:HyperLink>
                   <br />
                   <asp:HyperLink ID="HyperLink3" runat="server">HyperLink</asp:HyperLink>
                   <br />
                   <asp:HyperLink ID="HyperLink4" runat="server">HyperLink</asp:HyperLink>
                   <br />
                   <br />
                   <br />
                   </marquiee>
                </fieldset></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style2">
            </td>
            <td class="style16">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style14">
                </td>
            <td class="style14">
                </td>
            <td class="style17">
                </td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style16">
                </td>
            <td class="style7" rowspan="9" 
                
                style="text-transform: capitalize; color: #00FFFF; line-height: normal; text-align: justify; white-space: normal; text-indent: inherit">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style16">
                </td>
            <td style="border: thin solid #000000; background-color: #333333; font-size: medium; color: #FFFFFF; font-style: normal;" 
                class="style10">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <b>NEWS</b></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td rowspan="7" class="style11">
                <fieldset style="border: thin solid #000000; height: 200px; width: 234px;">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </fieldset></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

