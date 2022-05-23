using Microsoft.EntityFrameworkCore;

namespace DemoApp2405.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
    }
}
