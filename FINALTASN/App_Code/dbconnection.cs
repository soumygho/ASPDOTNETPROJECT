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
using System.Web.Configuration;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dbconnection
/// </summary>
public class dbconnection
{
	public dbconnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection1"].ConnectionString.ToString());
    public SqlCommand cmd = new SqlCommand();
    public SqlDataReader dr;
}
