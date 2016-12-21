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
using System.Drawing;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //notice hyperlink add
      /*  dbconnection db = new dbconnection();
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select * from notice";
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            int i = 1;
            if (db.dr.HasRows)
            {
               // HtmlTable noticeTable = notices;
                while (db.dr.Read())
                {
//Style s = new Style();
//s.text-decoration="none";
                    HyperLink link = new HyperLink();
link.Attributes.Add("Class","link");
                    link.NavigateUrl = "~/Notice_client.aspx"+"?"+"id="+db.dr["id"].ToString();
                    System.Web.UI.WebControls.Label num = new System.Web.UI.WebControls.Label();
                    System.Web.UI.WebControls.Label br = new System.Web.UI.WebControls.Label();
                    br.Text = "<br/>";
                    num.Text = i.ToString()+".";
                    link.Text = db.dr["sub"].ToString()+"dated on" + db.dr["date"].ToString();
                    i++;
                    link.ForeColor = Color.Blue;
//link.CopyFrom(s);
                    Panel1.Controls.Add(num);
                    Panel1.Controls.Add(link);
                    Panel1.Controls.Add(br);
                }
            }
        }
        catch (Exception m)
        {
            Session["error"] = m.Message;
        }
        finally
        {
            db.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }*/
    }

    
}
