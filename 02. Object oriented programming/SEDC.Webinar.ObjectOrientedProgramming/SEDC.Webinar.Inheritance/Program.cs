using SEDC.Webinar.Inheritance.Models;
using System;

namespace SEDC.Webinar.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Inheritance
            //Instances from Student class
            Student std1 = new Student("Martin Panovski", 26, "070/345-554", "G2", Academy.WebDevelopment);
            Student std2 = new Student("Dejan Jovanov", 27, "071/342-554", "G2", Academy.WebDesign);
            Student std3 = new Student("Ivo Kostovski", 29, "071/335-554", "G2", Academy.Networks);

            //Instances from Trainer class
            Trainer trainer = new Trainer("Dragan Gelevski", 27, "070/234-998", 3);

            std1.Info();
            std2.Info();
            std3.Info();


            trainer.Info();

            //Since student inherits from human we can create an instance from student 
            //But the type of that instance to be Human
            //Basically it is the same thing because Student inherits from Human!
            Human std4 = new Student("Ivo Kostovski", 29, "071/335-554", "G2", Academy.Networks);









            #endregion


            Console.ReadLine();
        }
    }
}
