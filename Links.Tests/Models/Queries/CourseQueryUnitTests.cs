using Links.Data;
using Links.Data.Entities;
using Links.Models.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;

namespace Links.Tests.Models.Queries
{
    [TestClass]
    public class CourseQueryUnitTests : PersistenceTest<LinksContext>
    {
        [TestMethod]
        public void ShouldFindCourseById()
        {
            var courseEntity = new Course {Name = "Cinco Ranch Golf Course"};
            Insert(courseEntity);

            var query = new CourseQuery() {Id = courseEntity.Id};
            var viewModel = Mediator.Send(query);

            viewModel.Id.ShouldEqual(courseEntity.Id);
            viewModel.Name.ShouldEqual(courseEntity.Name);
        }
    }
}
