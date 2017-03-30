using System;


namespace Project_2
{
    class Project_2
    {
        //Main method used to begin execution of program
        static void Main(string[] args)
        {
            //Variables declared
            DateTime input1;
            DateTime input2;

            /* Methods are used to prompt user, While loop used to check input and convert string value into DateTime structure if possible, 
               if not possible user is prompted to try again until conditions are met */
            Console.Write("Please enter your first date: ");
            while (!DateTime.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("\n");
                Console.Write("Try again! Please enter an actual date: ");
            }

            Console.WriteLine("\n");

            Console.Write("Please enter your second date: ");
            while (!DateTime.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("\n");
                Console.Write("Try again! Please enter an actual date: ");
            }

            Console.WriteLine("\n");

            //Both DateTime values are used to determine the difference in time and create a new variable
            TimeSpan difference = input1 - input2;
        
            //Program calculates the difference in time with days and creates a new variable that can be converted to an integer
            var value = difference.TotalDays;

            //Variable converted to integer data type
            int time = Convert.ToInt32(value);

            //Operations are used to determine timespans
            int years = Math.Abs(time / 365);
            int months = Math.Abs((time % 365) / 30);
            int days = Math.Abs((time % 365) % 30);

            //Method used to return values, if/else statement used for proper grammer
            Console.Write("The time difference is: ");

            if (years == 1)
            { Console.Write(years + " year "); }
            else
            { Console.Write(years + " years, "); }

            if (months == 1)
            { Console.Write(months + " month and "); }
            else
            { Console.Write(months + " months and ");

            if (days == 1)
            { Console.Write(days + " day."); }
            else
            { Console.Write(days + " days."); }

            Console.ReadKey();
            }
        }
    }
}
