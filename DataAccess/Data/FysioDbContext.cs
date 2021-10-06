using Domain.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class FysioDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Physiotherapist> Physiotherapists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Patiëntdossier> Patiëntdossiers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

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
            modelBuilder.Entity<Physiotherapist>().ToTable("Physiotherapist");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");

            //modelBuilder.Entity<Patiëntdossier>()
            //    .ToTable("Patiëntdossier")
            //    .HasKey(p => p.Patient);
                    

            //modelBuilder.Entity<Patient>()
            //    .HasOne(p => p.Patiëntdossier)
            //    .WithOne(pd => pd.Patient)
            //    .HasForeignKey<Patient>(p => p.Emailaddress)
            //    .IsRequired(false)
            //    .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
