using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfRestService.Model;

namespace WcfRestService.BL
{
    public class UserService
    {
        private List<User> lvUserList;

        public UserService() {
            lvUserList = new List<User>();

            User lvUser1 = new User
            {
                Name = "Edapadi PalinidSamy",
                Department = "TamilNadu Arasu Tirutu Paya sankam",
                Salary = 100000
            };
            User lvUser2 = new User
            {
                Name = "O Panner Selvam",
                Department = "TamilNadu Arasu Tirutu Paya sankam",
                Salary = 10000
            };
            User lvUser3 = new User
            {
                Name = "Ragul Gandi",
                Department = "India Somberi sankam",
                Salary = 10000
            };
            User lvUser4 = new User
            {
                Name = "Modi",
                Department = "India Vaiyabari Sankam",
                Salary = 10000
            };
            lvUserList.Add(lvUser1);
            lvUserList.Add(lvUser2);
            lvUserList.Add(lvUser3);
            lvUserList.Add(lvUser4);

        }
        public  User CreateUser(User pvUser)
       {
            pvUser.Message = "User Created";
            lvUserList.Add(pvUser);
           
            return pvUser;
       }

        public User UpdateUser(User pvUser)
        {
            pvUser.Message = "User Updated";
            lvUserList.Add(pvUser);           
            return pvUser;
        }

        public String DeleteUser(User pvUser)
        {
            return "User " + pvUser.Name + "deleted.";
        }

        public  User GetUser(string pvName)
        {
            var lvUser = (from x in lvUserList
                          where x.Name == pvName
                          select x).FirstOrDefault();
            return lvUser;
        }

        public List<User> ListUser()
        {
            return lvUserList;
        }
    }
}