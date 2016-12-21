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
using System.IO;

public partial class uploadteacherdetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection cn = new dbconnection();
        bool flag = false;
        String path;
        if (FileUpload1.HasFile)
        {
            try
            {
                String ext = Path.GetExtension(FileUpload1.FileName);
                path = name.Text + DateTime.Today.ToShortDateString().ToString().Replace('/', '_') + ext;
                FileUpload1.SaveAs(Server.MapPath("~/TEACHER PIC") + "\\" + path);
                Label1.Visible = true;
                Label1.Text = "SUCCESSFULLY UPLOADED!!!";
                flag = true;
                if (flag)
                {
                    try
                    {
                        cn.con.Open();
                        cn.cmd.CommandText = "insert into teacher (path,trade,name,qualification) values('" + path + "','" +  trade.SelectedItem.Text.Trim() + "','" + name.Text.Trim() + "','" + qualification.Text.Trim() + "')";
                        cn.cmd.Connection = cn.con;
                        cn.cmd.ExecuteNonQuery();
                    }
                    catch (Exception ee)
                    {
                        Session["error"] = ee.Message;
                    }
                    finally
                    {
                        cn.con.Close();
                        if (Session["error"] != null)
                        {
                            Response.Redirect("~/error.aspx");
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }

        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "NO FILE SELECTED!!";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Administrative_login.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/index.aspx");
    }
}
