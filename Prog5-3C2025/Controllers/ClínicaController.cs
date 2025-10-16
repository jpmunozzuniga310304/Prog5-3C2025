using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prog5_3C2025.Data;
using Prog5_3C2025.Models;

namespace Prog5_3C2025.Controllers
{
    public class ClínicaController : Controller
    {
        private readonly AppDbContext _context;

        public ClínicaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Clínica
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clínica.ToListAsync());
        }

        // GET: Clínica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clínica = await _context.Clínica
                .FirstOrDefaultAsync(m => m.IddelaClínica == id);
            if (clínica == null)
            {
                return NotFound();
            }

            return View(clínica);
        }

        // GET: Clínica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clínica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IddelaClínica,NombredelaClínica,ProvinciaId,CantonId,DistritoId,FechaCreacion,FechaModificacion")] Clínica clínica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clínica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clínica);
        }

        // GET: Clínica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clínica = await _context.Clínica.FindAsync(id);
            if (clínica == null)
            {
                return NotFound();
            }
            return View(clínica);
        }

        // POST: Clínica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IddelaClínica,NombredelaClínica,ProvinciaId,CantonId,DistritoId,FechaCreacion,FechaModificacion")] Clínica clínica)
        {
            if (id != clínica.IddelaClínica)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clínica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClínicaExists(clínica.IddelaClínica))
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
            return View(clínica);
        }

        // GET: Clínica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clínica = await _context.Clínica
                .FirstOrDefaultAsync(m => m.IddelaClínica == id);
            if (clínica == null)
            {
                return NotFound();
            }

            return View(clínica);
        }

        // POST: Clínica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clínica = await _context.Clínica.FindAsync(id);
            if (clínica != null)
            {
                _context.Clínica.Remove(clínica);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClínicaExists(int id)
        {
            return _context.Clínica.Any(e => e.IddelaClínica == id);
        }
    }
}
