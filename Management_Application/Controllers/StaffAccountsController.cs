using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ManagementApp.Data;

namespace ManagementApp.Web.Controllers
{
    public class StaffAccountsController : Controller
    {
        private readonly Db _context;

        public StaffAccountsController(Db context)
        {
            _context = context;
        }

        // GET: StaffAccounts
        public async Task<IActionResult> Index()
        {
            var db = _context.StaffAccounts.Include(s => s.Permissions);
            return View(await db.ToListAsync());
        }

        // GET: StaffAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffAccount = await _context.StaffAccounts
                .Include(s => s.Permissions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staffAccount == null)
            {
                return NotFound();
            }

            return View(staffAccount);
        }

        // GET: StaffAccounts/Create
        public IActionResult Create()
        {
            ViewData["PermissionID"] = new SelectList(_context.Permissions, "Id", "Name");
            return View();
        }

        // POST: StaffAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StaffID,Name,PermissionID")] StaffAccount staffAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PermissionID"] = new SelectList(_context.Permissions, "Id", "Name", staffAccount.PermissionID);
            return View(staffAccount);
        }

        // GET: StaffAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffAccount = await _context.StaffAccounts.FindAsync(id);
            if (staffAccount == null)
            {
                return NotFound();
            }
            ViewData["PermissionID"] = new SelectList(_context.Permissions, "Id", "Name", staffAccount.PermissionID);
            return View(staffAccount);
        }

        // POST: StaffAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StaffID,Name,PermissionID")] StaffAccount staffAccount)
        {
            if (id != staffAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffAccountExists(staffAccount.Id))
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
            ViewData["PermissionID"] = new SelectList(_context.Permissions, "Id", "Name", staffAccount.PermissionID);
            return View(staffAccount);
        }

        // GET: StaffAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffAccount = await _context.StaffAccounts
                .Include(s => s.Permissions)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (staffAccount == null)
            {
                return NotFound();
            }

            return View(staffAccount);
        }

        // POST: StaffAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffAccount = await _context.StaffAccounts.FindAsync(id);
            _context.StaffAccounts.Remove(staffAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffAccountExists(int id)
        {
            return _context.StaffAccounts.Any(e => e.Id == id);
        }
    }
}
