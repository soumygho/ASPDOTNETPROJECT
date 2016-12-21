<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="utf-8" %>
<%@ Import Namespace="SocialNetworkingSiteLibrary" %>
<!doctype html>

<script runat="server">

    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    ClassConvertServerSideDatatoClientSidedata servertoclient = new ClassConvertServerSideDatatoClientSidedata();
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            confLabel.Visible = false;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
       ClassUserId userid = new ClassUserId();
        
        userid.Name = TextName.Text.Trim();
        userid.Password = TextPassword.Text.Trim();
        userid.Doj = DateTime.Today.ToShortDateString();
        userid.Email = TextEmail.Text.Trim();
        RegistrationService.RegistrationWebService client = new RegistrationService.RegistrationWebService();
        bool flag = false;
        try
        {
            flag = client.registerUser(clienttoserver.convertToServerSideClassUserId(userid));
        }
        catch (Exception em)
        {
            confLabel.Visible = true;
            confLabel.Text = em.Message.ToString();
        }
        if (flag)
        {
            confLabel.Visible = true;
            confLabel.Text = "SIGNUP PROCESS SUCCESSFUL!!!";
        }
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ClassUserId userid = new ClassUserId();
        userid.Email = TextEmailId.Text.ToString().Trim();
        userid.Password = TextPwd.Text.ToString().Trim();
        RegistrationService.RegistrationWebService client = new RegistrationService.RegistrationWebService();
         RegistrationService.ClassUserId user =  client.login(clienttoserver.convertToServerSideClassUserId(userid));
        if (user.Activated==1)
        {
            Session["user"] = user;
            Response.Redirect("~//userwall.aspx");
        }
    }
</script>

<html>
<head>
<meta charset="utf-8">

<title>LOGIN OR REGISTRATION</title>

<style type="text/css">

body {
	font: 100%/1.4 Verdana, Arial, Helvetica, sans-serif;
	background-color: #42413C;
	margin: 0;
	padding: 0;
	color: #000;
}
/* ~~ Element/tag selectors ~~ */
ul, ol, dl { /* Due to variations between browsers, it's best practices to zero padding and margin on lists. For consistency, you can either specify the amounts you want here, or on the list items (LI, DT, DD) they contain. Remember that what you do here will cascade to the .nav list unless you write a more specific selector. */
	padding: 0;
	margin: 0;
}
h1, h2, h3, h4, h5, h6, p {
	margin-top: 0;	 /* removing the top margin gets around an issue where margins can escape from their containing block. The remaining bottom margin will hold it away from any elements that follow. */
	padding-right: 15px;
	padding-left: 15px;
        width: 500px;
        height: 26px;
    }
a img { /* this selector removes the default blue border displayed in some browsers around an image when it is surrounded by a link */
	border: none;
}
/* ~~ Styling for your site's links must remain in this order - including the group of selectors that create the hover effect. ~~ */
a:link {
	color: #42413C;
	text-decoration: underline; /* unless you style your links to look extremely unique, it's best to provide underlines for quick visual identification */
}
a:visited {
	color: #6E6C64;
	text-decoration: underline;
}
a:hover, a:active, a:focus { /* this group of selectors will give a keyboard navigator the same hover experience as the person using a mouse. */
	text-decoration: none;
}
/* ~~ This fixed width container surrounds all other blocks ~~ */
.container {
	width: 960px;
	background-color: #FFFFFF;
	margin: 0 auto; /* the auto value on the sides, coupled with the width, centers the layout */
}
/* ~~ The header is not given a width. It will extend the full width of your layout. ~~ */
header {
	background-color: #ADB96E;
}
/* ~~ These are the columns for the layout. ~~ 

1) Padding is only placed on the top and/or bottom of the block elements. The elements within these blocks have padding on their sides. This saves you from any "box model math". Keep in mind, if you add any side padding or border to the block itself, it will be added to the width you define to create the *total* width. You may also choose to remove the padding on the element in the block element and place a second block element within it with no width and the padding necessary for your design.

2) No margin has been given to the columns since they are all floated. If you must add margin, avoid placing it on the side you're floating toward (for example: a right margin on a block set to float right). Many times, padding can be used instead. For blocks where this rule must be broken, you should add a "display:inline" declaration to the block element's rule to tame a bug where some versions of Internet Explorer double the margin.

3) Since classes can be used multiple times in a document (and an element can also have multiple classes applied), the columns have been assigned class names instead of IDs. For example, two sidebar blocks could be stacked if necessary. These can very easily be changed to IDs if that's your preference, as long as you'll only be using them once per document.

4) If you prefer your nav on the left instead of the right, simply float these columns the opposite direction (all left instead of all right) and they'll render in reverse order. There's no need to move the blocks around in the HTML source.

*/
.sidebar1 {
	float: left;
	width: 180px;
	background-color: #EADCAE;
	padding-bottom: 10px;
}
.content {
	padding: 10px 0;
	width: 600px;
	float: left;
}
aside {
	float: left;
	width: 180px;
	background-color: #EADCAE;
	padding: 10px 0;
}

/* ~~ This grouped selector gives the lists in the .content area space ~~ */
.content ul, .content ol {
	padding: 0 15px 15px 40px; /* this padding mirrors the right padding in the headings and paragraph rule above. Padding was placed on the bottom for space between other elements on the lists and on the left to create the indention. These may be adjusted as you wish. */
}

