<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="Administrative_login.aspx.cs" Inherits="Default2" Title="Untitled Page" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css" >
.popup
{
 background-color:Gray;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td colspan="7" style="text-align: center">
                ADMINISTRATIVE SECTION</td>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table class="style1">
                            <tr>
                                <td>
                                    <fieldset style="height: 125px; background-color: #CCCCCC;">
                                        <legend style="width: 600px; text-align: center"><b>LOGIN</b></legend>ENTER 
                                        USERID:
                                        <asp:TextBox ID="TextBox1" runat="server" Height="24px" ValidationGroup="a" 
                                            Width="274px"></asp:TextBox>
                                        <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                                            runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="USERID">
                                        </cc1:TextBoxWatermarkExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                        <br />
                                        PASSWORD:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="TextBox2" runat="server" Height="22px" ValidationGroup="a" 
                                            Width="271px"></asp:TextBox>
                                        <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                                            runat="server" Enabled="True" TargetControlID="TextBox2" 
                                            WatermarkText="PASSWORD">
                                        </cc1:TextBoxWatermarkExtender>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                    </fieldset></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="LOGIN" />
                                   
                                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                                    </asp:ScriptManager>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                                        <ProgressTemplate>
                                            <br />
                                            <br />
                                            <br />
                                            <asp:Panel ID="Panel2" runat="server" Width="383px">
                                                <br />
                                                <asp:Panel ID="Panel3" runat="server">
                                                    <asp:Image ID="Image2" runat="server" Height="153px" 
                                                        ImageUrl="~/PIC/ipi_please_wait.gif" Width="387px" />
                                                </asp:Panel>
                                                <cc1:ModalPopupExtender ID="Panel3_ModalPopupExtender" runat="server" 
                                                    DynamicServicePath="" Enabled="True" TargetControlID="Button1" 
                                                    PopupControlID="Panel3" BackgroundCssClass="popup" >
                                                </cc1:ModalPopupExtender>
                                            </asp:Panel>
                                            <br />
                                        </ProgressTemplate>
                                    </asp:UpdateProgress>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
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
            <td colspan="7">
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
                <asp:Panel ID="Panel1" runat="server">
                    
                </asp:Panel>
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
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

