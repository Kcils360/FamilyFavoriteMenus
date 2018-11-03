using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class Ingredient
    {
        [Key]
        public string IngredientType { get; set; }
    }
}
