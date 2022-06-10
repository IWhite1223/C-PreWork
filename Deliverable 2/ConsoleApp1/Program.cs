using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace ConsoleApp1
{
   
    internal class Program 
    {
       

        static void Main(string[] args)
        {

            double Water;
            double Juice;
            double Coffee;
            double FoodCost;
            double PartyOf;
            string bevAnswer;
            double waterDrink;
            double coffeeDrink;
            double fruitDrink;
           

           

            Water = 0.50;
            Juice = 5.00;
            Coffee = 3.50;

            Console.WriteLine("Hello! Welcome to Iesha's Buffet! Where you can have all you can eat for $9.99! *Drinks are not included.* ");
            Console.WriteLine();
            Console.WriteLine("How many are in the party? Please keep in mind we can only seat a party of 6 at this time. ");
            PartyOf = int.Parse(Console.ReadLine());


            if (PartyOf > 6)
            {
                Console.WriteLine("We are unable to accomodate this at this time, Goodbye!");
                return;
            }

            else if (PartyOf <= 6)
            {


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Okay, " + PartyOf + "\tYou may sit at any table marked avaiable. Please wait at table for your waiter to offer you refreshments. \t\t Enjoy your meal!");

                Console.WriteLine("-------------------------------");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
              
                

                Console.WriteLine("Hello! My name is Sheila-bot and I will be your waiter today! ");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine(" Please see menu below and choose your drink!");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("-------------------");
                Console.WriteLine("Water .50");
                Console.WriteLine("-------------------");
                Console.WriteLine("Fruit Juice $5.00");
                Console.WriteLine("-------------------");
                Console.WriteLine("Coffee $3.50");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

                Console.WriteLine("Would you like a beverage from this list? y/n ");
                bevAnswer = Console.ReadLine();
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

                if (bevAnswer == "y")
                {
                    Console.WriteLine("Okay! How many would like Water? ");
                    waterDrink = int.Parse(Console.ReadLine());
                    if (waterDrink == 0)
                        Console.WriteLine("No waters got it!");

                    Console.WriteLine("What about Fruit Juice? ");
                    fruitDrink = int.Parse(Console.ReadLine());
                    if (fruitDrink == 0)
                        Console.WriteLine("No Juice got it!");

                    Console.WriteLine("What about Coffee? ");
                    coffeeDrink = int.Parse(Console.ReadLine());
                    if (coffeeDrink == 0)
                        Console.WriteLine("No Coffee got it!");
                   
                        
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                    Console.WriteLine("Okay I will grab those for you! You can go ahead and begin grabbing your food!");


                }
                else if (bevAnswer == "n")
                    Console.WriteLine("No drinks? Okay! You can go ahead and begin grabbing your food!");

                Console.WriteLine("-------------------------------");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

                Console.WriteLine("Here are your drinks!");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("I have added your reciept on the screen. You can pay once you are all set to leave.");

                
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
               

                Console.WriteLine("-------------");
                Console.WriteLine("Receipt");
                Console.WriteLine("-------------");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t");


                Console.WriteLine("Food Total " + PartyOf * 9.99);
               






            }








        }

    }
}
