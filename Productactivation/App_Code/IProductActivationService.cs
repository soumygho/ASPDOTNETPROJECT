using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IProductActivationService" here, you must also update the reference to "IProductActivationService" in Web.config.
[ServiceContract]
public interface IProductActivationService
{
    [OperationContract]
    string getActivationStatus(String productKey);
    [OperationContract]
    string activate(String productKey, String name, String emailaddress, String id);
}
