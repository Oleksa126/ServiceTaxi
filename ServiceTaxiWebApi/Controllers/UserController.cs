using ServiceTaxiBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceTaxiWebApi.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserServise _userService;

        public UserController(IUserServise userServise) {
            _userService = userServise;
        }




        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}