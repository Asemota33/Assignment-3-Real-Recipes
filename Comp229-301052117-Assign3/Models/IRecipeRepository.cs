using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp229_301052117_Assign3.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipes> Recipes { get; }

        void SaveRecipe(Recipes recipe);
        void EditRecipe(Recipes recipe);


        Recipes DeleteRecipe(string dishName);
        void SaveReview(Recipes e);
    }
}
