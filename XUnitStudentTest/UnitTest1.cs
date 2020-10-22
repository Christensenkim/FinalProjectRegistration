using System;
using Core.ApplicationService.Services;
using Core.DomainService;
using Core.entity;
using Moq;
using Xunit;

namespace XUnitStudentTest
{
    public class UnitTest1
    {
        private Mock<IStudentRepository> mockRepository;

        [Fact]
        public void Test1()
        {
            mockRepository = new Mock<IStudentRepository>();
        }

        [Theory]
        [InlineData(1, "Kim", "Danmarkvej 3", -3000, "Århus", "email@email.com")]
        [InlineData(-1, "Kim", "Danmarkvej 3", 3000, "Århus", "email@email.com")]
        [InlineData(1, null, "Danmarkvej 3", 3000, "Århus", "email@email.com")]
        [InlineData(1, "Kim", null, 3000, "Århus", "email@email.com")]
        [InlineData(1, "Kim", "Danmarkvej 3", 3000, null, "email@email.com")]
        public void AddNewStudentTest(int testID, string testName, string testAddress, int testZipCode, string testPostalDistrict, string testEmail)
        {
            mockRepository = new Mock<IStudentRepository>();
            StudentService studentService = new StudentService(mockRepository.Object);
            
            Student student = new Student()
            {
                ID = testID,
                Name = testName,
                Address = testAddress,
                ZipCode = testZipCode,
                PostalDistrict = testPostalDistrict,
                Email = testEmail
            };

            Assert.Throws<InvalidOperationException>(() => studentService.Add(student));
        }
    }
}
