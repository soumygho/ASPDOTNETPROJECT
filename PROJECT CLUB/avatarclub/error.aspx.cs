using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["error"] == null)
        {
            Response.Redirect("~/registration.aspx");
        }
        else
        {
            Label1.Text = Session["error"].ToString();
            Session["error"] = null;
        }
        Session.Abandon();
        Session.Clear();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
}
