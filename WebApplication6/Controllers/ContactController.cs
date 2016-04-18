using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class ContactController : Controller
    {

        private static Models.ContactModel _contact;

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail() {

            if (_contact == null)
            {
                _contact = new Models.ContactModel()
                {
                    ContactID = 123,
                    FirstName = "Bob",
                    LastName = "Jones"
                };
            }
            
            return View(_contact);

        }

        [HttpPost]
        public ActionResult Detail(Models.ContactModel contact)
        {
            _contact = contact;
            return RedirectToAction("Detail");
        }

    }
}