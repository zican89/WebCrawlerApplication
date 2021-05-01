using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCrawlerApplication.Data;
using WebCrawlerApplication.Models;
using WebCrawlerApplication.Repositories;

namespace WebCrawlerApplication.Controllers
{
    public class ReportController : Controller
    {
        private readonly ICrawlerSearchRepository _crawlerSearchRepository;

        public ReportController(ICrawlerSearchRepository crawlerSearchRepository)
        {
            _crawlerSearchRepository = crawlerSearchRepository;
        }

        // GET: Report
        public async Task<IActionResult> Index()
        {
            return View();
        }

        //// GET: Report/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var reportModel = await _context.ReportModel
        //        .FirstOrDefaultAsync(m => m.Crawlername == id);
        //    if (reportModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(reportModel);
        //}

        //// GET: Report/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Report/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Crawlername,Date,URL,Expression,HitCount")] ReportModel reportModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(reportModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(reportModel);
        //}

        //// GET: Report/Edit/5
        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var reportModel = await _context.ReportModel.FindAsync(id);
        //    if (reportModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(reportModel);
        //}

        //// POST: Report/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Crawlername,Date,URL,Expression,HitCount")] ReportModel reportModel)
        //{
        //    if (id != reportModel.Crawlername)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(reportModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ReportModelExists(reportModel.Crawlername))
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
        //    return View(reportModel);
        //}

        //// GET: Report/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var reportModel = await _context.ReportModel
        //        .FirstOrDefaultAsync(m => m.Crawlername == id);
        //    if (reportModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(reportModel);
        //}

        //// POST: Report/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var reportModel = await _context.ReportModel.FindAsync(id);
        //    _context.ReportModel.Remove(reportModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ReportModelExists(string id)
        //{
        //    return _context.ReportModel.Any(e => e.Crawlername == id);
        //}
    }
}
