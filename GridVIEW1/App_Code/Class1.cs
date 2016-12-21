using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Connection
{
   public SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\SOUMYA\\GridVIEW1\\App_Data\\STUDENT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
  public  SqlCommand cmd = new SqlCommand();
  public SqlDataReader dr;
   public DataSet ds = new DataSet();
    public void Adapter(string s)
    {
        SqlDataAdapter da = new SqlDataAdapter(s,con);
        da.Fill(ds);
    }
}
