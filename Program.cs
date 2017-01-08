using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, coloR;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();


            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());



            Console.WriteLine("What is your birth month?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your favorite ROYGBIV color? If you don't know ROYGBIV, please enter help");
            coloR = Console.ReadLine();

            if (coloR == "help")

            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet" + "\n");
                Console.WriteLine("What's your favorite ROYGBIV color?");
                coloR = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());

            Console.WriteLine(firstName + " " + lastName);

            if (age % 2 == 0)

            {
                Console.WriteLine("You will retire in 3 years");
            }
            else
            {
                Console.WriteLine("You will retire in 5 years");
            }

            if (month <= 4)
            {
                Console.WriteLine("You will have $50,000 in the bank");
            }
            else
            {
                if (month <= 8)
                {
                    Console.WriteLine("You will have $75,000 in the bank");
                }
                else
                    if (month <= 12)
                {
                    Console.WriteLine("You will have $100,000 in the bank");
                }

                //ROYGBIV 
                coloR = coloR.ToLower();

                if (coloR == "red" || coloR == "orange" || coloR == "yellow" || coloR == "green" || coloR == "blue" || coloR == "indigo" || coloR == "violet" )

                    switch (coloR)

                    {
                        case "red":
                            Console.WriteLine("You will drive a red Ferrari, winner winner!");
                            break;

                        case "orange":
                            Console.WriteLine("You will drive an orange oldsmobile station wagon");
                            break;

                        case "yellow":
                            Console.WriteLine("You will drive a yellow Porsche");
                            break;

                        case "green":
                            Console.WriteLine("You will fly a futuristic airplane");
                            break;

                        case "blue":
                            Console.WriteLine("You will captain a submarine");
                            break;

                        case "indigo":
                            Console.WriteLine("You will drive through the speed of light in a teleportation device");
                            break;

                        case "violet":
                            Console.WriteLine("You will drive a violet smart car");
                            break;
                      
                     
                    }

                if (siblings == 0)
                {
                    Console.WriteLine("You will have a vacation home in Florida");
                }
                else
                {
                    if (siblings == 1)
                    {
                        Console.WriteLine("You will have a vacation home in Yemen");
                    }
                    else
                        if (siblings == 2)
                    {
                        Console.WriteLine("You will have a vacation home in Syria");
                    }
                    else
                        if (siblings >= 3)
                    {
                        Console.WriteLine("You will have a vacation home in Afghanistan");
                    }



                }
            }
        }
    }
}
 
