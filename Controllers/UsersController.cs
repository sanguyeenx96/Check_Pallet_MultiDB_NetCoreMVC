using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging;
using pdc.Models.Lichsu;

namespace pdc.Controllers
{
    public class UsersController : Controller
    {
        private readonly CheckPalletPDCContext _context;

        public UsersController(CheckPalletPDCContext context)
        {
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> Caidat()
        {
            var list = await _context.AdminSettings.ToListAsync();
            return View(list);
        }

        [HttpPost, ActionName("thaydoi")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Caidat(int id, int value)
        {
            var setting = await _context.AdminSettings.FindAsync(id);
            if (value == 0)
            {
                setting.Value = 1;
            }
            if (value == 1)
            {
                setting.Value = 0;
            }
            _context.Update(setting);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Caidat));
        }

        public async Task<IActionResult> Index()
        {
            return _context.Users != null ?
                        View(await _context.Users.ToListAsync()) :
                        Problem("Entity set 'CheckPalletPDCContext.Users'  is null.");
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string hoten)
        {
            if (hoten == null || _context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Hoten == hoten);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                User themtaikhoan = new User();
                themtaikhoan.Manv = user.Manv.Trim();
                themtaikhoan.Password = user.Password.Trim();
                themtaikhoan.Hoten = user.Hoten.Trim();
                themtaikhoan.Bophan = user.Bophan;
                themtaikhoan.Calamviec = user.Calamviec;
                var checktrung = _context.Users.Where(x => user.Manv.Contains(x.Manv)).Count();
                if (checktrung > 0)
                {
                    StatusMessage = "Mã nhân viên đã có tài khoản!";
                }
                else
                {
                    _context.Add(themtaikhoan);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Manv,Password,Hoten,Bophan,Calamviec")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'CheckPalletPDCContext.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}