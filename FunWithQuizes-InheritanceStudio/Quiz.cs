using System;
using System.Collections.Generic;


namespace FunWithQuizes_InheritanceStudio
{
    public class Quiz
    {
        public List<Question> QuizQuestions { get; set; }
        public int MaxPoints { get; set; }
        public double PointsEarned { get; set; }

        public Quiz(List<Question> questions)
        {
            QuizQuestions = questions;
            int points = 0;
            foreach(Question question in questions)
            {
                points += question.PointValue;
            }
            MaxPoints = points;
        }

        public void GiveQuiz()
        {
            foreach (Question question in QuizQuestions)
            {
               
                Console.WriteLine(question.ToString());
                string answer = Console.ReadLine();
                PointsEarned += question.CheckAnswer(answer);
                
            }
        }

        public void GetGrade()
        {
            Console.WriteLine("Your grade is: " + PointsEarned/MaxPoints * 100 + "%");
        } 





    }
}
