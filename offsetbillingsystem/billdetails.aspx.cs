using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class billdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["billid"] != null)
        {
            try
            {
                int billid = Int32.Parse(Session["billid"].ToString());
                bindData(billid);
            }
            catch (Exception em)
            {
                Label1.Text = em.Message;
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    OrderDetailsReport orderreport = new OrderDetailsReport();
    BillPaymentDetailsOperation paymentops = new BillPaymentDetailsOperation();
    AdminTransactionReport adminreport = new AdminTransactionReport();
    
    private void bindData(int billid)
    {
        try
        {
            Bill bill = new Bill();
            bill.Id = billid;
            List<OrderDetails> orders = orderreport.getOrdersForBill(bill);
            DataTable dt = orderreport.generateTableForOrders(orders);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            List<AdminTransaction> admintransactions = adminreport.getUserTransactions(billid);
            dt = adminreport.generateTableForAdminTransaction(admintransactions);
            GridView4.DataSource = dt;
            GridView4.DataBind();
            List<CostTable> costs = orderreport.getCostTable(orders);
            dt = orderreport.generateTableForCost(costs);
            GridView3.DataSource = dt;
            GridView3.DataBind();
            BillPaymentDetails payment = paymentops.readPaymentDetails(billid);
            List<BillPaymentDetails> payments = new List<BillPaymentDetails>();
            payments.Add(payment);
            dt = paymentops.generatePaymentDetailstable(payments);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
}
