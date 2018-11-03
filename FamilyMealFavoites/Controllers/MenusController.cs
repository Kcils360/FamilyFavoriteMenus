using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamilyMealFavoites.Data;
using Microsoft.EntityFrameworkCore;

namespace FamilyMealFavoites.Controllers
{
    public class MenusController : Controller
    {
        private readonly FamilyFavoritesDbContext _context;
        public MenusController(FamilyFavoritesDbContext context)
        {
            _context = context;
        }

        //Get: Menus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Menu.ToListAsync());
        }
    }
}