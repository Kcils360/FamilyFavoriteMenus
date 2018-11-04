using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class AccountMenu
    {
        public int MenuID { get; set; }
        public int AccountID { get; set; }

        //navigation properties
        public Menu Menu { get; set; }
        public Account Account { get; set; }
        public ICollection<Member> Members { get; set; }


    }
}
