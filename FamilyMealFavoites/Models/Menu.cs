using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string DishName { get; set; }
        public int AvgRating { get; set; }

        //navigation properties
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
