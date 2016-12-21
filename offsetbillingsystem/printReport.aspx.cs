using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class printReport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    private void bindData()
    {
        if (Session["data"] != null)
        {
            DataTable dt = (DataTable)Session["data"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindData();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
