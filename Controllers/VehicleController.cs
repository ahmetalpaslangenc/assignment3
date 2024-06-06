using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VehicleRegistrationApp.Data;
using VehicleRegistrationApp.Models;

namespace VehicleRegistrationApp.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehicleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vehicles = _context.Vehicles.Include(v => v.Brand).ToList();
            return View(vehicles);
        }

        public IActionResult Create()
        {
            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Vehicles.Add(vehicle);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name", vehicle.BrandId);
            return View(vehicle);
        }

        public IActionResult Edit(int id)
        {
            var vehicle = _context.Vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name", vehicle.BrandId);
            return View(vehicle);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Vehicles.Update(vehicle);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Brands = new SelectList(_context.Brands, "Id", "Name", vehicle.BrandId);
            return View(vehicle);
        }

        public IActionResult Delete(int id)
        {
            var vehicle = _context.Vehicles.Include(v => v.Brand).FirstOrDefault(v => v.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var vehicle = _context.Vehicles.Find(id);
            _context.Vehicles.Remove(vehicle);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

