using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tutorial5.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public string Index()
        {
            return "This page to show the subject homepage";
        }

        public string Subjects()
        {
            return "This page is to show the list of subjects that the student is enrolled in";
        }

        public string Details(string subjectId)
        {
            return HttpUtility.HtmlEncode("Subject Code: " + subjectId);
        }

        public ActionResult Edit(int subjectId)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int subjectId)
        {
            return RedirectToAction("Index");
        }
    }
}
