using System;

namespace FunWithQuizes_InheritanceStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Question trueFalse = new TrueFalse("The moon is in space.", "true");
            Question multiChoice = new MultipleChoice("What year is it?", "2020", "1904", "happy birthday", "2017", 0);
            Question checkbox = new Checkbox("Which two elements make up the sun?", "Oxygen", "Helium", "Hydrogen", "Carbon", 1, 2);
            List<Question> = { trueFalse, multiChoice, checkbox}
            Quiz quiz = new Quiz();
        }
    }
}
