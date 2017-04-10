using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddDemo
{
    class GetInputandCalculate
    {
        public void userInput(int usernumber)
        {
            if (usernumber % 2 == 0)
            {
                Console.WriteLine(usernumber+ " Number is even!!");
            }
            else Console.WriteLine(usernumber+ " Number is odd!");
            
        }
    }
    class Program
    {
        /* Write a program that takes in an array of numbers and 
         * Outputs whether the are even or odd.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of integers to be added to the array : ");

            string testInput = Console.ReadLine();
            String[] substrings = testInput.Split(' ');
            int[] myInts = Array.ConvertAll(substrings, int.Parse);
            
            // Looping the customers input into an array
           

            GetInputandCalculate guess = new GetInputandCalculate();


            System.Collections.ArrayList l = new System.Collections.ArrayList();
            for (int a = 0; a < myInts.Length; a++)
            {
            guess.userInput(myInts[a]);
            }
            for (int k = 0; k < l.Count; k++)
            {
                Console.Write((int)l[k] + (int)l[k] + " ");
            }

            Console.ReadKey();

        }
    }
}
