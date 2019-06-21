using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FortuneTeller
{
    class Program
    {
        private static long bankBalance;
        private static string modeTransportation;
        private static string retireYears;

        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("heeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            Console.WriteLine("Welcome to Fortune Teller! Answer the questions to find your future. Type in \"QUIT\" if you want to exit the game.");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            string upperFirstName = firstName.ToUpper();
            if (upperFirstName == "QUIT")
            {
                Console.WriteLine("Nobody likes a quitter...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("What is your last name");
                string lastName = Console.ReadLine();
                string upperLastName = lastName.ToUpper();
                if (upperLastName == "QUIT")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    Environment.Exit(0);
                }
                else
                {
                    string quitVar = null;
                    int retireYears = 0;
                    Console.WriteLine("How old are you?");
                    do
                    {
                        quitVar = Console.ReadLine();
                        if (quitVar.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Nobody likes a quitter");
                            Environment.Exit(0);
                        }
                        else
                        {
                            int age = Int32.Parse(quitVar);
                            if (age % 2 == 0)
                            {
                                retireYears = 10;
                            }
                            else
                            {
                                retireYears = 50;
                            }
                        }
                    }
                    while (quitVar == null);
                    String quitVar2 = null;
                    Console.WriteLine("What month were you born? Please input as a number 1-12");
                    do
                    {
                        quitVar2 = Console.ReadLine();
                        if (quitVar2.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Nobody likes a quitter...");
                            Environment.Exit(0);
                        }
                        else
                        {
                            int birthMonth = Int32.Parse(quitVar2);
                            switch (birthMonth)
                            {
                                case 1:
                                    bankBalance = 4201989;
                                    break;
                                case 2:
                                    bankBalance = 4201989;
                                    break;
                                case 3:
                                    bankBalance = 4201989;
                                    break;
                                case 4:
                                    bankBalance = 4201989;
                                    break;
                                case 5:
                                    bankBalance = 900000;
                                    break;
                                case 6:
                                    bankBalance = 900000;
                                    break;
                                case 7:
                                    bankBalance = 900000;
                                    break;
                                case 8:
                                    bankBalance = 900000;
                                    break;
                                case 9:
                                    bankBalance = 5;
                                    break;
                                case 10:
                                    bankBalance = 5;
                                    break;
                                case 11:
                                    bankBalance = 5;
                                    break;
                                case 12:
                                    bankBalance = 5;
                                    break;
                            }
                        }
                    }
                    while (quitVar2 == null);

                    string modeTransportation = null;

                    Console.WriteLine("What is your favorite ROYGBIV color? Need Help? Enter Help.");

                    do
                    {
                        string favColor = Console.ReadLine();

                        if (favColor.Trim().Equals("help", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(

                                    "The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet. Please enter your favorite ROYGBIV color");

                        }
                        else if (lastName.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Nobody likes a quitter...");
                            Environment.Exit(0);

                        }
                        else if (favColor.Trim().Equals("red", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "horse";
                        }
                        else if (favColor.Trim().Equals("orange", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "Mercedes Benz";
                        }
                        else if (favColor.Trim().Equals("yellow", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "bike";
                        }
                        else if (favColor.Trim().Equals("green", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "Uber";
                        }
                        else if (favColor.Trim().Equals("blue", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "Lyft";
                        }
                        else if (favColor.Trim().Equals("indigo", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "spaceship";
                        }
                        else if (favColor.Trim().Equals("violet", StringComparison.OrdinalIgnoreCase))
                        {
                            modeTransportation = "minivan";
                        }
                        else
                        {
                            Console.WriteLine("Sorry that's not a valid color! Please enter a valid ROYGBIV color");
                        }
                    } while (modeTransportation == null);

                }
                String vacationHome = null;
                String quitVar1 = null;
                Console.WriteLine("How many siblings do you have?");
                do
                {
                    quitVar1 = Console.ReadLine();
                    if (quitVar1.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        int siblings = Int32.Parse(quitVar1);

                        if (siblings == 0)
                        {
                            vacationHome = "Cleveland, Ohio";
                        }
                        else if (siblings == 1)
                        {
                            vacationHome = "Rome, Italy";
                        }
                        else if (siblings == 2)
                        {
                            vacationHome = "Miami, Florida";
                        }
                        else if (siblings == 3)
                        {
                            vacationHome = "Cancun, Mexico";
                        }
                        else if (siblings > 3)
                        {
                            vacationHome = "San Francsico, California";
                        }
                        else if (siblings < 0)
                        {
                            vacationHome = "Dayton,Ohio";
                        }
                    }
                } while (quitVar1 == null);

                Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYears + " years with $"
                        + bankBalance + " in the bank, a vacation home in " + vacationHome + " , and travel by "
                        + modeTransportation + ".");


            }
        }
    }
}
