using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Webinar.Exceptions
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Compile time error
            //string name = 5342342342342;
            
            try
            {
                List<User> users = new List<User>()
                {
                    new User{ Id = 1, FullName = "Martin Panovski" },
                    new User{ Id = 2, FullName = "Dragan Gelevski" },
                    new User{ Id = 3, FullName = "Miodrag Cekikj" }
                };

                Console.WriteLine("Hello user! Please eneter a number of a user!");
                int number = int.Parse(Console.ReadLine());

                User user = users.Single(x => x.Id == number);

                Console.WriteLine($"You entered the number: {number}");
                Console.WriteLine($"The user you request is: {user.FullName}");


                User martin = null;
                if (martin != null)
                {
                    Console.WriteLine(martin.FullName);
                }
                else
                {
                    //throw new Exception("An exception occured");
                    throw new NullReferenceException("Cannot access property of null reference object.");
                }


            }
            catch (FormatException fex)
            {
                Console.WriteLine($"Format exception occured! Message {fex.Message}");
            }
            catch (InvalidOperationException iex)
            {
                Console.WriteLine($"Invalid operation exception occured! Message {iex.Message}");
            }
            catch (NullReferenceException nullRefEx)
            {
                Console.WriteLine($"Null reference exception occured! Message {nullRefEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }




            Console.ReadLine();
        }
    }
}
