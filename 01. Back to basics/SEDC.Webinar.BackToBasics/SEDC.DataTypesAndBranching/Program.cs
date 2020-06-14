using System;

namespace SEDC.DataTypesAndBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables and data types

            int number = 10;
            double decimalNumber = 10.5;
            char character = 'C';
            string words = "Hello there!";
            float number1 = 6.3F;
            bool isRaining = false;

            Console.WriteLine(number);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(character);
            Console.WriteLine(words);

            Console.WriteLine("==============================================");

            int parsedNumber = int.Parse("23");
            double parsedIntoDouble = double.Parse("23.5");

            Console.WriteLine(parsedNumber);
            Console.WriteLine(parsedIntoDouble);

            Console.WriteLine(parsedNumber.GetType());
            Console.WriteLine(parsedNumber.GetType().Name);

            Console.WriteLine(parsedIntoDouble.GetType());
            Console.WriteLine(parsedIntoDouble.GetType().Name);

            //Cannot be parsed dobuble into int
            //int numberParsed = int.Parse("23.5");
            //Console.WriteLine(numberParsed);


            int parseInt;
            //bool ifParsed = int.TryParse("12", out parseInt);
            //Console.WriteLine(parseInt);

            Console.WriteLine("==============================================");

            Console.WriteLine("Hello user, please enter a number");
            bool userInput = int.TryParse(Console.ReadLine(), out parseInt);
            if (userInput)
            {
                Console.WriteLine("Thank you. Have a nice day :)");
            }
            else
            {
                Console.WriteLine("Wrong input, please try again!");
            }

            string name = Console.ReadLine();
            Console.WriteLine("Hello there " + name);




            Console.WriteLine("==============================================");
            int a = 10;
            int b = 20;
            int c = 30;

            if (a > b)
            {
                Console.WriteLine("5 is bigger th5n 2");
            }
            else if (c > a)
            {
                if (b > a)
                {
                    Console.WriteLine("Success!");

                }
            }
            else
            {
                Console.WriteLine("End condition!");
            }


            string color = "red";
            switch (color)
            {
                case "red":
                    Console.WriteLine("Red means STOP!");
                    break;
                case "yellow":
                    Console.WriteLine("Yellow means PREPARE!");
                    break;
                case "green":    
                    Console.WriteLine("Green means GO!");
                    break;
                default:
                    Console.WriteLine("There is no such color in the traffic light!");
                    break;
            }

            int day = 2;
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Work day :(");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("WEEKEND! YEEY!");
                    break;
                default:
                    Console.WriteLine("There is no such a day in the week!");
                    break;
            }








            #endregion



            Console.ReadLine();
        }
    }
}
