using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using offsetLibrary;

public partial class printQuotation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["bill"] != null)
        {
            Bill bill = (Bill)Session["bill"];
            lblbillid.Text = bill.Id.ToString();
            GridView1.DataSource = generateOrderTable(bill);
            GridView1.DataBind();
            lblname.Text = bill.Customer.Customername;
            lblMob.Text = bill.Customer.Customermobno;
            lblAddress.Text = bill.Customer.CustomerAddress;
            lblTotal.Text = bill.Totalamount.ToString();

        }
        
    }
    private DataTable generateOrderTable(Bill bill)
    {
        DataTable dt = null;
        try
        {
            List<OrderDetails> orders = bill.Orders;
            if (orders != null && orders.Count > 0)
            {
                dt = new DataTable();
                DataColumn dc = new DataColumn("INDEX");
                dt.Columns.Add(dc);
                dc = new DataColumn("DESCRIPTION");
                dt.Columns.Add(dc);
                dc = new DataColumn("QTY");
                dt.Columns.Add(dc);
                dc = new DataColumn("COST");
                dt.Columns.Add(dc);
                int index = 0;
                for (int i = 0; i < orders.Count; i++)
                {
                    ++index;
                    OrderDetails order = orders[i];
                    DataRow dr = dt.NewRow();
                    dr["INDEX"] = index;
                    dr["DESCRIPTION"] = order.Description;
                    dr["QTY"] = order.Qty;
                    dr["COST"] = order.Cost.Totalcost;
                    dt.Rows.Add(dr);
                }
            }
        }
        catch (Exception e)
        {

        }
        return dt;
    }
}
