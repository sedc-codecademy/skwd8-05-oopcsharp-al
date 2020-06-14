using System;

namespace SEDC.WorkingWithStringsAndDateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Strings and string manipulation methods

            //Declaration of string variables
            string partOne = "Hello world!";
            string partTwo = "We have the first webinar from the series of three";

            //String concatenation
            string message = partOne + " " + partTwo;
            Console.WriteLine(message);

            //String interpolation using $ sign in front of it
            string stringInterpolation = $"{partOne} \"{partTwo}\"";
            Console.WriteLine(stringInterpolation);


            //String interpolation using @ sign in front of it
            string stringInQuatations = @"{partOne} ""{partTwo}""";
            Console.WriteLine(stringInQuatations);


            //Formating string using Format() method 
            string formatedString = String.Format("Text inside {0} {1}", partOne, partTwo);
            Console.WriteLine(formatedString);


            //String with empty spaces from beginning and using TrimStart() for removing them
            string stringWithEmptySpaces = "               Hello! My name is Martin!";
            Console.WriteLine(stringWithEmptySpaces);


            string trimedString = stringWithEmptySpaces.TrimStart();
            Console.WriteLine(trimedString);


            //String for manipulation of string ToLower(), ToUpper(), Split()
            string stringToUpper = partOne.ToUpper();
            Console.WriteLine($"To upper: {stringToUpper}");
            string stringToLower = partTwo.ToLower();
            Console.WriteLine($"To lower: {stringToLower}");

            string name = "Martin Panovski";
            string[] splitedName = name.Split(" ");
            foreach (var item in splitedName)
            {
                Console.WriteLine($"Splited name: {item}");
            }

            #endregion

            #region DateTime and methods for working with dates
            //Initialization of new DateTime variable using empty constructor
            DateTime date = new DateTime();
            Console.WriteLine(date);

            //Initialization of new DateTime variable using constructor that accepts year, month and day as inputs
            DateTime myBirthday = new DateTime(1993, 08, 27);
            Console.WriteLine(myBirthday);


            //Get the current date AND time
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //Get only the current Date
            DateTime today = DateTime.Today;
            Console.WriteLine(today.ToShortDateString());


            Console.WriteLine("==========================================");

            Console.WriteLine("Hello user please enter your birth date!");
            string input = Console.ReadLine();

            //Parsing from string to DateTime using Parse() method (Throws an error if parsing fails)
            //DateTime usersBirthDay = DateTime.Parse(input);
            //Console.WriteLine($"You are born on {usersBirthDay}");

            //Parsing from string to DateTime using TryParse() (Do not throws an error if parsing fails)
            //Instead it returns bool type, so you can check if the parse went well or not and have more control on your code
            DateTime result;
            bool isDateParsed = DateTime.TryParse(input, out result);

            if (isDateParsed)
            {
                Console.WriteLine($"You are born on {result}");
                Console.WriteLine($"One year and two months added on your birth day is: {result.AddYears(1).AddMonths(2)}");
                Console.WriteLine($"One year before your birth day was : {result.AddYears(-1)}");
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
