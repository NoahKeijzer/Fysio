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
            var sut = new Student
                ("FirstName","LastName", "Emailadres", 012345678, DateTime.Now, Geslacht.Man, "Wachtwoord", 12345678);

            // Act
            // Implement method that validates the data and stores in repo


            //Assert
           
        }
    }
}
