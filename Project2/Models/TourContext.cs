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

        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Time>().HasData(
                    new Time { SlotId = 1, Month = "March", Day = 28, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 2, Month = "March", Day = 28, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 3, Month = "March", Day = 28, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 4, Month = "March", Day = 28, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 5, Month = "March", Day = 28, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 6, Month = "March", Day = 28, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 7, Month = "March", Day = 28, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 8, Month = "March", Day = 28, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 9, Month = "March", Day = 28, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 10, Month = "March", Day = 28, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 11, Month = "March", Day = 28, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 12, Month = "March", Day = 28, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 13, Month = "March", Day = 29, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 14, Month = "March", Day = 29, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 15, Month = "March", Day = 29, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 16, Month = "March", Day = 29, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 17, Month = "March", Day = 29, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 18, Month = "March", Day = 29, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 19, Month = "March", Day = 29, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 20, Month = "March", Day = 29, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 21, Month = "March", Day = 29, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 22, Month = "March", Day = 29, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 23, Month = "March", Day = 29, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 24, Month = "March", Day = 29, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 25, Month = "March", Day = 30, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 26, Month = "March", Day = 30, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 27, Month = "March", Day = 30, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 28, Month = "March", Day = 30, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 29, Month = "March", Day = 30, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 30, Month = "March", Day = 30, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 31, Month = "March", Day = 30, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 32, Month = "March", Day = 30, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 33, Month = "March", Day = 30, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 34, Month = "March", Day = 30, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 35, Month = "March", Day = 30, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 36, Month = "March", Day = 30, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 37, Month = "March", Day = 31, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 38, Month = "March", Day = 31, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 39, Month = "March", Day = 31, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 40, Month = "March", Day = 31, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 41, Month = "March", Day = 31, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 42, Month = "March", Day = 31, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 43, Month = "March", Day = 31, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 44, Month = "March", Day = 31, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 45, Month = "March", Day = 31, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 46, Month = "March", Day = 31, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 47, Month = "March", Day = 31, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 48, Month = "March", Day = 31, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 49, Month = "April", Day = 1, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 50, Month = "April", Day = 1, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 51, Month = "April", Day = 1, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 52, Month = "April", Day = 1, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 53, Month = "April", Day = 1, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 54, Month = "April", Day = 1, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 55, Month = "April", Day = 1, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 56, Month = "April", Day = 1, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 57, Month = "April", Day = 1, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 58, Month = "April", Day = 1, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 59, Month = "April", Day = 1, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 60, Month = "April", Day = 1, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 61, Month = "April", Day = 2, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 62, Month = "April", Day = 2, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 63, Month = "April", Day = 2, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 64, Month = "April", Day = 2, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 65, Month = "April", Day = 2, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 66, Month = "April", Day = 2, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 67, Month = "April", Day = 2, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 68, Month = "April", Day = 2, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 69, Month = "April", Day = 2, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 70, Month = "April", Day = 2, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 71, Month = "April", Day = 2, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 72, Month = "April", Day = 2, Times = "7:00 PM", Filled = false },
                    new Time { SlotId = 73, Month = "April", Day = 3, Times = "8:00 AM", Filled = false },
                    new Time { SlotId = 74, Month = "April", Day = 3, Times = "9:00 AM", Filled = false },
                    new Time { SlotId = 75, Month = "April", Day = 3, Times = "10:00 AM", Filled = false },
                    new Time { SlotId = 76, Month = "April", Day = 3, Times = "11:00 AM", Filled = false },
                    new Time { SlotId = 77, Month = "April", Day = 3, Times = "12:00 PM", Filled = false },
                    new Time { SlotId = 78, Month = "April", Day = 3, Times = "1:00 PM", Filled = false },
                    new Time { SlotId = 79, Month = "April", Day = 3, Times = "2:00 PM", Filled = false },
                    new Time { SlotId = 80, Month = "April", Day = 3, Times = "3:00 PM", Filled = false },
                    new Time { SlotId = 81, Month = "April", Day = 3, Times = "4:00 PM", Filled = false },
                    new Time { SlotId = 82, Month = "April", Day = 3, Times = "5:00 PM", Filled = false },
                    new Time { SlotId = 83, Month = "April", Day = 3, Times = "6:00 PM", Filled = false },
                    new Time { SlotId = 84, Month = "April", Day = 3, Times = "7:00 PM", Filled = false }
                );

        }
    }
}



