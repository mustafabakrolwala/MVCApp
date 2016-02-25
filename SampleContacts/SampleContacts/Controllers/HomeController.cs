using SampleContacts.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleContacts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
//task2
//task2 again
//dsf
            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
	//feature
            return View();
        }

        //this is comment added bt sureklhas
        public ActionResult UnAuthorized()
        {
//task
//task again
            return View();
        }
    }
}
