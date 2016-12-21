<%@ Page Title="" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="friendlist.aspx.cs" Inherits="friendlist" %>

<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; font-style: italic; text-align: center">
                FRIEND LIST DETAILS</td>
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
                                <cc1:DataPagerRepeater ID="DataPagerRepeater3" runat="server" 
                                PersistentDataSource="true">
                                <HeaderTemplate>
                                <div>
                                <br />
                                </div>
                                </HeaderTemplate>
                                <ItemTemplate>
                                <div style="border: thin solid #000066;background-color :White;">
                                <table>
                                <tr>
                                <td><asp:Image ID="Image2" runat="server" Height="60px" 
                                        Width="60px" ImageUrl='<%#string.Format
                    ("~/ImageHandler.ashx?url={0}",Eval("Profimgurl")) %>' /></td>
                                <td><asp:HyperLink runat="server" ID="profLink" 
                                        NavigateUrl='<%#string.Format("~/Usertimeline.aspx?id={0}",Eval("Profid"))%>' 
                                        Text='<%#Eval("Name") %>' ></asp:HyperLink></td>
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
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>

