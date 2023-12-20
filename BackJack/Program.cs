using System;
using System.Security.Cryptography;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            string menyval = "0";
            Console.WriteLine("Välkommen till 21:an");
            string namn = "Ingen vinnare än";
            do
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnare");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                menyval = Console.ReadLine();
                switch (menyval)
                {
                    case "1":

                        Console.WriteLine("");
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        Thread.Sleep(200);
                        Random slump = new Random();
                        int spelardrag1 = slump.Next(1, 12);
                        int spelardrag2 = slump.Next(1, 12);
                        int sumspelardrag = spelardrag1 + spelardrag2;
                        int datordrag1 = slump.Next(1, 12);
                        int datordrag2 = slump.Next(1, 12);
                        int sumdatordrag = datordrag1 + datordrag2;
                        Console.WriteLine("Dina poäng: " + sumspelardrag);
                        Console.WriteLine("Datorns poäng: " + sumdatordrag);
                        Thread.Sleep(200);
                        if (sumspelardrag > 21)
                        {
                            Console.WriteLine("Du har förlorat");
                            namn = "datorn";
                            Console.WriteLine("");
                            break;
                        }
                        else if (sumdatordrag > 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv ditt namn:");
                            namn = Console.ReadLine();
                            Console.WriteLine("");
                            break;
                        }
                        Console.WriteLine("Vill du dra ett till kort? (j/n)");
                        Console.WriteLine("");
                        string spelval = Console.ReadLine().ToLower();
                        while (spelval == "j")
                        {
                            int spelardrag3 = slump.Next(1, 12);
                            Thread.Sleep(200);
                            Console.WriteLine("Ditt nya kort är värt: " + spelardrag3);
                            sumspelardrag += spelardrag3;
                            Console.WriteLine("Dina poäng är: " + sumspelardrag);
                            Console.WriteLine("Datorns poäng är: " + sumdatordrag);
                            Thread.Sleep(200);
                            if (sumspelardrag > 21)
                            {
                                Console.WriteLine("Du har förlorat");
                                namn = "datorn";
                                Console.WriteLine("");
                                break;
                            }
                            Console.WriteLine("Vill du dra ett till kort? (j/n)");
                            Console.WriteLine("");
                            spelval = Console.ReadLine().ToLower(); 
                        }
                        while (sumdatordrag < 18 && sumspelardrag < 22)
                        {
                            int datordrag3 = slump.Next(1, 12);
                            Console.WriteLine("Datorn drog ett kort värt: " + datordrag3);
                            sumdatordrag += datordrag3;
                            Console.WriteLine("Datorns poäng är: " + sumdatordrag);
                            Console.WriteLine("");
                            Thread.Sleep(200);
                            if (sumdatordrag > 21)
                            {
                                Console.WriteLine("Du har vunnit!");
                                Console.WriteLine("Skriv ditt namn:");
                                namn = Console.ReadLine();
                                Console.WriteLine("");
                                break;
                            }
                        }
                        if (sumdatordrag >= sumspelardrag && sumdatordrag <= 21 && sumspelardrag <= 21)
                        {
                            Console.WriteLine("Du har förlorat");
                            namn = "datorn";
                            Console.WriteLine("");
                            break;
                        }
                        else if (sumdatordrag < sumspelardrag && sumdatordrag <= 21 && sumspelardrag <= 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv ditt namn:");
                            namn = Console.ReadLine();
                            Console.WriteLine("");
                            break;
                        }
                        break;

                    case "2":

                        Console.WriteLine("");
                        Console.WriteLine("Den senaste vinnaren var: " + namn);
                        Console.WriteLine("");
                        break;

                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1 - 11 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        Console.WriteLine("");
                        break;

                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("programmet avslutas");
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        Console.WriteLine("");
                        break;
                }
            } while (menyval != "4");
            Console.ReadKey();
        }
    }
}
