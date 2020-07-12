using NUnit.Framework;
using TechnicalTestShared;

namespace TechnicalTestUnitTests
{
    [TestFixture]
    public class Tests
    {
        private SubtextMatchFinder _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SubtextMatchFinder();
        }

        [Test]
        public void FindSubtextWithinText()
        {
            //Arrange
            var text = "testing";
            var subtext = "test";
            const string expected = "0";

            //Act
            var characterPositions = _sut.FindMatches(text, subtext);

            //Assert
            Assert.AreEqual(expected, characterPositions.StringForDisplay);
        }

        [Test]
        public void AllowCaseInsensitiveMatching()
        {
            //Arrange
            var text = "Testing";
            var subtext = "test";
            const string expected = "0";

            //Act
            var characterPositions = _sut.FindMatches(text, subtext);

            //Assert
            Assert.AreEqual(expected, characterPositions.StringForDisplay);
        }

        [Test]
        public void AllowMultipleMatches()
        {
            //Arrange
            var text = "Abra Kadabra";
            var subtext = "abra";
            const string expected = "0,8";

            //Act
            var characterPositions = _sut.FindMatches(text, subtext);

            //Assert
            Assert.AreEqual(expected, characterPositions.StringForDisplay);
        }

        [Test]
        public void AllowSubtextWithSpaces()
        {
            //Arrange
            var text = "Test tester testing";
            var subtext = " test ";
            const string expected = "0,5,12";

            //Act
            var characterPositions = _sut.FindMatches(text, subtext);

            //Assert
            Assert.AreEqual(expected, characterPositions.StringForDisplay);
        }

        [Test]
        public void PreventSearchStringBeingBiggerThanMainString()
        {
            //Arrange
            var text = "test";
            var subtext = "testing";
            
            //Act
            var characterPositions = _sut.FindMatches(text, subtext);

            //Assert
            Assert.AreEqual(string.Empty, characterPositions.StringForDisplay);
        }
    }
}