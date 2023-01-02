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
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Sad");

        }
        [Test]
        public void GivenMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            //Arrange
            string message = " Iam in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(actual, "Happy");
        }
    }
}
   