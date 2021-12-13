using Xunit;

namespace ComicConRegistration.UnitTest
{
    public class ParticipantTests
    {
        [Fact]
        public void CreateParticipantTest()
        {
            // Arrange
            var firstName = "Bruce";
            var lastName = "Wayne";
            var email = "totallynotbatman@gotham.gov";
            var favoriteSuperhero = "Batman";
            var favoriteQuote = "I am vengeance. I am the night. I am Batman.";

            // Act
            var participant = new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);

            // Assert
            Assert.Equal(firstName, participant.FirstName);
            Assert.Equal(lastName, participant.LastName);
            Assert.Equal(email, participant.Email);
            Assert.Equal(favoriteSuperhero, participant.FavoriteSuperhero);
            Assert.Equal(favoriteQuote, participant.FavoriteQuote);
        }
    }
}