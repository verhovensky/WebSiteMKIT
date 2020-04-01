using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class WorkListsController : Controller
    {
        private readonly ApplicationContext _context;

        public WorkListsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: WorkLists
        public async Task<IActionResult> Index(int id=0)
        {
            HttpContext.Session.SetString("ResumeId", id.ToString());
            var applicationContext = _context.WorkList.Where(x=>x.ResumeId==id).Include(w => w.Resume);
            return View(await applicationContext.ToListAsync());
        }

        // GET: WorkLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workList = await _context.WorkList
                .Include(w => w.Resume)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workList == null)
            {
                return NotFound();
            }

            return View(workList);
        }

        // GET: WorkLists/Create
        public IActionResult Create(int id)
        {
            //ViewData["ResumeId"] = new SelectList(_context.Resume, "Id", "BirthPlace");
            int resumeId = int.Parse(HttpContext.Session.GetString("ResumeId"));
            WorkList workList = new WorkList();
            workList.ResumeId = resumeId;
            workList.Lang = id;
            return View(workList);
        }

        // POST: WorkLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Termine,OrgName,Positions,ResumeId,Desc,Lang")] WorkList workList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ResumeId"] = new SelectList(_context.Resume, "Id", "BirthPlace", workList.ResumeId);
            return View(workList);
        }

        // GET: WorkLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workList = await _context.WorkList.FindAsync(id);
            if (workList == null)
            {
                return NotFound();
            }
            ViewData["ResumeId"] = new SelectList(_context.Resume, "Id", "BirthPlace", workList.ResumeId);
            return View(workList);
        }

        // POST: WorkLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Termine,OrgName,Positions,ResumeId,Desc,Lang")] WorkList workList)
        {
            if (id != workList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkListExists(workList.Id))
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
            ViewData["ResumeId"] = new SelectList(_context.Resume, "Id", "BirthPlace", workList.ResumeId);
            return View(workList);
        }

        // GET: WorkLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workList = await _context.WorkList
                .Include(w => w.Resume)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workList == null)
            {
                return NotFound();
            }

            return View(workList);
        }

        // POST: WorkLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workList = await _context.WorkList.FindAsync(id);
            _context.WorkList.Remove(workList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkListExists(int id)
        {
            return _context.WorkList.Any(e => e.Id == id);
        }
    }
}
