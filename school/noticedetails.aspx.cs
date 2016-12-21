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
using System.Windows.Forms;

public partial class noticedetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        try
        {
            db.con.Open();
            db.cmd.CommandText = "select * from notice";
            db.cmd.Connection = db.con;
            db.dr = db.cmd.ExecuteReader();
            int i = 1;
            if (db.dr.HasRows)
            {
                while (db.dr.Read())
                {
                    HyperLink link = new HyperLink();
                    link.NavigateUrl = "~/Notice_client.aspx"+"?"+"id="+db.dr["id"].ToString();
                    System.Web.UI.WebControls.Label num = new System.Web.UI.WebControls.Label();
                    System.Web.UI.WebControls.Label br = new System.Web.UI.WebControls.Label();
                    br.Text = "<br/>";
                    num.Text = i.ToString()+".";
                    link.Text = db.dr["sub"].ToString()+"dated" + db.dr["date"].ToString();
                    Panel1.Controls.Add(num);
                    Panel1.Controls.Add(link);
                    Panel1.Controls.Add(br);
                }
            }
        }
        catch (Exception m)
        {
            MessageBox.Show("Error occured:"+m.Message);
        }
        finally
        {
            db.con.Close();
        }
    }
}
