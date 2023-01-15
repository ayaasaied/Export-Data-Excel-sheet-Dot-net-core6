using ExportandImportExcelSheet.Models;
using Microsoft.EntityFrameworkCore;
using ExportandImportExcelSheet.ViewModel;

namespace ExportandImportExcelSheet.Data
{
    public class SchooleDBPractice :DbContext
    {
        public SchooleDBPractice(DbContextOptions<SchooleDBPractice> options)
           : base(options)
        {

        }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Student>()
               .HasMany<Subject>(s => s.Subjects)
                .WithMany(s => s.Students);
                 //.Map(cs =>
                 //{
                 //    cs.MapLeftKey("StudentId");
                 //    cs.MapRightKey("SubjectId");
                 //    cs.ToTable("StudentSubject");
                 //});




        }

        public DbSet<Schoole> Schoole { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teasher> Teasher { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();


        }


        public DbSet<ExportandImportExcelSheet.ViewModel.StudentsDeatilesVM> StudentsDeatilesVM { get; set; }
    }

  

}




