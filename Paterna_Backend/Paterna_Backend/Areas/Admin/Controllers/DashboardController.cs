using Microsoft.AspNetCore.Mvc;
using Paterna_Backend.DAL;
using Paterna_Backend.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paterna_Backend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ServicesCard> servicesCards = _context.servicesCards.ToList();
            return View(servicesCards);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            ServicesCard dbservicesCard = _context.servicesCards.Find(id);
            if (dbservicesCard == null) return View(dbservicesCard);
            return View(dbservicesCard);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            ServicesCard dbservicesCard = _context.servicesCards.Find(id);
            if (dbservicesCard == null) return View(dbservicesCard);
            _context.servicesCards.Remove(dbservicesCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Create(ServicesCard servicesCard)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ServicesCard newServicesCard = new ServicesCard();
            newServicesCard.IconPath = servicesCard.IconPath;
            newServicesCard.Name = servicesCard.Name;
            newServicesCard.Description = servicesCard.Description;
            await _context.servicesCards.AddAsync(newServicesCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult>Update(int? id)
        {
            if (id == null) return NotFound();
            ServicesCard dbServiceCard= await _context.servicesCards.FindAsync(id);
            if(dbServiceCard == null) return NotFound();
            return View(dbServiceCard);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Update(ServicesCard servicesCard,int? id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            ServicesCard dbServiceCard = await _context.servicesCards.FindAsync(id);
            if(dbServiceCard==null) return NotFound();
            dbServiceCard.IconPath = servicesCard.IconPath;
            dbServiceCard.Name = servicesCard.Name;
            dbServiceCard.Description = servicesCard.Description;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
