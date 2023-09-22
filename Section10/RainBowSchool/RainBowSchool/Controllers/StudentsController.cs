using Microsoft.AspNetCore.Mvc;
using RainBowSchool.Models;

namespace RainBowSchool.Controllers
{
    public class StudentsController : Controller
    {
        public static List<Students> stu=new List<Students>()
        {
            new Students(){Id=1,Name="Samuel",Age=16,Grade="O",SClass="10A"},
            new Students(){Id=2,Name="Janani",Age=15,Grade="A",SClass="9B"}
        };
        public IActionResult Index()
        {
            return View(stu);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Students());
        }
        [HttpPost]
        public IActionResult Create(Students student)
        {
            if(ModelState.IsValid)
            {
                stu.Add(student);
                return RedirectToAction("Index");
            }
            else
            {
                return View(stu);
            }
        }
    }
}
