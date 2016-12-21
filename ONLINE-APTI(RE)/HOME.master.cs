using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class HOME : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }
    [System.Web.Services.WebMethod]
    public static int checkLogin()
    {
        int result = 0;
        if (HttpContext.Current.Session["username"]==null)
        {

            return result;
        }
        result = 1;
        return result;
    }
}
