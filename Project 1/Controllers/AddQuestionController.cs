using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_1.DAL;
using Project_1.Models;

namespace Project_1.Controllers
{
    public class AddQuestionController : Controller
    {
        private ISFAQContext db = new ISFAQContext();

        // GET: AddQuestion
        public ActionResult Index()
        {
            return View(db.Degree_Question.ToList());
        }

        // GET: AddQuestion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeQuestions degreeQuestions = db.Degree_Question.Find(id);
            if (degreeQuestions == null)
            {
                return HttpNotFound();
            }
            return View(degreeQuestions);
        }











        // ALLOWS YOU TO ADD A QUESTION TO THE BSIS FAQ PAGE
        public ActionResult AddBSISQuestion()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBSISQuestion([Bind(Include = "degreeQuestionID,degreeID,userID,question,answer")] DegreeQuestions degreeQuestions)
        {
                db.Degree_Question.Add(degreeQuestions);
                db.SaveChanges();
                return RedirectToAction("BSIS", "Degree");
        }







        // ALLOWS YOU TO ADD A QUESETION TO THE MISM PAGE
        public ActionResult AddMISMQuestion()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMISMQuestion([Bind(Include = "degreeQuestionID,degreeID,userID,question,answer")] DegreeQuestions degreeQuestions)
        {
                db.Degree_Question.Add(degreeQuestions);
                db.SaveChanges();
                return RedirectToAction("MISM", "Degree");
        }
















        // GET: AddQuestion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeQuestions degreeQuestions = db.Degree_Question.Find(id);
            if (degreeQuestions == null)
            {
                return HttpNotFound();
            }
            return View(degreeQuestions);
        }

        // POST: AddQuestion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "degreeQuestionID,degreeID,userID,question,answer")] DegreeQuestions degreeQuestions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(degreeQuestions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(degreeQuestions);
        }

        // GET: AddQuestion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DegreeQuestions degreeQuestions = db.Degree_Question.Find(id);
            if (degreeQuestions == null)
            {
                return HttpNotFound();
            }
            return View(degreeQuestions);
        }

        // POST: AddQuestion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DegreeQuestions degreeQuestions = db.Degree_Question.Find(id);
            db.Degree_Question.Remove(degreeQuestions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
