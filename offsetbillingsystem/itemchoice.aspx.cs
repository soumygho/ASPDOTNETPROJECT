using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class itemchoice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedIndex)
        {
            case 0:
                Response.Redirect("~/dtpsell.aspx");
                break;
            case 1:
                Response.Redirect("~/flexsell.aspx");
                break;
            case 2:
                Response.Redirect("~/identitycardsell.aspx");
                break;
            case 3:
                Response.Redirect("~/rubberstampsell.aspx");
                break;
            case 4:
                Response.Redirect("~/passportsizephotosell.aspx");
                break;
            case 5:
                Response.Redirect("~/xerox.aspx");
                break;
            case 6:
                Response.Redirect("~/colorxeroxsell.aspx");
                break;
        }
    }
}
