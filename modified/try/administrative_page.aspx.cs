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

public partial class administrative_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userid"] == null)
        {
            Response.Redirect("~/Administrative_login.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string url = DropDownList1.SelectedItem.Value.ToString();
        url += ".aspx";
        Response.Redirect(url.ToString());
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Session.Clear();
        Response.Redirect("~/Administrative_login.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string fName = Server.MapPath("~/Registration").ToString() + "//" + "registrationdb.accdb";
        FileInfo fi = new FileInfo(fName);
        long sz = fi.Length;

        Response.ClearContent();
        String filename = "\"" + System.IO.Path.GetFileName(fName).ToString() + "\"";
        Response.ContentType = MimeType(Path.GetExtension(fName));
        Response.AddHeader("Content-Disposition", string.Format("attachment; filename = {0}", filename));
        Response.AddHeader("Content-Length", sz.ToString("F0"));
        Response.TransmitFile(fName);
        Response.End();
    }
    public static string MimeType(string Extension)
    {
        string mime = "application/octetstream";
        if (string.IsNullOrEmpty(Extension))
            return mime;
        string ext = Extension.ToLower();
        Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
        if (rk != null && rk.GetValue("Content Type") != null)
            mime = rk.GetValue("Content Type").ToString();
        return mime;
    } 
}
