using System;

namespace Db_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Trago DB");

            string ninput;
            Console.WriteLine("Type Username");

            ninput = Console.ReadLine();

            string pinput;
            Console.WriteLine("Type Password");

            pinput = Console.ReadLine();

            if (ninput == "admin")
            {

                if (pinput == "admin")
                {

                    Console.WriteLine("Processing...");
                    Console.WriteLine("Confirming");

                    Console.WriteLine("Welcome admin");

                    Console.WriteLine("1) Add to DB");
                    Console.WriteLine("2) View Current DB ");
                    Console.WriteLine("3) Change Password");
                    Console.WriteLine("4) Exit");

                    int input1 = Convert.ToInt32(Console.ReadLine());

                    if (input1 == 1)
                    {
                        string yourName;
                        Console.WriteLine("Type your name");

                        yourName = Console.ReadLine();

                        Console.WriteLine("Type your age");
                        int age = Convert.ToInt32(Console.ReadLine());

                        string pnInput;
                        Console.WriteLine("Type your password");

                        pnInput = Console.ReadLine();

                        Console.WriteLine("Adding name and age to DB");


                        Console.WriteLine("Hello {0}", yourName);
                        Console.WriteLine("You age is {0}", age);
                        Console.WriteLine("The password you set is {0}", pnInput);

                        Console.WriteLine("Adding to Database...");
                        Console.WriteLine("DONE!");

                    }


                    // breaker 

                    else if (input1 == 2)
                    {
                        Console.WriteLine("Loading DB...");
                        Console.WriteLine(" Name       Password");
                        Console.WriteLine(" admin      admin");
                        Console.WriteLine(" {1}         {2}");

                        Console.WriteLine("Done printing accounts!");

                    }

                    // breaker

                    else if (input1 == 3)
                    {
                        Console.WriteLine("Changing password protocol running...");
                        string chngpsd;
                        Console.WriteLine("Type new password");

                        chngpsd = Console.ReadLine();

                        Console.WriteLine("Changing password to {0}", chngpsd);
                        Console.WriteLine("Changing...");
                        Console.WriteLine("Done!");

                    }

                    else if (input1 == 4)
                    {
                        System.Environment.Exit(1);
                    }

                    // breaker

                }

                // breaker
            } 
            else {
                Console.WriteLine("Wrong Username or Password!");
            }

            // breaker

        }
    }
}
