using Microsoft.EntityFrameworkCore;
using System;

namespace PrescriptionApp.Models
{
    public class PrescriptionContext : DbContext
    {
        public PrescriptionContext(DbContextOptions<PrescriptionContext> options)
            : base(options)
        { }

        public DbSet<Prescription> Prescriptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prescription>().HasData(
                new Prescription
                {
                    PrescriptionId = 1,
                    MedicationName = "Atorvastatin",
                    FillStatus = "New",
                    Cost = 19.99,
                    RequestTime = new DateTime(2025, 9, 20, 9, 30, 0)
                }
            );
        }
    }
}
