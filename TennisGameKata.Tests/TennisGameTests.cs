using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameKata.Tests
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void LoveAll()
        {
            // arrange
            const string expected = "Love All";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 0;
            sut.AwayScore = 0;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LoveFifteen()
        {
            // arrange
            const string expected = "Love Fifteen";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 0;
            sut.AwayScore = 1;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FifteenAll()
        {
            // arrange
            const string expected = "Fifteen All";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 1;
            sut.AwayScore = 1;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThirtyFifteen()
        {
            // arrange
            const string expected = "Thirty Fifteen";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 2;
            sut.AwayScore = 1;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void FortyFifteen()
        {
            // arrange
            const string expected = "Forty Fifteen";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 3;
            sut.AwayScore = 1;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Deuce_When_3_3()
        {
            // arrange
            const string expected = "Deuce";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 3;
            sut.AwayScore = 3;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Home_Advantage()
        {
            // arrange
            const string expected = "John Adv";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 4;
            sut.AwayScore = 3;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Deuce_When_4_4()
        {
            // arrange
            const string expected = "Deuce";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 4;
            sut.AwayScore = 4;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Away_Advantage()
        {
            // arrange
            const string expected = "Tom Adv";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 3;
            sut.AwayScore = 4;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Home_Win_5_3()
        {
            // arrange
            const string expected = "John Win";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 5;
            sut.AwayScore = 3;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Home_Win_4_0()
        {
            // arrange
            const string expected = "John Win";
            var sut = new TennisGame();
            
            // act
            sut.HomeScore = 4;
            sut.AwayScore = 0;
            var actual = sut.Score();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
    

    
}