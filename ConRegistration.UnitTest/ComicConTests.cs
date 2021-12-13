using Xunit;

namespace ComicConRegistration.UnitTest
{
    public class ComicConTests
    {
        [Fact]
        public void CreateComicConTest()
        {
        //Arrange
        var expectedType = typeof(ComicCon);
        //Act
        var con = new ComicCon();
            //Assert
            Assert.IsType(expectedType, con);
        }

        [Fact]
        public void AddParticipantToComicCon()
        {
            //Arrange
            var expectedNumberOfParticipants = 1;
            var comicCon = new ComicCon();

            var firstName = "Peter";
            var lastName = "Parker";
            var email = "theamazingspidi@ny.com";
            var favoriteSuperhero = "Spiderman";
            var favoriteQuote = "With great power comes great responsibility";
            var participant = new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);

            //Act
            comicCon.AddParticipant(participant);

            //Assert
            Assert.Equal(expectedNumberOfParticipants, comicCon.Participants.Count);
        }
    }

}