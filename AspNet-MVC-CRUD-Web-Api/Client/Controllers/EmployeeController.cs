using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> emplist;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employee").Result;
            emplist = response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            return View(emplist);
        }
    }
}