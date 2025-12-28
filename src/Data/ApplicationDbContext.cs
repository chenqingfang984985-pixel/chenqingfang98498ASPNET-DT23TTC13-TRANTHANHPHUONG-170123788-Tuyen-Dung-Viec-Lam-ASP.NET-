using Microsoft.EntityFrameworkCore;
using TuyenDungViecLam.Models;

namespace TuyenDungViecLam.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<phuongtran84> phuongtran84 { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Job configuration
            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Requirements).HasConversion(
                    v => string.Join(';', v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());
                entity.Property(e => e.Benefits).HasConversion(
                    v => string.Join(';', v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());
            });

            // Employer configuration
            modelBuilder.Entity<Employer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Jobs).HasConversion(
                    v => string.Join(';', v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());
            });

            // Candidate configuration
            modelBuilder.Entity<phuongtran84>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Skills).HasConversion(
                    v => string.Join(';', v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList());
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}