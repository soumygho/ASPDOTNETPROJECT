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

public partial class resultupload : System.Web.UI.Page
{
    DatabaseConnection data = new DatabaseConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
        Label1.Visible = false;
        date.Text = System.DateTime.Today.Date.ToShortDateString();
        date.Enabled = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {

        if (fileupload.HasFile)
        {
            try
            {
                String path = Server.MapPath("~\\database");
                String name = Path.GetFileName(fileupload.PostedFile.FileName.ToString());
                data.con.Open();
                data.cmd.CommandText = "insert into filerecord values('" + classname.Text.Trim() + "','" + examname.Text.Trim() + "','" + date.Text.Trim() + "','FALSE','" + name + "','" + DateTime.Today.Date.Year.ToString() + "')";
                data.cmd.Connection = data.con;
                data.cmd.ExecuteNonQuery();
                path += "//" + name;
                fileupload.SaveAs(path);
                data.insertRecord(classname.Text.Trim(), examname.Text.Trim(), date.Text.Trim(), name, Label1);
                if (!Label1.Text.Equals(""))
                {
                    Label1.Visible = true;
                    Label1.Text = "FILE UPLOAD SUCCESSFUL";
                }
            }
            catch (Exception ee)
            {
                Session["error"] = ee.Message;
            }
            finally
            {
                data.con.Close();
                if (Session["error"] != null)
                {
                    Response.Redirect("~/error.aspx");
                }
            }
        }
    }
}
