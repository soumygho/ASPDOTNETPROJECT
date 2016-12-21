<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="HomePage" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<meta name="description" content="Welcome to Tutranga Anchal Sikshaniketan">
<meta name = "keywords" content="tutranga,tutranga anchal,tutranga anchal sikshaniketan,tutranga school,thakurchak,tasn">
    <style type="text/css">
#text
{
text-align:justify;
}
 .link
        {
            text-decoration : none;
             
        }
        .img
        {
        	float:left;
        }
    .Style14
    {
    	color : Red;
    }
        .style4
        {
            width: 100%;
            border: 1px solid #FFFFFF;
        }
        .flash
        {
            text-align: center;
        }
        .style13
        {
            text-align: center;
        }
        .style14
        {
            font-weight: bold;
        }
        .style7
        {
            font-size: large;
text-align:justify;
        }
        #tech
        {
            height: 275px;
            width: 866px;
        }
.blink_me {
text-decoration : underline;
color : Blue;
    -webkit-animation-name: blinker;
    -webkit-animation-duration: 1s;
    -webkit-animation-timing-function: linear;
    -webkit-animation-iteration-count: infinite;
    
    -moz-animation-name: blinker;
    -moz-animation-duration: 1s;
    -moz-animation-timing-function: linear;
    -moz-animation-iteration-count: infinite;
    
    animation-name: blinker;
    animation-duration: 1s;
    animation-timing-function: linear;
    animation-iteration-count: infinite;
}

@-moz-keyframes blinker {  
    0% { opacity: 1.0; }
    50% { opacity: 0.0; }
    100% { opacity: 1.0; }
}

@-webkit-keyframes blinker {  
    0% { opacity: 1.0; }
    50% { opacity: 0.0; }
    100% { opacity: 1.0; }
}

@keyframes blinker {  
    0% { opacity: 1.0; }
    50% { opacity: 0.0; }
    100% { opacity: 1.0; }
}
#para
{
background-color: #ffffff;
}
        </style>
        <script type='text/javascript'>
var slideArray = new Array();
slideArray[0] = new Image();
slideArray[1] = new Image();
slideArray[2] = new Image();
slideArray[3] = new Image();
slideArray[4] = new Image();
slideArray[5] = new Image();
slideArray[6] = new Image();
slideArray[0].src = "~/SLIDE/1.bmp";
slideArray[1].src = "~/SLIDE/2.bmp";
slideArray[2].src = "~/SLIDE/3.bmp";
slideArray[3].src = "~/SLIDE/4.bmp";
slideArray[4].src = "~/SLIDE/5.bmp";
slideArray[5].src = "~/SLIDE/6.bmp";
slideArray[6].src = "~/SLIDE/7.bmp";

var step=0

function slideit(){
 //if browser does not support the image object, exit.
 if (!document.images)
  return ;
 document.getElementById('slide').src = slideArray[step].src ;
 if (step<6)
  step++;
 else
  step=0 ;
 //call function "slideit()" every 2.5 seconds
 setTimeout("slideit()",2500)
}

slideit();
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="body">
        <tr>
            <td colspan="7">
<div>
<DIV CLASS="blink_me">
<marquee DIRECTION="HORIZONTAL" onMouseOver="this.setAttribute('scrollamount', 0, 0);" OnMouseOut="this.setAttribute('scrollamount', 6, 0);" scrolldelay=180>TUTRANGA ANCHAL SIKSHANIKETAN WELCOMES YOU!!!THANKS FOR VISITING US!!!NEW GOLDEN JUBILEE PAGE LAUNCHED!!!<a href='goldenjubileepage.aspx'>CLICK HERE</a></marquee>
</DIV>
</div>
<div>
<center>
 <asp:Image ID="SlideImg" runat="server"      
style="width: 654px; height: 410px; position: relative; z-index : 0;" ImageUrl="~/SLIDE/1.bmp"/>

</center>
</div>

                </td>
        </tr>
        <tr>
            <td colspan="4">
            <div>
            <h2 class="section" style="background-color: #000000; color: #FFFFFF">
                                FROM THE HEADMASTER&#39;S DESK</h2>
