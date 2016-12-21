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

public partial class view : System.Web.UI.Page
{
    dbconnection database = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        if (Session["tablename"] == null || Session["maxrecord"] == null)
        {
            Response.Redirect("~/viewResult.aspx");
        }
        int min = Int32.Parse(Request.QueryString["min"].ToString().Trim());
        int max = Int32.Parse(Request.QueryString["max"].ToString().Trim());
        Session["min"] = min;
        Session["max"] = max;
        Label tablehead = new Label();
        tablehead.Text = "<table><tr>";
        Label action = new Label();
        action.Text = "<td><b>ACTION</td></b><td></td><td></td>";
        Label name = new Label();
        name.Text = "<td><b>" + "NAME" + "</b></td><td></td><td></td>";
        Label roll = new Label();
        roll.Text = "<td><b>ROLL</td></b><td></td><td></td>";
        Label Class = new Label();
        Class.Text = "<td><b>CLASS</td></b><td></td><td></td>";
        Label foot = new Label();
        foot.Text = "</tr><br/><br/>";
        Label footer = new Label();
        footer.Text = "</table>";
        Panel1.Controls.Add(tablehead);
        Panel1.Controls.Add(action);
        Panel1.Controls.Add(name);
        Panel1.Controls.Add(roll);
        Panel1.Controls.Add(Class);
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from subject where tablename='"+Session["tablename"].ToString().Trim()+"';";
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            String[] subject = new String[20];
            int i=0;
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    Label sub = new Label();
                    sub.Text = "<td><b>" + database.dr["subname"].ToString().Trim() + "</b></td><td></td><td></td>";
                    subject[i] = database.dr["subname"].ToString().Trim();
                    Panel1.Controls.Add(sub);
                    i++;
                }
            }
            Panel1.Controls.Add(foot);
            int maxsubject = i;
            database.dr.Close();
            database.cmd.CommandText = "select * from " + Session["tablename"].ToString().Trim() +" where roll between "+min+" AND "+max+";";
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    i = 0;
                    HyperLink update = new HyperLink();
                    HyperLink delete = new HyperLink();
                    update.Text = "UPDATE    ";
                    delete.Text = "DELETE";
                    Label label1 = new Label();
                    label1.Text = "<td><b>";
                    update.NavigateUrl = "~/updateResult.aspx?tablename=" + Session["tablename"].ToString().Trim() + "&roll=" + database.dr["roll"].ToString().Trim();
                    delete.NavigateUrl = "~/deleteResult.aspx?tablename=" + Session["tablename"].ToString().Trim() + "&roll=" + database.dr["roll"].ToString().Trim();
                    Label label2 = new Label();
                    label2.Text = "</b></td><td></td><td></td>";
                    Label rowstart = new Label();
                    rowstart.Text = "<tr>";
                    Panel1.Controls.Add(rowstart);
                    Panel1.Controls.Add(label1);
                    Panel1.Controls.Add(update);
                    Panel1.Controls.Add(delete);
                    Panel1.Controls.Add(label2);
                    Label name1 = new Label();
                    name1.Text = "<td><b>" + database.dr["name"].ToString().Trim() + "</b></td><td></td><td></td>";
                    Panel1.Controls.Add(name1);
                    Label roll1 = new Label();
                    roll1.Text = "<td><b>" + database.dr["roll"].ToString().Trim() + "</b></td><td></td><td></td>";
                    Label class1 = new Label();
                    class1.Text = "<td><b>" + database.dr["class"].ToString().Trim() + "</b></td><td></td><td></td>";
                    Panel1.Controls.Add(roll1);
                    Panel1.Controls.Add(class1);
                    while (i < maxsubject)
                    {
                        Label sub1 = new Label();
                        sub1.Text = "<td><b>" + database.dr[subject[i]].ToString().Trim() + "</b></td><td></td><td></td>";
                        Panel1.Controls.Add(sub1);
                        i++;
                    }
                    Label rowend = new Label();
                    rowend.Text = "</tr><br/>";
                    Panel1.Controls.Add(rowend);
                }
            }
            Panel1.Controls.Add(footer);
            if (min == 1)
            {
                HyperLink2.Visible = false;
            }
            if (max == Int32.Parse(Session["maxrecord"].ToString().Trim()))
            {
                HyperLink3.Visible = false;
            }
            if (min >= 21)
            {
                if (min == 21)
                {
                    HyperLink2.NavigateUrl = "~/view.aspx?min=" + (min - 20) + "&max=" + (min - 1);
                }
                else
                {
                    HyperLink2.NavigateUrl = "~/view.aspx?min=" + (min - 21) + "&max=" + (min - 1);
                }
            }
            if (max < Int32.Parse(Session["maxrecord"].ToString().Trim()))
            {
                if ((max + 21) < Int32.Parse(Session["maxrecord"].ToString().Trim()))
                {
                    HyperLink3.NavigateUrl = "~/view.aspx?min=" + (max + 1) + "&max=" + (max + 21);
                }
                else
                {
                    HyperLink3.NavigateUrl = "~/view.aspx?min=" + (max + 1) + "&max=" + Int32.Parse(Session["maxrecord"].ToString().Trim());
                }
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
