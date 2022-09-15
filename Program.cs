// samuel culp 
// fall 2022 c# cis 215
// array parsing

using System;



//# Objective
//A client has requested that a Console application be built to receive an unknown quantity of delimited numbers.

//# Limitations
//* Valid inputs will be Numeric (Whole or Decimal)
//*Invalid inputs should be discarded and/or ignored
//* Must be able to enter multiple times
//    > Need to have a way to repeat the entry multiple times without restarting the application.
//* CANNOT use any Extensions
//* Must use the Array DataType
//    * CANNOT use any of the Collection Object Types.
//* Any Methods/Functions must be directly accessible from the Object/Type being used
//    > Can be Static or Instance based.

//# Deliverables (Attached to Assignment)
//* Word Document
//    * Contains link to your GitHub Repository for the Homework Assignment
//    * Document any problems you struggled with.

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
