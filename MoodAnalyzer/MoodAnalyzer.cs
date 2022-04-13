using System;
namespace Mood_Analyzer_problem
{
    public enum Mood
    {
        Happy,
        sad,
    }

    public class MoodAnalyzer
    {
        public string message;

        public MoodAnalyzer()
        {
            this.message = "";
        }

        public MoodAnalyzer(string msg)
        {
            this.message = msg;
        }
        public string CheckMood(string msg)
        {
            //msg : Snehal is Happy for her new laptop
            //msg : Snehal is Sad after getting Fail In exam
            if (msg == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }
            else if (msg.Length < 1)
            {
                throw new CustomMoodAnalyzerException("provided message is empty", ExceptionType.EMPTY_TYPE);
            }

            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            return null;
        }
    }
}