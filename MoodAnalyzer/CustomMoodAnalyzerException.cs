using System;
namespace Mood_Analyzer_problem
{
    public enum ExceptionType
    {
        NULL_VALUE,
        EMPTY_TYPE,
    }

    public class CustomMoodAnalyzerException : Exception
    {
        public ExceptionType extype;

        public CustomMoodAnalyzerException(string msg, ExceptionType extype) : base(msg)
        {
            this.extype = extype;
        }
    }
}