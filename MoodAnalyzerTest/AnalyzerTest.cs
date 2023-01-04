using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyserProblem;
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
        [Test]
        public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyzer analyser = new MoodAnalyzer(null);
            //Act
            string result = analyser.AnalyserMood();
            Assert.AreEqual(result, "Happy");
 
        }
        [Test]
        public void GivenMessage_WhenAnalyze_CustomizedNullException()

        {
            //Arrange
            string expected = "Mood should not be null";
            try
            {
                //Act
                MoodAnalyzer analyser = new MoodAnalyzer(null);
                analyser.AnalyserMood();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [Test]
        public void GivenMessage_WhenAnalyze_CustomizedEmptyException()

        {
            //Arrange
            string expected = "Mood should not be empty";
            try
            {
                //Act
                MoodAnalyzer analyser = new MoodAnalyzer(string.Empty);
                analyser.AnalyserMood();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// Using Reflection-UC4-Default Constructor
        /// </summary>
        [Test]
        public void Reflection_Return_Default_Constructor_No_Class_Found()
        {
            string expected = "Class not found";
            object obj = null;
            try
            {
                MoodAnalyserReflection moodAnalyser = new MoodAnalyserReflection();
                obj = moodAnalyser.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnaly", "MoodAnaly");

            }
            catch (CustomException actual)

            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        [Test]
        public void Reflection_Return_Default_Constructor_No_Constructor_Found()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                MoodAnalyserReflection moodAnalyser = new MoodAnalyserReflection();
                obj = moodAnalyser.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnaly");

            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }

    }
}

    




    

   