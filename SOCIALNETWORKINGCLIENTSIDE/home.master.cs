using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialNetworkingSiteLibrary;

public partial class home : System.Web.UI.MasterPage
{
    ClassUserId user = new ClassUserId();
    RegistrationService.RegistrationWebService registrationservice = new RegistrationService.RegistrationWebService();
    ClassConvertClientDataToServerSideData clienttoserver = new ClassConvertClientDataToServerSideData();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            user.Userid = ((RegistrationService.ClassUserId)Session["user"]).Userid;
            RegistrationService.ClassUserDetails userdetails = registrationservice.getUserDetails(clienttoserver.convertToServerSideClassUserId(user));
            
            Image1.ImageUrl = "~/ImageHandler.ashx?url=" + user.Userid + "//image//profilepic.png";
            LinkButton1.Text = userdetails.Name;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        registrationservice.logOut((RegistrationService.ClassUserId)Session["user"]);
        Response.Redirect("~//index.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~//Usertimeline.aspx?id="+user.Userid);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~//userwall.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~//searchResult.aspx?q=" + TextBox1.Text.Trim());
    }
}
