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

public partial class changeadminpassword : System.Web.UI.Page
{
    DatabaseConnection db = new DatabaseConnection();
    String userid = null;
    bool profilestatus = false;
    bool matched = false;
    bool status = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["userid"] == null)
        {
            Response.Redirect("~/adminlogin.aspx");
        }
        msg.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        userid = Session["userid"].ToString().Trim();
        String password = null;
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select password from admin where username = '"+userid+"';";
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    password = db.dr["password"].ToString().Trim();
                    profilestatus = true;
                }
                db.dr.Close();
                if (profilestatus)
                {
                    if (currentpassword.Text.Trim().Equals(password))
                    {
                        matched = true;
                        if (newpassword.Text.Trim().Equals(confirmnewpassword.Text.Trim()))
                        {
                            password = newpassword.Text.Trim();
                            db.cmd.CommandText = "update admin set password = '" + password + "' where username = '" + userid + "';";
                            db.cmd.ExecuteNonQuery();
                            status = true;
                        }
                    }
                    else
                    {
                        matched = false;
                    }
                }
            }
            else
            {
                profilestatus = false;
            }
            db.dr.Close();
            if (!profilestatus)
            {
                msg.Visible = true;
                msg.Text = "CURRENT PROFILE NOT FOUND !!!";
            }
            else if (!matched)
            {
                msg.Visible = true;
                msg.Text = "PLEASE RE-ENTER PASSWORD!!!PASSWORD DID NOT MATCHED!!!";
            }
            else if (!status)
            {
                msg.Visible = true;
                msg.Text = "YOUR NEW PASSWORD AND CONFIRMED PASSWORD DID NOT MATCHED!!!";
            }
          
        }
        catch(Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            db.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
            if (status)
            {
                Response.Redirect("~/operationsuccessful.aspx");
            }
        }
       
    }
}
