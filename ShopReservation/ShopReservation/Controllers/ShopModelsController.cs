using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopReservation.Context;
using ShopReservation.Models;

namespace ShopReservation
{
    public class ShopModelsController : Controller
    {
        private readonly MvcShopContext _context;

        public ShopModelsController(MvcShopContext context)
        {
            _context = context;
        }

        // GET: ShopModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shop.ToListAsync());
        }

        // GET: ShopModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopModel = await _context.Shop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopModel == null)
            {
                return NotFound();
            }

            return View(shopModel);
        }

        // GET: ShopModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShopModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Time,Reserved,Spots")] ShopModel shopModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shopModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shopModel);
        }

        public async Task<IActionResult> Add(ShopModel shop)
        {
            if (shop == null)
            {
                return NotFound();
            }

            var shopmodel = await _context.Shop.FindAsync(shop.Id);
            if (shopmodel == null)
            {
                return NotFound();
            }

            if (shop.Spots != shop.Reserved)
            {
                shop.Reserved++;
                _context.Update(shop);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "ShopModels");
            }

            return RedirectToAction("Index", "ShopModels");

        }

        // GET: ShopModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopModel = await _context.Shop.FindAsync(id);
            if (shopModel == null)
            {
                return NotFound();
            }
            //shopModel.Reserved++;
            return View(shopModel);
        }


        // POST: ShopModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Time,Reserved,Spots")] ShopModel shopModel)
        {
            if (id != shopModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    shopModel.Reserved++;
                    _context.Update(shopModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopModelExists(shopModel.Id))
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
            return View(shopModel);
        }

        // GET: ShopModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopModel = await _context.Shop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopModel == null)
            {
                return NotFound();
            }

            return View(shopModel);
        }

        // POST: ShopModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shopModel = await _context.Shop.FindAsync(id);
            _context.Shop.Remove(shopModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopModelExists(int id)
        {
            return _context.Shop.Any(e => e.Id == id);
        }
    }
}
