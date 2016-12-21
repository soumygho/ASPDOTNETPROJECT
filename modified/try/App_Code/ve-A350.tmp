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
using System.Collections;

/// <summary>
/// Summary description for ResultDAO
/// </summary>
public class ResultDAO
{
    String sqlStatement = "";
    String tableName = "";
    private dbconnection database = new dbconnection();
	public ResultDAO(String cmd,String table)
	{
		//
		// TODO: Add constructor logic here
		//
        sqlStatement = cmd;
        tableName = table;
	}
    public void insertResult()
    {
        try
        {
            database.con.Open();
            database.cmd.CommandText = sqlStatement;
            database.cmd.Connection = database.con;
            database.cmd.ExecuteNonQuery();
        }
        catch(Exception ee)
        {
            throw(ee);
        }
        finally
        {
            database.con.Close();
        }
    }
    public Result getResult(int roll)
    {
        Result ob = null;
        return ob;
    }
    public ArrayList getSetOfResult(int min, int max)
    {
        ArrayList al = new ArrayList();
        return al;
    }
    public void update(String command)
    {
        sqlStatement = command;
    }
}
