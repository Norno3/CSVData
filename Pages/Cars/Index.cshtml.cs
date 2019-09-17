using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CSVData.Models;

namespace CSVData.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly CSVData.Models.CSVDataContext _context;

        public IndexModel(CSVData.Models.CSVDataContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
