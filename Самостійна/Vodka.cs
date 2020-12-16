using System;
using System.Collections.Generic;
namespace samrob
{
    class Vodka
    {
        public List<Napoi> nap = new List<Napoi>();

        public void AddNewNapoi()
        {
            string Excerpt;
            string Country_made;
            int Cost;
            int Volume;
            Console.Write("\nEnter a excerpt of napoi: ");
            Excerpt = Console.ReadLine();
            Console.Write("Enter a country made of napoi: ");
            Country_made = Console.ReadLine();
            Console.Write("Enter a napois price: ");
            while (!int.TryParse(Console.ReadLine(), out Cost) || Cost <= 0)
            {
                Console.Write("Enter a correct speed value, please: ");
            }
            Console.Write("Enter a vodka's volume of bottle: ");
            while (!int.TryParse(Console.ReadLine(), out Volume) || Volume > 10 || Volume < 0)
            {
                Console.Write("Enter a correct volume, please: ");
            }
            Napoi newNapoi = new Napoi(Excerpt, Country_made, Cost, Volume);
            nap.Add(newNapoi);
        }
        public void DisplayAllNapois()
        {
            int i = 1;
            foreach (Napoi c in nap)
            {
                DisplayInfoAboutNapoi(c);
                i++;
            }
        }
        public void SearchByOneCharacteristic(char characteristic)
        {
            int i = 0;
            switch (characteristic)
            {
                case 'n':
                    Console.Write("What excerpt would you like to find: ");
                    string excerpt = Console.ReadLine();

                    foreach (Napoi c in nap)
                    {
                        if (c.Excerpt == excerpt)
                        {
                            DisplayInfoAboutNapoi(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("What country_made would you like to find: ");
                    string country_name = Console.ReadLine();
                    foreach (Napoi c in nap)
                    {
                        if (c.Country_made == country_name)
                        {
                            DisplayInfoAboutNapoi(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Which cost would you like to find: ");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    foreach (Napoi c in nap)
                    {
                        if (c.Cost == cost)
                        {
                            DisplayInfoAboutNapoi(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("What name would you like to find: ");
                    int volume = Convert.ToInt32(Console.ReadLine());
                    foreach (Napoi c in nap)
                    {
                        if (c.Volume == volume)
                        {
                            DisplayInfoAboutNapoi(c);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("Sorry, no matches found.");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Sorry, no such characteristic.");
                    break;
            }

        }

        public void DisplayInfoAboutNapoi(Napoi Napoi)
        {
            Console.WriteLine("\nExcerpt  : {0}\nCountry_made  : {1}\nCost  : {2}\nVolume  : {3}", Napoi.Excerpt, Napoi.Country_made, Napoi.Cost, Napoi.Volume);
        }
    }
}