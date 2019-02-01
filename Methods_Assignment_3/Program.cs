/*
 * Author: Tracey McCombs
 * Date: 1/31/2019
 * Comments: This C# console application code will show the use of methods after getting input from users. There are two methods: one value return method and one void method. 
 */

using System;

namespace Methods_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name.");

            /*Use try catch to validate users input.
             * If bad input in entered the catch block will handle the error and a message will display.
             */
          
            try
            {
                // this variable will gather data from user
                string input = Console.ReadLine();

                Console.WriteLine("Hello!" + input);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);

            }// end of try

            catch
            {
                Console.WriteLine("Please enter your name next time...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }// end of catch
        }//end of static void main

        /* this is the static value return method -  it cannot be instantiated with the key word "new".
         * The accessor is private which means the method is limited to the containing class
        */
        //private static void Hello_name(string value_of_input);
       // {

      //  }

        

    }//end of class
}//end of namespace
