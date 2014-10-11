using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Links.Data.Entities
{
    public class CourseHandicap
    {
        [Key, ForeignKey("Course"), Column(Order=0)]
        public int CourseId { get; set; }

        [Key, Column(Order=1)]
        public byte Id { get; set; }

        public string Description { get; set; }

        public virtual Course Course { get; set; }
    }
}
