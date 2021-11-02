using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCC.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options)
            : base(options)
        {
        }
        public DbSet<Payment> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, UserId = 1, Date = new DateTime(2021, 10, 1, 5, 10, 20), Amount = 20.00m, Status = "Closed"},
                new Payment { Id = 2, UserId = 1, Date = new DateTime(2021, 10, 2, 5, 10, 20), Amount = 30.00m, Status = "Open" },
                new Payment { Id = 3, UserId = 1, Date = new DateTime(2021, 10, 3, 5, 10, 20), Amount = 40.00m, Status = "Closed" },
                new Payment { Id = 13, UserId = 1, Date = new DateTime(2021, 10, 2, 5, 8, 20), Amount = 70.00m, Status = "Closed" },


                new Payment { Id = 4, UserId = 2, Date = new DateTime(2021, 10, 5, 5, 10, 20), Amount = 25.00m, Status = "Closed" },
                new Payment { Id = 5, UserId = 2, Date = new DateTime(2021, 10, 6, 5, 10, 20), Amount = 35.00m, Status = "Open" },
                new Payment { Id = 6, UserId = 2, Date = new DateTime(2021, 10, 7, 5, 10, 20), Amount = 15.00m, Status = "Closed" },
                new Payment { Id = 7, UserId = 2, Date = new DateTime(2021, 10, 8, 5, 10, 20), Amount = 32.00m, Status = "Closed" },

                new Payment { Id = 8, UserId = 3, Date = new DateTime(2021, 10, 9, 5, 10, 20), Amount = 90.00m, Status = "Closed" },
                new Payment { Id = 9, UserId = 3, Date = new DateTime(2021, 10, 10, 5, 10, 20), Amount = 20.00m, Status = "Open" },
                new Payment { Id = 10, UserId = 3, Date = new DateTime(2021, 10, 11, 5, 10, 20), Amount = 60.00m, Status = "Closed" },
                new Payment { Id = 11, UserId = 3, Date = new DateTime(2021, 10, 12, 5, 10, 20), Amount = 80.00m, Status = "Open" },
                new Payment { Id = 12, UserId = 3, Date = new DateTime(2021, 10, 13, 5, 10, 20), Amount = 10.00m, Status = "Closed" }
            );
        }

    }
}
