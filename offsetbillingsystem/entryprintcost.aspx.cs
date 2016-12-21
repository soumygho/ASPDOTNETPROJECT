using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;
using offsetLibrary;
using System.Data;

public partial class entryprintcost : System.Web.UI.Page
{
    PrintCostOperation printcostops = new PrintCostOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        bindGridData();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        PrintCost printcost = new PrintCost();
        try
        {
            printcost.Color = DropDownList1.SelectedItem.Text.ToString().Trim();
            printcost.Min = Int32.Parse(TextBox1.Text);
            printcost.Max = Int32.Parse(TextBox2.Text);
            printcost.Printrate = float.Parse(TextBox3.Text);
            bool flag = printcostops.insertIntoPrintCost(printcost);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY INSERTED!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
        bindGridData();
    }

    private void bindGridData()
    {
        try
        {
            List<PrintCost> printcosts = printcostops.getPrintCost();
            if (printcosts != null)
            {
                DataTable dt = printcostops.generateTable(printcosts);
                GridView1.DataSource = dt;
                GridView1.DataBind(); 
            }
        }
        catch (Exception e)
        {
            Label1.Text = e.Message;
            Label1.Visible = true;
        }
    }
}
