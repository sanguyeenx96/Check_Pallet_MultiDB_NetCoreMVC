using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pdc.Helpers;
using pdc.Models.Lichsu;

namespace pdc.Controllers
{
    public class LichsusController : Controller
    {
        private readonly CheckPalletPDCContext _context;

        public LichsusController(CheckPalletPDCContext context)
        {
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }

        // GET: Lichsus
        public async Task<IActionResult> Index(string ngaybatdau, string ngayketthuc, string mapallet, string mabody)
        {
            if (!String.IsNullOrEmpty(ngaybatdau) && !String.IsNullOrEmpty(ngayketthuc)) // kiểm tra chuỗi tìm kiếm có rỗng/null hay không
            {
                DateTime start = DateTime.Parse(ngaybatdau);
                start = start.ChangeTime(1, 0, 10);
                DateTime end = DateTime.Parse(ngayketthuc);
                end = end.ChangeTime(23, 0, 10);
                var list = await _context.Lichsus
                               .Where(x => x.Ngaygio >= start && x.Ngaygio <= end)
                               .ToListAsync();
                TempData["ngaybatdau"] = start.ToString("yyyy/MM/dd");
                TempData["ngayketthuc"] = end.ToString("yyyy/MM/dd");
                return View(list);
            }
            if (!String.IsNullOrEmpty(mapallet) && String.IsNullOrEmpty(mabody))
            {
                string ma = mapallet.Trim();
                var list = await _context.Lichsus
                               .Where(x => x.Mapallet == ma)
                               .ToListAsync();
                return View(list);
            }
            if (!String.IsNullOrEmpty(mabody) && String.IsNullOrEmpty(mapallet))
            {
                string ma = mabody.Trim();
                var list = await _context.Lichsus
                               .Where(x => x.Mabodycheck == ma)
                               .ToListAsync();
                return View(list);
            }
            if (!String.IsNullOrEmpty(mapallet) && !String.IsNullOrEmpty(mabody))
            {
                string mapl = mapallet.Trim();
                string mabd = mabody.Trim();
                var list = await _context.Lichsus
                               .Where(x => (x.Mapallet == mapl && x.Mabodycheck == mabd))
                               .ToListAsync();
                return View(list);
            }
            return View();
        }

        public async Task<IActionResult> Thongketrongngay(int? id)
        {
            DateTime today = DateTime.Now;
            today = today.ChangeTime(1, 0, 10);
            var list = await _context.Lichsus.Where(x => x.Ngaygio >= today).ToListAsync();
            return View(list);
        }

        // GET: Lichsus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lichsus == null)
            {
                return NotFound();
            }

            var lichsu = await _context.Lichsus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lichsu == null)
            {
                return NotFound();
            }

            return View(lichsu);
        }

        // GET: Lichsus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lichsus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,Thitruong,Mapallet,Mabodydb,Mabodycheck,Ngaygio,Nguoithaotac")] Lichsu lichsu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lichsu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lichsu);
        }

        // GET: Lichsus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lichsus == null)
            {
                return NotFound();
            }

            var lichsu = await _context.Lichsus.FindAsync(id);
            if (lichsu == null)
            {
                return NotFound();
            }
            return View(lichsu);
        }

        // POST: Lichsus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,Thitruong,Mapallet,Mabodydb,Mabodycheck,Ngaygio,Nguoithaotac")] Lichsu lichsu)
        {
            if (id != lichsu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lichsu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichsuExists(lichsu.Id))
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
            return View(lichsu);
        }

        // GET: Lichsus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lichsus == null)
            {
                return NotFound();
            }

            var lichsu = await _context.Lichsus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lichsu == null)
            {
                return NotFound();
            }

            return View(lichsu);
        }

        // POST: Lichsus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lichsus == null)
            {
                return Problem("Entity set 'CheckPalletPDCContext.Lichsus'  is null.");
            }
            var lichsu = await _context.Lichsus.FindAsync(id);
            if (lichsu != null)
            {
                _context.Lichsus.Remove(lichsu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichsuExists(int id)
        {
            return (_context.Lichsus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}