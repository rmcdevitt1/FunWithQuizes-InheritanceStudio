using System;
using System.Collections.Generic;

namespace FunWithQuizes_InheritanceStudio
{
    public class MultipleChoice : Question
    {

        public MultipleChoice(string question, int numPoints, string answer) : base(question, numPoints)
        {
            CorrectAnswer = answer;
            AnswerChoices = new List<string> { "A", "B", "C", "D" };
        }

    }
}