/* ~~ The navigation list styles (can be removed if you choose to use a premade flyout menu like Spry) ~~ */
ul.nav {
	list-style: none; /* this removes the list marker */
	border-top: 1px solid #666; /* this creates the top border for the links - all others are placed using a bottom border on the LI */
	margin-bottom: 15px; /* this creates the space between the navigation on the content below */
}
ul.nav li {
	border-bottom: 1px solid #666; /* this creates the button separation */
}
ul.nav a, ul.nav a:visited { /* grouping these selectors makes sure that your links retain their button look even after being visited */
	padding: 5px 5px 5px 15px;
	display: block; /* this gives the link block properties causing it to fill the whole LI containing it. This causes the entire area to react to a mouse click. */
	width: 160px;  /*this width makes the entire button clickable for IE6. If you don't need to support IE6, it can be removed. Calculate the proper width by subtracting the padding on this link from the width of your sidebar container. */
	text-decoration: none;
	background-color: #C6D580;
}
ul.nav a:hover, ul.nav a:active, ul.nav a:focus { /* this changes the background and text color for both mouse and keyboard navigators */
	background-color: #ADB96E;
	color: #FFF;
}

/* ~~ The footer ~~ */
footer {
	padding: 10px 0;
	background-color: #CCC49F;
	position: relative;/* this gives IE6 hasLayout to properly clear */
	clear: both; /* this clear property forces the .container to understand where the columns end and contain them */
}
/* ~~ Miscellaneous float/clear classes ~~ */
.fltrt {  /* this class can be used to float an element right in your page. The floated element must precede the element it should be next to on the page. */
	float: right;
	margin-left: 8px;
}
.fltlft { /* this class can be used to float an element left in your page. The floated element must precede the element it should be next to on the page. */
	float: left;
	margin-right: 8px;
}
.clearfloat { /* this class can be placed on a <br /> or empty block element as the final element following the last floated block (within the .container) if the footer is removed or taken out of the .container */
	clear:both;
	height:0;
	font-size: 1px;
	line-height: 0px;
}

/*HTML 5 support - Sets new HTML 5 tags to display:block so browsers know how to render the tags properly. */
header, section, footer, aside, article, figure {
	display: block;
}
    .style1
    {
    }
    .style2
    {
        width: 100%;
    }
    .style3
    {
        height: 26px;
        width: 218px;
    }
    .style4
    {
        width: 235px;
    }
    .style5
    {
        height: 26px;
        width: 235px;
    }
    .sideimg
    {
        opacity : 0.4;
    }
    .style8
    {
    }
    .style9
    {
        height: 32px;
    }
    .style10
    {
        width: 235px;
        height: 32px;
    }
    -->
</style><!--[if lt IE 9]>
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]--></head>

<body>

    <form id="form1" runat="server">

<div class="container" style="background-image: url('img/back.jpg')">
  <header>
    <a href="#"><img src="" alt="Insert Logo Here" width="180" height="90" id="Insert_logo" style="background-color: #C6D580; display:block;" /></a>
  </header>
  
  
  <article class="content">
  <div>
    <table class="style2" 
        style="padding: inherit; margin: auto;  width: 552px;color: #FFFFFF">
        <tr>
        <td class="style1" colspan="2"> <h2 style="color: #FFFFFF">NEW USER REGISTRATION<asp:ScriptManager 
                ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            </h2></td>
        <td class="style1" rowspan="15"> 
            <asp:Image ID="Image1" runat="server" Height="616px" 
                ImageUrl="~/img/guitar-player-2005.jpg" Width="420px" 
                CssClass ="sideimg" />
            </td>
        </tr>
        <tr>
            <td class="style8">
                ENTER YOUR NAME</td>
            <td class="style4">
                <asp:TextBox ID="TextName" runat="server" Width="236px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                ENTER EMAIL ID</td>
            <td class="style4">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="TextEmail" runat="server" Width="235px"></asp:TextBox>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td class="style3">
                ENTER PASSWORD</td>
            <td class="style5">
                <asp:TextBox ID="TextPassword" runat="server" Width="233px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                RE-ENTER PASSWORD&nbsp;</td>
            <td class="style4">
                <asp:TextBox ID="TextRePassword" runat="server" Width="233px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Label ID="confLabel" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style4">
                &nbsp; &nbsp; <asp:Button ID="Button2" runat="server" Text="SIGNUP" 
                    onclick="Button2_Click" />
                &nbsp; &nbsp; &nbsp;&nbsp; <asp:Button ID="Button3" runat="server" 
                    Text="CANCEL" onclick="Button3_Click" />
            </td>
        </tr>
        <tr>
            <td class="style8" colspan="2">
                <h2>CURRENT USER LOGIN HERE</h2></td>
        </tr>
        <tr>
            <td class="style8">
                EMAIL ID&nbsp;</td>
            <td class="style4">
                <asp:TextBox ID="TextEmailId" runat="server" Width="232px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                PASSWORD</td>
            <td class="style4">
                <asp:TextBox ID="TextPwd" runat="server" Width="232px" TextMode="Password" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style4">
                <asp:Button ID="Button4" runat="server" Text="LOGIN" onclick="Button4_Click" />
            </td>
        </tr>
        <tr>
            <td class="style9">
                </td>
            <td class="style10">
                <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="White">FORGOT PASSORD?</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
        </tr>
    </table>
     
    </section>
    <section>
      
    </section>
    </div>
  <!-- end .content --></article>
  <footer>
    <p>This footer contains the declaration position:relative; to give Internet Explorer 6 hasLayout for the footer and cause it to clear correctly. If you're not required to support IE6, you may remove it.</p>
    <address>
      Address Content
    </address>
  </footer>
  <!-- end .container --></div>
    </form>
</body>
</html>
