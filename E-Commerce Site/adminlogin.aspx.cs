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

public partial class Default2 : System.Web.UI.Page
{
    dbconnection db = new dbconnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        bool flag = false;
        try
        {
            db.con.Open();
            db.cmd.Connection = db.con;
            db.cmd.CommandText = "SELECT * FROM admin";
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    if (TextBox2.Text == db.dr["id"].ToString() && TextBox3.Text == db.dr["password"].ToString())
                    {
                        flag = true;
                        Session["username"] = TextBox2.Text;
                        Label4.Visible = true;
                        Label4.Text = TextBox3.Text;
                        break;
                    }
                }
            }
            db.dr.Close();
        }
        catch(Exception ee)
        {
            Label4.Visible = true;
            Label4.Text = ee.Message;
        }
        finally
        {
            db.con.Close();
        }
    }
}
