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

public partial class addresult : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    String year = null;
    String Class = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("-SELECT THE TABLE NAME-");
            Panel1.Visible = false;
            Button2.Visible = false;
            try
            {
                cn.con.Open();
                cn.cmd.CommandText = "select table_name from table_name;";
                cn.cmd.Connection = cn.con;
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        DropDownList1.Items.Add(new ListItem(cn.dr["table_name"].ToString().Trim(), cn.dr["table_name"].ToString().Trim()));
                    }
                }
                DropDownList1.DataBind();
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
            Session["subno"] = null;
        }
        else
        {
            createControl();
            Panel1.Visible = true;
        }
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        createControl();
        Button2.Visible = true;
        Panel1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int no = Int32.Parse(Session["subno"].ToString().Trim());
        String sqlcommand = "insert into "+DropDownList1.SelectedItem.Text+" (name,roll,class,";
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "select subname from subject where tablename = '" + DropDownList1.SelectedItem.Text + "'";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            int i = 0;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    i++;
                    if (i == no)
                    {
                        sqlcommand += cn.dr["subname"].ToString();
                    }
                    else
                    {
                        sqlcommand += cn.dr["subname"].ToString() + ",";
                    }
                }
                sqlcommand += ") values(";
            }
             TextBox tx = (TextBox)Panel1.FindControl("textbox1");
             sqlcommand += "'" + tx.Text.Trim() + "',";
             tx.Text = "";
             TextBox roll = (TextBox)Panel1.FindControl("textbox2");
             sqlcommand += ""+roll.Text.Trim()+",'"+Class+"',";
             roll.Text = "";
             int m = 3;
             while (m < (no + 3))
             {
                 TextBox sub = (TextBox)Panel1.FindControl("textbox"+m.ToString());
                 if (m == (no + 2))
                 {
                     sqlcommand += "'" + sub.Text.Trim() + "');";
                 }
                 else
                 {
                     sqlcommand += "'" + sub.Text.Trim() + "',";
                 }
                 m++;
                 sub.Text = "";
             }
             ResultDAO dao = new ResultDAO(sqlcommand,DropDownList1.SelectedItem.Text);
             dao.insertResult();
             Label1.Visible = true;
             Label1.Text = "Successfully Inserted!!!";
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
    private void createControl()
    {
        try
        {
            cn.con.Open();
            cn.cmd.CommandText = "select * from table_name where table_name = '"+DropDownList1.SelectedItem.Text+"';";
            cn.cmd.Connection = cn.con;
            cn.dr = cn.cmd.ExecuteReader();
            int num = 0;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    year = cn.dr["year"].ToString();
                    Class = cn.dr["class"].ToString();
                }
            }
            cn.dr.Close();
            cn.cmd.CommandText = "select subname from subject where tablename = '"+DropDownList1.SelectedItem.Text+"'";
            cn.dr = cn.cmd.ExecuteReader();
            Panel1.Controls.Clear();
            Label sub1 = new Label();
            sub1.Text = "ENTER THE NAME"+" ::  ";
            Label msg1 = new Label();
            msg1.Text = "<br/>";
            TextBox tx1 = new TextBox();
            tx1.ID = "textbox1";
            Panel1.Controls.Add(sub1);
            Panel1.Controls.Add(tx1);
            Panel1.Controls.Add(msg1);
            Label sub2 = new Label();
            sub2.Text = "ENTER THE ROLL" + " ::  ";
            Label msg2 = new Label();
            msg2.Text = "<br/>";
            TextBox tx2 = new TextBox();
            tx2.ID = "textbox2";
            Panel1.Controls.Add(sub2);
            Panel1.Controls.Add(tx2);
            Panel1.Controls.Add(msg2);
            int i = 3;
            if (cn.dr.HasRows)
            {
                while (cn.dr.Read())
                {
                    Label sub = new Label();
                    sub.Text = "ENTER THE MARKS IN  "+cn.dr["subname"].ToString()+" ::  ";
                    Label msg = new Label();
                    msg.Text = "<br/>";
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
}
