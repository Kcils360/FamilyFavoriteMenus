using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public int AvgRating { get; set; }

        //navigation properties
        public ICollection<User> Users { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
