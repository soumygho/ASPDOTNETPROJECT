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

public partial class SHOW_USERNAME : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"].ToString() == null)
        {
            Response.Redirect("LOGIN.aspx");
        }
        Label3.Visible = false;
        DBCONNECTION cn = new DBCONNECTION();
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "select userid from form where email='" + Session["email"] + "'";
            cn.dr = cn.cmd.ExecuteReader();
            while (cn.dr.Read())
            {
                Label2.Text = cn.dr["USERID"].ToString();
            }
            cn.dr.Close();
        }
        catch (Exception ee)
        {
            Label3.Visible = true;
            Label3.Text = ee.Message;
        }
        finally
        {
            cn.con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("LOGIN.aspx");
    }
}
