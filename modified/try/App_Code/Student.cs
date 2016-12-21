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

/// <summary>
/// Summary description for Student
/// </summary>
public class Student
{
   public String name = null;
    public String Class = null;
    public int roll = 0;
    public Result[] result = null;
	public Student()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void createResult(String name,String Class,int roll,Result[] ob)
    {
        this.name = name;
        this.Class = Class;
        this.roll = roll;
        this.result = ob;
    }
}
