using System;

namespace CircleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            int circleObjCount = 0;
            bool runProgram = true;
            while (runProgram && circleObjCount >= 0)
            {
                Circle circle = new Circle(2);

                Console.WriteLine(circle.CalculateFormattedCircumference());
                Console.WriteLine(circle.CalculateFormattedArea());
                circleObjCount++;

                Console.WriteLine("Would you like to try again?: (y/n)");
                while (true)
                {
                    string tryAgain = Console.ReadLine();
                    if (tryAgain.Equals("y"))
                    {
                        break;
                    }
                    else if (tryAgain.Equals("n"))
                    {
                        runProgram = false;
                        Console.WriteLine($"Goodbye. You created { circleObjCount } Circle object(s)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please try again. (y/n)");
                    }
                }
            }
        }
    }
}
