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
      su.Id = Guid.NewGuid().ToString();
      su.Save();
      return View();
    }
  }
}
