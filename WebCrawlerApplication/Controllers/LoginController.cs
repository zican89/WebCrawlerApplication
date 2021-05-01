using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCrawlerApplication.Data;
using WebCrawlerApplication.Models;
using WebCrawlerApplication.Services;

namespace WebCrawlerApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Email,Password")] LoginModel loginModel)
        {
            if (await _userService.DoesUserExist(loginModel))
                return RedirectToAction("CrawlerStart", "Index");

            return View();
        }

        //// GET: Login/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var loginModel = await _context.LoginModel
        //        .FirstOrDefaultAsync(m => m.Email == id);
        //    if (loginModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(loginModel);
        //}

        //// GET: Login/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Login/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Email,Password")] LoginModel loginModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(loginModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(loginModel);
        //}

        //// GET: Login/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var loginModel = await _context.LoginModel.FindAsync(id);
        //    if (loginModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(loginModel);
        //}

        //// POST: Login/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Email,Password")] LoginModel loginModel)
        //{
        //    if (id != loginModel.Email)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(loginModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LoginModelExists(loginModel.Email))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(loginModel);
        //}

        //// GET: Login/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var loginModel = await _context.LoginModel
        //        .FirstOrDefaultAsync(m => m.Email == id);
        //    if (loginModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(loginModel);
        //}

        //// POST: Login/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var loginModel = await _context.LoginModel.FindAsync(id);
        //    _context.LoginModel.Remove(loginModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool LoginModelExists(string id)
        //{
        //    return _context.LoginModel.Any(e => e.Email == id);
        //}
    }
}
