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

public partial class adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] != null)
        {
            Response.Redirect("~/adminhome.aspx");
        }
        Label1.Visible = false;
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        DatabaseConnection db = new DatabaseConnection();
        bool flag = false;
        try
        {
            
            db.con.Open();
            db.cmd.CommandText = "select * from admin where username=@username";
            db.cmd.Parameters.AddWithValue("username",username.Text.Trim());
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    if (db.dr["password"].ToString().Trim().Equals(password.Text.Trim()))
                    {
                        flag = true;
                        Session["userid"] = db.dr["username"].ToString().Trim();
                        break;
                    }
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "NO SUCH USERNAME FOUND!!!!!";
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (flag)
            {
                Response.Redirect("~/adminhome.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "PASSWORD INCORRECT!!!!!";
            }
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
