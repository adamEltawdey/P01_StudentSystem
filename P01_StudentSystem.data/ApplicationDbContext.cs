using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.P01_StudentSystem.data
{
    class ApplicationDbContext : DbContext
    {
    public DbSet<student> students { get; set; }
    public DbSet<homework> homeworks { get; set; }
    public DbSet<resources> resources { get; set; }
    public DbSet<course> courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=P01_StudentSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}

