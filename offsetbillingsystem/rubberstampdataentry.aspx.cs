using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class rubberstampdataentry : System.Web.UI.Page
{
    RubberStampOperation stampops = new RubberStampOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindDropdown();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string modelno = TextBox1.Text.Trim();
            float rate = float.Parse(TextBox2.Text);
            RubberStamp stamp = new RubberStamp();
            stamp.Modelno = modelno;
            stamp.Rate = rate;
            bool flag = stampops.insertIntoRubberStamp(stamp);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY INSERTED!!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
        bindDropdown();
    }
    private void bindDropdown()
    {
        try
        {
            List<RubberStamp> stamps = stampops.readRubberStamp();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add(new ListItem("-SELECT-","-SELECT-"));
            if (stamps != null && stamps.Count > 0)
            {
                for (int i = 0; i < stamps.Count; i++)
                {
                    DropDownList1.Items.Add(new ListItem(stamps[i].Modelno,stamps[i].Modelno));
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
            if (DropDownList1.SelectedIndex != 0)
            {
                RubberStamp stamp = new RubberStamp();
                stamp.Modelno = DropDownList1.SelectedItem.Value;
                List<RubberStamp> stamps = stampops.readRubberStamp(stamp);
                TextBox3.Text = stamps[0].Rate.ToString();
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (DropDownList1.SelectedIndex != 0)
            {
                RubberStamp stamp = new RubberStamp();
                stamp.Modelno = DropDownList1.SelectedValue.ToString();
                stamp.Rate = float.Parse(TextBox3.Text);
              bool isdone =  stampops.upadteRubberStamp(stamp);
              if (isdone)
              {
                  Label1.Text = "UPDATE SUCCESSFUL!!!";
              }
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
        bindDropdown();
    }
}
