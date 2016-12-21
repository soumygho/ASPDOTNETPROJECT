using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customer
/// </summary>
public class Customer
{
	public Customer()
	{
		
	}
    private String _email = "";

    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private int _id = 0;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private String _name = "";

    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
