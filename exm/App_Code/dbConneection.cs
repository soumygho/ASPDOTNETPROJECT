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
/// Summary description for dbConneection
/// </summary>
public class dbConneection
{
	public dbConneection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
     public SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=F:\\SOUMYA\\ASP.NET PROJECT\\exm\\App_Data\\user.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
     public SqlCommand cmd = new SqlCommand();
     public SqlDataReader dr;
}
