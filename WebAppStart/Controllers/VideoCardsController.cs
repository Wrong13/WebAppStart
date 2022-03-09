#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppStart.Data;
using WebAppStart.Models;

namespace WebAppStart.Controllers
{
    public class VideoCardsController : Controller
    {
        private readonly WebAppStartContext _context;

        public VideoCardsController(WebAppStartContext context)
        {
            _context = context;
        }

        // GET: VideoCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.VideoCard.ToListAsync());
        }

        // GET: VideoCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoCard = await _context.VideoCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoCard == null)
            {
                return NotFound();
            }

            return View(videoCard);
        }

        // GET: VideoCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameCard,Manufacturer,Series,Model,ReleaseDate,Price")] VideoCard videoCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoCard);
        }

        // GET: VideoCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoCard = await _context.VideoCard.FindAsync(id);
            if (videoCard == null)
            {
                return NotFound();
            }
            return View(videoCard);
        }

        // POST: VideoCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameCard,Manufacturer,Series,Model,ReleaseDate,Price")] VideoCard videoCard)
        {
            if (id != videoCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoCardExists(videoCard.Id))
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
            return View(videoCard);
        }

        // GET: VideoCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoCard = await _context.VideoCard
                .FirstOrDefaultAsync(m => m.Id == id);
            if (videoCard == null)
            {
                return NotFound();
            }

            return View(videoCard);
        }

        // POST: VideoCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoCard = await _context.VideoCard.FindAsync(id);
            _context.VideoCard.Remove(videoCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoCardExists(int id)
        {
            return _context.VideoCard.Any(e => e.Id == id);
        }
    }
}
