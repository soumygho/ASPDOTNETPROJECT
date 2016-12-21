using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClassLisence
/// </summary>
public class ClassLisence
{
	public ClassLisence()
	{
		//
		// TODO: Add constructor logic here
		//

      
	}

    private string productkey = "";

    public string Productkey
    {
        get { return productkey; }
        set { productkey = value; }
    }
    private string activationdate = "";

    public string Activationdate
    {
        get { return activationdate; }
        set { activationdate = value; }
    }
    private string deactivationdate = "";

    public string Deactivationdate
    {
        get { return deactivationdate; }
        set { deactivationdate = value; }
    }
    private string softwaretype = "";

    public string Softwaretype
    {
        get { return softwaretype; }
        set { softwaretype = value; }
    }
    private string uniqueid = "";

    public string Uniqueid
    {
        get { return uniqueid; }
        set { uniqueid = value; }
    }
    private string name = "";

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string email = "";

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string status = "";

    public string Status
    {
        get { return status; }
        set { status = value; }
    }
    int id = 0;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}
