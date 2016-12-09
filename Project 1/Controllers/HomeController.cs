using Project_1.DAL;
using Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

//THIS WAS BUILT BY THOMAS FISHER ON 12/8/16. IT ALLOWS USERS TO CREATE AN ACCOUNT, LOGIN, VIEW DEGREE FAQS, POST QUESTIONS, AND ANSWER THEM

namespace Project_1.Controllers
{
    public class HomeController : Controller
    {
        private ISFAQContext db = new ISFAQContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Thank you for your interest!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Thank you for your interest!";

            return View();
        }

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        // THIS LOGS IN USER. IF THEY ENTER AN INCORRECT EMAIL THEY'RE GIVEN THAT MESSAGE, IF THEY GIVE THE WRONG PASSWORD THEY'RE GIVENT THAT MESSAGE
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email address"].ToString();
            String password = form["Password"].ToString();

            bool validUser = db.User.Any(m => m.userEmail.Equals(email));

            if(validUser)
            {
                Users tempUser = db.User.SingleOrDefault(m => m.userEmail.Equals(email));

                int myUserID = tempUser.userID;
                Session["TESLA"] = myUserID;
               
                if(string.Equals(tempUser.password, password))
                {
                    FormsAuthentication.SetAuthCookie(email, rememberMe);
                    return RedirectToAction("Index", "Degree");
                }
                else
                {
                    ViewBag.error = "Password is incorrect.";
                    return View();
                }
            }
            else
            {
                ViewBag.error = "Account does not exist";
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        // THIS SAVES A NEW USER TO THE DATABASE AND SAVES THEIR SESSION KEY/COOKIES SO THEY ARE AUTOMATICALLY LOGGED IN
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "userID, userEmail, password, userFirstName, userLastName")] Users User, FormCollection Form, bool rememberMe = false)
        {
            if (ModelState.IsValid)
            {
                String userEmail = Form["userEmail"].ToString();
                db.User.Add(User);
                db.SaveChanges();
                FormsAuthentication.SetAuthCookie(userEmail, rememberMe);

                int myUserID = User.userID;
                Session["TESLA"] = myUserID;
                return RedirectToAction("Index", "Degree");
            }

            return View(User);
        } 

    }
}