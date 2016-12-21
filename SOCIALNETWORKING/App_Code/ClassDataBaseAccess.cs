using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
/// <summary>
/// Summary description for ClassDataBaseAccess
/// </summary>
public class ClassDataBaseAccess
{
    private string urlOfDatabase = "";
    public OleDbConnection con = null;
    public OleDbDataReader dr = null;
    public OleDbDataAdapter da = null;
    public OleDbCommand cmd = null;
    public DataSet dataset = new DataSet();
	public ClassDataBaseAccess(string url)
	{
        urlOfDatabase = url;
        con = new OleDbConnection(url);

	}
    
}
