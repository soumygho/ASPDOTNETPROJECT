using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
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
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection1"].ToString());
    public SqlCommand cmd = new SqlCommand();
    public SqlDataAdapter da = new SqlDataAdapter();
    public SqlDataReader dr;
}
