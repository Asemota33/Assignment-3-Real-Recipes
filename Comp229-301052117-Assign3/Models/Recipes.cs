using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Comp229_301052117_Assign3.Models
{
    public class Recipes
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please choose the amount of servings")]
        public string Servings { get; set; }
        [Required(ErrorMessage = "Please enter your dish name")]
        public string DishName { get; set; }
        [Required(ErrorMessage = "Please enter the description of your dish")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the Instructions of your dish")]
        public string Instructions { get; set; }
        [Required(ErrorMessage = "Please choose a category")]
        public string Category { get; set; }
        public string ingredients1 { get; set; }
        public string ingredients2 { get; set; }
        public string ingredients3 { get; set; }
        public string review { get; set; }
        [Key]
        public int RecipesID { get; set; }

    }
}
