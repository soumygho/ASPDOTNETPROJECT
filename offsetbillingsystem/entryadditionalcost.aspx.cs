using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class entryadditionalcost : System.Web.UI.Page
{
    ActualCostOperation costops = new ActualCostOperation();
    CategoryOperation categoryops = new CategoryOperation();
    List<Category> categories = null;
    ActualCost actualcost = null;
    Category category = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindDropdownData();
        }
        
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        bool flag = false;
        try
        {
            categories = categoryops.getCategory();
            actualcost = new ActualCost();
            actualcost.Categoryid = categories[DropDownList1.SelectedIndex - 1].Id;
            actualcost.Bindingcost = float.Parse(bindcost.Text);
           // actualcost.Colorcostperpage = float.Parse(colorcost.Text);
            actualcost.Deliverycostperunit = float.Parse(deliverycost.Text);
            actualcost.Dtpcostperpage = float.Parse(dtpcost.Text);
           // actualcost.Printcostperpage = float.Parse(printcost.Text);
            actualcost.Profit = float.Parse(additionalprofit.Text);
            flag = costops.insertActualCost(actualcost);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY INSERTED!!!";
                Button1.Visible = false;
                Button2.Visible = true;
            }
          
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }

    private void bindDropdownData()
    {
        Label1.Visible = true;
        try
        {
             categories = categoryops.getCategory();
            if (categories != null && categories.Count > 0)
            {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add(new ListItem("-SELECT-"));
                for (int i = 0; i < categories.Count; i++)
                {
                    DropDownList1.Items.Add(new ListItem(categories[i].Categoryname,categories[i].Id.ToString()));

                }

            }
        }
        catch (Exception e)
        {
            Label1.Text = e.Message;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            categories = categoryops.getCategory();
            category = categories[DropDownList1.SelectedIndex - 1];
            bindData();
        }
        catch (Exception em)
        {
            DropDownList1.SelectedIndex = 1;
            category = categories[0];
            bindData();
        }
    }
    private void bindData()
    {
        if (category != null)
        {
            List<ActualCost> actualcosts = costops.readActualcost(category);
            if (actualcosts != null && actualcosts.Count > 0)
            {
                actualcost = actualcosts[0];
              //  colorcost.Text = actualcost.Colorcostperpage.ToString();
                bindcost.Text = actualcost.Bindingcost.ToString();
                dtpcost.Text = actualcost.Dtpcostperpage.ToString();
                deliverycost.Text = actualcost.Deliverycostperunit.ToString();
                additionalprofit.Text = actualcost.Profit.ToString();
             //   printcost.Text = actualcost.Printcostperpage.ToString();
                Button1.Visible = false;
                Button2.Visible = true;
            }
            else
            {
                int i = 0;
               // colorcost.Text = i.ToString();
                bindcost.Text = i.ToString();
                dtpcost.Text = i.ToString();
                deliverycost.Text = i.ToString();
                additionalprofit.Text = i.ToString();
             //   printcost.Text = i.ToString();
                Button2.Visible = false;
                Button1.Visible = true;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        bool flag = false;
        try
        {
            actualcost = new ActualCost();
            actualcost.Categoryid = categories[DropDownList1.SelectedIndex - 1].Id;
            actualcost.Bindingcost = float.Parse(bindcost.Text);
          //  actualcost.Colorcostperpage = float.Parse(colorcost.Text);
            actualcost.Deliverycostperunit = float.Parse(deliverycost.Text);
            actualcost.Dtpcostperpage = float.Parse(dtpcost.Text);
          //  actualcost.Printcostperpage = float.Parse(printcost.Text);
            actualcost.Profit = float.Parse(additionalprofit.Text);
            flag = costops.updateActualCost(actualcost);
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
