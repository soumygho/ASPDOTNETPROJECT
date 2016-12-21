using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class addtextbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
        if (!IsPostBack)
        {
            Session["dynamiccontrols"] = null;
            createControl(Int32.Parse(Session["no"].ToString()));
        }
        else
        {
            recreateControl();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        ArrayList al = (ArrayList)Session["dynamiccontrols"];
        foreach (ControlInfo ci in al)
        {
            TextBox tx = (TextBox)Page.FindControl(ci.controlid);
            Label1.Text += tx.Text;
        }
    }
    private void persistControl(ControlInfo ci)
    {
        ArrayList al = (ArrayList)Session["dynamiccontrols"];
        if (al == null)
        {
            al = new ArrayList();
        }
        al.Add(ci);
        Session["dynamiccontrols"] = al;
    }
    private void createControl(int num)
    {
        Panel1.Controls.Clear();
        int top = 20;
        int left = 20;
        for (int i = 1; i <= num; i++)
        {
            TextBox tx = new TextBox();
            tx.ID = "TextBox" + i.ToString();
            tx.Style["top"] = top.ToString()+"px";
            tx.Style["left"] = left.ToString()+"px";
            Panel1.Controls.Add(tx);
            Label lab = new Label();
            lab.Text = "<br/>";
            Panel1.Controls.Add(lab);
            ControlInfo ci = new ControlInfo(tx.ID,"TextBox",tx.Style["top"].ToString(),tx.Style["left"].ToString());
            persistControl(ci);
            top += 40;
        }
        Label la = new Label();
        la.Text = Request.UserHostName.ToString();
        la.Text += Request.UserHostAddress.ToString();
        Panel1.Controls.Add(la);
    }
    private void recreateControl()
    {
        Panel1.Controls.Clear();
        if (Session["dynamiccontrols"] != null)
        {
            ArrayList al = (ArrayList)Session["dynamiccontrols"];
            foreach (ControlInfo ci in al)
            {
                String type = ci.controltype;
                if (type.Equals("TextBox"))
                {
                    TextBox tx = new TextBox();
                    tx.ID = ci.controlid;
                    tx.Style["top"] = ci.top;
                    tx.Style["left"] = ci.left;
                    Panel1.Controls.Add(tx);
                    Label lab = new Label();
                    lab.Text = "<br/>";
                    Panel1.Controls.Add(lab);
                }
            }
        }
    }
}
