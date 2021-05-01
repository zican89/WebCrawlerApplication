using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCrawlerApplication.Data;
using WebCrawlerApplication.Models;

namespace WebCrawlerApplication.Controllers
{
    public class CrawlerStartController : Controller
    {
        private readonly WebCrawlerApplicationContext _context;

        public CrawlerStartController(WebCrawlerApplicationContext context)
        {
            _context = context;
        }

        // GET: CrawlerStart
        public async Task<IActionResult> Index()
        {
            return View();
        }

        //// GET: CrawlerStart/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var crawlerStartModel = await _context.CrawlerStartModel
        //        .FirstOrDefaultAsync(m => m.URL == id);
        //    if (crawlerStartModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(crawlerStartModel);
        //}

        //// GET: CrawlerStart/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CrawlerStart/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("URL,Expression,Depth")] CrawlerStartModel crawlerStartModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(crawlerStartModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(crawlerStartModel);
        //}

        //// GET: CrawlerStart/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var crawlerStartModel = await _context.CrawlerStartModel.FindAsync(id);
        //    if (crawlerStartModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(crawlerStartModel);
        //}

        //// POST: CrawlerStart/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("URL,Expression,Depth")] CrawlerStartModel crawlerStartModel)
        //{
        //    if (id != crawlerStartModel.URL)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(crawlerStartModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CrawlerStartModelExists(crawlerStartModel.URL))
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
        //    return View(crawlerStartModel);
        //}

        //// GET: CrawlerStart/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var crawlerStartModel = await _context.CrawlerStartModel
        //        .FirstOrDefaultAsync(m => m.URL == id);
        //    if (crawlerStartModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(crawlerStartModel);
        //}

        //// POST: CrawlerStart/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var crawlerStartModel = await _context.CrawlerStartModel.FindAsync(id);
        //    _context.CrawlerStartModel.Remove(crawlerStartModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CrawlerStartModelExists(string id)
        //{
        //    return _context.CrawlerStartModel.Any(e => e.URL == id);
        //}
    }
}
