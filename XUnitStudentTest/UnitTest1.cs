using System;
using System.Collections.Generic;
using Core.ApplicationService.Services;
using Core.DomainService;
using Core.entity;
using Infrastructure;
using Moq;
using Xunit;

namespace XUnitStudentTest
{
    public class UnitTest1
    {
        private Mock<IStudentRepository> mockRepository;
        private Mock<ITeamRepository> mockTeamRepo;

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

        [Fact]
        public void DeleteStudentFromTeamTest()
        {
            //Arrange
            mockTeamRepo = new Mock<ITeamRepository>();
            TeamService teamService = new TeamService(mockTeamRepo.Object);

            Team team = new Team()
            {
                id = 1,
                TeamList = new List<Student>()
            };

            Student student1 = new Student()
            {
                ID = 1,
            };
            FakeDB.teams.Add(student1);
            team.TeamList.Add(student1);

            Student student2 = new Student()
            {
                ID = 2,
            };
            FakeDB.teams.Add(student2);
            team.TeamList.Add(student2);

            Student student3 = new Student()
            {
                ID = 3,
            };
            FakeDB.teams.Add(student3);
            team.TeamList.Add(student3);

            Student student4 = new Student()
            {
                ID = 4,
            };
            FakeDB.teams.Add(student4);
            team.TeamList.Add(student4);

            //Act
            teamService.RemoveStudentFromTeam(team, student3);

            //Assert
            List<Student> result = new List<Student>() {student1, student2, student4};

            Assert.Equal(result, FakeDB.teams);
        }
    }
}
