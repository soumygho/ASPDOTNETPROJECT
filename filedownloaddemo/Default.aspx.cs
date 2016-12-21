using System;
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
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DirectoryInfo directory = new DirectoryInfo("C:\\Users\\soumya\\Desktop\\applet");
        int count=0;
        foreach (FileInfo file in directory.GetFiles())
        {
            HyperLink link = new HyperLink();
            link.Text = file.Name;
            link.ID = "link" + count;
            link.NavigateUrl = "download.aspx?downloadid="+file.Name;
            Page.Controls.Add(link);
            Page.Controls.Add(new LiteralControl("<br/>"));
        }
    }
}
