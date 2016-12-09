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

namespace Project_1.Views
{
    public class QuestionAnswerController : Controller
    {
        private ISFAQContext db = new ISFAQContext();

        // GET: QuestionAnswer
        public ActionResult Index()
        {
            return View(db.Degree_Question.ToList());
        }

        // GET: QuestionAnswer/Details/5
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

        // GET: QuestionAnswer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionAnswer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "degreeQuestionID,degreeID,userID,question,answer")] DegreeQuestions degreeQuestions)
        {
            if (ModelState.IsValid)
            {
                db.Degree_Question.Add(degreeQuestions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(degreeQuestions);
        }










        // THIS REDIRECTS YOU TO THE ANSWER QUESTION VIEW
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

        // ONCE YOU'VE ENTERED IN THE ANSWER TO A QUESTION IT SAVES IT AND REDIRECTS YOU TO THE PROPER FAQ PAGE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "degreeQuestionID,degreeID,userID,question,answer")] DegreeQuestions degreeQuestions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(degreeQuestions).State = EntityState.Modified;
                db.SaveChanges();

                if(degreeQuestions.degreeID == 5)
                {
                    return RedirectToAction("BSIS", "Degree");
                }
                else
                {
                    return RedirectToAction("MISM", "Degree");
                }
            }
            return View(degreeQuestions);
        }

















        // GET: QuestionAnswer/Delete/5
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

        // POST: QuestionAnswer/Delete/5
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
