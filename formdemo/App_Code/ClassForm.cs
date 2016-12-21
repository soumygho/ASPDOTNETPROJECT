using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClassForm
/// </summary>
public class ClassForm
{
	public ClassForm()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private String _userName = null;

    public String UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    private String _pwd = null;

    public String Pwd
    {
        get { return _pwd; }
        set { _pwd = value; }
    }
    private int _userid = 0;

    public int Userid
    {
        get { return _userid; }
        set { _userid = value; }
    }

    private String _name = null;

    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private String _address = null;

    public String Address
    {
        get { return _address; }
        set { _address = value; }
    }
    private String _city = null;

    public String City
    {
        get { return _city; }
        set { _city = value; }
    }
    private String _state = null;

    public String State
    {
        get { return _state; }
        set { _state = value; }
    }
    private String _postalcode = null;

    public String Postalcode
    {
        get { return _postalcode; }
        set { _postalcode = value; }
    }
    private string _email = null;

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private String _sex = null;

    public String Sex
    {
        get { return _sex; }
        set { _sex = value; }
    }
    private String _interest = null;

    public String Interest
    {
        get { return _interest; }
        set { _interest = value; }
    }
    private String _comment = null;

    public String Comment
    {
        get { return _comment; }
        set { _comment = value; }
    }
        private String _rating = null;

    public String Rating
    {
        get { return _rating; }
        set { _rating = value; }
    }
}
