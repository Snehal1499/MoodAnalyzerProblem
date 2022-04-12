using System;
namespace Mood_Analyzer_problem
{
    public enum Mood
    {
        Happy,
        sad
    }

    public class MoodAnalyzer
    {
        public string CheckMood(string msg)
        {
            //msg : Snehal is Happy for her new Mobile
            //msg : Snehal is Sad after getting Fail In Exam
            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }



}
