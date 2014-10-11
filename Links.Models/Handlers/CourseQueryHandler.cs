using Links.Data;
using Links.Models.Queries;
using Links.Models.ViewModels;
using MediatR;
using System.Linq;

namespace Links.Models.Handlers
{
    class CourseQueryHandler : IRequestHandler<CourseQuery, CourseViewModel>
    {
        public CourseViewModel Handle(CourseQuery message)
        {
            using (var context = new LinksContext())
            {
                var courseEntity = context.Courses.FirstOrDefault(c => c.Id == message.Id);
                if (courseEntity != null)
                {
                    var vm = new CourseViewModel()
                    {
                        Id = courseEntity.Id,
                        Name = courseEntity.Name
                    };
                    return vm;
                }
            }
            return null;
        }
    }
}
