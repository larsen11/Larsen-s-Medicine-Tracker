using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Medicine Tracker by Larsen Reyes!");

        Console.Write("Enter the number of medicines you want to track: ");
        int numberOfMedicines = int.Parse(Console.ReadLine());

        for (int x = 0; x < numberOfMedicines; x++)
        {
            Console.WriteLine();
            Console.WriteLine($"Medicine #{x + 1}");

            Console.Write("Enter the starting date of your prescribed medicine (dd/MM/yyyy): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the name of the prescribed medicine: ");
            string medicineName = Console.ReadLine();

            Console.Write("Enter the number of times you need to drink the medicine: ");
            int numberOfTimes = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of days gap between medicine intake: ");
            int gapDays = int.Parse(Console.ReadLine());

            Console.WriteLine("Dates to drink the medicine:");

            int count = 0;
            DateTime currentDate = startDate;

            for (int i = 0; i < numberOfTimes; i++)
            {
                string formattedDate = currentDate.ToString("dd/MM/yyyy");
                Console.WriteLine($"{formattedDate}: Take {medicineName}");
                count++;
                currentDate = currentDate.AddDays(gapDays);
            }

            if (count == 0)
            {
                Console.WriteLine("No medicine intake days found.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Press Enter to run the program again or any other key to exit.");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Main(args);
        }
        else
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}