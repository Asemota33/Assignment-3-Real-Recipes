using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Comp229_301052117_Assign3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comp229_301052117_Assign3.Controllers
{
    public class CrudController : Controller
    {
        private IRecipeRepository repository;
        public CrudController(IRecipeRepository repo) { repository = repo;  }
        public ViewResult Index() => View(repository.Recipes);
        public ViewResult Edit(string dishName) => View(repository.Recipes.FirstOrDefault(p => p.DishName == dishName));
        [HttpPost]
        public IActionResult Edit(Recipes recipes)
        {
            if (ModelState.IsValid)
            {
                repository.EditRecipe(recipes);
                return RedirectToAction("DataPage", "Home");
            }
            else
            {
                return View(recipes);
            }
        }
        [HttpGet]
        public ViewResult InsertPage()
        {
            return View("InsertPage");
        }

        [HttpPost]
        public ActionResult InsertPage(Recipes recipes)
        {
            //Instantiate an object of ingredient
            //Ingredients ingredients = repository.
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipes);
                return RedirectToAction("DataPage", "Home");
            }
            else
            {
                return View("InsertPage");
            }
        }
        [HttpPost]
        public IActionResult Delete(string dishName)
        {
            Recipes deletedRecipe = repository.DeleteRecipe(dishName);
            
            return RedirectToAction("DataPage", "Home");

        }
        
        //[HttpGet]
        public ViewResult Review(string dishName) => View(repository.Recipes.FirstOrDefault(p => p.DishName == dishName));
        [HttpPost]
        public IActionResult Review(Recipes re)
        {
                repository.SaveReview(re);//Same as edit recipe
                return RedirectToAction("DataPage", "Home");
            
        }
        
    }
}