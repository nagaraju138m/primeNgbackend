using Microsoft.EntityFrameworkCore;

namespace samplePractise.Modals
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options): base(options) { }

        public DbSet<Student> Students { get; set; }
    }

    
}
