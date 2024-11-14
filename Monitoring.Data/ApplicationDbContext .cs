using System;
using Microsoft.EntityFrameworkCore;
using Monitoring.Domain.Models;
using System.Reflection;

namespace Monitoring.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Sensor> Sensors => Set<Sensor>();
        public DbSet<Notification> Notifications => Set<Notification>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var assembly = Assembly.GetExecutingAssembly();
            modelBuilder.ApplyConfigurationsFromAssembly(assembly); 
        }
    }
}
