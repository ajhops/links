using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Links.Data.Entities
{
    public class HoleTee
    {
        [Key, ForeignKey("CourseTee"), Column(Order = 0)]
        public int CourseId { get; set; }

        [Key, ForeignKey("CourseTee"), Column(Order = 1)]
        public byte CourseTeeId { get; set; }

        [Key, Column(Order = 3)]
        public byte HoleNumber { get; set; }

        public short Distance { get; set; }

        public string DistanceUnit { get; set; }

        public virtual CourseTee CourseTee { get; set; }
    }
}
