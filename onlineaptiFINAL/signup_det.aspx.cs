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

public partial class signup_det : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"].ToString() != null && Session["name"].ToString() != null)
        {
            Label1.Text = Session["username"].ToString();
            Label2.Text = Session["name"].ToString();
        }
        else
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }
    }
}
