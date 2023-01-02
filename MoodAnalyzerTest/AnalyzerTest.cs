using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class Tests
    {


        [Test]
        public void GivenMessage_WhenAnalyze_ShouldReturnSadMood()
        {
            //Arrange
            string message = " Iam in Sad Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Sad");

        }
        [Test]
        public void GivenMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            //Arrange
            string message = " Iam in Any Mood";
            //Act
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}