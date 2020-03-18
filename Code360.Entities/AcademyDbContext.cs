using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Code360.Entities
{
    public class AcademyDbContext : IdentityDbContext
    {
        public AcademyDbContext(DbContextOptions<AcademyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Eminem Strict",
                    Email = "email@email.com"
                },
                new Student
                {
                    StudentId = Guid.NewGuid(),
                    FirstName = "Whatever Iwolomo",
                    Email = "olasehindeayodeji270@gmail.com"
                });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<PaymentHistory> paymentHistories { get; set; }
        public DbSet<Payment> payments { get; set; }

    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AcademyDbContext>
    {
        public AcademyDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../Code360.Web/appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AcademyDbContext>();
            var connectionString = configuration.GetConnectionString("conn");
            builder.UseSqlServer(connectionString);
            return new AcademyDbContext(builder.Options);
        }
    }
}
