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
using System.Threading;

public partial class Default2 : System.Web.UI.Page
{
    dbconnection database = new dbconnection();
    bool flag = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Session["userid"] != null)
        {
            Response.Redirect("~/administrative_page.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["userid"] = null;
        try
        {
            database.con.Open();
            database.cmd.CommandText = "select * from admin";
            database.cmd.Connection = database.con;
            database.dr = database.cmd.ExecuteReader();
            //
            if (database.dr.HasRows)
            {
                while (database.dr.Read())
                {
                    if (TextBox1.Text.Equals(database.dr["userid"].ToString()))
                    {
                        if (TextBox2.Text.Equals(database.dr["passwors"].ToString()))
                        {
                            flag = true;
                            Session["userid"] = TextBox1.Text;
                        }
                        break;
                    }
                }
            }
        }
        catch(Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (flag)
            {
                Response.Redirect("Administrative_page.aspx");
            }
            else if (!flag && Session["error"] == null)
            {
                Label1.Visible = true;
                Label1.Text = "USERNAME,PASSWORD DID NOT MATCHED";
            }
            else
            {
                Response.Redirect("~/error.aspx");
            }
        }
       
    }
}
