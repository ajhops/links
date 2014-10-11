using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Links.Data.Entities
{
    public class HolePar
    {
        [Key, ForeignKey("Course"), Column(Order = 0)]
        public int CourseId { get; set; }

        [Key, Column(Order = 1)]
        public byte HoleNumber { get; set; }
        
        [Required]
        public byte Par { get; set; }

        public virtual Course Course { get; set; }
    }
}
