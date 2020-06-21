using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.Inheritance.Models
{
    //Class Trainer inherits from Human
    public class Trainer : Human
    {
        public int YearsOfExperience { get; set; }
        public List<string> ProgrammingLanguages { get; set; }

        //Constructor of the Trainer class that inherits the base() constructor from the parent class
        public Trainer(string fullName, int age, string phone, int yearsOfExcp) 
            : base(fullName, age, phone)
        {
            YearsOfExperience = yearsOfExcp;
            ProgrammingLanguages = new List<string>();
        }

        //Override of the method Info() that is inherited from the Human parent class
        public override void Info()
        {
            Console.WriteLine($"{FullName} - {Age}. It is a trainer with {YearsOfExperience} years of experience!");
        }
    }
}
