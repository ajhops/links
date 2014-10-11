using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Links.Data.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CourseTee> CourseTees { get; set; }
        public virtual ICollection<HolePar> HolePars { get; set; }
        public virtual ICollection<CourseHandicap> CourseHandicaps { get; set; } 
    }
}
