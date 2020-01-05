using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuestBook.Data;
using GuestBook.Models;



namespace GuestBook.Controllers
{
    public class GuestController : Controller
    {

        private readonly GuestbookContext _context;

        public GuestController(GuestbookContext context)
        {
            _context = context;
        }

        //
        // GET: /Guestlist/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /read/
        public async Task<IActionResult> read()
        {
            return View(await _context.Guest.ToListAsync());
        }

        // //
        // // GET: /sign/ 
        // public IActionResult ()
        // {
        //     return View();
        // }

        //
        // POST: /sign/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Name,SignedDate")] Guest guest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guest);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return View(guest);
            }
            return View(guest);
        }


    }
}