using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp229_301052117_Assign3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comp229_301052117_Assign3.Controllers
{
    public class HomeController : Controller
    {

        private IRecipeRepository repository; // Whenever i call this class i am calling EFRecipeRepository with the addTransient method in startup

        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View();
        }
       
        public ViewResult DisplayPage(Recipes recipe) // the value gotten from the url
        {
            if (recipe.DishName == null)
            {
                return View();
            }
            else
            {
                return View(repository.Recipes.FirstOrDefault(r => r.DishName == recipe.DishName));
            }
        }

        public ViewResult UserPage()
        {
            return View("UserPage", repository.Recipes);
        }
        public ViewResult DataPage()
        {
            return View("DataPage", repository.Recipes);
        }
        
    }

}