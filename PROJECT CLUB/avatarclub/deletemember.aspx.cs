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

public partial class deletemember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/adminlogin.aspx");
        }
        warninglbl.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        DatabaseConnection database = new DatabaseConnection();
        bool flag = false;
        string pass = "";
        string thumb = "";
        string sign = "";
        try
        {
            database.con.Open();
            database.cmd.Connection = database.con;
            database.cmd.CommandText = "select * from userdetails where id=@id";
            database.cmd.Parameters.AddWithValue("id",id.Text.ToString().Trim());
            database.dr = database.cmd.ExecuteReader();
            if (database.dr.HasRows)
            {
                flag = true;
                while (database.dr.Read())
                {
                    pass = database.dr["passporturl"].ToString().Trim();
                    thumb = database.dr["thumburl"].ToString().Trim();
                    sign = database.dr["signatureurl"].ToString().Trim();
                }
            }
            database.dr.Close();
            if (flag)
            {
                database.cmd.CommandText = "delete from userdetails where id=@id";
                database.cmd.Parameters.Clear();
                database.cmd.Parameters.AddWithValue("id", id.Text.ToString().Trim());
                database.cmd.ExecuteNonQuery();
                warninglbl.Visible = true;
                warninglbl.Text = "SUCCESSFULLY DELETED!!!";
                String path = Server.MapPath("~/picture");
                String imgpath = path + "\\" + pass;
                File.Delete(imgpath);
                imgpath = path + "\\" + thumb;
                File.Delete(imgpath);
                imgpath = path + "\\" + sign;
                File.Delete(imgpath);
            }
            else
            {
                warninglbl.Visible = true;
                warninglbl.Text = "NO RECORD FOUND FOR THIS ID!!!";
            }
        }
        catch (Exception ee)
        {
            Session["error"] = ee.Message;
        }
        finally
        {
            database.con.Close();
            if (Session["error"] != null)
            {
                Response.Redirect("~/error.aspx");
            }
        }
    }
}
