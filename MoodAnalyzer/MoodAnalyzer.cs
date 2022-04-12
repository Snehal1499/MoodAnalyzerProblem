using System;
namespace Mood_Analyzer_problem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Equals(string.Empty))
                {
                    throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.EMPTY_TYPE_EXCEPTION, "Message should not be empty");
                }
                else if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyzerException(CustomMoodAnalyzerException.ExceptionType.INVALID_MOOD_EXCEPTION, "Message should not be null");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

    }
}
