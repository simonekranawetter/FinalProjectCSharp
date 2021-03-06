using System;
using Xunit;

namespace ComicConRegistration.UnitTest
{
    public class ComicConTests
    {
        /// <summary>
        /// Checks that the type of ComicCon is ComicCon
        /// </summary>
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

        /// <summary>
        /// Checks that the adding functionality works as intended
        /// </summary>
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

        /// <summary>
        /// Checks that the removing functionality works as intended
        /// </summary>
        [Fact]
        public void RemoveParticipantFromComicCon()
        {
            //Arrange
            var expectedNumberOfParticipants = 0;

            var firstName = "Miles";
            var lastName = "Morales";
            var email = "intothespiderverse@ny.com";
            var favoriteSuperhero = "Spiderman";
            var favoriteQuote = "It's a leap of faith. That's all it is, Miles. A leap of faith.";
            var participant = new Participant(firstName, lastName, email, favoriteSuperhero, favoriteQuote);

            var comicCon = new ComicCon();
            comicCon.AddParticipant(participant);

            //Act
            comicCon.Remove(0);

            //Assert
            Assert.Equal(expectedNumberOfParticipants, comicCon.Participants.Count);
        }

        /// <summary>
        /// Checks that the discount code has the right format
        /// </summary>
        [Fact]
        public void CreateDiscountCodeForParticipant()
        {
            //Arrange
            var comicCon = new ComicCon();
            //Act
            var result = ComicCon.CreateDiscountCode().ToString();

            //Assert
            Assert.True(Guid.TryParse(result, out _));
        }
    }

}