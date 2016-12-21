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

public partial class updateResult : System.Web.UI.Page
{
    private dbconnection cn = new dbconnection();
    String year = "";
    String Class="";
    String tablename = "";
    int roll = 0;
    int num = 0;
    String[] subjectname = new String[20];
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        if (Session["min"] == null || Session["max"] == null)
        {
            Response.Redirect("~/STUDENTS.aspx");
        }
        tablename = Request.QueryString["tablename"].ToString().Trim();
        roll =Int32.Parse( Request.QueryString["roll"].ToString().Trim());
        HyperLink2.NavigateUrl = "~/view.aspx?min=" + Session["min"].ToString().Trim() + "&max=" + Session["max"].ToString().Trim();
        createControl();
        if (!IsPostBack)
        {
            bindData();
        }
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "update " + tablename+" set ";
            int i = 3;
                    TextBox name = (TextBox)Panel1.FindControl("textbox1");
                    cn.cmd.CommandText += "name = '"+name.Text+"',";
                    int m = 0;
                    while (i < num + 3)
                    {
                        TextBox sub = (TextBox)Panel1.FindControl("textbox" + i.ToString());
                        if (m == Int32.Parse(Session["subno"].ToString().Trim()) - 1)
                        {
                            cn.cmd.CommandText += subjectname[m] + " = '" + sub.Text.Trim() + "'";
                        }
                        else
                        {
                            cn.cmd.CommandText += subjectname[m] + " = '" + sub.Text.Trim() + "',";
                        }
                        m++;
                        i++;
                    }
            cn.cmd.CommandText += " where roll = " + roll + " ;";
            cn.cmd.Connection = cn.con;
            cn.cmd.ExecuteNonQuery();
            Label1.Visible = true;
            Label1.Text = "SUCCESSFULLY UPDATED!!!";
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.con.Close();
            bindData();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    private void createControl()
    {
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "select * from table_name where table_name = '" + tablename + "';";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            num = 0;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    year = cn.dr["year"].ToString();
                    Class = cn.dr["class"].ToString();
                }
            }
            cn.dr.Close();
            cn.cmd.CommandText = "select subname from subject where tablename = '" +tablename+ "'";
            cn.dr = cn.cmd.ExecuteReader();
            Panel1.Controls.Clear();
            Label sub1 = new Label();
            sub1.Text = "ENTER THE NAME" + " ::  ";
            Label msg1 = new Label();
            msg1.Text = "<br/>";
            TextBox tx1 = new TextBox();
            tx1.ID = "textbox1";
            Panel1.Controls.Add(sub1);
            Panel1.Controls.Add(tx1);
            Panel1.Controls.Add(msg1);
            Label sub2 = new Label();
            sub2.Text = "ROLL" + " ::  ";
            Label msg2 = new Label();
            msg2.Text = "<br/>";
            Label tx2 = new Label();
            tx2.ID = "roll";
            Panel1.Controls.Add(sub2);
            Panel1.Controls.Add(tx2);
            Panel1.Controls.Add(msg2);
            int i = 3;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    Label sub = new Label();
                    sub.Text = "ENTER THE MARKS IN  " + cn.dr["subname"].ToString() + " ::  ";
                    Label msg = new Label();
                    msg.Text = "<br/>";
                    subjectname[num] = cn.dr["subname"].ToString().Trim();
                    TextBox tx = new TextBox();
                    tx.ID = "textbox" + i.ToString();
                    i++;
                    num++;
                    Panel1.Controls.Add(sub);
                    Panel1.Controls.Add(tx);
                    Panel1.Controls.Add(msg);
                }
                Session["subno"] = num;
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    private void bindData()
    {
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "select * from "+tablename+" where roll = "+roll+" ;";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            int i=3;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    TextBox name = (TextBox)Panel1.FindControl("textbox1");
                    name.Text = cn.dr["name"].ToString().Trim();
                    Label roll1 = (Label)Panel1.FindControl("roll");
                    roll1.Text = cn.dr["roll"].ToString().Trim();
                    int m = 0;
                    while (i < num + 3)
                    {
                        TextBox sub = (TextBox)Panel1.FindControl("textbox" + i.ToString());
                        sub.Text = cn.dr[subjectname[m]].ToString().Trim();
                        m++;
                        i++;
                    }
                }
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            cn.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Int32.Parse(Session["maxrecord"].ToString().Trim()) > 20)
        {
            Response.Redirect("~/view.aspx?min=1&max=20");
        }
        else
        {
            Response.Redirect("~/view.aspx?min=1&max=" + Int32.Parse(Session["maxrecord"].ToString().Trim()));
        }
    }
}
