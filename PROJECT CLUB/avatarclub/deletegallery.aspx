<%@ Page Title="DELETE IMAGE" Language="C#" MasterPageFile="~/home.master" AutoEventWireup="true" CodeFile="deletegallery.aspx.cs" Inherits="deletegallery" %>
<%@ Register assembly="DataPagerRepeater" namespace="DataPagerRepeater" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            width: 9px;
        }
           #content_data
{
    height:480px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
        .style6
        {
            width: 9px;
            height: 29px;
        }
        .style7
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content_data">
<center>
    <table>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/adminhome.aspx" 
                    style="color: #FF0000">HOMEPAGE</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: center">
                LIST OF IMAGES CURRENTLY IN DATABASE</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center; font-weight: 700">
                <cc1:DataPagerRepeater ID="Repeater1" runat="server" EnableTheming="True" 
                    PagingInDataSource="False" PersistentDataSource="True">
               
                <ItemTemplate>
                <div>
                <asp:Image runat="server" ImageUrl='<%#"GALLERY" +"\\"+Eval("picname") %>' style=" width : 125px; height : 125px; " />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" Text= "IMAGE TITLE :"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text= '<%#Eval("title") %>'>></asp:Label>
                </div>
                </ItemTemplate>
                <FooterTemplate>
                </FooterTemplate>
                </cc1:DataPagerRepeater>
                <asp:DataPager ID="DataPager1" runat="server" PagedControlID="Repeater1" 
                    PageSize="2">
                    <Fields>
                        <asp:NextPreviousPagerField />
                    </Fields>
                </asp:DataPager>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td style="font-weight: 700" class="style7">
                ENTER THE IMAGE TITLE TO DELETE:<asp:TextBox ID="TextBox1" runat="server" 
                    Width="229px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
            </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
            <td class="style7">
                </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-weight: 700" Text="SUBMIT" />
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Label ID="Label2" runat="server" style="font-weight: 700; color: #FF0000" 
                    Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
        </center>
</div>
</asp:Content>

