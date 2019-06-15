using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodDonationApplication.Models;

namespace BloodDonationApplication.Controllers
{
    public class KrvnaGrupaController : Controller
    {
        private readonly BDAContext _context;

        public KrvnaGrupaController(BDAContext context)
        {
            _context = context;
        }

        // GET: KrvnaGrupa
        public async Task<IActionResult> Index()
        {
            return View(await _context.KrvnaGrupa.ToListAsync());
        }

        // GET: KrvnaGrupa/Details/5
        public async Task<IActionResult> Details(int? id, int? sifra)
        {
            if (id == null)
            {
                return NotFound();
            }

            var krvnaGrupa = await _context.KrvnaGrupa
                .FirstOrDefaultAsync(m => m.KrvnaGrupaId == id);

            if (sifra == 57) return RedirectToAction("IndexPoKrvnojGrupi", "Donor", new { krvnaGrupaNaziv = krvnaGrupa.Naziv });

            if (krvnaGrupa == null)
            {
                return NotFound();
            }

            return View(krvnaGrupa);
        }

        // GET: KrvnaGrupa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KrvnaGrupa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KrvnaGrupaId,Naziv")] KrvnaGrupa krvnaGrupa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(krvnaGrupa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(krvnaGrupa);
        }

        // GET: KrvnaGrupa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var krvnaGrupa = await _context.KrvnaGrupa.FindAsync(id);
            if (krvnaGrupa == null)
            {
                return NotFound();
            }
            return View(krvnaGrupa);
        }

        // POST: KrvnaGrupa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KrvnaGrupaId,Naziv")] KrvnaGrupa krvnaGrupa)
        {
            if (id != krvnaGrupa.KrvnaGrupaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(krvnaGrupa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KrvnaGrupaExists(krvnaGrupa.KrvnaGrupaId))
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
            return View(krvnaGrupa);
        }

        // GET: KrvnaGrupa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var krvnaGrupa = await _context.KrvnaGrupa
                .FirstOrDefaultAsync(m => m.KrvnaGrupaId == id);
            if (krvnaGrupa == null)
            {
                return NotFound();
            }

            return View(krvnaGrupa);
        }

        // POST: KrvnaGrupa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var krvnaGrupa = await _context.KrvnaGrupa.FindAsync(id);
            _context.KrvnaGrupa.Remove(krvnaGrupa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KrvnaGrupaExists(int id)
        {
            return _context.KrvnaGrupa.Any(e => e.KrvnaGrupaId == id);
        }
    }
}
