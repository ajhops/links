using System.Data.Entity;
using Links.Data.Entities;

namespace Links.Data
{
    public class LinksContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTee> CourseTees { get; set; }
        public DbSet<CourseHandicap> CourseHandicaps { get; set; }
        public DbSet<HolePar> HolePars { get; set; }
        public DbSet<HoleHandicap> HoleHandicaps { get; set; }
        public DbSet<HoleTee> HoleTees { get; set; }

        public LinksContext() : base("LinksConnection")
        {
            
        }
    }
}
