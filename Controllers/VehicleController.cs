using Gestion_voiture_BackOffice.Configurations;
using Gestion_voiture_BackOffice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestion_voiture_BackOffice.Controllers
{
    [ServiceFilter(typeof(AuthorizeFilter))]
    public class VehicleController : Controller
    {
        private readonly ApplicationDBContext _ContextVehicle;
        public VehicleController(ApplicationDBContext vehicleDBContext) {
            _ContextVehicle = vehicleDBContext;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            return View(await _ContextVehicle.Vehicles.ToListAsync());
        }

        public IActionResult details(int id)
        {
            return View();
        }

        // GET: Vehicle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _ContextVehicle.Vehicles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicle/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number,Pseudo,Type,Brand,Model,Capacity,DailyPrice,IsAvailable,PhotoUrl")] Vehicles vehicle)
        {
            if (ModelState.IsValid)
            {
                _ContextVehicle.Add(vehicle);
                await _ContextVehicle.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _ContextVehicle.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Number,Pseudo,Type,Brand,Model,Capacity,DailyPrice,IsAvailable,PhotoUrl")] Vehicles vehicle)
        {
            if (id != vehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ContextVehicle.Update(vehicle);
                    await _ContextVehicle.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _ContextVehicle.Vehicles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _ContextVehicle.Vehicles.FindAsync(id);
            _ContextVehicle.Vehicles.Remove(vehicle);
            await _ContextVehicle.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _ContextVehicle.Vehicles.Any(e => e.Id == id);
        }
    }
}
