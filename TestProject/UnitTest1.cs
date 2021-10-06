using DataAccess.LocalRepo;
using Domain.DomainModels;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        StudentRepo repo = new StudentRepo();

        // US_01 Als fysiotherapeut wil ik een nieuwe patiënt in kunnen voeren in het systeem, zodat ik deze
        // patiënt ook kan gaan behandelen.

        [Fact]
        public void ShouldRegisterAPersonInRepoWhenRegisterFormIsCorrect()
        {
            // Arrangea
            var sut = new Student
                ("FirstName", "LastName", "Emailadres", 012345678, DateTime.Now, "Male", 12345678);
            // Act
            repo.Create(sut);
            //Assert
            Assert.Equal(sut, repo.Get(12345678));
        }
    }
}
