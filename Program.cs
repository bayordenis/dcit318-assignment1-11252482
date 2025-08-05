using System;

namespace TrippleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("TRIPPLE APP MENU");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        GradeCalculator();
                        break;
                    case 2:
                        TicketPriceCalculator();
                        break;
                    case 3:
                        TriangleTypeIdentifier();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
                Console.Clear();

            } while (choice != 0);
        }

        static void GradeCalculator()
        {
            Console.WriteLine("GRADE CALCULATOR");
            Console.Write("Enter your grade (0 - 100): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }

        static void TicketPriceCalculator()
        {
            Console.WriteLine("TICKET PRICE CALCULATOR");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
        }

        static void TriangleTypeIdentifier()
        {
            Console.WriteLine("TRIANGLE TYPE IDENTIFIER");
            Console.Write("Enter side A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("The triangle is Equilateral.");
            else if (a == b || b == c || a == c)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
    }
}
