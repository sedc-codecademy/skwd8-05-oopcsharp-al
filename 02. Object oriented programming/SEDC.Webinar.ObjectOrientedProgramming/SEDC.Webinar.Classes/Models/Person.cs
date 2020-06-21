using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Webinar.Classes.Models
{
    //Simple declaration of class in C#
    public class Person
    {
        //Properties (Data)
        //Every instance of this class can have FirstName, LastName, Age.....
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        private string Password { get; set; }


        //Default constructor explicitly specified
        //If we want to instantiate object with empty constructor but still we want to have 
        //Different constructors for creating instances by using different constructor
        public Person()
        {

        }

        public Person(string firstName, string lastName, int age, string profession)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Profession = profession;
        }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Profession = "Not defined";
        }


        //Methods (Behavior)
        //Every instance of this class can have different behavior like
        //Every instanc can Eat, can Sleep, can Work
        public void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} years old and its profession is {Profession}!");
        }

        public void Eat(string meal)
        {
            Console.WriteLine($"{FirstName} is eating {meal}");
        }

        public void Sleep(int from, int till)
        {
            Console.WriteLine($"{FirstName} is sleeping from {from} till {till}");
        }

        public string Work()
        {
            return $"{FirstName} is working hard!";
        }


        public bool SetPasswrod(string password)
        {
            if(password.Length == 0 || password.Length <= 5)
            {
                return false;
            }
            else
            {
                Password = password;
                return true;
            }
        }
    }
}
