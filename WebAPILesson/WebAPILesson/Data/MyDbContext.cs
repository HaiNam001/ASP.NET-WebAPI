using Microsoft.EntityFrameworkCore;

namespace WebAPILesson.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options) { }
        #region DbSet
        public  DbSet<Gears> Gears { get; set; }
        public DbSet<Course> Courses { get; set; }
        #endregion

    }
}
