using Microsoft.EntityFrameworkCore;
using College_Registration.Domain.Entities;

namespace College_Registration.Data
{
    public class Entities : DbContext
    {

        public DbSet<College> Colleges => Set<College>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Schedule> Schedules => Set<Schedule>();


        public Entities(DbContextOptions<Entities> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Section>()
             .HasKey(pc => new { pc.Id });

            modelBuilder.Entity<Section>()
                .HasOne(pc => pc.College)
                .WithMany(p => p.Sections)
                .HasForeignKey(pc => pc.CollegeId);

            modelBuilder.Entity<Section>()
                .HasOne(pc => pc.Course)
                .WithMany(c => c.Sections)
                .HasForeignKey(pc => pc.CourseId);
            //----------------------------------------------------
            modelBuilder.Entity<Schedule>()
             .HasKey(pc => new { pc.Id });

            modelBuilder.Entity<Schedule>()
                .HasOne(pc => pc.Subject)
                .WithMany(p => p.Schedules)
                .HasForeignKey(pc => pc.SubjectId);

            modelBuilder.Entity<Schedule>()
                .HasOne(pc => pc.Section)
                .WithMany(c => c.Schedules)
                .HasForeignKey(pc => pc.SectionId);
            //----------------------------------------------------
            modelBuilder.Entity<Student>()
            .HasKey(pc => new { pc.Id });

            modelBuilder.Entity<Student>()
                .HasOne(pc => pc.Account)
                .WithMany(p => p.Students)
                .HasForeignKey(pc => pc.AccountId);

            modelBuilder.Entity<Student>()
                .HasOne(pc => pc.Section)
                .WithMany(c => c.Students)
                .HasForeignKey(pc => pc.SectionId);
            //----------------------------------------------------
            modelBuilder.Entity<Teacher>()
          .HasKey(pc => new { pc.Id });

            modelBuilder.Entity<Teacher>()
                .HasOne(pc => pc.Account)
                .WithMany(p => p.Teachers)
                .HasForeignKey(pc => pc.AccountId);

            modelBuilder.Entity<Teacher>()
                .HasOne(pc => pc.Schedule)
                .WithMany(c => c.Teachers)
                .HasForeignKey(pc => pc.ScheduleId);
            //----------------------------------------------------
            modelBuilder.Entity<College>().HasKey(p => p.Id);
            modelBuilder.Entity<Course>().HasKey(p => p.Id);
            modelBuilder.Entity<Subject>().HasKey(p => p.Id);
            modelBuilder.Entity<Account>().HasKey(p => p.Id);
            //----------------------------------------------------
            modelBuilder.Entity<Subject>(entity => {
                entity.HasIndex(e => e.Name).IsUnique();
            });
        }
    }
}
