<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="HomePage" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="description" content="Welcome to Tutranga Anchal Sikshaniketan">
<meta name = "keywords" content="tutranga,tutranga anchal,tutranga anchal sikshaniketan,tutranga school,thakurchak,tasn">
<link href='http://fonts.googleapis.com/css?family=Slabo+27px' rel='stylesheet' type='text/css'>
    <style type="text/css">
        
#text
{
text-align:left;
float:left;
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
        .flash
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
width :600px;
height:450px;
float:left;
margin-left:2px;
margin-right:2px;
margin-bottom:10px;
padding:5px;
}

#sidebar
{
    float: left;
    width:200px;
    height:575px;
}
#quick
{
 margin-top:5px;   
}

        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="background-color: #CCCCCC;font-family: 'Slabo 27px', serif;">
<div class ="blink_me" >
<marquee DIRECTION="HORIZONTAL" onMouseOver="this.setAttribute('scrollamount', 0, 0);" OnMouseOut="this.setAttribute('scrollamount', 6, 0);" scrolldelay = "180">TUTRANGA ANCHAL SIKSHANIKETAN WELCOMES YOU!!!THANKS FOR VISITING US!!!NEW GOLDEN JUBILEE PAGE LAUNCHED!!!<a href='goldenjubileepage.aspx'>CLICK HERE</a></marquee>
</div>
<div>
<div>
<center>
          <div id="anvsoftJavaScriptSlideshow" style="width: 854px; height: 410px; position: relative; z-index : 0;" class="section">
  <script src="anvsoftJavaScriptSlideshow-1.0.0.min.js?xml_path=slides.xml"></script>
  <script>      anvsoftJavaScriptSlideshow.init("anvsoftJavaScriptSlideshow");</script>
  </center>
</div>
</div>
<table style="width:854px;">
<tr>
<td colspan="4" style="float:left; width:600px;">
 <h2 class="section" style="background-color: #000000; color: #FFFFFF">
                                FROM THE HEADMASTER&#39;S DESK</h2>
</td>
<td colspan="3">
 <h2 style="width: 200px; text-align: center; background-color: #000000; color: #FFFFFF;" class="section">NOTICE</h2>
</td>
</tr>
<tr>
<td colspan="4" style="float:left;width:600px;">

<div style="width:600px;">
           
            </div>
<div id="para" class="section">
 <asp:Image ID="Image6" runat="server" CssClass="img" Height="134px" 
                                Width="152px" ImageUrl="~/pic/head.gif" />
               
                                       <p style="font-family: 'Slabo 27px', serif;font-size:smaller;">
                                      
                                           <span class="style7">Our beloved school was established in 1965 with a view to spread education in 
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
                its students,teachers,guardians and educational interested persons.</span><b> <asp:LinkButton 
                                ID="LinkButton1" runat="server" PostBackUrl="~/fromheadmasterdesk.aspx">Click Here To Read More</asp:LinkButton></b>
                
                </p>
                                          
                               
                                              
</div>
                        
            
</td>
<td colspan="3" style="height:560px;">
<div id="sidebar">
 <div style="text-decoration : none; width:200px;">
               
                 <fieldset style="border: thin solid #000000; width:200px; Height = "250px"" class="section">
               <marquee behavior="scroll" direction="up" scrollamount="5" style="width:100%; height:100%; vertical-align:middle; cursor:pointer;" onmouseover="javascript:this.setAttribute('scrollamount','0');" onmouseout="javascript:this.setAttribute('scrollamount','5');" scrolldelay = 160>
               <div style =" text-decoration : none;">
                   <asp:Panel ID="Panel1" runat="server" Width="200px"  Height = "250px">
                       
                   </asp:Panel>
                   </div></marquee>
                   
                   </fieldset>
                   </div>
                   
            <div style="width:200px;">
            <h2 style=" width: 200px; text-align: center; background-color: #000000; color: #FFFFFF; " class="section">NEWS</h2>
            </div>
            <div style="width:200px;">
            <fieldset style="border: thin solid #000000; width:200px; height :210px" class = "section">
           <marquee behavior="scroll" direction="up" scrollamount="5" style="width:100%; height:100%; vertical-align:middle; cursor:pointer;" onmouseover="javascript:this.setAttribute('scrollamount','0');" onmouseout="javascript:this.setAttribute('scrollamount','5');" scrolldelay = 160>

            <div style = "text-decoration : BLINK; width : 200px;">
            
                <asp:Panel ID="Panel2" runat="server" Width="200px" Height="210px" ForeColor = "Blue">
                   OUR SCHOOL HAS COMPLETED ITS 49 YEARS ON 30 DEC 2013 AND INAUGARATION PROGRAM OF CELEBRATION OF 50 YEARS JOURNEY ALONG WITH THE FORMATION OF THE "SUBARNAJAYANTI UTSAB COMITEE" WAS HELD ON 4TH JANUARY,2014 WITH THE PRESENCE OF OUR BELOVED STUDENTS,GURDIANS,EX STUDENTS,EX TEACHERS,PRESENT MEMBERS OF THE MC AND EDUCATION INTERESTED PERSONS.HONOURABLE GUESTS OF HONOUR LIKE
                   DR.RAMPADA BERA,PROF. TUHIN KANTI DAS,HONOURABLE MLA SRIKANTA MAHATO,MR. SAIBAL GIRI,MR.MIHIR CHANDA,SK. KOWSER ALI AND OTHERS.
                </asp:Panel>
                </div></marquee>
                </fieldset>
                </div>
                </div>
                
</td>
</tr>

</table>
</div>




                
            
          
             
            


             
            
</asp:Content>
