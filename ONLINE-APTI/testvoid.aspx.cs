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
        if (Session["time"] != null)
            Response.Redirect("~/HOMEPAGE.aspx");
        else
            try
            {
                Label1.Text = Session["time"].ToString();
            }
            catch (Exception ee)
            {
                Response.Redirect("~/ONLINETEST.aspx");
            }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
