<%@ Page Title="USERDETAILS VIEW" Language="C#" MasterPageFile="~/home2.master" AutoEventWireup="true" CodeFile="adminview.aspx.cs" Inherits="adminview"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            background-color: #E6E6FA;
        }
        .style4
        {
            font-weight: 700;
        }
        .style5
        {
            height: 22px;
            font-weight: 700;
        }
        .style6
        {
            height: 22px;
        }
        .style7
        {
            color: #FF0000;
            font-weight: normal;
        }
         #content_data
{
    height:980px;
    width:950px;
    margin:auto;
    padding:0px;
    border:1px solid #000;
    margin-top:48px;
    border-radius:5px;
}
        .style8
        {
            font-weight: 700;
            height: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content_data">
<center>
    <table class="style3" 
        style="border: thin solid #000000; width: 950px; height: 980px; top: 11px; right: 16px; left: 15px;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/adminhome.aspx" 
                    style="color: #FF6600">HOMEPAGE</asp:HyperLink>
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
            <td style="font-weight: 700">
                ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="idlabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="font-weight: 700; text-align: center">
                A.V.A.T.A.R</td>
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
            <td style="font-weight: 700">
                DATE&nbsp;
                <asp:Label ID="date" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="font-weight: 700; text-align: center">
                ONLINE REGISTRATION FORM</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
            </td>
            <td class="style8">
            </td>
            <td class="style8">
                NAME
            </td>
            <td class="style8" style="font-weight: 700">
                <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4" colspan="3" rowspan="7">
                <asp:Image ID="passport" runat="server" Width="187px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                GUARDIAN RELATIONSHIP</td>
            <td>
                <asp:Label ID="guardian" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                GUARDIAN NAME</td>
            <td>
                <asp:Label ID="guardianname" runat="server" style="font-weight: 700" 
                    Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                DOB</td>
            <td>
                <asp:Label ID="dob" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                PAN</td>
            <td>
                <asp:Label ID="pan" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                ADHAAR CARD NO</td>
            <td>
                <asp:Label ID="adhaar" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                GENDER</td>
            <td>
                <asp:Label ID="gender" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                MARITAL STATUS</td>
            <td>
                <asp:Label ID="marital" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
            <td style="font-weight: 700">
                STATUS</td>
            <td>
                <asp:Label ID="statuslabel" runat="server" 
                    style="font-weight: 700; color: #FF0000" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                NATIONALITY</td>
            <td>
                <asp:Label ID="natinality" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700">
                EDUCATIONAL QUALIFICATION</td>
            <td>
                <asp:Label ID="qualification" runat="server" style="font-weight: 700" 
                    Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700">
                CONTACT DETAILS</td>
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
            <td style="font-weight: 700">
                MOB NO</td>
            <td>
                <asp:Label ID="mobno" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
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
            </td>
            <td class="style5">
            </td>
            <td class="style5">
                TELEPHONE NO(WITH STD CODE)</td>
            <td class="style5">
                <asp:Label ID="telno" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
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
            <td style="font-weight: 700">
                EMAIL ID</td>
            <td style="font-weight: 700">
                <asp:Label ID="emailid" runat="server" Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700">
                ADDRESS OF CORRESPONDENCE</td>
            <td colspan="4">
                <asp:Label ID="address" runat="server" style="font-weight: 700" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                TOWN/CITY</td>
            <td style="font-weight: 700">
                <asp:Label ID="town" runat="server" Text="Label"></asp:Label>
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
            </td>
            <td class="style5">
            </td>
            <td class="style5">
                DISTRICT</td>
            <td class="style5">
                <asp:Label ID="district" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
            <td class="style5">
            </td>
        </tr>
        <tr>
            <td class="style6">
            </td>
            <td class="style6">
            </td>
            <td class="style6" style="font-weight: 700">
                STATE</td>
            <td class="style6" style="font-weight: 700">
                <asp:Label ID="state" runat="server" Text="Label"></asp:Label>
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
            <td style="font-weight: 700">
                PIN CODE</td>
            <td style="font-weight: 700">
                <asp:Label ID="pin" runat="server" Text="Label"></asp:Label>
            </td>
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
            <td style="font-weight: 700">
                RATION CARD / VOTER ID</td>
            <td style="font-weight: 700">
                <asp:Label ID="votercard" runat="server" Text="Label"></asp:Label>
            </td>
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
            <td colspan="5" rowspan="3" style="font-weight: 700; text-align: left;">
                                                DECLARATION : 
                                                <span class="style7">I HERE BY DECLARE THAT THE ABOVE INFORMATION ARE TRUE TO THE BEST 
                                                OF MY KNOWLEDGE AND BELIEF,IN CASE ANY OF THE ABOVE INFORMATION IS FOUND TO BE 
                                                FALSE,I AM AWARE THAT I WILL BE SOLE RESPONSIBLE FOR THAT.</span></td>
        </tr>
        <tr>
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
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="font-weight: 700">
                LEFT/RIGHT THUM IMPRESSION</td>
            <td style="font-style: italic; font-weight: 700">
                APPLICANT&#39;S&nbsp; SIGNATURE</td>
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
            <td rowspan="7">
                <asp:Image ID="thumbimpression" runat="server" Height="130px" Width="298px" />
            </td>
            <td rowspan="7">
                <asp:Image ID="signature" runat="server" Height="130px" Width="298px" />
            </td>
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
            <td class="style5">
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
            <td style="font-weight: 700; text-align: center">
                CHANGE STATUS HERE :</td>
            <td style="text-align: center">
                <asp:DropDownList ID="Status" runat="server" Width="250px">
                    <asp:ListItem>--SELECT STATUS--</asp:ListItem>
                    <asp:ListItem>NOT REGISTERED</asp:ListItem>
                    <asp:ListItem>VALID</asp:ListItem>
                    <asp:ListItem>INVALID</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="warning" runat="server" style="color: #FF0000" Text="Label"></asp:Label>
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
            <td style="font-weight: 700; text-align: center">
                &nbsp;</td>
            <td style="text-align: center">
                <asp:Button ID="Submit" runat="server" onclick="Submit_Click" Text="SUBMIT" />
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

