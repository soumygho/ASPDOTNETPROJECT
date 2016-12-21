using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class SellSummary : System.Web.UI.Page
{
    OperationSell operationsell = new OperationSell();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["bill"] != null)
        {
            Bill bill = (Bill)Session["bill"];
            if (bill.Customer.Customerid == 0&&bill.Customer.Customername.Equals(""))
            {
                Label1.Text = "-NIL-";
                Label2.Text = "-NIL-";
                Label3.Text = "-NIL-";
                Label4.Text = "-NIL-";
                Panel1.Visible = false;
                Button2.Visible = false;
                Button5.Visible = false;
                Button4.Visible = false;
            }
            else
            {
                Label1.Text = bill.Customer.Customername;
                Label2.Text = bill.Customer.CustomerAddress;
                Label3.Text = bill.Customer.Customeremail;
                Label4.Text = bill.Customer.Customermobno;
                Label8.Text = bill.Finalamount.ToString();
                Button1.Visible = false;
            }
            Label5.Text = bill.Totalamount.ToString();
            Label6.Text = bill.Finalamount.ToString();
            GridView1.DataSource = generateOrderTable(bill);
            GridView1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            bool flag = operationsell.onspotSellNow((Bill)Session["bill"]);
            if (flag)
            {
                Label7.Text = "SOLD!!!";
            }
        }
        catch (Exception em)
        {
            Label7.Text = em.Message;
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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            float cons = float.Parse(TextBox1.Text);
            Bill bill =(Bill) Session["bill"];
            bill.Finalamount = bill.Totalamount - cons;
            bill.Cons = cons;
            Label6.Text = bill.Finalamount.ToString();
        }
        catch (Exception em)
        {
            Label7.Text = em.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            Receipt receipt = operationsell.payNow((Bill)Session["bill"],float.Parse(TextBox2.Text));
            if (receipt != null)
            {
                Session["receipt"] = receipt;
                Label7.Text = "SUCCESSFULLY SOLD!!!";
                Button2.Visible = false;
            }
        }
        catch (Exception em)
        {
            Label7.Text = em.Message;
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        Bill bill = null;
        try
        {
            bill = (Bill)Session["bill"];
            float outstanding = bill.Finalamount - float.Parse(TextBox2.Text) ;
            Label8.Text = outstanding.ToString();
        }
        catch (Exception em)
        {
            Label7.Text = em.Message;
            Label8.Text = bill.Finalamount.ToString();
        }
        
    }
}
