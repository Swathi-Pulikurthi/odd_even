//Swathi---------------------
//Write a program to print the command line argument is odd or even no
//Make sure args cannot be empty
//The entered argument is only number.

using System;


namespace odd_even
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = int.Parse(args[0]);
            Console.WriteLine("enter a number");
            try
            {
                int i = int.Parse(Console.ReadLine());
            
            //Console.WriteLine(i);
           
                if (i % 2 == 0)
                    Console.WriteLine("The given input number is even");
                else
                    Console.WriteLine("The given input number is odd");
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
