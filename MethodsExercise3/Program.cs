using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1-2 done with one method, two calls
            PrintToConsoleNumsInRange(-1000, 1000, 1);
            PrintToConsoleNumsInRange(3, 999, 3);

            //part 3, ask info in main, check and respond in CheckIfIntsAreEqual method
            Console.WriteLine("Give me two integers, and I will tell you if they are the same.");
            Console.Write("Int 1: ");
            int questionableInt1 = Int32.Parse(Console.ReadLine());
            Console.Write("Int 2: ");
            int questionableInt2 = Int32.Parse(Console.ReadLine());
            CheckIfIntsAreEqual(questionableInt1, questionableInt2);

            //part 4,
            Console.WriteLine("Give me an integer, and I will tell you if it is even or odd.");
            Console.Write("Int: ");
            int oddOrEvenInt = Int32.Parse(Console.ReadLine());
            IsNumOddOrEven(oddOrEvenInt);

            //part 5,
            Console.WriteLine("Give me an integer, and I will tell you if it is positive or negative.");
            Console.Write("Int: ");
            int posOrNegInt = Int32.Parse(Console.ReadLine());
            IsNumPosOrNeg(posOrNegInt);

            //part 6
            Console.WriteLine("What is your age");
            Console.Write("Age: ");
            int Age = Int32.Parse(Console.ReadLine());
            CanVote(Age);

            //Heatin' up
            //part 7
            Console.WriteLine("Give me a integer, and I will tell you if it is in the range -10 to 10");
            Console.Write("Int: ");
            int userInputInt = Int32.Parse(Console.ReadLine());
            IsWithinRange(-10, 10, userInputInt);

            //part 8
            Console.WriteLine("Give me a integer (1-12), and I will creat a multiplication table for it.");
            Console.Write("Int: ");
            int mTableInt = Int32.Parse(Console.ReadLine());
            MultiplicationTable(mTableInt);

        }

        public static void PrintToConsoleNumsInRange(int low, int high, int increment)
        {
            for (int i = low; i <= high;)
            {
                Console.WriteLine(i);
                i += increment;
            }
        }

        public static void CheckIfIntsAreEqual(int int1, int int2)
        {
            string response = (int1 == int2) ? "They are equal!" : "They are not equal, run for your lives!";
            Console.WriteLine(response);
        }

        public static void IsNumOddOrEven(int num)
        {
            string response = (num % 2 == 0) ? "Divinely even!" : "Odd, significantly so!";
            Console.WriteLine(response);
        }

        public static void IsNumPosOrNeg(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Zero isn't either positive or negative, and you know that! :(");
            }
            else
            {
                string response = (num > 0) ? "Particularly positive!" : "Downright negative!";
                Console.WriteLine(response);
            }
        }

        public static void CanVote(int age)
        {
            string response = (age >= 18) ? "You can vote!" : "No voting, smallfry!";
            Console.WriteLine(response);
        }

        public static void IsWithinRange(int low, int high, int testInt)
        {
            string response = (testInt >= low && testInt <= high) ? "In range, fire!" : "Not in range, it got away!";
            Console.WriteLine(response);
        }

        public static void MultiplicationTable(int size)
        {
            for (int k = 0; k < size; k++)
            {
                Console.Write("--------");
            }
            Console.WriteLine("");
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write(i * j);
                    Console.Write("\t|");
                }
                Console.WriteLine("");
                for (int k = 0; k < size; k++)
                {
                    Console.Write("--------");
                }
                Console.WriteLine("");
            }
        }

    }
}
