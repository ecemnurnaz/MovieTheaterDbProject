using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreMovieTheater.Models.Context;
using NetCoreMovieTheater.Models.Entities;

namespace NetCoreMovieTheater.Controllers
{
    public class SalloonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SalloonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Salloon
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salloons.ToListAsync());
        }

        // GET: Salloon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salloon = await _context.Salloons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salloon == null)
            {
                return NotFound();
            }

            return View(salloon);
        }

        // GET: Salloon/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Salloon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SalloonName,Capacity,Id,CreatedDate")] Salloon salloon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salloon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salloon);
        }

        // GET: Salloon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salloon = await _context.Salloons.FindAsync(id);
            if (salloon == null)
            {
                return NotFound();
            }
            return View(salloon);
        }

        // POST: Salloon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SalloonName,Capacity,Id,CreatedDate")] Salloon salloon)
        {
            if (id != salloon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salloon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalloonExists(salloon.Id))
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
            return View(salloon);
        }

        // GET: Salloon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salloon = await _context.Salloons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salloon == null)
            {
                return NotFound();
            }

            return View(salloon);
        }

        // POST: Salloon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salloon = await _context.Salloons.FindAsync(id);
            _context.Salloons.Remove(salloon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalloonExists(int id)
        {
            return _context.Salloons.Any(e => e.Id == id);
        }
    }
}
