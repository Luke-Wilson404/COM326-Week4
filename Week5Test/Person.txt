using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CW1_Practice_test
{
    internal class Person
    {
        private string firstName; //Set the firstName variable as private
        private string lastName; //Set the lastName variable as private
        private int age; //Set the age variable as private

        public string fName //Sets fName and firstName to equal each other
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lName //Sets lName and lastName to equal each other
        {
            get { return lastName; } 
            set { lastName = value; }
        }
        public int Age //Sets age and Age to equal each other
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string fName, string lName, int Age) //This is the class constructor 
        {
            this.fName = fName;
            this.lName = lName;
            this.Age = Age;
        }

        public void PrintName() //The PrintName method prints variables of the Person
        {
            Console.WriteLine("First Name: " + fName);
            Console.WriteLine("Last Name: " + lName);
            Console.WriteLine("Age: " + Age);
        }
        public void CalculateOldest(Person P1, Person P2) //The method calculates the oldest using the P1 and P2 objects
        {
            if (P1.age > P2.age) //If Person 1 is older than Person 2 the method prints the details of Person 1 
            {
                Console.WriteLine(P1.fName + " is the oldest person.");
                P1.PrintName(); //Uses the PrintName method with P1 object
            }
            else //If Person 2 is older the method prints the details of Person 2
            {
                Console.WriteLine(P2.fName + " is the oldest person.");
                P2.PrintName(); //Uses the PrintName method with P2 object
            }
        }
    }
}