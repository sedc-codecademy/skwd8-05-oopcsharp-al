using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Webinar.Inheritance.Models
{
    //Class Student inherits from Human
    public class Student : Human
    {
        public string Group { get; set; }
        public List<string> Subjects { get; set; }
        public Academy AcademyType { get; set; }

        //Constructor of the Student class that inherits the base() constructor from the parent class
        public Student(string fullName, int age, string phone, string group, Academy academyType)
            : base(fullName, age, phone)
        {
            Group = group;
            AcademyType = academyType;
            Subjects = new List<string>();
        }

        //Override of the method Info() that is inherited from the Human parent class
        public override void Info()
        {
            Console.WriteLine($"{FullName} - {Age}. It is a studetn in group {Group}");
        }
    }

    //Enum for different academy types
    public enum Academy
    {
        WebDevelopment = 1,
        WebDesign,
        Networks
    }
}
