using Colonize.Website.Data;
using Colonize.Website.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;



namespace Colonize.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext context;

        public IList<Voyage> VoyageList = new List<Voyage>();

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        // HTTP GET /
        // HTTP GET /index
        public void OnGet()
        {
            VoyageList = context.Voyage
                .Include(x => x.Destination)
                .ToList();
        }
    }
}



