<div id="para" class="section">
 <asp:Image ID="Image6" runat="server" CssClass="img" Height="134px" 
                                Width="152px" ImageUrl="~/pic/head.gif" />
                <b>
                                       <p>
                                           </b><span class="style7">Our beloved school was established in 1965 with a view to spread education in 
                            the rural locality named Tutranga since the dawn of its foundation and till date
                                         it has been playing a great role to spread &quot;Education for all&quot;,Our school 
                                         obtained recognition as (X)
                standard school in 1971 and it achieved X+2 standard in 2005-06.It has obtained 
                necessary permission to teach vocational courses in VIII+ &amp; X+ in 2006-2007 and 
                it is continuing its educational programme without any interruption.Honourable 
                persons like Late Bipin Bihari Santra(Doner),Late shasanka Sekhar Pal,Late Binod Bihari Khutia,Late Ramjiban Dey,Late Nityananda Das,Late Priya Nath 
                Pradhan,Late Sudhan Jana,Late Kumud Bandu Shyamal,Late Adhar Chandra 
                Khutia,Late Gostha Bihari Dutta,Late Satish Chandra Pradhan,Sri Hrishikesh 
                Pradhan(Founder),Sri Bimal Chandra Kuila(Ex Head Master),Sri Ajit Kumar 
                Pradhan(Ex A.H.M),Sri Nikhil Ranjan Das(Ex. A.T.) Sri Pashupati Das were 
                connected with the establishment of this school.I convey my hartiest 
                congratulation to all the guardians,education interested persons for their help 
                and love to our school.A school can not achive its progress without the help of 
                its students,teachers,guardians and educational interested persons.</span></p>
                                           <p>
                                               <span class="style7">&quot;Vivekananda Sangeet Mahabidyalaya&quot; has been established in 
                                               2010-11 with a view to make our students culturally sound and grown up. 
                                               N.C.C.(Girls) was introduced in 2011-2012.We have established Science Echo 
                                               Club(Kalpan Chawla Eco Club) in 2004-05.The School Library has been recognized 
                                               as&quot;Dipak Patra Smriti Pathagar&quot; from 2010-11.Sm. Usha Patra,the wife of&nbsp; Late 
                                               Dipak Patra,Gifted Rs. 2,00,000/- for the sake of development of our school .We 
                                               are grateful to her.
                                <span class="style14">
                                <asp:LinkButton 
                                ID="LinkButton1" runat="server" PostBackUrl="~/fromheadmasterdesk.aspx">Click Here To Read More</asp:LinkButton>
                                               </span>
                                               </span>
</div>
                            <span class="style14">
                                           </p>
                            <p>
                                <b>
                                           &nbsp;</b></span></div>
                </td>
            <td colspan="3">
            <div style="text-decoration : none;">
                <h2 style="width: 234px; text-align: center; background-color: #000000; color: #FFFFFF;" class="section">NOTICE</h2>
                 <fieldset style="border: thin solid #000000;" class="section">
               <marquee direction = "up"onMouseOver="this.setAttribute('scrollamount', 0, 0);" OnMouseOut="this.setAttribute('scrollamount', 6, 0);" scrolldelay=180>
               <div style =" text-decoration : none;">
                   <asp:Panel ID="Panel1" runat="server" Width="233px" Class="Style14" Height = "500px">
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
                   </div>
                   </marquee>
                   </div>
            <div>
            <h2 style="height: 29px; width: 234px; text-align: center; background-color: #000000; color: #FFFFFF; width:234PX;" class="section">NEWS</h2>
            </div>
            <fieldset style="border: thin solid #000000;" class="section">
            <marquee direction = "up"onMouseOver="this.setAttribute('scrollamount', 0, 0);" OnMouseOut="this.setAttribute('scrollamount', 6, 0);" scrolldelay=120>
            <div style =" text-decoration : BLINK;">
                <asp:Panel ID="Panel2" runat="server" Width="233px" Height = "500px" ForeColor = "Blue">
                   OUR SCHOOL HAS COMPLETED ITS 49 YEARS ON 30 DEC 2013 AND INAUGARATION PROGRAM OF CELEBRATION OF 50 YEARS JOURNEY ALONG WITH THE FORMATION OF THE "SUBARNAJAYANTI UTSAB COMITEE" WAS HELD ON 4TH JANUARY,2014 WITH THE PRESENCE OF OUR BELOVED STUDENTS,GURDIANS,EX STUDENTS,EX TEACHERS,PRESENT MEMBERS OF THE MC AND EDUCATION INTERESTED PERSONS.HONOURABLE GUESTS OF HONOUR LIKE
                   DR.RAMPADA BERA,PROF. TUHIN KANTI DAS,HONOURABLE MLA SRIKANTA MAHATO,MR. SAIBAL GIRI,MR.MIHIR CHANDA,SK. KOWSER ALI AND OTHERS.
                </asp:Panel>
                </div>
                </marquee>
                </fieldset>
                </td>
        </tr>
        </table>
</asp:Content>
