using FlowerStore.DAL;
using FlowerStore.Models;
using FlowerStore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Controllers
{
    public class HomeController : Controller
    { private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            var slider = _context.Sliders.FirstOrDefault();

            var valentine = _context.Valentines.FirstOrDefault();

            List<ListItem> listItems = _context.LitsItems.ToList(); 

            return View(new HomeViewModel {slider=slider,valentine=valentine,listItem=listItems });
        }

       
    }
}
