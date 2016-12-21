using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class refundBill : System.Web.UI.Page
{
    SellReport sellreport = new SellReport();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bindDropDown();
    }
    private void bindDropDown()
    {
        try
        {
            int custid = Int32.Parse(userid.Text);
            CustomerDetails cust = new CustomerDetails();
            cust.Customerid = custid;
            List<Bill> bills = sellreport.readNonOnspotBill(cust);
            if (bills != null && bills.Count > 0)
            {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add(new ListItem("-SELECT-", "-SELECT-"));
                for (int i = 0; i < bills.Count;i++ )
                {
                    DropDownList1.Items.Add(new ListItem(bills[i].Id.ToString(),bills[i].Id.ToString()));
                }
            }
        }
        catch (Exception e)
        {
            Label1.Text = e.Message;
        }
    }
    BillOperation billops = new BillOperation();
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            Bill bill = new Bill();
            bill.Id = Int32.Parse(DropDownList1.SelectedValue.ToString());
            int custid = Int32.Parse(userid.Text);
            CustomerDetails cust = new CustomerDetails();
            cust.Customerid = custid;
            bill.Customer = cust;
            bool flag = billops.refundBill(bill);
            if (flag)
            {
                Label1.Text = "REFUNDED!!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
}
