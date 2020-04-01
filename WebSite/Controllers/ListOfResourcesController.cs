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
    public class ListOfResourcesController : Controller
    {
        private readonly ApplicationContext _context;

        public ListOfResourcesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: ListOfResources
        public async Task<IActionResult> Index()
        {
            return View(await _context.ListOfResources.ToListAsync());
        }

        // GET: ListOfResources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfResources = await _context.ListOfResources
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfResources == null)
            {
                return NotFound();
            }

            return View(listOfResources);
        }

        // GET: ListOfResources/Create
        public IActionResult Create(int id)
        {
            ListOfResources lr = new ListOfResources();
            lr.Lang = id;
            return View(lr);
        }

        // POST: ListOfResources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Links,Desc,Lang")] ListOfResources listOfResources)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listOfResources);
                await _context.SaveChangesAsync();
                listOfResources.Links = "<a href='" + listOfResources.Links + "' target='_blank'>";
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(listOfResources);
        }

        // GET: ListOfResources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfResources = await _context.ListOfResources.FindAsync(id);
            if (listOfResources == null)
            {
                return NotFound();
            }
            return View(listOfResources);
        }

        // POST: ListOfResources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Links,Desc,Lang")] ListOfResources listOfResources)
        {
            if (id != listOfResources.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listOfResources);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListOfResourcesExists(listOfResources.Id))
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
            return View(listOfResources);
        }

        // GET: ListOfResources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listOfResources = await _context.ListOfResources
                .FirstOrDefaultAsync(m => m.Id == id);
            if (listOfResources == null)
            {
                return NotFound();
            }

            return View(listOfResources);
        }

        // POST: ListOfResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listOfResources = await _context.ListOfResources.FindAsync(id);
            _context.ListOfResources.Remove(listOfResources);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListOfResourcesExists(int id)
        {
            return _context.ListOfResources.Any(e => e.Id == id);
        }
    }
}
