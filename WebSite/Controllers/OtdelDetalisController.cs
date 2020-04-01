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
    public class OtdelDetalisController : Controller
    {
        private readonly ApplicationContext _context;

        public OtdelDetalisController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: OtdelDetalis
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.OtdelDetali.Include(o => o.Otdel).Include(o => o.Positions);
            return View(await applicationContext.ToListAsync());
        }

        // GET: OtdelDetalis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otdelDetali = await _context.OtdelDetali
                .Include(o => o.Otdel)
                .Include(o => o.Positions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otdelDetali == null)
            {
                return NotFound();
            }

            return View(otdelDetali);
        }

        // GET: OtdelDetalis/Create
        public IActionResult Create(int id)
        {
            ViewData["OtdelId"] = new SelectList(_context.Otdel, "Id", "Desc");
            ViewData["PositionsId"] = new SelectList(_context.Positions, "Id", "Desc");
            OtdelDetali otdel = new OtdelDetali();
            otdel.Lang = id;
            return View(otdel);
        }

        // POST: OtdelDetalis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,OtdelId,PositionsId,WorkPhone,Phone,Fax,Email,Lang")] OtdelDetali otdelDetali)
        {
            if (ModelState.IsValid)
            {
                _context.Add(otdelDetali);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OtdelId"] = new SelectList(_context.Otdel, "Id", "Desc", otdelDetali.OtdelId);
            ViewData["PositionsId"] = new SelectList(_context.Positions, "Id", "Desc", otdelDetali.PositionsId);
            return View(otdelDetali);
        }

        // GET: OtdelDetalis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otdelDetali = await _context.OtdelDetali.FindAsync(id);
            if (otdelDetali == null)
            {
                return NotFound();
            }
            ViewData["OtdelId"] = new SelectList(_context.Otdel, "Id", "Desc", otdelDetali.OtdelId);
            ViewData["PositionsId"] = new SelectList(_context.Positions, "Id", "Desc", otdelDetali.PositionsId);
            return View(otdelDetali);
        }

        // POST: OtdelDetalis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,OtdelId,PositionsId,WorkPhone,Phone,Fax,Email,Lang")] OtdelDetali otdelDetali)
        {
            if (id != otdelDetali.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(otdelDetali);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OtdelDetaliExists(otdelDetali.Id))
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
            ViewData["OtdelId"] = new SelectList(_context.Otdel, "Id", "Desc", otdelDetali.OtdelId);
            ViewData["PositionsId"] = new SelectList(_context.Positions, "Id", "Desc", otdelDetali.PositionsId);
            return View(otdelDetali);
        }

        // GET: OtdelDetalis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var otdelDetali = await _context.OtdelDetali
                .Include(o => o.Otdel)
                .Include(o => o.Positions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (otdelDetali == null)
            {
                return NotFound();
            }

            return View(otdelDetali);
        }

        // POST: OtdelDetalis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var otdelDetali = await _context.OtdelDetali.FindAsync(id);
            _context.OtdelDetali.Remove(otdelDetali);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OtdelDetaliExists(int id)
        {
            return _context.OtdelDetali.Any(e => e.Id == id);
        }
    }
}
