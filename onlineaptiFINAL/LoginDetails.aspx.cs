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

public partial class LoginDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null || Session["name"] == null || Session["password"] == null)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/HOMEPAGE.aspx");
        }
        Label1.Text = Session["username"].ToString();
        Label2.Text = Session["password"].ToString();
        Label3.Text = Session["name"].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
