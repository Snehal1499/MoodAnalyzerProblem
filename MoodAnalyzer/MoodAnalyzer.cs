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
            message = msg;
            //msg : Snehal is Happy for her new Mobile
            //msg : Snehal is Sad after getting Fail in  Exam
            if (message == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }
            else if (message.Length < 1)
            {
                throw new CustomMoodAnalyzerException("provided message is empty", ExceptionType.EMPTY_TYPE);
            }

            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            return null;
        }

        public string CheckMoodTwo()
        {
            if (message == null)
            {
                throw new CustomMoodAnalyzerException("message is null", ExceptionType.NULL_VALUE);
            }
            else if (message.Length < 1)
            {
                throw new CustomMoodAnalyzerException("provided message is empty", ExceptionType.EMPTY_TYPE);
            }

            if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            return null;
        }
    }
}