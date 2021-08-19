using System;
using System.Collections.Generic;

namespace FunWithQuizes_InheritanceStudio
{
    public class Checkbox : Question
    {
        public List<string> CorrectAnswers { get; set; }

        public Checkbox(string question, int numPoints, List<string> choices, List<string> answers) : base(question, numPoints, choices)
        {
            CorrectAnswers = answers;
        }

        public override int CheckAnswer(string userAnswers)
        {
            int points = 0;

            foreach (string answer in CorrectAnswers)
            {
                if(userAnswers.Contains(answer))
                {
                    points += PointValue / CorrectAnswers.Count;
                }
            } return points;
        }

       
    }
}
