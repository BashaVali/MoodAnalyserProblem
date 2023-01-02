using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string AnalyzeMood(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}