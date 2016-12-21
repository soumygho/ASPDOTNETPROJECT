using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class successful : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            UserDetails user = (UserDetails)Session["user"];
            Label1.Text = "REGISTRATION SUCCESSFUL!!!!Please note the user id for future reference.YOUR USERID IS : " + user.id;
            Session.Abandon();
            Session.Clear();
        }
        else
        {
            Response.Redirect("~/registartion.aspx");
        }
    }
}
