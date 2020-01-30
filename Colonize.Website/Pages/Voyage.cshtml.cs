using Colonize.Website.Data;
using Colonize.Website.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Colonize.Website
{
    public class VoyageModel : PageModel
    {
        private ApplicationDbContext context;

        public Voyage Voyage { get; set; }

        public VoyageModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(int id)
        {
            Voyage = context.Voyage
                .Include(x => x.Destination)
                .FirstOrDefault(x => x.Id == id);

            if (Voyage == null)
            {
                 return NotFound(); // HTTP 404
              //  return RedirectToPage("404");//
            }

            return Page();
        }
    }
}