using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301052117_Assign3.Models
{
    public class EFRecipesRepository : IRecipeRepository
    {
        private ApplicationDbContext context;
        public EFRecipesRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Recipes> Recipes => context.Recipes;

        public void EditRecipe(Recipes recipe)
        {
    
                Recipes dbEntry = context.Recipes.FirstOrDefault(p => p.DishName == recipe.DishName);
                if (dbEntry != null)
                {
                    dbEntry.DishName = recipe.DishName;
                    dbEntry.Description = recipe.Description;
                    dbEntry.Category = recipe.Category;
                    dbEntry.Author = recipe.Author;
                    dbEntry.Servings = recipe.Servings;
                    dbEntry.ingredients1 = recipe.ingredients1;
                    dbEntry.ingredients2 = recipe.ingredients2;
                    dbEntry.ingredients3 = recipe.ingredients3;
                    dbEntry.review = dbEntry.review;

            }

            context.SaveChanges();
        }

        public void SaveRecipe(Recipes recipe)
        {
            context.Recipes.AttachRange(recipe);
            
            context.SaveChanges();
        }
        public void SaveReview(Recipes recipe)
        {
            // Break point to see value of dishname
                Recipes dbEntry = context.Recipes.FirstOrDefault(p => p.DishName == recipe.DishName);
            
                dbEntry.DishName = recipe.DishName;
                dbEntry.Description = recipe.Description;
                dbEntry.Category = recipe.Category;
                dbEntry.Author = recipe.Author;
                dbEntry.Servings = recipe.Servings;
                dbEntry.ingredients1 = recipe.ingredients1;
                dbEntry.ingredients2 = recipe.ingredients2;
                dbEntry.ingredients3 = recipe.ingredients3;
                dbEntry.review = recipe.review;
            
            context.SaveChanges();
        }
        public Recipes DeleteRecipe(string dishName)
        {
            Recipes dbEntry = context.Recipes.FirstOrDefault(p => p.DishName == dishName);
            if (dbEntry != null)
            {
                context.Recipes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
