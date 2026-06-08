using CampusCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CampusCore.Infrastructure.Data
{
    public class CampusCoreDbContext : DbContext
    {
        public CampusCoreDbContext(DbContextOptions<CampusCoreDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Fee> Fees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Result>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Results)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Result>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Results)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Fee>()
            .Property(f => f.TotalAmount)
            .HasPrecision(18, 2);

            modelBuilder.Entity<Fee>()
                .Property(f => f.PaidAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Fee>()
                .Property(f => f.PendingAmount)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Result>()
                .Property(r => r.MarksObtained)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Result>()
                .Property(r => r.MaximumMarks)
                .HasPrecision(18, 2);
        }
    }
}
