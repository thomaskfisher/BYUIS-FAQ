using Project_1.DAL;
using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1.Controllers
{
    public class DegreeController : Controller
    {

        private ISFAQContext db = new ISFAQContext();

        // GET: Degree
        public ActionResult Index()
        {
            return View();
        }

        // MUST BE LOGGED IN TO VIEW THE FAQ PAGE
        [Authorize]
        public ActionResult BSIS()
        {
            ViewBag.Picture = Url.Content("~/Content/Images/CAlbrecht.jpg");

            var model = new DegreesAndQuestions();
            model.Degree = db.Degree.Where(m => m.degreeID == 5).ToList();
            model.DegreeQuestion = db.Degree_Question.Where(m => m.degreeID == 5).ToList();
            //PASSES THE CORRECT MODEL TO THE FAQ PAGE

            return View(model);
        }

        // MUST BE LOGGED IN TO VIEW THE FAQ PAGE
        [Authorize]
        public ActionResult MISM()
        {
            ViewBag.Picture = Url.Content("~/Content/Images/BAnderson.jpg");

            var model = new DegreesAndQuestions();
            model.Degree = db.Degree.Where(m => m.degreeID == 6).ToList();
            model.DegreeQuestion = db.Degree_Question.Where(m => m.degreeID == 6).ToList();
            //PASSES THE CORRECT MODEL TO THE FAQ PAGE

            return View(model);
        }
   }
}