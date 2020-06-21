using System;
using System.Collections.Generic;

namespace SEDC.Webinar.Methods
{
    class Program
    {

        //Method with no parameters and no return type
        public static void SayHi()
        {
            Console.WriteLine("Hi there!");
        }

        //Method with one input parameter and no return type
        public static void Greet(string person)
        {
            Console.WriteLine($"Hi there {person}");
        }

        //Method with input parameters and return type
        public static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static string RoleCheck(string name)
        {
            switch (name)
            {
                case "Martin":
                    return $"{name} is a presenter for the second webinar!";
                case "Dragan":
                    return $"{name} is the master!";
                default:
                    return "Probably this name doesn't exist at all!";
            }
        }

        public static void DisplayStudents(List<string> studentNames)
        {
            foreach (var student in studentNames)
            {
                Console.WriteLine($"This is student {student}");
            }
        }

        static double Multiply(int a, int b)
        {
            return a * b;
        }


        //Method calling a method as a return type
        public static double MultiplyResult(int a, int b)
        {
            return Multiply(a, b);
        }


        static void Main(string[] args)
        {
            #region Methods
            SayHi();

            Console.WriteLine("Greet() ------------------------");
            Greet("Martin");
            Greet("Dragan");

            Console.WriteLine("Sum() ------------------------");
            Console.WriteLine(Sum(10, 27));
            Console.WriteLine(Sum(13, 43)); 

            Console.WriteLine("RoleCheck() ------------------------");
            Console.WriteLine(RoleCheck("Martin"));
            Console.WriteLine(RoleCheck("Dragan"));
            Console.WriteLine(RoleCheck("Dejan"));
            
            
           

            List<string> students = new List<string>() { "Martin", "Dragan", "Dejan", "Ivo", "Miodrag" };
            Console.WriteLine("Printing student names ------------------");
            DisplayStudents(students);


            Console.WriteLine("Multiply() ------------------------");
            Console.WriteLine(Multiply(14, 18));
            Console.WriteLine(Multiply(14, 22));
            
          

            Console.WriteLine("MultiplyResult() ------------------------");
            Console.WriteLine(MultiplyResult(2, 10));
            Console.WriteLine(MultiplyResult(4, 18));
            


            Console.ReadLine();
            #endregion
        }
    }
}
