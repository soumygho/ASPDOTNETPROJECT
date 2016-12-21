<%@ Page Language="C#" AutoEventWireup="true" CodeFile="searchResult.aspx.cs" Inherits="searchResult" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
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
                <td style="font-weight: 700; font-style: italic; text-decoration: underline; color: #000066; text-align: center">
                    SEARCH RESULT</td>
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
                <cc1:DataPagerRepeater ID="DataPagerRepeater1" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="text-align: center; border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:Image ID="Image2" runat="server" Height="60px" Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Imgurl")) %>' /></td>
                                <td><asp:HyperLink runat="server" ID="profLink" NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Userid"))%>' Text='<%#Eval("Profname") %>' ></asp:HyperLink></td>
                                </tr>
                                </table>
                                </div>
                                </ItemTemplate>
                                </cc1:DataPagerRepeater>
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
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
