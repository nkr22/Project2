using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<Tour> Tours { get; set; }
        public DbSet<Time> Times { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                    new Time { SlotId = 1, Month = "March", Day = 28, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 2, Month = "March", Day = 28, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 3, Month = "March", Day = 28, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 4, Month = "March", Day = 28, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 5, Month = "March", Day = 28, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 6, Month = "March", Day = 28, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 7, Month = "March", Day = 28, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 8, Month = "March", Day = 28, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 9, Month = "March", Day = 28, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 10, Month = "March", Day = 28, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 11, Month = "March", Day = 28, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 12, Month = "March", Day = 28, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 13, Month = "March", Day = 28, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 14, Month = "March", Day = 29, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 15, Month = "March", Day = 29, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 16, Month = "March", Day = 29, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 17, Month = "March", Day = 29, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 18, Month = "March", Day = 29, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 19, Month = "March", Day = 29, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 20, Month = "March", Day = 29, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 21, Month = "March", Day = 29, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 22, Month = "March", Day = 29, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 23, Month = "March", Day = 29, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 24, Month = "March", Day = 29, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 25, Month = "March", Day = 29, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 26, Month = "March", Day = 29, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 27, Month = "March", Day = 30, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 28, Month = "March", Day = 30, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 29, Month = "March", Day = 30, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 30, Month = "March", Day = 30, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 31, Month = "March", Day = 30, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 32, Month = "March", Day = 30, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 33, Month = "March", Day = 30, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 34, Month = "March", Day = 30, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 35, Month = "March", Day = 30, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 36, Month = "March", Day = 30, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 37, Month = "March", Day = 30, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 38, Month = "March", Day = 30, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 39, Month = "March", Day = 30, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 40, Month = "March", Day = 31, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 41, Month = "March", Day = 31, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 42, Month = "March", Day = 31, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 43, Month = "March", Day = 31, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 44, Month = "March", Day = 31, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 45, Month = "March", Day = 31, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 46, Month = "March", Day = 31, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 47, Month = "March", Day = 31, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 48, Month = "March", Day = 31, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 49, Month = "March", Day = 31, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 50, Month = "March", Day = 31, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 51, Month = "March", Day = 31, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 52, Month = "March", Day = 31, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 53, Month = "April", Day = 1, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 54, Month = "April", Day = 1, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 55, Month = "April", Day = 1, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 56, Month = "April", Day = 1, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 57, Month = "April", Day = 1, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 58, Month = "April", Day = 1, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 59, Month = "April", Day = 1, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 60, Month = "April", Day = 1, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 61, Month = "April", Day = 1, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 62, Month = "April", Day = 1, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 63, Month = "April", Day = 1, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 64, Month = "April", Day = 1, Hour = "7:00 PM", Filled = false },
                     new Time { SlotId = 65, Month = "April", Day = 1, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 66, Month = "April", Day = 2, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 67, Month = "April", Day = 2, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 68, Month = "April", Day = 2, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 69, Month = "April", Day = 2, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 70, Month = "April", Day = 2, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 71, Month = "April", Day = 2, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 72, Month = "April", Day = 2, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 73, Month = "April", Day = 2, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 74, Month = "April", Day = 2, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 75, Month = "April", Day = 2, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 76, Month = "April", Day = 2, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 77, Month = "April", Day = 2, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 78, Month = "April", Day = 2, Hour = "8:00 PM", Filled = false },
                    new Time { SlotId = 79, Month = "April", Day = 3, Hour = "8:00 AM", Filled = false },
                    new Time { SlotId = 80, Month = "April", Day = 3, Hour = "9:00 AM", Filled = false },
                    new Time { SlotId = 81, Month = "April", Day = 3, Hour = "10:00 AM", Filled = false },
                    new Time { SlotId = 82, Month = "April", Day = 3, Hour = "11:00 AM", Filled = false },
                    new Time { SlotId = 83, Month = "April", Day = 3, Hour = "12:00 PM", Filled = false },
                    new Time { SlotId = 84, Month = "April", Day = 3, Hour = "1:00 PM", Filled = false },
                    new Time { SlotId = 85, Month = "April", Day = 3, Hour = "2:00 PM", Filled = false },
                    new Time { SlotId = 86, Month = "April", Day = 3, Hour = "3:00 PM", Filled = false },
                    new Time { SlotId = 87, Month = "April", Day = 3, Hour = "4:00 PM", Filled = false },
                    new Time { SlotId = 88, Month = "April", Day = 3, Hour = "5:00 PM", Filled = false },
                    new Time { SlotId = 89, Month = "April", Day = 3, Hour = "6:00 PM", Filled = false },
                    new Time { SlotId = 90, Month = "April", Day = 3, Hour = "7:00 PM", Filled = false },
                    new Time { SlotId = 91, Month = "April", Day = 3, Hour = "8:00 PM", Filled = false }
                );

        }
    }
}



