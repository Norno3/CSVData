using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSVData.Models
{
    public class Car
    {
        public Guid ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime SellDate { get; set; }
    }
}
