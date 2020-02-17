using BusinessEntites.Contexts.Junction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessEntites.Contexts
{
    public class AlumnProgramContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=OOSU2Lab2AlumnAppen;Trusted_Connection=True; Integrated Security=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnActivity>().HasKey(t => new {t.ActivityID, t.UserID });

            modelBuilder.Entity<AlumnActivity>()
                .HasOne(pt => pt.Alumn)
                .WithMany(p => p.AlumnActivities)
                .HasForeignKey(pt => pt.UserID);

            modelBuilder.Entity<AlumnActivity>()
                .HasOne(pt => pt.Activity)
                .WithMany(p => p.AlumnActivities)
                .HasForeignKey(pt => pt.ActivityID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<FinishedEducation> FinishedEducations { get; set; }
        public DbSet<ListExport> ListExports { get; set; }
        public DbSet<OtherEducation> OtherEducations { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<AlumnActivity> AlumnActivities { get; set; }
    }
}
