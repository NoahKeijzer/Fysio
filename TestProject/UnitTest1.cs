using Fysio.Models;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        // US_01 Als fysiotherapeut wil ik een nieuwe patiënt in kunnen voeren in het systeem, zodat ik deze
        // patiënt ook kan gaan behandelen.
        
        [Fact]
        public void ShouldRegisterAPersonInRepoWhenRegisterFormIsCorrect()
        {
            // Arrange
            var sut = new Person
            {
                Name = "Name",
                Emailadres = "Emailadres",
                Telefoonnummer = 012345678,
                Geboortedatum = DateTime.Now,
                Geslacht = Geslacht.Man,
           };
            // Act
            // Implement method that validates the data and stores in repo


            //Assert

        }
    }
}
