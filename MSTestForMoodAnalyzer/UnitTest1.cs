using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_problem;

namespace MSTestForMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        //Arrangement
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        [TestMethod]
        public void CheckMoodHappy()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Snehal is Happy for her new Mobile");
            //Assert
            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            //Action
            string res = moodAnalyzer.CheckMood("Snehal is Sad after getting Fail In Exam");
            //Assert
            Assert.AreEqual("sad", res);
        }
    }
}