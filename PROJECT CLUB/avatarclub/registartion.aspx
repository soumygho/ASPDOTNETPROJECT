<%@ Page Title="MEMBER REGISTRATION" Language="C#" MasterPageFile="~/homepage1.master" AutoEventWireup="true" CodeFile="registartion.aspx.cs" Inherits="registartion" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width:929px;
            height: 1073px;
        }
        .style3
        {
            height: 25px;
            font-weight: 700;
            text-align: left;
        }
        .style4
        {
            height: 28px;
        }
        .style5
        {
            height: 26px;
        }
        .style7
        {
            height: 27px;
            text-align: center;
            color: #0000FF;
        }
    .style8
    {
            height: 40px;
        }
        .style10
        {
            color: #FF0000;
            font-weight: normal;
        }
            #content_data
{
    height:1256px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
        .style11
        {
            height: 58px;
        }
        .style12
        {
            height: 31px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content_data">
<center>
    <table>
                <tr>
                    <td class="style8">
                        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                        </asp:ToolkitScriptManager>
                    </td>
                </tr>
                <tr>
                    <td style="font-weight: 700; text-align: center;">
                                                A.V.A.T.A.R</td>
                </tr>
                <tr>
                    <td style="font-weight: 700; text-align: center">
                        ONLINE REGISTRATION</td>
                </tr>
                <tr>
                    <td class="style7">
                        REGISTER HERE AND HELP US TO GET TOGETHER AGAINST THE DRUGS AND EVIL PRODUCTS</td>
                </tr>
                <tr>
                    <td style="color: #FF0000; text-align: center">
                
                            
                                Please fill the following form carefully</td>
                </tr>
                <tr>
                    <td>
                        
                        
                                <asp:Panel ID="Panel3" runat="server" style="text-align: left" Height="1087px" 
                                    Width="932px">
                                    <table class="style2">
                                        <tr>
                                            <td style="font-weight: 700; text-align: left;" colspan="2">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700; text-align: left;">
                                                NAME</td>
                                            <td>
                                                <asp:TextBox ID="name" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="name_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="name" 
                                                    WatermarkText="Enter Name">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                                                    ControlToValidate="name" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                GURDIAN</td>
                                            <td>
                                                <asp:DropDownList ID="gurdian" runat="server">
                                                    <asp:ListItem>-SELECT RELATIONSHIP-</asp:ListItem>
                                                    <asp:ListItem>HUSBAND</asp:ListItem>
                                                    <asp:ListItem>MOTHER</asp:ListItem>
                                                    <asp:ListItem>FATHER</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="rellbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                GUARDIAN NAME</td>
                                            <td>
                                                <asp:TextBox ID="guardianname" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="guardianname_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="guardianname" 
                                                    WatermarkText="GUARDIAN NAME">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                                                    ControlToValidate="guardianname" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                DOB</td>
                                            <td style="color: #FF3300">
                                                <asp:TextBox ID="dob" runat="server" ontextchanged="TextBox3_TextChanged" 
                                                    Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="dob_TextBoxWatermarkExtender" runat="server" 
                                                    Enabled="True" TargetControlID="dob" WatermarkText="DATE OF BIRTH">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:CalendarExtender ID="dob_CalendarExtender" runat="server" 
                                                    Enabled="True" TargetControlID="dob" DefaultView="Years" 
                                                    PopupPosition="Right">
                                                </asp:CalendarExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                                    ControlToValidate="dob" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                                &nbsp;*(MM/DD/YYYY)</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                PAN</td>
                                            <td>
                                                <asp:TextBox ID="pan" runat="server" ontextchanged="TextBox4_TextChanged" 
                                                    Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="pan_TextBoxWatermarkExtender" runat="server" 
                                                    Enabled="True" TargetControlID="pan" WatermarkText="PAN CARD NO">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                ADHAAR CARD NO</td>
                                            <td>
                                                <asp:TextBox ID="adhaarcardno" runat="server" 
                                                    ontextchanged="TextBox5_TextChanged" Width="250px"></asp:TextBox>
                                                <asp:RoundedCornersExtender ID="adhaarcardno_RoundedCornersExtender" 
                                                    runat="server" Enabled="True" TargetControlID="adhaarcardno">
                                                </asp:RoundedCornersExtender>
                                                <asp:TextBoxWatermarkExtender ID="adhaarcardno_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="adhaarcardno" 
                                                    WatermarkText="ADHAAR CARD NO">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700" class="style12">
                                                GENDER</td>
                                            <td class="style12">
                                                <asp:DropDownList ID="gender" runat="server">
                                                    <asp:ListItem>-SELECT GENDER-</asp:ListItem>
                                                    <asp:ListItem>MALE</asp:ListItem>
                                                    <asp:ListItem>FEMALE</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="genlbl" runat="server" style="color: #FF3300" Text="Label"></asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                MARITAL STATUS</td>
                                            <td>
                                                <asp:DropDownList ID="maritalstatus" runat="server">
                                                    <asp:ListItem>-SELECT MARITAL STATUS-</asp:ListItem>
                                                    <asp:ListItem>MARRIED</asp:ListItem>
                                                    <asp:ListItem>SINGLE</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="marlbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700" class="style5">
                                                </td>
                                            <td class="style5">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                NATIONALITY</td>
                                            <td>
                                                <asp:TextBox ID="natinality" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="natinality_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="natinality" 
                                                    WatermarkText="NATIONALITY">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                                    ControlToValidate="natinality" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700" class="style3">
                                                EDUCATIONAL QUALIFICATION</td>
                                            <td class="style3">
                                                <asp:DropDownList ID="qualification" runat="server">
                                                    <asp:ListItem>-SELECT QUALIFICATION-</asp:ListItem>
                                                    <asp:ListItem>10th+/DPILOMA</asp:ListItem>
                                                    <asp:ListItem>BELOW 10TH</asp:ListItem>
                                                    <asp:ListItem>GRADUATE</asp:ListItem>
                                                    <asp:ListItem>POST-GRADUATE OR HIGHER</asp:ListItem>
                                                    <asp:ListItem>PROFESSIONAL COURSE</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Label ID="quallbl" runat="server" Font-Bold="False" style="color: #FF3300" 
                                                    Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                &nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                CONATACT DETAILS</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                MOBILE NO</td>
                                            <td>
                                                <asp:TextBox ID="mobno" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="mobno_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="mobno" 
                                                    WatermarkText="ENTER MOBILE NO">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                                    ControlToValidate="mobno" ErrorMessage="*enter valid mobno" 
                                                    ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                    ControlToValidate="mobno" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                TELEPHONE NO WITH STD CODE</td>
                                            <td style="color: #FF0000">
                                                <asp:TextBox ID="telno" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="telno_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="telno" 
                                                    WatermarkText="TELEPHONE NO WITH STD CODE">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                                    ControlToValidate="telno" ErrorMessage="*enter valid tel no" 
                                                    ValidationExpression="[0-9]{5}[-][0-9]{6}"></asp:RegularExpressionValidator>
                                                &nbsp;*(xxxxx-xxxxxx)</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                E-MAIL ID</td>
                                            <td>
                                            
                                                        <asp:TextBox ID="emailid" runat="server" ontextchanged="emailid_TextChanged" 
                                                            style="margin-bottom: 0px; height: 22px;" Width="250px"></asp:TextBox>
                                                        <asp:TextBoxWatermarkExtender ID="emailid_TextBoxWatermarkExtender" 
                                                            runat="server" Enabled="True" TargetControlID="emailid" 
                                                            WatermarkText="EMAIL ID">
                                                        </asp:TextBoxWatermarkExtender>
                                                        <asp:Label ID="emaillbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                   
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                                    ErrorMessage="*enter valid email" 
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                                    ControlToValidate="emailid"></asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                    ControlToValidate="emailid" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                                &nbsp;&nbsp;
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                ADDRESS FOR CORRESPONDANCE</td>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                &nbsp;</td>
                                            <td>
                                                <asp:TextBox ID="address" runat="server" Height="100px" TextMode="MultiLine" 
                                                    Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="address_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="address" WatermarkText="ADDRESS">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                    ControlToValidate="address" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                TOWN/CITY</td>
                                            <td>
                                                <asp:TextBox ID="town" runat="server" Width="250px"></asp:TextBox>
                                                <asp:RoundedCornersExtender ID="town_RoundedCornersExtender" runat="server" 
                                                    Enabled="True" TargetControlID="town">
                                                </asp:RoundedCornersExtender>
                                                <asp:TextBoxWatermarkExtender ID="town_TextBoxWatermarkExtender" runat="server" 
                                                    Enabled="True" TargetControlID="town" WatermarkText="TOWN">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                    ControlToValidate="town" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                DISTRICT</td>
                                            <td>
                                                <asp:TextBox ID="district" runat="server" Height="22px" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="district_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="district" 
                                                    WatermarkText="DISTRICT">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                                    ControlToValidate="district" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700" class="style4">
                                                STATE</td>
                                            <td class="style4">
                                                <asp:DropDownList ID="state" runat="server" Width="250px">
                                                <asp:ListItem>-SELECT STATE-</asp:ListItem>
                                                    <asp:ListItem>WESTBENGAL</asp:ListItem>
                                                    <asp:ListItem>ASSAM</asp:ListItem>
                                                    <asp:ListItem>HARIYANA</asp:ListItem>
                                                    <asp:ListItem>PUNJAB</asp:ListItem>
                                                    <asp:ListItem>KERALA</asp:ListItem>
                                                    <asp:ListItem>KARNATAKA</asp:ListItem>
                                                    <asp:ListItem>UP</asp:ListItem>
                                                    <asp:ListItem>MP</asp:ListItem>
                                                    <asp:ListItem>DELHI</asp:ListItem>
                                                    <asp:ListItem>JHADKHAND</asp:ListItem>
                                                    <asp:ListItem>ARUNACHALPRADESH</asp:ListItem>
                                                    <asp:ListItem>MEGHALAYA</asp:ListItem>
                                                    <asp:ListItem>ANDHRAPRADESH</asp:ListItem>
                                                    <asp:ListItem>MAHARASTRA</asp:ListItem>
                                                    <asp:ListItem>GUJRAT</asp:ListItem>
                                                    <asp:ListItem>JAMMU & KASMIR</asp:ListItem>
                                                    <asp:ListItem>RAJASTHAN</asp:ListItem>
                                                    <asp:ListItem>MANIPUR</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:Label ID="statelbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                PINCODE</td>
                                            <td>
                                                <asp:TextBox ID="pincode" runat="server" ontextchanged="TextBox14_TextChanged" 
                                                    Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="pincode_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="pincode" 
                                                    WatermarkText="pincode">
                                                </asp:TextBoxWatermarkExtender>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                                    ControlToValidate="pincode" ErrorMessage="*enter valid zipcode" 
                                                    ValidationExpression="[0-9]{6}"></asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                                    ControlToValidate="pincode" ErrorMessage="*Required"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                RATION CARD NO/VOTER ID</td>
                                            <td>
                                                <asp:TextBox ID="rationcardno" runat="server" Width="250px"></asp:TextBox>
                                                <asp:TextBoxWatermarkExtender ID="rationcardno_TextBoxWatermarkExtender" 
                                                    runat="server" Enabled="True" TargetControlID="rationcardno" 
                                                    WatermarkText="rationcard no">
                                                </asp:TextBoxWatermarkExtender>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                UPLOAD YOUR PICTURE</td>
                                            <td>
                                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                                <asp:RoundedCornersExtender ID="FileUpload1_RoundedCornersExtender" 
                                                    runat="server" Enabled="True" TargetControlID="FileUpload1">
                                                </asp:RoundedCornersExtender>
                                                &nbsp; &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator10" 
                                                    runat="server" ErrorMessage="*Required" ControlToValidate="FileUpload1"></asp:RequiredFieldValidator>
&nbsp;<asp:Label ID="voterlbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                                &nbsp;<asp:Label ID="Label1" runat="server" style="color: #FF3300" 
                                                    Text="*NOT MORETHAN 25 KB"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                UPLOAD YOUR LEFT/RIGHT<br />
                                                &nbsp;HAND THUMB IMPRESSION</td>
                                            <td>
                                                <asp:FileUpload ID="FileUpload2" runat="server" />
                                                <asp:RoundedCornersExtender ID="FileUpload2_RoundedCornersExtender" 
                                                    runat="server" Enabled="True" TargetControlID="FileUpload2">
                                                </asp:RoundedCornersExtender>
                                                &nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                                    ErrorMessage="*Required" ControlToValidate="FileUpload2"></asp:RequiredFieldValidator>
                                                <asp:Label ID="thumblbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                                &nbsp;<asp:Label ID="Label2" runat="server" style="color: #FF6600" 
                                                    Text="*NOT MORETHAN 8 KB"></asp:Label>
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="font-weight: 700">
                                                UPLOAD YOUR SIGNATURE</td>
                                            <td>
                                                <asp:FileUpload ID="FileUpload3" runat="server" />
                                                <asp:RoundedCornersExtender ID="FileUpload3_RoundedCornersExtender" 
                                                    runat="server" Enabled="True" TargetControlID="FileUpload3">
                                                </asp:RoundedCornersExtender>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator 
                                                    ID="RequiredFieldValidator12" runat="server" 
                                                    ErrorMessage="*Required" ControlToValidate="FileUpload3"></asp:RequiredFieldValidator>
&nbsp;<asp:Label ID="signlbl" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
                                                &nbsp;<asp:Label ID="Label3" runat="server" style="color: #FF6600" 
                                                    Text="*NOT MORETHAN 8KB"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="font-weight: 700" class="style11">
                                                DECLARATION : <span class="style10">
                                                I HERE BY DECLARE THAT THE ABOVE INFORMATION ARE TRUE TO THE BEST OF MY 
                                                KNOWLEDGE AND BELIEF,IN CASE ANY OF THE ABOVE INFORMATION IS FOUND TO BE FALSE,I 
                                                AM AWARE THAT I WILL BE SOLE RESPONSIBLE FOR THAT.</span></td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center;">
                                                <asp:Button ID="Button1" runat="server" style="font-weight: 700" 
                                                    Text="VIEW FORM" onclick="Button1_Click" />
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Button ID="Button2" runat="server" style="font-weight: 700" Text="RESET" 
                                                    onclick="Button2_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center;">
                                                &nbsp;</td>
                                            <td style="text-align: center">
                                                <asp:Label ID="warn" runat="server" 
                                                    style="font-weight: 700; color: #FF0000" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
            
                        
                    </td>
                </tr>
                </table>
                </center>
                  </div>
</asp:Content>

