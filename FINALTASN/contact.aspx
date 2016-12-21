<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta name="description" content="Welcome to Tutranga Anchal Sikshaniketan">
<meta name = "keywords" content="tutranga,tutranga anchal,tutranga anchal sikshaniketan,tutranga school,thakurchak,tasn">
    <style type="text/css">
        .style4
        {
           
            background-color: #FFFFFF;
        }
.heading
{
padding:10px 10px 20px 10px; /*leave enough padding to accommodate the shadow*/
font-size:1.2em;
letter-spacing:.2em;
font-weight:bold;
color:#ffffff;
/*use two shadows, the first the colour of the background, the second the same colour as the text*/ 
text-shadow: 1px 2px 0px #e4e4c7, 1px 1px 0px #526972;
}
        .email
{
     width: 875px;
     height : 475px;
 font-family: 'Source Sans Pro', sans-serif;
  font-weight: 500;
  font-size: 16px;
  color: #ffffff;
  -webkit-transition: all ease .3s;
  -o-transition: all ease .3s;
  -moz-transition: all ease .3s;
  -ms-transition: all ease .3s;
  transition: all ease .3s;
 border-radius: 3px;
 background: #3b5998;
  border-radius: 3px;
  border: 1px solid #2b4479;
  border: 1px solid #2d4373;
  -webkit-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -o-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -moz-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -ms-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div >
    <table class="email">
        <tr>
            <td style="font-weight: 700; color: #FFFFFF;" class="heading">
                CONTACT US</td>
        </tr>
        <tr>
            <td style="font-weight: 700; text-align: center">
                PHONE :&nbsp;&nbsp;&nbsp;&nbsp; (03229) 205310</td>
        </tr>
        <tr>
            <td style="font-weight: 700; text-align: center">
                MOBILE NO : 9474305123</td>
        </tr>
        <tr>
            <td style="font-weight: 700; text-align: center">
                E-MAIL ADDRESS : </td>
        </tr>
        <tr>
            <td>
            <div>
            <center>
            <ul style="list-style-type : none;">
            <li style="text-decoration : none;">info@tutrangaanchalsikshaniketan.in</li>
            <li style="text-decoration : none;">admin@tutrangaanchalsikshaniketan.in</li>
            </ul>
            </center>
            </div>
                </td>
        </tr>
        <tr>
            <td>
            <div  style="font-size: large; font-weight: bold">
            <div><center style="font-size: large; font-weight: bold">EMAIL US YOUR QUERY</center></div>
            <center>
            <table>
            <tr>
            <td>
             YOUR EMAIL ADDRESS
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*Required"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td>
            YOUR QUERY 
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="103px" TextMode="MultiLine" 
                    Width="350px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*Required"></asp:RequiredFieldValidator>
            </td>
            </tr>
            <tr>
            <td>
            </td>
            <td>
            <center>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="font-weight: 700; text-align: center" Text="SUBMIT" />
                &nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #FF0000" 
                    Text="Label"></asp:Label>
                    </center>
            </td>
            </tr>
            <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            </tr>
            </table>
            </center>
            </div>
             </td>
        </tr>
        </table>
        </div>
</asp:Content>

