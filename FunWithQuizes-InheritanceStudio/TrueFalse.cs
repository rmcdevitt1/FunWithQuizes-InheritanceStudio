using System;
using System.Collections.Generic;

namespace FunWithQuizes_InheritanceStudio
{
    public class TrueFalse : Question
    {
        public string CorrectAnswer { get; set; }

        public TrueFalse(string question, int numPoints, string answer) :base (question, numPoints)
        {
            CorrectAnswer = answer;
            AnswerChoices = new List<string> { "True", "False" };
        }

        
    }
}
