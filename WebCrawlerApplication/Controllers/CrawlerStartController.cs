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
using WebCrawlerApplication.Services;

namespace WebCrawlerApplication.Controllers
{
    public class CrawlerStartController : Controller
    {
        private readonly ICrawlerSearchService _crawlerSearchService;

        public CrawlerStartController(ICrawlerSearchService crawlerSearchService)
        {
            _crawlerSearchService = crawlerSearchService;
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

        // GET: CrawlerStart/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CrawlerStart/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("URL,Expression,Depth")] CrawlerStartModel crawlerStartModel)
        {
            if (crawlerStartModel.Depth==null)
                crawlerStartModel.Depth = 1;

            if (ModelState.IsValid)
            {
                await _crawlerSearchService.CrawlerStart(crawlerStartModel);
                return RedirectToAction(nameof(Finish));
            }
            return View(crawlerStartModel);
        }

        public IActionResult Finish()
        {
            return View();
        }

    }
}
