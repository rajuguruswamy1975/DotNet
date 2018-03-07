using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfRestService.BL;
using WcfRestService.Model;

namespace WcfRestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserRestService.svc or UserRestService.svc.cs at the Solution Explorer and start debugging.
    public class UserRestService : IUserRestService
    {

        User IUserRestService.GetUser(string Name)
        {
            UserService service = new UserService();

            User lvUser = service.GetUser(Name);

            return lvUser;
        }

        public List<User> ListUsers()
        {
            UserService service = new UserService();
            return service.ListUser();

        }

        public User CreateUser(User pvUser)
        {
            UserService service = new UserService();
           return service.CreateUser(pvUser);
        }

        public User UpdateUser(User pvUser)
        {
            UserService service = new UserService();
            return service.UpdateUser(pvUser);
        }


        public string DeleteUser(User pvUser)
        {
            UserService service = new UserService();
            return service.DeleteUser(pvUser);
        }

    }
}
