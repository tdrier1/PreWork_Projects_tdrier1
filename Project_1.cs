using System;


namespace Project_1
{
    class Project_1
    {   
        //Main method and entry point for the program execution
        static void Main(string[] args)
        {
            //Here is were the variables are defined
            int rem;
            int rev = 0;


            //Prompt for user to enter string value and convert to an integer
            Console.Write("Please Enter Your Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //While loop used to perform the number reversal
            while (num > 0)
            {
                rem = (num % 10);
                rev = (rev * 10) + rem;
                num = (num / 10);
            }

            Console.WriteLine("\n");

            //Comand returning string value and input number reveresed 
            Console.WriteLine("Your Number Reversed: " + rev);

            Console.ReadKey();

        }
    }
}
