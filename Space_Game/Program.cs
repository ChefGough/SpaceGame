using System;

namespace Space_Game
{

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Space Game Main Menu:");
            Console.WriteLine("Please enter your character's name");
            string CharacterName = Console.ReadLine();
            Console.WriteLine("Your chosen name is: " + CharacterName);
            Console.WriteLine("Hello " + CharacterName + " The year is 2225. You have just bought your first starship.");
            Console.WriteLine("Your cargo hold can only hold 1 unit of cargo. You have only 25 credits left");
            Console.WriteLine("Oxygen in available on earth for: 15 credits");
            Console.WriteLine("Nitrogen is available for 5 credits");
            Console.WriteLine("Co2 is available for 10 credits.");
            Console.WriteLine("Each Element has a different value between the different planets.");
            Console.WriteLine("travel to them to find out and make a profit!");
            Console.WriteLine("Press enter to continue");
            PlanetScreenEarth();
            Console.ReadLine();
        }




        static void PlanetScreenEarth()
        {
            string input = "";
            Console.WriteLine("Welcome to Earth");
            Console.WriteLine("To Enter the Trading post Press: a");
            Console.WriteLine("To enter the Upgrade shop Press: b");
            Console.WriteLine("To Travel Press: c");

            input = Console.ReadLine();
            if (input == "a")
            {
                TradingPostEarth();
            }
            if (input == "b")
            {
                UpgradeShop();
            }
            if (input == "c")
            {
                TravelPlanetsEarth();
            }


        }
        static void TradingPostEarth()
        {
            string input = "";
            Console.WriteLine("To buy Oxygen (15 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (5) press: b");
            Console.WriteLine("To buy Co2 (10) press: c");
            input = Console.ReadLine();

        }

        static void UpgradeShop()
        {
            string input = "";
            Console.WriteLine("To upgrade Warp Drive Press: a");
            Console.WriteLine("To upgrade Cargo Hold Press: b");
            input = Console.ReadLine();
        }
        static void TravelPlanetsEarth()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: a");
            Console.WriteLine("To travel to m63 Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                PlanetScreenAlphaCentauri();
            }
            if (input == "b")
            {
                PlanetScreenM63();
            }
            else
            {
                PlanetScreenEarth();
            }
        }




        static void PlanetScreenAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("Welcome to Alpha Centauri");
            Console.WriteLine("To Enter the Trading post Press: a");
            Console.WriteLine("To enter the Upgrade shop Press: b");
            Console.WriteLine("To Travel Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                TradingPostAlphaCentauri();
            }
            if (input == "b")
            {
                UpgradeShop();
            }
            if (input == "c")
            {
                TravelPlanetsAlphaCentauri();
            }
            else
            {
                PlanetScreenAlphaCentauri();
            }

        }
        static void TradingPostAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("To buy Oxygen (20 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (10) press: b");
            Console.WriteLine("To buy Co2 (5) press: c");
            input = Console.ReadLine();

        }
        static void TravelPlanetsAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("To travel to Earth Press: a");
            Console.WriteLine("To travel to m63 Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                PlanetScreenEarth();
            }
            if (input == "b")
            {
                PlanetScreenM63();
            }
            else
            {
                PlanetScreenAlphaCentauri();
            }
        }

        static void PlanetScreenM63()
        {
            string input = "";
            Console.WriteLine("Welcome to M63");
            Console.WriteLine("To Enter the Trading post Press: a");
            Console.WriteLine("To enter the Upgrade shop Press: b");
            Console.WriteLine("To Travel Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                TradingPostM63();
            }
            if (input == "b")
            {
                UpgradeShop();
            }
            if (input == "c")
            {
                TravelPlanetsM63();
            }
            else
            {
                PlanetScreenM63();
            }

        }
        static void TradingPostM63()
        {
            string input = "";
            Console.WriteLine("To buy Oxygen (10 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (25 Credits) press: b");
            Console.WriteLine("To buy Co2 (10 Credits) press: c");
            Console.WriteLine("To return to menu Press: d");
            input = Console.ReadLine();

        }
        static void TravelPlanetsM63()
        {
            string input = "";
            Console.WriteLine("To travel to Earth Press: a");
            Console.WriteLine("To travel to Alpha Centauri Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                PlanetScreenEarth();
            }
            if (input == "b")
            {
                PlanetScreenAlphaCentauri();
            }
            else
            {
                PlanetScreenM63();
            }
        }
    }
}

