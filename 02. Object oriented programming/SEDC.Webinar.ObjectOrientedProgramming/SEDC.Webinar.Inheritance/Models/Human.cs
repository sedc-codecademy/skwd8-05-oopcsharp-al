using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.Inheritance.Models
{
    public class Human
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        //Default constructor in the parent class Human, that can or cannot be explicitly instantiated
        //public Human()
        //{

        //}

        public Human(string fullName, int age, string phone)
        {
            FullName = fullName;
            Age = age;
            Phone = phone;
        }

        //Virtual method that can be override in the child classes
        public virtual void Info()
        {
            Console.WriteLine($"{FullName} - {Age}");
        }
    }
}
