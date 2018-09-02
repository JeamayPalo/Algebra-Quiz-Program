using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JemPalo_QuizProgram_ENGR115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This is the Algebra quiz program of Jeamay Palo.");

            string[] questionsArray = new string[]
            {
                "1.) In the equation 2x + 5 = 17, what is x? a.) x = 10, b.) x = 6, c.) x = 4, d.) x = 9",
                "2.) In Algebra, a variable is any letter that represents a number. True or False a.) True b.) False",
                "3.) The additive inverse of -5 is: a.) 10 b.) 3 c.) 5 d.) -4",
                "4.) If x - 13 = 12, x = 15. True or False? a.) True b.) False",
                "5.) If xy = 12 and x is -4, then y = ? a.) 2 b.) 3 c.) -3 d.) -4",
                "6.) In the equation y = 4x + 2, the slope of the line is: a.) 2 b.) 3 c.) -3 d.) 4",
                "7.) In the equation y = 4x + 2, the y-intercept of the line is: a.) 2 b.) 3 c.) -3 d.) 4",
                "8.) 1, 2, 4, 8 is a series of numbers showing exponential growth. True or False? a.) True b.) False",
                "9.) 2, 4, 6, 8 is a series of numbers showing which relationship? a.) Exponential b.) Quadratic c.) Cubic d.) Linear",
                "10.) Which of the following shows the commutative property? a.) a = b is b = a b.) a = b and b = c so a = c c.) (a + b) + c = a + (b + c) d.) a = a and b = b"
            };

            string[] correctAnswers = new string[] { "b", "a", "c", "b", "c", "d", "a", "a", "d", "a" };

            foreach (string question in questionsArray)
            {
                System.Console.WriteLine($"{question}");
                GetAnswers();
            }

           void GetAnswers()
            {
                string userAnswer = Console.ReadLine();
                if (userAnswer == "a" || userAnswer == "b" || userAnswer == "c" || userAnswer == "d")
                {
                    Console.WriteLine("Next question");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a, b, c or d");
                }
            }

            // /* The following method is where I will implement the counter to track user's correct answers
            //  static void AnswerCounter()  
            // {
            //  string[] userAnswers = new string[10]
            // }
            //        

        }
    }
}
