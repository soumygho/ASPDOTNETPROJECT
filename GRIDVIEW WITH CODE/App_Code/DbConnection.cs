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
using System.Web.Configuration;

/// <summary>
/// Summary description for DbConnection
/// </summary>
public class DbConnection
{
	public DbConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection1"].ConnectionString.ToString());
    public SqlCommand cmd = new SqlCommand();
}
