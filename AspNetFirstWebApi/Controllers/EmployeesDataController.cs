using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetFirstWebApi.Controllers
{
    public class EmployeesDataController : ApiController//specifies that it is a API controller
    {
        public string[] EmployyesArray = { "Saad","Haris","Zubair","Arshad","Azam" };

        [HttpGet]
        public string[] GetEmployees()
        {
            return EmployyesArray;
        }
        [HttpGet]
        public string GetEmployeesByIndex(int ID)
        {
            return EmployyesArray[ID];
        }
    }
}
