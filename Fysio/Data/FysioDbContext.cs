using Fysio.Models;
using Microsoft.EntityFrameworkCore;

namespace Fysio.Data
{
    public class FysioDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Fysiotherapeut> Fysiotherapeuts { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Patiëntdossier> Patiëntdossiers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Docent> Docenten { get; set; }

        public FysioDbContext(DbContextOptions<FysioDbContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Fysiotherapeut>().ToTable("Fysiotherapeut");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Docent>().ToTable("Docent");
        }
    }
}
