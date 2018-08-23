using System;

namespace Space_Game
{

    class Program
    {
        static int bankPlayer = 25;
        static int CargoSpace = 1;
        static int Oxygen = 0;
        static int Nitrogen = 0;
        static int Co2 = 0;
        static int TimeYears = 40;
        static int WarpLevel = 5;
        static void Main()
        {

            Console.WriteLine("Welcome to Space Game Main Menu:");
            Console.WriteLine("Hello Traveler The year is 2225.You have saved enough money on earth to afford your first Star Ship");
            Console.WriteLine("Your cargo hold can only hold 1 unit of cargo for now. You have only 25 credits left");
            Console.WriteLine("Each Element has a different value between the different planets.");
            Console.WriteLine("travel to them to find out and make a profit!");
            Console.WriteLine("Press Enter to Start your journey!");
            Console.ReadLine();
            Console.Clear();
            PlanetScreenEarth();
            Console.ReadLine();
        }


        //Earth
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
                Console.Clear();
                TradingPostEarth();
            }
            if (input == "b")
            {
                Console.Clear();
                UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                TravelPlanetsEarth();
            }
            else
            {
                Console.Clear();
                PlanetScreenEarth();
            }


        }
        static void TradingPostEarth()
        {
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (15 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (5) press: b");
            Console.WriteLine("To buy Co2 (10) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (15 Credits) press: d");
            Console.WriteLine("To sell Nitrogen (5) press: e");
            Console.WriteLine("To sell Co2(10) press: f");
            Console.WriteLine("To return to Main menu Press: g");
            Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (bankPlayer < 15)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 15;
                    CargoSpace -= 1;
                    Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "b")
            {
                if (bankPlayer < 5)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    
                      bankPlayer -= 5;
                      CargoSpace -= 1;
                      Nitrogen += 1;
                      Console.Clear();
                      Console.WriteLine("You have bought 1 unit of Nitrogen you have " + bankPlayer + " Credits left");
                      Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold.");
                      Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                      Console.ReadLine();
                                   
                }
            }
            if (input == "c")
            {
                if (bankPlayer < 10)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 10;
                    CargoSpace -= 1;
                    Co2 += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Co2 you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "d")
            {
                if (Oxygen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 15;
                    CargoSpace += 1;
                    Oxygen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "e")
            {
                if (Nitrogen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 5;
                    CargoSpace += 1;
                    Nitrogen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "f")
            {
                if (Co2 < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 10;
                    CargoSpace += 1;
                    Co2 -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Co2 you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                PlanetScreenEarth();
            }
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
                Console.Clear();
                PlanetScreenAlphaCentauri();
            }
            if (input == "b")
            {
                Console.Clear();
                PlanetScreenM63();
            }
            else
            {
                Console.Clear();
                PlanetScreenEarth();
            }
        }

        //Alpha Centauri
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
                Console.Clear();
                TradingPostAlphaCentauri();
            }
            if (input == "b")
            {
                Console.Clear();
                UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                TravelPlanetsAlphaCentauri();
            }
            else
            {
                Console.Clear();
                PlanetScreenAlphaCentauri();
            }

        }
        static void TradingPostAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (20) press: a");
            Console.WriteLine("To buy Nitrogen (10) press: b");
            Console.WriteLine("To buy Co2 (5) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (20) press: d");
            Console.WriteLine("To sell Nitrogen(10) press: e");
            Console.WriteLine("to sell Co2 (5) press: f");
            Console.WriteLine("To return to Main menu Press: g");
             Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (bankPlayer < 20)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 20;
                    CargoSpace -= 1;
                    Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "b")
            {
                if (bankPlayer < 10)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {

                    bankPlayer -= 10;
                    CargoSpace -= 1;
                    Nitrogen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Nitrogen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();

                }
            }
            if (input == "c")
            {
                if (bankPlayer < 5)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 5;
                    CargoSpace -= 1;
                    Co2 += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Co2 you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "d") 
            {
                if (Oxygen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 20;
                    CargoSpace += 1;
                    Oxygen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "e")
            {
                if (Nitrogen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 10;
                    CargoSpace += 1;
                    Nitrogen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Nitrogen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "f")
            {
                if (Co2 < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 5;
                    CargoSpace += 1;
                    Co2 -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Co2 you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                PlanetScreenAlphaCentauri();
            }

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
                Console.Clear();
                PlanetScreenEarth();
            }
            if (input == "b")
            {
                Console.Clear();
                PlanetScreenM63();
            }
            else
            {
                Console.Clear();
                PlanetScreenAlphaCentauri();
            }
        }

        //M63
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
                Console.Clear();
                TradingPostM63();
            }
            if (input == "b")
            {
                Console.Clear();
                UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                TravelPlanetsM63();
            }
            else
            {
                Console.Clear();
                PlanetScreenM63();
            }

        }
        static void TradingPostM63()
        {
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (10 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (25 Credits) press: b");
            Console.WriteLine("To buy Co2 (15 Credits) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (10 Credits) press: d");
            Console.WriteLine("To sell Nitrogen (25 Credits) press: e");
            Console.WriteLine("To sell Co2 (15 Credits) press: f");
            Console.WriteLine("To return to menu Press: g");
            Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (bankPlayer < 10)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 10;
                    CargoSpace -= 1;
                    Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "b")
            {
                if (bankPlayer < 25)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {

                    bankPlayer -= 25;
                    CargoSpace -= 1;
                    Nitrogen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Nitrogen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();

                }
            }
            if (input == "c")
            {
                if (bankPlayer < 5)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 5;
                    CargoSpace -= 1;
                    Co2 += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Co2 you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "d")
            {
                if (Oxygen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 10;
                    CargoSpace += 1;
                    Oxygen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "e")
            {
                if (Nitrogen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth(); Console.WriteLine("You do not have any to sell");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer += 25;
                    CargoSpace += 1;
                    Nitrogen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Nitrogen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "f")
            {
                if (Co2 < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradingPostEarth();
                }
                else
                {
                    bankPlayer += 15;
                    CargoSpace += 1;
                    Co2 -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Co2 you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                PlanetScreenM63();
            }

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

                Console.Clear();
                PlanetScreenEarth();
            }
            if (input == "b")
            {
                Console.Clear();
                PlanetScreenAlphaCentauri();
            }
            else
            {
                Console.Clear();
                PlanetScreenM63();
            }
        }

        static void WarpTravel()
        {
            //v(WarpLevel) = WarpLevel ^ 10 / 3 + (10 - WarpLevel) ^ (-11 / 3);

        }
        static void UpgradeShop()
            {
                string input = "";
                Console.WriteLine("To upgrade Warp Drive for 50 Credits Press: a");
                Console.WriteLine("To upgrade Cargo Hold Press: b");
                Console.WriteLine("To return to Main menu Press: c");
                input = Console.ReadLine();
            if (input == "a")
            {
                if (WarpLevel > 9)
                {
                    Console.WriteLine("Warp level at maximum");
                    Console.WriteLine();
                }
                if (bankPlayer < 50)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                else
                {
                    WarpLevel += 1;
                    bankPlayer -= 50;
                    Console.WriteLine("You have upgraded your warp level to: " + WarpLevel);
                    Console.ReadLine();
                }
            }
            }
        static void EndCreditsTime()
           {
            Console.WriteLine("You have Traveled for over 40 years, its time to retire from space trading.");
            Console.WriteLine("You have retired with " + bankPlayer + " Credits");
            Console.WriteLine("Press Enter to return to the main menu");
            Main();
           }
        static void EndCreditsMoney()
        {
            Console.WriteLine("You have ran out of funds for your adventure");
            Console.WriteLine("Time to move back in with your Space Parents");
            Console.WriteLine("Press enter to return to the main menu");
            Main();

        }
        
        
        
    }

}

