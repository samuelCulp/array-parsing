// samuel culp 
// fall 2022 c# cis 215
// array parsing

using System;


namespace HW1Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            double[] numbers = new double[1000];
            int i = 0;
           

            do // do while loop will go until the user types S
            {

                Console.WriteLine("Enter a number type S to stop: "); // outputs to the user
                string input = Console.ReadLine(); // gets input from the user

                bool isNum = double.TryParse(input, out numbers[i]); // is a boolean to see if the input is a number

                if (input == "S" || input == "s") { break; } // if the user types s the loop stops
                if (!isNum) // if the input is a char or string this will subtract i and and output invalid
                {
                    i--;
                    Console.WriteLine(input + " is invalid");
                }

                i++; // add the loops
            } while (true);

            double[] arr = new double[i];//  a new array for the output
            for (int j = 0; j < i; j++){
                arr[j] = numbers[j]; // adds an array to an array 
            }
            
            Console.WriteLine(string.Join(", ", arr)); //outputs
        }
    }
}
