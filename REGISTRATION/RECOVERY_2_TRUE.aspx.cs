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

public partial class RECOVERY_2_TRUE : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        DBCONNECTION cn = new DBCONNECTION();
        try
        {
            cn.con.Open();
            cn.cmd.Connection = cn.con;
            cn.cmd.CommandText = "SELECT EMAIL,MOB,DOB FROM FORM";
            cn.dr = cn.cmd.ExecuteReader();
            while (cn.dr.Read())
            {
                if (TextBox1.Text == cn.dr["EMAIL"].ToString() && TextBox2.Text == cn.dr["DOB"].ToString() && cn.dr["MOB"].ToString() == TextBox3.Text)
                {
                    flag = true;
                    Session["email"] = TextBox1.Text;
                    break;
                }
            }
            cn.dr.Close();
            if (flag)
            {
                Response.Redirect("SHOW_USERNAME.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "INCORRECT INFORMATION TRY AGAIN";
            }

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
}
