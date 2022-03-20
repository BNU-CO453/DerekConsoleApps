using Microsoft.EntityFrameworkCore;
using ConsoleAppProject.App03;

namespace Web.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
