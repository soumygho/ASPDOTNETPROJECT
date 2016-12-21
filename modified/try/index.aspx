<%@ Page Language="C#" MasterPageFile="~/HomePage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="HomePage" Title="::WELCOME TO TUTRANGA ANCHAL SIKSHANIKETAN::" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit"  TagPrefix="cc1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
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
            width: 875px;
            border:2px solid #8D8D8D;
      color:#000;
      border-radius:5px; 
      border: 1px solid #2b4479;
  border: 1px solid #2d4373;
  -webkit-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -o-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -moz-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  -ms-box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
  box-shadow: 0 1px 2px rgba(2, 2, 2, 0.25), inset 0 1px 1px rgba(255, 255, 255, 0.15);
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
        }
        #tech
        {
            height: 275px;
            width: 866px;
        }
        .link
        {
            text-decoration : none;
            color : Blue;
        }
        </style>
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="body">
        <tr>
            <td colspan="7">
                <div class="flash">
      <object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" 
                        codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,0,0" 
                        id="tech" align="middle" >
        <param name="movie" value="FLASH.swf" />
        <param name="quality" value="high" />
        <param name="allowFullScreen" value="true" />
        <param name="wmode" value="transparent" />
        <param name="allowScriptAccess" value="always" />
        <param name="_flashcreator" value="http://www.photo-flash-maker.com" />
        <param name="_flashhost" value="http://www.go2album.com" />
        <embed src="FLASH.swf" width="640" height="480" quality="high" allowFullScreen="true" wmode="transparent" allowScriptAccess="always" name="tech" align="middle" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />
      </object>
    </div>

                </td>
        </tr>
        <tr>
            <td colspan="4">
            <div>
            <h2 class="style13" style="background-color: #000066; color: #FFFFFF">
                                FROM THE HEADMASTER&#39;S DESK</h2>
 <asp:Image ID="Image6" runat="server" CssClass="img" Height="134px" 
                                Width="152px" ImageUrl="~/pic/head.gif" />
                <b>
                                       <p>
                                           </b><span class="style7">Our beloved school was established in 1965 with a view to spread education in 
                            the rural locality since the dawn of its foundation and till date
                                         it has been playing a great role to spread &quot;Education for all&quot;,Our school 
                                         obtained recognition as (X)
                standard school in 1971 and it achieved X+2 standard in 2005-06.It has obtained 
                necessary permission to teach vocational courses in VIII+ &amp; X+ in 2006-2007 and 
                it is continuing its educational programme without any interruption.Honourable 
                persons like Late Bipin Bihari Santra(Doner),Late Nityananda Das,Late Priya Nath 
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
                            <span class="style14">
                                           </p>
                            <p>
                                <b>
                                           &nbsp;</b></span></div>
                </td>
            <td colspan="3">
            <div>
                <h2 style="width: 234px; text-align: center; background-color: #000066; color: #FFFFFF;">NOTICE</h2>
                 <fieldset style="border: thin solid #000000;" class=" section">
               <marquee direction = "up" onmouseover="this.stop()" onmouseout="this.start()">
               <div >
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
                   </div></marquee>
                   </div>
            <div>
            <h2 style="height: 29px; width: 234px; text-align: center; background-color: #000066; color: #FFFFFF; width:234PX;">NEWS</h2>
            </div>
            <fieldset style="border: thin solid #000000;" class=" section">
            <marquee direction = "up" onmouseover="this.stop()" onmouseout="this.start()">
            <div style =" text-decoration : BLINK;">
                <asp:Panel ID="Panel2" runat="server" Width="233px" Height = "500px" ForeColor = "Red">
                <b>
                   OUR SCHOOL HAS COMPLETED ITS 49 YEARS ON 30 DEC 2013 AND INAUGARATION PROGRAM OF CELEBRATION OF 50 YEARS JOURNEY ALONG WITH THE FORMATION OF THE "SUBARNAJAYANTI UTSAB COMITEE" WAS HELD ON 4TH JANUARY,2014 WITH THE PRESENCE OF OUR BELOVED STUDENTS,GURDIANS,EX STUDENTS,EX TEACHERS,PRESENT MEMBERS OF THE MC AND EDUCATION INTERESTED PERSONS.HONOURABLE GUESTS OF HONOUR LIKE
                   DR.RAMPADA BERA,PROF. TUHIN KANTI DAS,HONOURABLE MLA SRIKANTA MAHATO,MR. SAIBAL GIRI,MR.MIHIR CHANDA,SK. KOWSER ALI AND OTHERS.
                   </b>
                </asp:Panel>
                </div></marquee>
                </fieldset>
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

