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

public partial class galleryupload : System.Web.UI.Page
{
    dbconnection database = new dbconnection();
    String filename = null;
    protected void Page_Load(object sender, EventArgs e)
    {
if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label1.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool flag =false;
        try
        {
            if (FileUpload1.HasFile)
            {
                String ext = Path.GetExtension(FileUpload1.FileName.ToString());
                if (ext.Equals(".JPG") || ext.Equals(".jpg") || ext.Equals(".PNG") || ext.Equals(".png") || ext.Equals(".BMP") || ext.Equals(".bmp"))
                {
                    filename = TextBox1.Text + ext;
                    String path = Server.MapPath("~/GALLERY").ToString() + "\\" + filename;
                    FileUpload1.SaveAs(path);
                    flag = true;
                    Label1.Visible = true;
                    Label1.Text = "SUCCESSFULLY UPLOADED";
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "FILE FORMAT NOT SUPPORTED!!! SUPPORTED EXTENSIONS ARE .jpg,.JPG,.BMP,.bmp,.png,.PNG";
                }
            }
        }
        catch(Exception ee)
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
        if (flag)
        {
            try
            {
                database.con.Open();
                database.cmd.CommandText = "insert into gallery values('" + filename + "',@title,@description)";
                database.cmd.Parameters.AddWithValue("title", TextBox1.Text);
                database.cmd.Parameters.AddWithValue("description", TextBox2.Text);
                database.cmd.Connection = database.con;
                database.cmd.ExecuteNonQuery();
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/index.aspx");
    }
}
