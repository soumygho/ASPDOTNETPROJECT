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
/// Summary description for DBCONNECTION
/// </summary>
public class DBCONNECTION
{
    public SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\DELL\\REGISTRATION\\App_Data\\ACCOUNT_LOGIN.mdf;Integrated Security=True;User Instance=True");
   public SqlCommand cmd = new SqlCommand();
   public SqlDataReader dr;
   public SqlDataReader da;
	public DBCONNECTION()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
