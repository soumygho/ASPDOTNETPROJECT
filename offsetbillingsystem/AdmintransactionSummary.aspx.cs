using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using offsetLibrary;

public partial class AdmintransactionSummary : System.Web.UI.Page
{
    AdminTransactionReport transReport = new AdminTransactionReport();
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!IsPostBack)
        {
            try
            {
                List<AdminTransaction> transactions = transReport.getUserTransactions();
                Session["transactions"] = transactions;
                bindData(transactions);
            }
            catch (Exception em)
            {
                Label1.Text = em.Message;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    
    private void bindData(List<AdminTransaction> transactions)
    {
        try
        {
            DataTable dt = transReport.generateTableForAdminTransaction(transactions);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception e)
        {
            throw e;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {


    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bindData((List<AdminTransaction>)Session["transactions"]);
    }
}
