using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\formdb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    public SqlCommand cmd = new SqlCommand();
    public SqlDataReader dr = null;
    public SqlDataAdapter da = null;
}
