using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class dtpdataentry : System.Web.UI.Page
{
    DtpOperation dtpops = new DtpOperation();
    List<Dtp> dtps = null;
    Dtp dtp = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        bindGridData();
       
        Label1.Visible = false;
        Label2.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex > 0)
        {
            Label1.Visible = true;
            Dtp dtp = new Dtp();
            dtp.Papersize = TextBox1.Text.ToString().ToUpper().Trim();
            try
            {
                dtp.Rateperpage = float.Parse(TextBox2.Text);
                dtp.Type = DropDownList2.SelectedItem.Value;
                bool flag = dtpops.insertIntoDtp(dtp);
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
    }

    private void bindGridData()
    {
        
        Label2.Visible = true;
        try
        {
            
            List<Dtp> dtps = dtpops.readDtp();
            if (dtps != null)
            {
                GridView1.DataSource = dtpops.generateTable(dtps);
                GridView1.DataBind();
            }
        }
        catch (Exception e)
        {
            Label2.Text = e.Message;
        }

    }
    private void bindDropDownData()
    {
        if (DropDownList3.SelectedIndex > 0)
        {
            try
            {
                if (DropDownList3.SelectedIndex == 1)
                {
                    dtps = dtpops.readColorxeroxDtp();
                }
                else
                {
                    dtps = dtpops.readxeroxDtp();
                }
                if (dtps != null && dtps.Count > 0)
                {
                    DropDownList1.Items.Add("-SELECT-");
                    for (int i = 0; i < dtps.Count; i++)
                    {
                        DropDownList1.Items.Add(new ListItem(dtps[i].Papersize, dtps[i].Id.ToString()));
                    }
                }
            }
            catch (Exception e)
            {
                Label1.Text = e.Message;
            }
        }
    }
   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            dtp = new Dtp();
            dtp.Type = DropDownList3.SelectedValue;
            dtp.Papersize = DropDownList1.SelectedItem.Text;
            List<Dtp> dtps = dtpops.readDtp(dtp);
            dtp = dtps[0];
            TextBox3.Text = dtp.Rateperpage.ToString();
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        Label2.Visible = true;
        try
        {
            dtp = new Dtp();
            dtp.Papersize = DropDownList1.SelectedItem.Text;
            dtp.Type = DropDownList3.SelectedValue;
            dtp.Rateperpage = float.Parse(TextBox3.Text);
            bool flag = dtpops.upadteDtp(dtp);
            if (flag)
            {
                Label2.Text = "SUCCESSFULLY UPDATED!!!";
            }
        }
        catch (Exception em)
        {
            Label2.Text = em.Message;
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        bindDropDownData();
    }
}
