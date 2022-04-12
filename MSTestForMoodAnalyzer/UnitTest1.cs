using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_problem;

namespace MSTestForMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenNullShouldReturnCustomNullException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be null";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenEmptyShouldReturnCustomEmptyException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be empty";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(string.Empty);
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomMoodAnalyzerException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);
            }
        }

    }
}