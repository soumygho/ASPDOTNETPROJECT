using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class flex : System.Web.UI.Page
{
    FlexOperation flexops = new FlexOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!IsPostBack)
        {
            bindData();
        }
    }

    private void bindData()
    {
        try
        {
            List<Flex> cards = flexops.readFlex();
            if (cards != null && cards.Count > 0)
            {
                Button1.Visible = false;
                TextBox1.Text = cards[0].Ratepersquarefeet.ToString();
            }
            else
            {
                Button2.Visible = false;
            }

        }
        catch (Exception e)
        {
            Label1.Text = e.Message;
            Label1.Visible = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        try
        {
            Flex flex = new Flex();
            flex.Ratepersquarefeet = float.Parse(TextBox1.Text);
            bool flag = flexops.insertActualCost(flex);
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        try
        {
            Flex flex = new Flex();
            flex.Id = 1;
            flex.Ratepersquarefeet = float.Parse(TextBox1.Text);
            bool flag = flexops.updateActualCost(flex);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY UPDATED!!!";
            }
            bindData();
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
}
