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

public partial class Searchadmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        if (Session["userid"] == null)
        {
            Response.Redirect("~/adminlogin.aspx");
        }
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
        }
    }
    protected void namesubmit_Click(object sender, EventArgs e)
    {
        DatabaseConnection db = new DatabaseConnection();
        String id = "";
        try
        {
            
            db.con.Open();
            db.cmd.CommandText = "select id from userdetails where name=@name";
            db.cmd.Parameters.AddWithValue("name",name.Text.Trim());
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    id = db.dr["id"].ToString().Trim();
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "SORRY NO DATA FOUND!!!";
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (!id.Equals(""))
            {
                Response.Redirect("~/adminview.aspx?id="+id);
            }
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void idsubmit_Click(object sender, EventArgs e)
    {
        String id1 = "";
        DatabaseConnection db = new DatabaseConnection();
        try
        {
            String name = "";
            db.con.Open();
            db.cmd.CommandText = "select name from userdetails where id=@id";
            db.cmd.Parameters.AddWithValue("id", id.Text.Trim());
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    name = db.dr["name"].ToString().Trim();
                    id1 = id.Text.Trim();
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "SORRY NO DATA FOUND!!!";
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (!id1.Equals(""))
            {
                Response.Redirect("~/adminview.aspx?id=" + id.Text.Trim());
            }
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
}
