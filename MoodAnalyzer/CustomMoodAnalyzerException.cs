using System;
namespace Mood_Analyzer_problem
{
    public class CustomMoodAnalyzerException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            INVALID_MOOD_EXCEPTION,
            EMPTY_TYPE_EXCEPTION
        }

        public CustomMoodAnalyzerException(ExceptionType type, string massage) : base(massage)
        {
            this.type = type;
        }
    }
}
