/* 
 * CW1.cs
 * Desc: Practice class test for COM326 OOP.
 * 
 * Version information 
 * Author: 
 * Date: 12-10-24
 *  
 */


using CW1_Practice_test;
using System.Security.Cryptography;

namespace CW1
{
    internal class CW1
    {
        static void Main(string[] args)
        {
            // Do not edit this code
            Question1();
            Question2();
            Question3();
            Question5();
            Question6();
            Question7();
        }


        static void Question1()
        {
            // Question 1: 
            Console.WriteLine("-------Question 1-------");
            // Enter code and comments here...
            int number = 1; //Sets starting number
            //This loop prints the number and adds 1 as long as the number is under 10 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number++);
            }
        }

        static void Question2()
        {
            // Question 2:
            Console.WriteLine("\n-------Question 2-------");
            // Enter code and comments here...
            int number = 10; //Sets starting number
            //This loop prints the number and subtracts 1 as long as the number is over 0 
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(number--);
            }
        }

        static void Question3()
        {
            // Question 3:
            Console.WriteLine("\n-------Question 3-------");
            // Enter code and comments here...
            Console.WriteLine("Please enter the numbers you would like to add up: "); //Asks the user to enter a number to add up
            Console.WriteLine("Press 0 to add up or exit: "); //Tells user to enter 0 to end the loop
            int num = 0; //Sets the num variable 
            int sum = 0; //Sets the sum variable 
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num; //Adds the new number to the total sum
            } while (num != 0); //This while loop will keep going until the user types 0 
            Console.WriteLine(sum); //Prints total sum
        }

        static void Question5()
        {
            // Question 5: 
            Console.WriteLine("\n-------Question 5-------");
            // Enter code and comments here... 
            Person P1 = new Person("John", "Doe", 20); //The 1st Person object
            Person P2 = new Person("Jane", "Doe", 23); //The 2nd Person object
            P1.PrintName(); //Uses the PrintName method with P1 object
            P2.PrintName(); //Uses the PrintName method with P2 object
        }

        static void Question6()
        {
            // Question 6:
            Console.WriteLine("\n-------Question 6-------");
            // Enter code and comments here...
            Person P1 = new Person("John", "Doe", 25); //The 1st Person object
            Person P2 = new Person("Jane", "Doe", 23); //The 2nd Person object
            P1.CalculateOldest(P1, P2); //Uses the CalculateOldest method with P1 object and passes P1 & P2 into the method
        }

        static void Question7()
        {
            // Question 7:
            Console.WriteLine("\n-------Question 7-------");
            // Enter code and comments here...

            
        }
    }
}