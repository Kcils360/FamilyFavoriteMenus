using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMealFavoites.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //navigation properties
        //public int AccountID { get; set; }
    }
}
