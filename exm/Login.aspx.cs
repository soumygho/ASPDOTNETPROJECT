using System;
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

public partial class _Default : System.Web.UI.Page 
{
    dbConneection db = new dbConneection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        //Label1.Visible = true;
        //Label1.Text = "YOU CLICKED THE SUBMIT BUTTON";
        try
        {
            db.con.Open();
            string command="select * from login";
            db.cmd.Connection = db.con;
            db.cmd.CommandText = command;
            db.dr = db.cmd.ExecuteReader();
           while (db.dr.Read())
           {
               if (db.dr["username"].ToString() == TextBox1.Text && db.dr["password"].ToString() == TextBox2.Text)
               {
                   flag = true;
                   break;
               }
           }
           db.dr.Close();
           if (flag == true)
           {
               Session["USER"] = TextBox1.Text;
               Response.Redirect("account.aspx");
           }
           else
           {
               Label1.Visible = true;
               Label1.Text = "YOUR USERNAME AND PASSWORD DID NOT MATCH";
           }
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            //db.dr.Close();
            db.con.Close();
        }
    }
}
