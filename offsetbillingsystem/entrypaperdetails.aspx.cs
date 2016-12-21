using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;
using System.Data;

public partial class entrypaperdetails : System.Web.UI.Page
{
    PaperDetailsOperation ops = new PaperDetailsOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        bindData();
        if (!IsPostBack)
        {
            bindDropDownData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        bool flag = false;
        if (!TextBox1.Text.Equals(""))
        {
            PaperDetails paper = new PaperDetails();
             paper.Papername = TextBox1.Text.Trim().ToUpper();
             
             try
             {
                 paper.Paperrate = float.Parse(TextBox2.Text);
                 flag = ops.insertIntoPaperDetails(paper);
             }
             catch (Exception em)
             {
                 Label1.Text = em.Message;
             }
             if (flag)
             {

                 Label1.Text = "PAPER DETAILS ADDED!!!";
                 
             }
             else
             {
                 Label1.Text = "PAPER NOT ADDED!!!";
             }
             bindData();
        }
    }
    List<PaperDetails> papers = null;
    private void bindData()
    {
        try
        {
             papers = ops.readAllPaperDetails();
            if (papers != null)
            {
                GridView1.AutoGenerateColumns = true;
                DataTable table = ops.generatePageDetailsTable(papers);
                GridView1.DataSource = table;
                GridView1.DataBind();
                
                
                
            }
            
        }
        catch (Exception e)
        {
            Label1.Visible = true;
            Label1.Text = e.Message;
        }
    }

    private void bindDropDownData()
    {
        if (papers!=null&&papers.Count > 0)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add(new ListItem("-SELECT-"));
            for (int i = 0; i < papers.Count; i++)
            {
                DropDownList1.Items.Add(new ListItem(papers[i].Papername, papers[i].Id.ToString()));


            }
        }
    }
    PaperDetails paper = null;
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (papers != null)
        {
            TextBox3.Text = papers[DropDownList1.SelectedIndex-1].Paperrate.ToString();
            paper = papers[DropDownList1.SelectedIndex-1];
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        if (papers != null)
        {
            paper = papers[DropDownList1.SelectedIndex-1];
            try
            {
                paper.Paperrate = float.Parse(TextBox3.Text.Trim());
                bool flag = ops.upadtePaperDetails(paper);
                if (flag)
                {
                    Label1.Text = "SUCCESSFULLY UPDATED!!!";
                }
                else
                {
                    Label1.Text = "NOT UPDATED!!!";
                }
            }
            catch (Exception em)
            {
                Label1.Text = em.Message;
            }
        }
        else
        {
            Label1.Text = "SELECT SOMETHING TO UPDATE!!!";
        }
        bindData();
    }
}
