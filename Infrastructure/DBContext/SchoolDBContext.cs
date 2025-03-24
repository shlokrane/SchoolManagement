using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.DBContext
{
    public class SchoolDBContextFactory : IDesignTimeDbContextFactory<SchoolDBContext>
    {
        public SchoolDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolDBContext>();
            optionsBuilder.UseSqlServer("Server=C1-5CD4397133-L; Database=school_mgmt_1; User Id=sa; Password=Northstarsr@1; Encrypt=False; TrustServerCertificate=True");

            return new SchoolDBContext(optionsBuilder.Options);
        }
    }
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Attendance> Attendance { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("SchoolConnectionString",
                    b => b.MigrationsAssembly("Infrastructure")); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Marks>()
                .HasOne(m => m.Student)
                .WithMany()
                .HasForeignKey(m => m.StudentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Marks>()
                .HasOne(m => m.Teacher)
                .WithMany()
                .HasForeignKey(m => m.TeacherID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Student)
                .WithMany()
                .HasForeignKey(a => a.StudentID)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Attendance>()
            //    .HasOne(a => a.Teacher) 
            //    .WithMany()
            //    .HasForeignKey(a => a.TeacherID)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
