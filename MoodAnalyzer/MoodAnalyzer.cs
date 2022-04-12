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
                if (message.ToLower().Contains("sad"))
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
                return "happy";
            }

        }
    }



}
