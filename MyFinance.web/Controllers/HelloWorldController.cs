using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFinance.web.Controllers
{
    /*
         * if you want to test using this: Click “Set as start-up project”
         */
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Welcome(string name, int Numtimes=1)
        {
            return "this is my name "+name+" and numtimes ="+Numtimes;
        }
        [Route("welcome2/{name}/{Numtimes}")]
        // this will be called directly
        public string Welcome2(string name, int Numtimes = 1)
        {
            return "this is my name " + name + " and numtimes =" + Numtimes;
        }
        public ActionResult Affich(string name, int Numtimes = 1)
        {
            ViewBag.Message = "my name is" + name ;
            ViewBag.nbre = Numtimes;
            return View();
        }
    }
}