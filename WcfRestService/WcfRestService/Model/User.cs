using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfRestService.Model
{
    public class User
    {

        public string Name { get; set; }
        public string Department { get; set; }

        public int Salary { get; set; }
        public string Message { get; set; }
    }
}