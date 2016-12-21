using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Extensions;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

/// <summary>
/// Summary description for autocompleteservice
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.ComponentModel.ToolboxItem(false)]
[ScriptService]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class autocompleteservice : System.Web.Services.WebService {

    public autocompleteservice () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string getList()
    {
        Customer[] customers = new Customer[2];
        customers[0] = new Customer();

        customers[0].Id = 1;
        customers[0].Name = "SOUMYA";
        customers[1] = new Customer();
        customers[1].Id = 2;
        customers[1].Name = "SUBHRA";
        return new JavaScriptSerializer().Serialize(customers);
    }
}

