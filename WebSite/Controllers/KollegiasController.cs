using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class KollegiasController : Controller
    {
        private readonly ApplicationContext _context;

        public KollegiasController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: Kollegias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kollegia.ToListAsync());
        }

        // GET: Kollegias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kollegia = await _context.Kollegia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kollegia == null)
            {
                return NotFound();
            }

            return View(kollegia);
        }

        // GET: Kollegias/Create
        public IActionResult Create(int id)
        {
            Kollegia kollegia = new Kollegia();
            kollegia.Lang = id;
            return View(kollegia);
        }

        // POST: Kollegias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Positions,Desc,Lang")] Kollegia kollegia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kollegia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kollegia);
        }

        // GET: Kollegias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kollegia = await _context.Kollegia.FindAsync(id);
            if (kollegia == null)
            {
                return NotFound();
            }
            return View(kollegia);
        }

        // POST: Kollegias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Positions,Desc,Lang")] Kollegia kollegia)
        {
            if (id != kollegia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kollegia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KollegiaExists(kollegia.Id))
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
            return View(kollegia);
        }

        // GET: Kollegias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kollegia = await _context.Kollegia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kollegia == null)
            {
                return NotFound();
            }

            return View(kollegia);
        }

        // POST: Kollegias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kollegia = await _context.Kollegia.FindAsync(id);
            _context.Kollegia.Remove(kollegia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KollegiaExists(int id)
        {
            return _context.Kollegia.Any(e => e.Id == id);
        }
    }
}
