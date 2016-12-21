using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerSuggest
/// </summary>
public class CustomerSuggest
{
	public CustomerSuggest()
	{
		//
		// TODO: Add constructor logic here
		//

        
	}
    private int _custid = 0;

    public int Custid
    {
        get { return _custid; }
        set { _custid = value; }
    }
    private String _custname = "";

    public String Custname
    {
        get { return _custname; }
        set { _custname = value; }
    }
    private string _Suggestion = "";

    public string Suggestion
    {
        get { return _Suggestion; }
        set { _Suggestion = value; }
    }

    private String _custaddress = "";

    public String Custaddress
    {
        get { return _custaddress; }
        set { _custaddress = value; }
    }
    private String _custmobno = "";

    public String Custmobno
    {
        get { return _custmobno; }
        set { _custmobno = value; }
    }
    private String _custemail = "";

    public String Custemail
    {
        get { return _custemail; }
        set { _custemail = value; }
    }
}
