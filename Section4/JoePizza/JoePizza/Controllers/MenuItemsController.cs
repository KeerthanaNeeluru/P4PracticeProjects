using JoePizza.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoePizza.Controllers
{
    public class MenuItemsController : Controller
    {
        public static List<MenuItem> menu=new List<MenuItem>()
        {
            new MenuItem(){Id=1,ItemName="Margerits Pizza",Toppings="Cheese & olives",Price=99},
            new MenuItem(){Id=2,ItemName="Corn & Cheese",Toppings="Cheese,Corn",Price=109}

        };

        public IActionResult Index()
        {
            return View(menu);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new MenuItem());
        }
        [HttpPost]
        public IActionResult Create(MenuItem item)
        {
            if(ModelState.IsValid)
            {
                menu.Add(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View(menu);
            }
        }
    }
}
