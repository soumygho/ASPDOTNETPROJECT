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

public partial class HOMEPAGE : System.Web.UI.Page
{
    DatabaseConnection dc = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox1.Text = null;
            TextBox2.Text = null;
        }
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["uname"] = TextBox1.Text;
        Session["pwd"] = TextBox2.Text;
        bool flag = false;
        try
        {
            dc.con.Open();
            dc.cmd.CommandText = "Select username,password from MEMBERS";
            dc.cmd.Connection = dc.con;
            dc.dr=dc.cmd.ExecuteReader();
            if (dc.dr.HasRows)
            {
                while (dc.dr.Read())
                {
                   
                   //Label1.Visible = true;
                   //Label1.Text = Session["username"].ToString();
                   if ((dc.dr["username"].ToString().Equals(Session["uname"].ToString())) &&(dc.dr["password"].ToString().Equals(Session["pwd"].ToString())))
                    {
                        Session["username"] = TextBox1.Text;
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Response.Redirect("~/Account.aspx");
            }
            else
            {
               Label1.Visible = true;
               Label1.Text = "USERNAME OR PASSWORD DID NOT MATCHED";
            }
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            dc.con.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
