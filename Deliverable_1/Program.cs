using System;
using System.Collections.Generic;



namespace Deliverable_1
{
    internal class Program
    {
        static bool KeepGoing()

        {

            while (true)

            {
                Console.WriteLine();

                Console.WriteLine("Would you like to calculate again?");

               

                string response = Console.ReadLine();

                response = response.ToLower();

                

                if (response == "y" || response == "yes")

                {

                    return true;



                }

                else if (response == "n" || response == "no")

                {

                    Console.WriteLine("Good Bye!");

                    return false;

                }

                else

                {

                    Console.WriteLine("Please enter y or n");

                }

            }

        }

        static void Main(string[] args)
        {

            do
            {


                int Bread;
                int PeanutButter;
                int Jelly;

                Console.WriteLine();
                Console.WriteLine("How many people are we making PB&J Sandwiches for?");
                int People = Convert.ToInt32(Console.ReadLine());

                Bread = People * 2;
                PeanutButter = People * 2;
                Jelly = People * 4;

                if (People >= 1)
                    Console.WriteLine("You need: ");
                Console.WriteLine(Bread + " Slices of bread ");
                Console.WriteLine(PeanutButter + " Tablespoons of peanut butter ");
                Console.WriteLine(Jelly + " Teaspoons of Jelly \t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t");

                int totalLoavesNeeded;
                int totalSlicesNeeded;
                int slicesPerLoaf;
                int jellyPerSandwich;
                int peanutbutterPerSandwich;

                slicesPerLoaf = 28;
                totalSlicesNeeded = Bread;
                totalLoavesNeeded = totalSlicesNeeded / slicesPerLoaf;
                peanutbutterPerSandwich = PeanutButter / 32;
                jellyPerSandwich = Jelly / 48;


                if (Bread >= 28 && PeanutButter >= 32 && Jelly >= 48)

                    Console.WriteLine("Which is... ");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t");
                Console.WriteLine(totalLoavesNeeded + " loaves of bread");
                Console.WriteLine(peanutbutterPerSandwich + " jars of peanut butter");
                Console.WriteLine(jellyPerSandwich + " jars of jelly");

            }
            while (KeepGoing());
             
        }






    }
}
