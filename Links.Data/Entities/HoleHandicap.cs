using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Links.Data.Entities
{
    public class HoleHandicap
    {
        
        [Key, ForeignKey("CourseHandicap"), Column(Order = 0)]
        public int CourseId { get; set; }

        [Key, ForeignKey("CourseHandicap"), Column(Order = 1)]
        public byte CourseHandicapId { get; set; }

        [Key, Column(Order = 3)]
        public byte HoleNumber { get; set; }

        public virtual CourseHandicap CourseHandicap { get; set; }
    }
}
