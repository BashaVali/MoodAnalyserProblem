using System;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("sad"))
                return "Sad";
            return "Happy";
        }
    }
}