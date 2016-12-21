using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class entrydigitalprintingdetails : System.Web.UI.Page
{
    DigitalPrintingOperation digitalops = new DigitalPrintingOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!IsPostBack)
        {
            bindData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        DigitalPrintingCost cost = new DigitalPrintingCost();
        try
        {
            cost.Rateperpage = float.Parse(TextBox1.Text);
            bool flag = digitalops.insertIntoDigitalPrintingCost(cost);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY INSERTED!!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }

    private void bindData()
    {
        try
        {
            List<DigitalPrintingCost> costs = digitalops.getPrintingCost();
            if (costs != null && costs.Count > 0)
            {
                Button1.Visible = false;
                TextBox1.Text = costs[0].Rateperpage.ToString();
            }
            else
            {
                Button2.Visible = false;
            }
        }
        catch (Exception e)
        {
            Label1.Visible = true;
            Label1.Text = e.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        DigitalPrintingCost cost = new DigitalPrintingCost();
        try
        {
            cost.Rateperpage = float.Parse(TextBox1.Text);
            bool flag = digitalops.updatePrintCost(cost);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY UPDATED!!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
}
