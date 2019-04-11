using MVCStudenti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudenti.Controllers
{
    public class StudentController : Controller
    {
        // GET: STudent
        public ActionResult Index()
        {
            var seznam = new List<Student>()
            {
                new Student(){ StudentId=1,StudentName="John",Age=18},
                new Student(){ StudentId=2,StudentName="Steve",Age=19},
                new Student(){ StudentId=3,StudentName="Bill",Age=20},
                new Student(){ StudentId=4,StudentName="Ron",Age=21},
                new Student(){ StudentId=5,StudentName="Rob",Age=18},
                new Student(){ StudentId=6,StudentName="Kris",Age=19},
                new Student(){ StudentId=7,StudentName="Bob",Age=20},
                new Student(){ StudentId=8,StudentName="Angel",Age=21}
            };
            return View(seznam);
        }
    }
}