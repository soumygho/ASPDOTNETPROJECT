<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="HomePage" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 875px;
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
        .style8
        {
            width: 566px;
        }
        .style9
        {
            font-family: Arial, Helvetica, sans-serif;
        font-weight: normal;
            height: 31px;
        }
        .img
        {
        	float:left;
        }
    .style11
    {
        width: 137px;
    }
    .style13
    {
        font-size: large;
        color: #FFFFFF;
        font-style: normal;
        border: thin solid #000000;
        background-color: #333333;
    }
    .Style14
    {
    	color : Red;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4" 
    style="background-image: none; background-color: #FFFFFF;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5" rowspan="9">
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
 
            <td rowspan="10" class="style11">
             <div>
                <h2 style="width: 234px; text-align: center; background-color: #333333; color: #FFFFFF;">NOTICE</h2>
                </div>
               <fieldset style="border: thin solid #000000;" >
               <marquee direction = "up" onmouseover="this.stop()" onmouseout="this.start()">
               <div >
                   <asp:Panel ID="Panel1" runat="server" Width="233px" Class="Style14">
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
                   </asp:Panel></marquee>
                   </div>
            </td>
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
            <td class="style2">
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style2">
                </td>
            <td class="style7" rowspan="15" 
                
                
                style="text-transform: capitalize; color: #00FFFF; line-height: normal; text-align: justify; white-space: normal; text-indent: inherit">
                <table class="style8">
                    <tr>
                        <td class="style9" style="color: #FF3300; text-align: center; ">
                            <h2 class="style13">
                                FROM THE HEADMASTER&#39;S DESK</h2>
                        </td>
                    </tr>
                    <tr>
                        <td style="float: left" width="556px">
                            <asp:Image ID="Image6" runat="server" CssClass="img" Height="134px" 
                                Width="152px" ImageUrl="~/pic/head.gif" />
                            <br />
                            <br />
&nbsp;&nbsp; 
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
                            <br />
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
                <hr />
                <div style="color: #000000; width: 563px; height: 10px;">
                <h5 style="height: 28px">Site developed and maintained by :<a href="www.seanetbiz.com">SEANETBIZ</a>           copyright reserved by T.A.S. 2013</h5>
                    <p>&nbsp;</p>
                    <hr />
                </div>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td rowspan="14" class="style11" style="height:200PX;">
            <div>
            <h2 style="height: 29px; width: 234px; text-align: center; background-color: #333333; color: #FFFFFF; width:234PX;">NEWS</h2>
            </div>
            <fieldset style="border: thin solid #000000;">
                <asp:Panel ID="Panel2" runat="server" Width="233px">
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
                    <br />
                    <br />
                </asp:Panel>
                </fieldset>
            </td>
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
</asp:Content>

