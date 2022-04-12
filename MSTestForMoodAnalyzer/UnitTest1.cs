using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_problem;

namespace MSTestForMoodAnalyzer
{
    [TestClass]
    public class MSTestForMoodAnalyzer
    {
        [TestMethod]
        [TestCategory("negativescenario")]
        public void GivenNullShouldReturnHappy()
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(null);

            //ACT
            string actual = moodAnalyser.AnalyzeMood();

            //ASSERT
            Assert.AreEqual(excepted, actual);
        }
    }
}