using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class sellreport : System.Web.UI.Page
{
    SellReport sellReport = new SellReport();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["bill"] = null;
        if (!IsPostBack)
        {
            List<Bill> bills = sellReport.readOnspotBill();
            DataTable dt = sellReport.generateTableForOnspotBill(bills);
            Session["onspot"] = dt;
            bills = sellReport.readNonOnspotBill();
            dt = sellReport.generateTableForOnspotBill(bills);
            Session["nononspot"] = dt;
            loaddata();
           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            CustomerDetails customer = new CustomerDetails();
            customer.Customerid = Int32.Parse(userid.Text);
            List<Bill> bills = sellReport.readNonOnspotBill(customer);
            DataTable dt = null;
            
            dt = sellReport.generateTableForNOnOnspotBill(bills);
            Session["nononspot"] = dt;
            loaddata();
        }
        catch (Exception em)
        {
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        loaddata();
    }
    private void loaddata()
    {
        try
        {
            DataTable dt = (DataTable)Session["onspot"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dt = (DataTable)Session["nononspot"];
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        catch (Exception em)
        {
            LabelError.Text = em.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["billid"] = Int32.Parse(TextBox3.Text);
        Response.Redirect("~/billdetails.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["data"] = null;
        Response.Redirect("~/printreport.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            List<Bill> bills = sellReport.readOnspotBillByYear(Int32.Parse(DropDownList2.Text));
            DataTable dt = sellReport.generateTableForOnspotBill(bills);
            Session["onspot"] = dt;
            bills = sellReport.readNonOnspotBillByYear(Int32.Parse(DropDownList2.Text));
            dt = sellReport.generateTableForNOnOnspotBill(bills);
            Session["nononspot"] = dt;
            loaddata();
        }
        catch (Exception em)
        {
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            List<Bill> bills = sellReport.readOnspotBillByMonth(Int32.Parse(DropDownList1.Text));
            DataTable dt = sellReport.generateTableForOnspotBill(bills);
            Session["onspot"] = dt;
            bills = sellReport.readNonOnspotBillByMonth(Int32.Parse(DropDownList1.Text));
            dt = sellReport.generateTableForNOnOnspotBill(bills);
            Session["nononspot"] = dt;
            loaddata();
        }
        catch (Exception em)
        {
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            List<Bill> bills = sellReport.readOnspotBillByDate(TextBox2.Text);
            DataTable dt = sellReport.generateTableForOnspotBill(bills);
            Session["onspot"] = dt;
            bills = sellReport.readNonOnspotBillByDate(TextBox2.Text);
            dt = sellReport.generateTableForNOnOnspotBill(bills);
            Session["nononspot"] = dt;
            loaddata();
        }
        catch (Exception em)
        {
        }
    }
}
