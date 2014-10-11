using Links.Models.ViewModels;
using MediatR;

namespace Links.Models.Queries
{
    public class CourseQuery : IRequest<CourseViewModel>
    {
        public int Id { get; set; }
    }
}
