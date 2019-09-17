using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSVData.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CSVDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CSVDataContext>>()))
            {
                // Look for any cars
                if (context.Car.Any())
                {
                    //return;   // DB has been seeded
                }

                IList<Car> cars = new List<Car>();
                string filePath = System.IO.Directory.GetCurrentDirectory() + @"\CSV\Cars.csv";
                //string filePath = @"C:\Users\user\source\repos\CSVData\CSV\Cars.csv";
                string csvData = System.IO.File.ReadAllText(filePath);

                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        cars.Add(new Car
                        {
                            ID = Guid.Parse(row.Split(',')[0]),
                            Make = row.Split(',')[1],
                            Model = row.Split(',')[2],
                            Year = Convert.ToInt32(row.Split(',')[3]),
                            Price = Convert.ToDouble(row.Split(',')[4]),
                            SellDate = Convert.ToDateTime(row.Split(',')[5])
                        });
                    }
                }

                context.Car.AddRange(cars);
                context.SaveChanges();
            }
        }
    }
}
