using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSVData.Models
{
    public class CSVDataContext : DbContext
    {
        public CSVDataContext (DbContextOptions<CSVDataContext> options)
            : base(options)
        {
        }

        public DbSet<CSVData.Models.Car> Car { get; set; }
    }
}
