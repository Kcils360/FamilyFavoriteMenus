using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class MenuRating
    {
        public int MenuId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }

        public User User { get; set; }
        public Menu Menu { get; set; }

    }
}
