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

public partial class Account : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label5.Visible = false;
        Panel1.Visible = false;
        Button2.Visible = false;
        if (Session["username"] != null)
        {
            Session["testvoid"] = "true";
            Session["optional_main"] = "true";
            Label1.Text = Session["username"].ToString();
            try
            {
                data.con.Open();
                data.cmd.CommandText = "SELECT * FROM EXAMDET WHERE ID = " + Session["id"].ToString();
                data.cmd.Connection = data.con;
                data.dr = data.cmd.ExecuteReader();
                if (data.dr.HasRows)
                {
                    Panel1.Visible = true;
                    Repeater1.DataSource = data.dr;
                    Repeater1.DataBind();
                }
                else
                {
                    Panel1.Visible = false;
                }
                data.dr.Close();
            }
            catch (Exception ee)
            {
                Label5.Visible = true;
                Label5.Text = ee.Message;
            }
            finally
            {
                data.con.Close();
            }
        }
        else
        {
            Response.Redirect("~/HOMEPAGE.aspx");
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/HOMEPAGE.aspx");
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //UpdatePanel1.Update();
       
       
        Button2.Visible = true;
        Button1.Visible = false;
        Repeater1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
       
        
        Button1.Visible = true;
        Button2.Visible = false;
        Repeater1.Visible = true;
    }
}
