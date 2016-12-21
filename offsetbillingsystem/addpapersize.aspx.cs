using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class addpapersize : System.Web.UI.Page
{
    PaperDetailsOperation paperops = new PaperDetailsOperation();
    PaperSizeOperation sizeops = new PaperSizeOperation();
    PaperDetails insertPaper = null;
    PaperDetails updatesize = null;
    PaperSize papersize = null;
    List<PaperDetails> papers = null;
    List<PaperSize> sizes = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        
            bindData();
            if (!IsPostBack)
            {
                bindDropDowndata();
            }
        
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (insertPaper != null && !desc.Text.Equals("") && !noofpapers.Text.Equals(""))
        {
            try
            {
                PaperSize papersize = new PaperSize();
                papersize.Description = desc.Text.Trim().ToUpper();
                papersize.Paperid = insertPaper.Id;
                papersize.Noofpaperspersheet = Int32.Parse(noofpapers.Text.Trim());
               bool done = sizeops.insertIntoPaperSize(papersize);
               Label1.Visible = true;
               if (done)
               {
                   Label1.Text = "SUCCESSFULLY INSERTED!!!";
               }
               else
               {
                   Label1.Text = "INSERTION FAILURE!!!";
               }
            }
            catch (Exception em)
            {
                Label1.Visible = true;
                Label1.Text = em.Message;
            }

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "ERROR OCCURED!!!";
        }
    }

    private void bindData()
    {
        try
        {
            papers = paperops.readAllPaperDetails();
            if (papers != null && papers.Count > 0)
            {
                insertPaper = papers[0];
                updatesize = papers[0];
                
            }
             sizes = sizeops.readAllPapersize();
            GridView1.DataSource = sizeops.generateTable(sizes);
            GridView1.DataBind();
           
        }
        catch (Exception e)
        {
            Label1.Visible = true;
            Label1.Text = e.Message;
        }
    }
    private void bindDropDowndata()
    {
        if (papers != null && papers.Count > 0)
        {
            DropDownList1.Items.Clear();
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add(new ListItem("-select-"));
            for (int i = 0; i < papers.Count; i++)
            {
                DropDownList1.Items.Add(new ListItem(papers[i].Papername, papers[i].Id.ToString()));
                DropDownList2.Items.Add(new ListItem(papers[i].Papername, papers[i].Id.ToString()));
            }
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        insertPaper = null;
        if (papers != null)
        {
            insertPaper = papers[DropDownList1.SelectedIndex];
        }
    }
    
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedIndex != 0)
        {
            bindDropDown();
        }
       
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList3.SelectedIndex != 0)
        {
            papersize = sizes[DropDownList3.SelectedIndex - 1];
            bindTextViewData();
        }
    }

    private void bindDropDown()
    {
        updatesize = null;
        if (papers != null&&papers.Count>0)
        {
            updatesize = papers[DropDownList2.SelectedIndex-1];
            try
            {
                sizes = sizeops.readPapersizeForSpecificPaper(updatesize);
                if (sizes != null && sizes.Count > 0)
                {
                    papersize = sizes[0];
                    DropDownList3.Items.Clear();
                    DropDownList3.Items.Add(new ListItem("-select-"));
                    for (int i = 0; i < sizes.Count; i++)
                    {
                        DropDownList3.Items.Add(new ListItem(sizes[i].Description, sizes[i].Id.ToString()));

                    }
                }
                
                    bindTextViewData();
                

            }
            catch (Exception em)
            {
                Label1.Visible = true;
                Label1.Text = em.Message;
            }
        }
    }

    private void bindTextViewData()
    {


        if (papersize != null)
        {
            Textdesc.Text = papersize.Description;
            Textno.Text = papersize.Noofpaperspersheet.ToString();
        }
        
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        papersize = sizes[DropDownList3.SelectedIndex - 1];
        PaperSize temp = new PaperSize();
        temp.Paperid = papersize.Paperid;
        temp.Id = papersize.Id;
        try
        {
            if (papersize != null)
            {
                temp.Description = Textdesc.Text.Trim().ToUpper();
                temp.Noofpaperspersheet = Int32.Parse(Textno.Text);
                bool flag =  sizeops.upadtePaperSize(temp);
                if (flag)
                {
                    Label1.Text = "UPDATED!!!";
                }
                else
                {
                    Label1.Text = "NOT UPDATED!!!";
                }
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
