using Xunit;

namespace ConRegistration.UnitTest
{
    public class ParticipantTests
    { /*
        [Fact]
        public void CreateParticipantTest()
        {
            // Arrange
            var expectedType = typeof(Participant);
            // Act
            var participant = new Participant();
            // Assert
            Assert.IsType(expectedType, participant);
        }

        [Fact]
        public void SetParticipantFirstName()
        {
            // Arrange
            var firstName = "Bruce";
            var participant = new Participant();
            // Act
            participant.FirstName = firstName;
            // Assert
            Assert.Equal(firstName, participant.FirstName);
        }

        [Fact]
        public void SetParticipantLastName()
        {
            // Arrange
            var lastName = "Wayne";
            var participant = new Participant();
            // Act
            participant.LastName = lastName;
            // Assert
            Assert.Equal(lastName, participant.LastName);
        }

        [Fact]
        public void SetParticipantEmail()
        {
            // Arrange
            var email = "totallynotbatman@gotham.gov";
            var participant = new Participant();
            // Act
            participant.Email = email;
            // Assert
            Assert.Equal(email, participant.Email);
        }

        [Fact]
        public void SetParticipantFavoriteSuperhero()
        {
            // Arrange
            var favoriteSuperhero = "Batman";
            var participant = new Participant();
            // Act
            participant.FavoriteSuperhero = favoriteSuperhero;
            // Assert
            Assert.Equal(favoriteSuperhero, participant.FavoriteSuperhero);
        } */

         //refactored from giving it a constructor
        [Fact]
        public void CreateParticipantTest()
        {
            // Arrange
            var firstName = "Bruce";
            var lastName = "Wayne";
            var email = "totallynotbatman@gotham.gov";
            var favoriteSuperhero = "Batman";

            // Act
            var participant = new Participant(firstName, lastName, email, favoriteSuperhero);

            // Assert
            Assert.Equal(firstName, participant.FirstName);
            Assert.Equal(lastName, participant.LastName);
            Assert.Equal(email, participant.Email);
            Assert.Equal(favoriteSuperhero, participant.FavoriteSuperhero);
        } 
    }
}