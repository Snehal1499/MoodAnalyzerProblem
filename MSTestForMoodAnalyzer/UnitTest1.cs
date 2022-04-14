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
            string res = moodAnalyzer.CheckMood("Snehal is Sad after getting Fail in  Exam");
            //Assert
            Assert.AreEqual("sad", res);
        }
        [TestMethod]
        public void CheckNullException()
        {
            try
            {
                //Action
                string res = moodAnalyzer.CheckMood(null);
            }
            catch (CustomMoodAnalyzerException mEx)
            {
                //Assert
                Assert.AreEqual(ExceptionType.NULL_VALUE, mEx.extype);
                Assert.AreEqual("message is null", mEx.Message);

            }

        }
        [TestMethod]
        public void CheckEmptyExcep()
        {
            try
            {
                //Action
                string res = moodAnalyzer.CheckMood("");
            }
            catch (CustomMoodAnalyzerException mEx)
            {
                //Assert
                Assert.AreEqual(ExceptionType.EMPTY_TYPE, mEx.extype);
                Assert.AreEqual("provided message is empty", mEx.Message);

            }

        }
        [TestMethod]
        public void CheckObjWithDefaultConstructor()
        {
            FactoryMood<MoodAnalyzer> myFact = new FactoryMood<MoodAnalyzer>();
            var res_obj = myFact.GetObjectByDefaultConstructor();

            Assert.IsInstanceOfType(res_obj, typeof(MoodAnalyzer));
        }
        [TestMethod]
        public void InvokedMethod()
        {
            FactoryMood<MoodAnalyzer> myFact = new FactoryMood<MoodAnalyzer>();

            string result = myFact.InvokeMood("Snehal is Happy for her new Mobile");
            Assert.AreEqual("happy", result);
        }

    }
}