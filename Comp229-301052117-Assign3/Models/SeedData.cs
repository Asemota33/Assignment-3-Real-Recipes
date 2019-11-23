using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Comp229_301052117_Assign3.Models
{
    public class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                            new Recipes
                            {
                                DishName = "Jollof",
                                Description = "Amazing African Delicacy",
                                Category = "African",
                                Servings = "1 - 5",
                                Author = "George",
                                Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                                ingredients1 = "2 killograms of this",
                                ingredients2 = "2 killograms of that",
                                ingredients3 = "3 killograms of all of it",
                                review = "This is the best recipe ever"
                            },
                    new Recipes
                    {
                        DishName = "BBQ Chicken",
                        Description = "Classic Timeless Chicken",
                        Category = "Other",
                        Servings = "1 - 5",
                        Author = "Michael",
                        Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                        ingredients1 = "2 killograms of this",
                        ingredients2 = "2 killograms of that",
                        ingredients3 = "3 killograms of all of it",
                        review = "This is the best recipe ever"

                    },
                    new Recipes
                    {
                        DishName = "Sweet Peas",
                        Description = "Mouth Watering Veggie Dish",
                        Category = "Vietnamese",
                        Servings = "6 - 10",
                        Author = "Henry",
                        Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                        ingredients1 = "2 killograms of this",
                        ingredients2 = "2 killograms of that",
                        ingredients3 = "3 killograms of all of it",
                        review = "This is the best recipe ever"

                    },
                    new Recipes
                    {
                        DishName = "Red Velvet Cake",
                        Description = "The Perfect Cake For Any Ocassion",
                        Category = "Other",
                        Servings = "6 - 10",
                        Author = "Angela",
                        Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                        ingredients1 = "2 killograms of this",
                        ingredients2 = "2 killograms of that",
                        ingredients3 = "3 killograms of all of it",
                        review = "This is the best recipe ever"

                    },
                    new Recipes
                    {
                        DishName = "Peanut Butter & Jelly Sandwich",
                        Description = "Perfect Pre Meal Snack",
                        Category = "Other",
                        Servings = "1 - 5",
                        Author = "Becky",
                        Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                        ingredients1 = "2 killograms of this",
                        ingredients2 = "2 killograms of that",
                        ingredients3 = "3 killograms of all of it",
                        review = "This is the best recipe ever"

                    },
                    new Recipes
                    {
                        DishName = "Spaghetti",
                        Description = "Time Tested Italian Delicacy",
                        Category = "Italian",
                        Servings = "11 - 15",
                        Author = "Edward",
                        Instructions = "1. Do this 2. Do that 3. Now do this 4. Voila",
                        ingredients1 = "2 killograms of this",
                        ingredients2 = "2 killograms of that",
                        ingredients3 = "3 killograms of all of it",
                        review = "This is the best recipe ever"

                    }

                    ); ;
                context.SaveChanges();
            }
        }
    }
}
