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

public partial class insertsubject : System.Web.UI.Page
{
    dbconnection cn = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        if (Session["class"] == null || Session["tablename"] == null || Session["num"]==null)
        {
            Response.Redirect("~/STUDENTS.aspx");
        }
        Label1.Text = Session["class"].ToString();
        Label2.Visible = false;
        createControl();
    }
    private void createControl()
    {
        int i = Int32.Parse(Session["num"].ToString().Trim());
        for (int j = 1; j <= i; j++)
        {
            Label msg = new Label();
            msg.Text = "ENTER THE SUBJECT NAME :::";
            Label msg1 = new Label();
            msg1.Text = "<br/>";
            TextBox sub = new TextBox();
            sub.ID = "textbox"+j.ToString();
            RequiredFieldValidator val = new RequiredFieldValidator();
            val.ErrorMessage = "*Required";
            val.ControlToValidate = sub.ID;
            Panel1.Controls.Add(msg);
            Panel1.Controls.Add(sub);
            Panel1.Controls.Add(val);
            Panel1.Controls.Add(msg1);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = Int32.Parse(Session["num"].ToString().Trim());
        try
        {
            cn.con.Open();
            String sql = "create table " + Session["tablename"].ToString().Trim() + " (name varchar(max) not null,roll int not null,class varchar(max) not null,primary key(roll),";
            for (int j = 1; j <= i; j++)
            {
              TextBox tx =(TextBox)  Panel1.FindControl("textbox"+j.ToString());
              if (i == j)
              {
                  sql += tx.Text + " varchar(max));";
              }
              else
              {
                  sql += tx.Text+" varchar(max),";
              }
            }
            cn.cmd.CommandText = sql;
            cn.cmd.Connection = cn.con;
            cn.cmd.ExecuteNonQuery();
            sql = "";
            sql = "insert into subject (tablename,subname) values('" + Session["tablename"].ToString().Trim() + "',";
            for (int j = 1; j <= i; j++)
            {
                TextBox tx =(TextBox)  Panel1.FindControl("textbox"+j.ToString());
                String sub = sql+"'" + tx.Text.Trim()+ "');";
                cn.cmd.CommandText = sub;
                cn.cmd.ExecuteNonQuery();
            }
            sql = "insert into table_name values('" + Session["tablename"].ToString().Trim() + "','" + Session["year"].ToString().Trim() + "','" + Session["class"].ToString().Trim() + "');";
            cn.cmd.CommandText = sql;
            cn.cmd.ExecuteNonQuery();
            Label2.Visible = true;
            Label2.Text = "SUCCESSFULLY TABLE CREATED!!!NOW U CAN ADD RESULT!!!";
            Session["class"] = null;
            Session["tablename"] = null;
            Session["num"] = null;
            Button1.Enabled = false;
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
