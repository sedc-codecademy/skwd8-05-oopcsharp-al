using SEDC.Webinar.Classes.Models;
using System;

namespace SEDC.Webinar.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Classes and objects
            Console.WriteLine("----------------- Martin object --------------------");
            Person martin = new Person();
            martin.FirstName = "Martin";
            martin.LastName = "Panovski";
            martin.Age = 26;
            martin.Profession = "Full stack web developer";

            martin.Info();
            martin.Eat("Pizza");
            martin.Sleep(2, 8);
            martin.Work();

            Console.WriteLine("----------------- Dragan object --------------------");
            Person dragan = new Person()
            {
                FirstName = "Dragan",
                LastName = "Gelevski",
                Age = 27,
                Profession = "Master in web development"
            };
            dragan.Info();
            dragan.Eat("Burger");
            dragan.Sleep(11, 8);
            dragan.Work();

            Console.WriteLine(martin.FirstName);


            Person dejan = new Person("Dejan", "Jovanov", 27, "Full stack developer");
            dejan.Info();
            dejan.Eat("Sandwich");
            dejan.Sleep(10, 9);
            dejan.Work();


            Person ivo = new Person("Ivo", "Kostovski", 30);
            ivo.Info();

            bool isPasswordSet = ivo.SetPasswrod("test");
            if (isPasswordSet)
            {
                Console.WriteLine("Password set successfully!");
            }
            else
            {
                Console.WriteLine("Password don't match the correct pattern!");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
