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

public partial class account : System.Web.UI.Page
{
    dbConneection db=new dbConneection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible=false;
        if (Session["USER"].ToString() == "")
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            string name=Session["USER"].ToString();
            try{
                db.con.Open();
                db.cmd.Connection=db.con;
                db.cmd.CommandText="SELECT * FROM login where username='"+name+"'";
                db.dr=db.cmd.ExecuteReader();
                if(db.dr.HasRows)
                {
                    Label1.Text=db.dr["username"].ToString();
                    Label2.Text=db.dr["password"].ToString();
                }
                db.dr.Close();
            }
            catch(Exception ee)
            {
                Label3.Visible=true;
                Label3.Text=ee.Message;
            }
            finally
            {
                //db.dr.Close();
                db.con.Close();
            }
        }
    }
protected void  LinkButton1_Click(object sender, EventArgs e)
{
    Session.Abandon();
    Session.Clear();
    Response.Redirect("Login.aspx");
}
}
