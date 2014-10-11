using Links.Data;
using Links.Data.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Links.Tests.Data.Entities
{
    [TestClass]
    public class CoursePersistenceTests : PersistenceTest<LinksContext>
    {
        [TestMethod]
        public void Should_Save_And_Load_Course()
        {
            var course = new Course()
            {
                Name = "Piney Point Golf Course"
            };

            Insert(course);
            Compare(SingleOrDefault<Course>(c => c.Id == course.Id), course);
        }
    }
}
