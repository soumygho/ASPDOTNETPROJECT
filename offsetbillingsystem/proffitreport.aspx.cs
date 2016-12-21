using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class proffitreport : System.Web.UI.Page
{
    ProfitReport report = new ProfitReport();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            List<Bill> bills = report.getProfitList();
            DataTable dt = report.generateTable(bills);
            Session["data"] = dt;
            bindData();
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void bindData()
    {
        DataTable dt = (DataTable)Session["data"];
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
