using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class usertransactionSummary : System.Web.UI.Page
{
    UserTransactionReport transactionreport = new UserTransactionReport();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int id = Int32.Parse(userid.Text);
            CustomerDetails customer = new CustomerDetails();
            customer.Customerid = id;
            List<UserTransaction> transactions = transactionreport.getUserTransactions(customer);
            bindGridData(transactions);
        }
        catch (Exception em)
        {
            Label2.Text = em.Message;
        }
    }

    private void bindGridData(List<UserTransaction> transactions)
    {
        try
        {
            
            DataTable dt = transactionreport.generateTableForOnspotBill(transactions);
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
        try
        {
            int id = Int32.Parse(userid.Text);
            CustomerDetails customer = new CustomerDetails();
            customer.Customerid = id;
            List<UserTransaction> transactions = transactionreport.getUserTransactions(customer,TextBox3.Text);
            bindGridData(transactions);
        }
        catch (Exception em)
        {
            Label2.Text = em.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
}
