using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DatabaseConnection
/// </summary>
public class DatabaseConnection
{
	public DatabaseConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public SqlConnection con = new SqlConnection("Data Source=NET-02\\SQLEXPRESS;Initial Catalog=STUDB;Integrated Security=True");
    public SqlCommand cmd = new SqlCommand();
    public SqlDataReader dr;
   
}
