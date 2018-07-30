using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SupplierPortal.Models;

namespace SupplierPortal.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Register(SupplierUser su)
    {
      if (su.Password != su.ConfirmPassword)
      {
	ModelState.AddModelError("confirm password", "密码和确认密码输入不匹配");
      }

      if (ModelState.IsValid)
      {
        su.Id = Guid.NewGuid().ToString();
        su.Save();
      }
      return View();
    }
  }
}
