using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class quotation : System.Web.UI.Page
{
    bool hasCustomer = false;
    OperationSell sellops = new OperationSell();
    Bill bill = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Button4.Visible = false;
        if (Session["bill"] != null)
        {
            bill = (Bill)Session["bill"];
            if (bill.Customer.Customerid == 0 && bill.Customer.Customername.Equals(""))
            {
                Label1.Text = "-NIL-";
                Label2.Text = "-NIL-";
                Label3.Text = "-NIL-";
                Label4.Text = "-NIL-";
                Button1.Enabled = false;
            }
            else
            {
                Label1.Text = bill.Customer.Customername;
                Label2.Text = bill.Customer.CustomerAddress;
                Label3.Text = bill.Customer.Customeremail;
                Label4.Text = bill.Customer.Customermobno;
                hasCustomer = true;
                
            }
            Label5.Text = bill.Totalamount.ToString();

            GridView1.DataSource = generateOrderTable(bill);
            GridView1.DataBind();
        }
        else
        {
            Button1.Enabled = false;
        }
    }
    Quotation quotation1 = null;
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        try
        {
            quotation1 = sellops.saveQuote(bill);
            bill.Id = quotation1.Id;
            Session["bill"] = bill;
            if(quotation1.Id>0)
            {
                Label7.Text = "SUCCESSFULLY SAVED!!!";
                Button4.Visible = true;
            }
        }
        catch (Exception em)
        {
            Label4.Text = em.Message;
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
            Label7.Text = e.Message;
        }
        return dt;
    }
     protected void Button4_Click(object sender, EventArgs e)
     {
         Response.Redirect("~/printQuotation.aspx");
     }
}
