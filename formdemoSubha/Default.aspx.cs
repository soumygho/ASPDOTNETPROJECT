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
        try
        {
            Label1.Text = Request.Form["name"].ToString();
            Label2.Text = Request.Form["mobno"].ToString();

            for (int i = 0; i < Request.Headers.Count; i++)
            {
                Label3.Text += Request.Headers.Get(i).ToString();
            }
        }
        catch (Exception em)
        {
            Response.Redirect("index.htm");
        }
    }
}
