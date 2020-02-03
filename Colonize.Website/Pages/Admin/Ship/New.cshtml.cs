using Colonize.Website.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Colonize.Website.Pages.Admin.Ship
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public NewModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        // HTTP GET /amin/ship/new
        public void OnGet()
        {

        }

        // HTTP POST /amin/ship/new
        // ...headers (metadata om anropet)
        // name=Haven&description=Lorem+ipsum&...
        public void OnPost(string name, string description, ushort capacity, string imageUrl)
        //public void OnPost(ShipDto shipDto)
        {
            var ship = new Entities.Ship(
                name,
                description,
                capacity,
                new Uri(imageUrl, UriKind.Absolute));

            context.Ship.Add(ship);

            context.SaveChanges();
        }
             public class ShipDto
        {
            public string Name { get; set; }
        }
    }
}