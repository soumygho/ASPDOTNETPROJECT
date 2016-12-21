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

public partial class Admin_login : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag = false;
        try
        {
            data.con.Open();
            data.cmd.CommandText = "Select * from ADMIN ";
            data.cmd.Connection = data.con;
            data.dr = data.cmd.ExecuteReader();
            if (data.dr.HasRows)
            {
                while (data.dr.Read())
                {
                    if (data.dr["adminid"].ToString().Equals(TextBox1.Text)&&data.dr["password"].ToString().Equals(TextBox2.Text))
                    {
                        Session["adminid"] = TextBox1.Text;
                        flag = true;
                        break;
                    }
                }
            }
            data.dr.Close();
        }
        catch (Exception ee)
        {
            Label1.Visible = true;
            Label1.Text = ee.Message;
        }
        finally
        {
            //Label1.Text = array[0].ToString();
            data.con.Close();
        }
        if (flag)
        {
            Response.Redirect("~/Upload_question.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "userid or password did not matched";
        }
    }
}
