using System;

namespace FitnessApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public void addExercise()
        {
            Console.WriteLine(" what exercise are you doing?");
            String exercise = Console.ReadLine();
            Console.WriteLine("how long is the exercise?");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many calories will you burn?");
            int calories = Convert.ToInt32(Console.ReadLine());

        }

        public void menu()
        {
            Console.WriteLine("1. Add Exercise");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    addExercise();
                    break;
                case 2:
                    //viewExercise();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        }

    }
}