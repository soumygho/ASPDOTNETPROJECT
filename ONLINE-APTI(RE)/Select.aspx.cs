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

public partial class Select : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["size"] = null;
        if (Session["username"] == null)
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }
        if (Session["testvoid"] == null)
        {
            Response.Redirect("~/ErrrorPage.aspx");
        }
        Label3.Visible = false;
        Label2.Visible = false;
        if (!IsPostBack)
        {
            if (Session["totalrow"] == null)
            {
                int count = 0;
                try
                {
                    data.con.Open();
                    data.cmd.CommandText = "Select * from QUESTION ";
                    data.cmd.Connection = data.con;
                    data.dr = data.cmd.ExecuteReader();
                    if (data.dr.HasRows)
                    {
                        while (data.dr.Read())
                        {
                            count++;
                        }
                        Session["totalrow"] = count;
                        Label1.Visible = true;
                        Label1.Text = count.ToString();
                    }
                }
                catch (Exception ee)
                {
                    Label2.Visible = true;
                    Label2.Text = ee.Message;
                }
                finally
                {
                    //Label1.Text = array[0].ToString();
                    data.dr.Close();
                    data.con.Close();
                }
            }
            else
            {
                Label1.Text = Session["totalrow"].ToString();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["size"] = TextBox1.Text;
        //Session["id"] = Session["username"].ToString();
        String s = Session["username"].ToString()+DateTime.Now;
       // Label2.Text = s;
        s = s.Replace("/","");
        s = s.Replace(":","");
        s = s.Replace(" ","");
        Session["examid"] = s;
        Label2.Text = Session["examid"].ToString();
        Session["date"] = DateTime.Today.Date.ToString().Trim();
        //Session["id"] = Session["username"].ToString();
        try
        {
            data.con.Open();
            data.cmd.CommandText = "create table " + Session["examid"].ToString() + " (question  varchar(max),questionno varchar(max),rightans varchar(max),ans varchar(max))";
            data.cmd.Connection = data.con;
            data.cmd.ExecuteNonQuery();
           // Label1.Text = Session["examid"].ToString() + "hasbeen created";
        }
        catch (Exception ee)
        {
            Label2.Visible = true;
            Label2.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
           // data.dr.Close();
            data.con.Close();
        }
        Session["testvoid"] = null;
        Response.Redirect("~/optional_main.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (int.Parse(TextBox1.Text) >= int.Parse(Session["totalrow"].ToString()))
        {
            Label3.Visible = true;
            Label3.Text = "PLEASE SELECT A NUMBER LESSTHAN" + Session["totalrow"].ToString();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/HOMEPAGE.aspx");
    }
}
