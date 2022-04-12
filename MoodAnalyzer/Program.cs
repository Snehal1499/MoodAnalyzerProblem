using System;

namespace Mood_Analyzer_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine(moodAnalyzer.CheckMood("Snehal is Happy for her new Mobile"));
        }
    }
}