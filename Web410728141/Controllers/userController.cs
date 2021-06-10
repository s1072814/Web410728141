using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410728141.ViewModels;

namespace Web410728141.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {
            if (ModelState.IsValid) {
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}