using Microsoft.AspNetCore.Mvc;
using Paterna_Backend.DAL;
using Paterna_Backend.ViewModels;
using System.Linq;

namespace Paterna_Backend.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.PageIntro = _context.pageIntros.FirstOrDefault();
            homeVM.Services = _context.services.FirstOrDefault();
            homeVM.servicesCard = _context.servicesCards.ToList();
            homeVM.Plan = _context.plans.FirstOrDefault();
            homeVM.planCards = _context.planCards.ToList();
            return View(homeVM);
        }
    }
}
