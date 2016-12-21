using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class dtpsell : System.Web.UI.Page
{
   
    PaperDetailsOperation paperops = new PaperDetailsOperation();
    PaperSizeOperation sizeops = new PaperSizeOperation();
    List<PaperDetails> papers = null;
    List<PaperSize> sizes = null;
    CustomerDetails customer = null;
    CustomerOperation custops = new CustomerOperation();
    ConstructCost construct = new ConstructCost();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack)
        {
            
            Label3.Text = userid.Text;
        }
        if (Session["bill"] != null)
        {


            Bill bill = (Bill)Session["bill"];
            customer = bill.Customer;
            if (customer.Customername.Equals(""))
            {
                CheckBox7.Checked = true;
                CheckBox7.Enabled = false;
                disableTexts();
            }
            else
            {
                CheckBox7.Checked = false;
                CheckBox1.Enabled = false;
                TextName.Text = customer.Customername;
                TextAddress.Text = customer.CustomerAddress;
                TextEmail.Text = customer.Customeremail;
                TextMobNo.Text = customer.Customermobno;
            }
        }
        bindData();
        if (!IsPostBack)
        {
            bindPageType();
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            printingside.Visible = true;
        }
        else
        {
            printingside.Visible = false;
        }
    }
   

    private int calculatetotalNoOfPagesPerUnit(bool printbothside)
    {
        
        int pagerequiredperunit = 0;
        try
        {
            float dtpcount = float.Parse(this.dtpcount.Text);
            int totalunits = Int32.Parse(qty.Text);
            float pagesperunit = 0;

            if (printbothside)
            {
                pagesperunit = dtpcount / 2;
                int dec = (int)pagesperunit;
                float diff = pagesperunit - dec;
                if (diff > 0)
                {
                    pagerequiredperunit = ++dec;
                }
                else
                {
                    pagerequiredperunit = dec;
                }
            }
            else
            {
                pagerequiredperunit = Int32.Parse(this.dtpcount.Text);
            }
            
        }
        catch (Exception e)
        {
        }
        return pagerequiredperunit;
    }


    private int calculateNoOfSheetsRequired(int paperspersheet,int totalpapers)
    {
        int noofsheets = 0;
        float dec = totalpapers / paperspersheet;
        int dim = (int)dec;
        float diff = dec - dim;
        if (diff > 0)
        {
            ++dim;
        }
        noofsheets = dim;
        return noofsheets;
    }
    private void bindData()
    {
        try
        {
            papers = paperops.readAllPaperDetails();
            
        }
        catch (Exception e)
        {
            Label3.Visible = true;
            Label3.Text = e.Message;
        }
    }
    private void bindPageType()
    {
        try
        {
            if (papers != null && papers.Count > 0)
            {
                pagetype.Items.Clear();
                pagetype.Items.Add(new ListItem("-SELECT-"));
                for (int i = 0; i < papers.Count; i++)
                {
                    pagetype.Items.Add(new ListItem(papers[i].Papername, papers[i].Id.ToString()));


                }
            }
        }
        catch (Exception e)
        {
            Label3.Visible = true;
            Label3.Text = e.Message;
        }
    }
    private void bindPageSize()
    {
        if (pagetype.SelectedIndex != 0)
        {
            PaperDetails paperdetails = papers[pagetype.SelectedIndex - 1];
            sizes = sizeops.readPapersizeForSpecificPaper(paperdetails);
            if (sizes != null && sizes.Count > 0)
            {
                
                papersize.Items.Clear();
                papersize.Items.Add(new ListItem("-select-"));
                for (int i = 0; i < sizes.Count; i++)
                {
                    papersize.Items.Add(new ListItem(sizes[i].Description, sizes[i].Id.ToString()));

                }
            }
        }
    }
    protected void pagetype_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindPageSize();
    }
    protected void papersize_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void qty_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox7.Checked)
        {
            disableTexts();
        }
    }

    private void disableTexts()
    {
        TextName.Enabled = false;
        TextEmail.Enabled = false;
        TextMobNo.Enabled = false;
        TextAddress.Enabled = false;
    }
    private void enableTexts()
    {
        TextName.Enabled = true;
        TextEmail.Enabled = true;
        TextMobNo.Enabled = true;
        TextAddress.Enabled = true;
    }

    private OrderDetails constructOrder()
    {
        OrderDetails orderDetails = new OrderDetails();
        orderDetails.Categoryid = Int32.Parse(categoryid.Value.ToString());
        if (CheckBox4.Checked)
        {
            if (color1.SelectedIndex != 0)
            {
                orderDetails.Color = color1.SelectedItem.Value;
            }
            if (color2.SelectedIndex != 0 && !color2.SelectedItem.Value.Equals(color1.SelectedItem.Value))
            {
                orderDetails.Color +=" "+color2.SelectedItem.Value;
            }
            if (color3.SelectedIndex != 0 && !color3.SelectedItem.Value.Equals(color1.SelectedItem.Value) && !color3.SelectedItem.Value.Equals(color2.SelectedItem.Value))
            {
                orderDetails.Color += " " + color3.SelectedItem.Value;
            }
            if (color4.SelectedIndex != 0 && !color4.SelectedItem.Value.Equals(color1.SelectedItem.Value) && !color4.SelectedItem.Value.Equals(color2.SelectedItem.Value) && !color4.SelectedItem.Value.Equals(color3.SelectedItem.Value))
            {
                orderDetails.Color += " " + color4.SelectedItem.Value;
            }

            orderDetails.Description = "OFFSET PRINTING";
        }
        else if (CheckBox8.Checked)
        {
            orderDetails.Description = "DIGITAL PRINTING";
        }

        orderDetails.Printside = printingside.SelectedItem.Text;
        if (pagetype.SelectedIndex > 0)
        {
            orderDetails.Papername = pagetype.SelectedItem.Text;
        }
        if (papersize.SelectedIndex > 0)
        {
            orderDetails.Size = papersize.SelectedItem.Text;
        }
        try
        {
            orderDetails.Qty = Int32.Parse(qty.Text);
        }
        catch (Exception e)
        {

        }
        return orderDetails;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        prepareOrder();
        Response.Redirect("~/SellSummary.aspx");
    }

    private void prepareOrder()
    {
      //  Session["bill"] = null;
        Bill bill = null;
        //get customer
        if (customer == null)
        {
            if (!CheckBox7.Checked)
            {
                if (userid.Text != null)
                {
                    customer = new CustomerDetails();
                    customer.Customerid = Int32.Parse(userid.Text.ToString());
                    customer = custops.readCustomers(customer)[0];
                }
            }
            else
            {
                customer = new CustomerDetails();
                customer.Customerid = 0;
            }

        }
        //get bill if applicable
        if (construct.getBillDetails() == null)
        {
            bill = new Bill();
            bill.Customer = customer;
            bill.Billdate = DateTime.Today.ToShortDateString();
            bill.Orders = new List<OrderDetails>();
            Session["bill"] = bill;
        }
        else
        {
            bill = (Bill)Session["bill"];
        }
        //create order
        OrderDetails order = constructOrder();
        //calculate totalnoofpagesperunit
        bool printbothside = false;
        if (printingside.SelectedIndex != 0)
        {
            printbothside = true;
        }
        int totalpagesrequired = calculatetotalNoOfPagesPerUnit(printbothside) * Int32.Parse(qty.Text);
        PaperDetails paperdetails = papers[pagetype.SelectedIndex];
        PaperSize size = sizeops.readSpecificPapersize(Int32.Parse(papersize.SelectedItem.Value))[0];
        int totalsheetsrequired = calculateNoOfSheetsRequired(size.Noofpaperspersheet, totalpagesrequired);
        float pagecost = totalsheetsrequired * paperdetails.Paperrate;
        Category cat = new Category();
        cat.Id = Int32.Parse(categoryid.Value.ToString());
        float distance = 0;
        if (CheckBox5.Checked)
        {
            distance = float.Parse(Textdistance.Text);
        }
        CostTable costtable = construct.getCost(true, CheckBox3.Checked, CheckBox6.Checked, CheckBox5.Checked, cat, Int32.Parse(qty.Text), Int32.Parse(this.dtpcount.Text), distance);
        //set page cost
        costtable.Pagecost = pagecost;
        costtable.Totalcost += costtable.Pagecost;
        //get print cost
        if (CheckBox4.Checked)
        {
            List<PrintCost> printcosts = new List<PrintCost>();
            PrintCost printcost = null;
            if (color1.SelectedIndex != 0)
            {
                printcost = new PrintCost();
                printcost.Color = color1.SelectedItem.Value;
                printcosts.Add(printcost);
            }
            if (color2.SelectedIndex != 0 && !color2.SelectedItem.Value.Equals(color1.SelectedItem.Value))
            {
                printcost = new PrintCost();
                printcost.Color = color2.SelectedItem.Value;
                printcosts.Add(printcost);
            }
            if (color3.SelectedIndex != 0 && !color3.SelectedItem.Value.Equals(color1.SelectedItem.Value) && !color3.SelectedItem.Value.Equals(color2.SelectedItem.Value))
            {
                printcost = new PrintCost();
                printcost.Color = color3.SelectedItem.Value;
                printcosts.Add(printcost);
            }
            if (color4.SelectedIndex != 0 && !color4.SelectedItem.Value.Equals(color1.SelectedItem.Value) && !color4.SelectedItem.Value.Equals(color2.SelectedItem.Value) && !color4.SelectedItem.Value.Equals(color3.SelectedItem.Value))
            {
                printcost = new PrintCost();
                printcost.Color = color4.SelectedItem.Value;
                printcosts.Add(printcost);
            }

            costtable = construct.getPrintCostForOffset(costtable, printcosts, Int32.Parse(this.dtpcount.Text), Int32.Parse(qty.Text));

        }
        else if (CheckBox8.Checked)
        {
            costtable = construct.getPrintCostForDigitalPrinting(costtable, Int32.Parse(this.dtpcount.Text), Int32.Parse(qty.Text));
        }
        costtable = construct.setProfit(costtable);
        order = construct.setCost(order, costtable);
        bill = construct.setOrderIntoBill(bill, order);
        bill = construct.setTotalValue();
        Session["bill"] = bill;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        prepareOrder();
        Response.Redirect("~/itemchoice.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        prepareOrder();
        Response.Redirect("~/quotation.aspx");
    }
}
