using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfRestService.Model;

namespace WcfRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserRestService" in both code and config file together.
    [ServiceContract]
    public interface IUserRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Users/{Name}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User GetUser(string Name);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Users", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<User> ListUsers();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Users/Create", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User CreateUser(User pvUser);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/Users/Update", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        User UpdateUser(User pvUser);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/Users/Delete", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
         String DeleteUser(User pvUser);



    }
}
