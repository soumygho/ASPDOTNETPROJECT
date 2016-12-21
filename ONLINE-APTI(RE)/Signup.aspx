<%@ Page Language="C#" MasterPageFile="~/HOME.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" Title="Untitled Page" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            height: 26px;
        }
        .style5
        {
            height: 30px;
        }
        .style6
        {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style3">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700; text-align: center; color: #800000; font-size: x-large; background-color: #66FFFF">
                Signup page</td>
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
                    <asp:ScriptManager ID="ScriptManager2" EnablePageMethods="true" runat="server">
                    </asp:ScriptManager>
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
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style4">
            </td>
            <td class="style4">
            </td>
            <td class="style4" style="font-weight: 700; color: #990000; text-align: center">
                ENTER YOUR NAME</td>
                                     <td class="style4" style="text-align: left">
                                         <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="256px"></asp:TextBox>
                                         <cc1:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
                                             runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="NAME">
                                         </cc1:TextBoxWatermarkExtender>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                             ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                     </td>
                                     <td class="style4">
                                     </td>
                                     <td class="style4">
                                     </td>
                                     <td class="style4">
                                     </td>
                                     <td class="style4">
                                     </td>
                                 </tr>
                                 <tr>
                                     <td class="style4">
                                         </td>
                                     <td class="style4">
                                         </td>
                                     <td class="style4">
                                         </td>
                                     <td style="font-weight: 700; color: #990000; text-align: center" class="style4">
                                         ENTER USERNAME</td>
                                     <td class="style4">
                                     &nbsp;
                                         <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                             <ContentTemplate>
                                                 <asp:TextBox ID="TextBox2" 
    runat="server" AutoPostBack="True" Width="256px" 
                                             
    ontextchanged="TextBox2_TextChanged"></asp:TextBox>
                                                 <cc1:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
                                             runat="server" Enabled="True" TargetControlID="TextBox2" 
                                             WatermarkText="USERNAME">
                                                 </cc1:TextBoxWatermarkExtender>
                                                 &nbsp;
                                                 <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                                                 &nbsp;
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                     ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                             </ContentTemplate>
                                         </asp:UpdatePanel>
                                     </td>
                                     <td class="style4">
                                         </td>
                                     <td class="style4">
                                         </td>
                                     <td class="style4">
                                         </td>
                                     <td class="style4">
                                         </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td style="font-weight: 700; color: #990000; text-align: center">
                                         ENTER PASSWORD</td>
                                     <td>
                                         <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                             <ContentTemplate>
                                                 <asp:TextBox ID="TextBox3" 
    runat="server" Width="256px" AutoPostBack="True" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
                                                 <cc1:TextBoxWatermarkExtender ID="TextBox3_TextBoxWatermarkExtender" 
                                             runat="server" Enabled="True" TargetControlID="TextBox3" 
                                             WatermarkText="PASSWORD">
                                                 </cc1:TextBoxWatermarkExtender>
                                                 &nbsp;
                                                 <asp:Label ID="Label2" runat="server" ForeColor="#FF3300" Text="Label"></asp:Label>
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                     ControlToValidate="TextBox3" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                                 &nbsp;<asp:Image ID="Image2" runat="server" />
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
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td style="font-weight: 700; color: #990000; text-align: center">
                                         RE ENTER PASSWORD</td>
                                     <td>
                                         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                             <ContentTemplate>
                                                 <asp:TextBox ID="TextBox6" 
    runat="server" Width="256px" AutoPostBack="True" ontextchanged="TextBox6_TextChanged"></asp:TextBox>
                                                 <cc1:TextBoxWatermarkExtender ID="TextBox6_TextBoxWatermarkExtender" 
                                             runat="server" Enabled="True" TargetControlID="TextBox6" 
                                             WatermarkText="RE-ENTER PASSWORD">
                                                 </cc1:TextBoxWatermarkExtender>
                                                 &nbsp;
                                                 <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                     ControlToValidate="TextBox6" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td style="font-weight: 700; color: #990000; text-align: center">
                                         DATE OF BIRTH</td>
                                     <td>
                                         <asp:TextBox ID="TextBox7" runat="server" Width="256px"></asp:TextBox>
                                         <cc1:CalendarExtender ID="TextBox7_CalendarExtender" runat="server" 
                                             Enabled="True" TargetControlID="TextBox7">
                                         </cc1:CalendarExtender>
&nbsp;
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                             ControlToValidate="TextBox5" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                     </td>
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
                                     <td style="font-weight: 700; color: #990000; text-align: center">
                                         SEX</td>
                                     <td>
&nbsp;&nbsp;&nbsp;&nbsp;
                                         <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                             <ContentTemplate>
                                                 <asp:RadioButton ID="RadioButton1" 
    runat="server" Text="MALE" AutoPostBack="True" GroupName="SEX" oncheckedchanged="RadioButton1_CheckedChanged" 
                                                     style="font-weight: 700" />
                                                 &nbsp;&nbsp;
                                                 <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                                                     GroupName="SEX" oncheckedchanged="RadioButton2_CheckedChanged" 
                                                     style="font-weight: 700" Text="FEMALE" />
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
                                 </tr>
                                 <tr>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td>
                                         &nbsp;</td>
                                     <td style="font-weight: 700; color: #990000; text-align: center">
                                         YEAR</td>
                                     <td>
                                         <asp:TextBox ID="TextBox8" runat="server" Width="257px"></asp:TextBox>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                             ControlToValidate="TextBox8" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                     </td>
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
                                     <td style="font-weight: 700; color: #990000; text-align: center; background-color: #FF6600">
                                         ENTER MOB NO</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Width="256px" Height="22px"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="TextBox4_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="TextBox4" WatermarkText="MOB NO">
                </cc1:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="TextBox6" ErrorMessage="*Required"></asp:RequiredFieldValidator>
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
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td class="style5">
                </td>
            <td style="font-weight: 700; color: #990000; text-align: center" class="style5">
                EMAIL</td>
            <td class="style5">
                <asp:TextBox ID="TextBox5" runat="server" Width="256px"></asp:TextBox>
                <cc1:TextBoxWatermarkExtender ID="TextBox5_TextBoxWatermarkExtender" 
                    runat="server" Enabled="True" TargetControlID="TextBox5" WatermarkText="E-MAIL">
                </cc1:TextBoxWatermarkExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="TextBox7" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TextBox5" ErrorMessage="Please enter a valid e-mail address" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="style5">
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
                <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="RESET" onclick="Button2_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" Text="CANCEL" onclick="Button3_Click" />
            </td>
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
            <td style="font-weight: 700; text-align: center">
                <asp:Label ID="Label4" runat="server" style="color: #FF3300; font-size: large" 
                    Text="Label"></asp:Label>
            </td>
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
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
                </td>
            <td class="style6">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

