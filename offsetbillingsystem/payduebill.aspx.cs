using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class payduebill : System.Web.UI.Page
{
    SellReport sellreport = new SellReport();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
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
                for (int i = 0; i < bills.Count; i++)
                {
                    DropDownList1.Items.Add(new ListItem(bills[i].Id.ToString(), bills[i].Id.ToString()));
                }
            }
        }
        catch (Exception e)
        {
            Label3.Text = e.Message;
        }
    }
    BillPaymentDetailsOperation paymentops = new BillPaymentDetailsOperation();
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex > 0)
            {
                BillPaymentDetails payment = paymentops.readPaymentDetails(Int32.Parse(DropDownList1.SelectedItem.Text));
                Label1.Text = payment.Paidamount.ToString();
                Label2.Text = payment.Outstanding.ToString();
                if (payment.Outstanding <= 0)
                {
                    Button1.Enabled = false;
                }
                else
                {
                    Button1.Enabled = true;
                }
            }
        }
        catch (Exception em)
        {
            Label3.Text = em.Message;
        }
    }
    BillOperation billops = new BillOperation();
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            BillPaymentDetails payment = new BillPaymentDetails();
            payment.Billid = Int32.Parse(DropDownList1.SelectedItem.Text);
            payment.Paidamount = float.Parse(TextBox3.Text);
            CustomerDetails cust = new CustomerDetails();
            cust.Customerid = Int32.Parse(userid.Text);
            Transaction transaction = new Transaction();
            transaction.Description = "DUE BILL PAID";
            transaction.Method = "CASH";
            bool flag = billops.payDueBill(payment, transaction, cust);
            if (flag)
            {
                Label3.Text = "SUCCESSFULLY PAID!!!";
            }
        }
        catch (Exception em)
        {
            Label3.Text = em.Message;
        }
    }
}
