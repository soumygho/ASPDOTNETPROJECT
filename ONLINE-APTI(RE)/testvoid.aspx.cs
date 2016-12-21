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

public partial class testvoid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["time"] != null ||  Session["username"] == null)
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }
        if (Session["testvoid"] != null)
        {
            if (Session["testvoid"].ToString().Equals("false"))
            {
                Response.Redirect("~/ErrorPage.aspx");
            }
        }
        else
        {
            Session["testvoid"] = "true";
            try
            {
                Label1.Text = Session["time"].ToString();
            }
            catch (Exception ee)
            {
                Response.Redirect("~/ONLINETEST.aspx");
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
