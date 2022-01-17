using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class QuestionAnswer
    {
        public char Key { get; set; }
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
    }
    public class UserAnswer
    {
        public List<char> Key { get; set; }
        public string UserId { get; set; }
        public uint? TimeAnswer { get; set; }
    }
    
    public class QuestionModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionAnswer> QuestionAnswers { get; set; }
        public string Explain { get; set; }
        public uint TotalTime { get; set; } = 30;
        public List<UserAnswer> UserAnswers { get; set; }
    }
}
