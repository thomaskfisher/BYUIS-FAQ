using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class DegreeController : Controller
    {
        // GET: Degree
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BSIS()
        {
            ViewBag.Name = "Bachelors of Science, Information Systems";
            ViewBag.Coordinator = "Dr. Conan Albrecht";
            ViewBag.ProfTitle = "Professor of Information Systems";
            ViewBag.OfficeAddress = "780 TNRB Provo, UT";
            ViewBag.PhDEducation = "PhD, Information Systems, University of Arizona, 2000";
            ViewBag.MasterEducation = "MAcc, Information Systems, Brigham Young University, 1997";
            ViewBag.BachelorEducation = "BS, Accounting, Brigham Young University, 1997";
            ViewBag.Picture = Url.Content("~/Content/Images/CAlbrecht.jpg");

            return View();
        }

        public ActionResult MISM()
        {
            ViewBag.Name = "Masters of Information Systems";
            ViewBag.Coordinator = "Dr. Bonnie Anderson";
            ViewBag.ProfTitle = "Associate Professor of Information Systems";
            ViewBag.OfficeAddress = "776 TNRB Provo, UT";
            ViewBag.PhDEducation = "PhD, Information Systems, Carnegie Mellon University, 2001";
            ViewBag.MasterEducation = "MAcc, Information Systems, Brigham Young University, 1995";
            ViewBag.BachelorEducation = "BS, Accounting, Brigham Young University, 1995";
            ViewBag.Picture = Url.Content("~/Content/Images/BAnderson.jpg");

            return View();
        }
    }
}