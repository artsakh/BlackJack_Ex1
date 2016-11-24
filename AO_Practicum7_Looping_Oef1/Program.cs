using System;

namespace AO_Practicum7_Looping_Oef1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inzet = 0;
            const int waardeKaartBoer = 10;
            const int waardeKaartDame = 10;
            const int waardeKaartHeer = 10;
            int getrokkenKaartBank = 0;
            int getrokkenKaartSpeler = 0;
            int waardeGetrokkenKaartBank = 0;
            int waardeGetrokkenKaartSpeler = 0;
            int totaalBank = 0;
            int totaalSpeler = 0;
            string naamGetrokkenKaart = "";
            string nogKaart = "";
            string resultaat = "";

            Console.WriteLine("BLACKJACK");
            Console.Write("Druk op enter om het spel te starten");
            Console.ReadLine();
            Console.Write("Gelieve je inzet in te geven: ");
            inzet = int.Parse(Console.ReadLine());
            Console.WriteLine("Druk op enter om een kaart te ontvangen.");
            Console.ReadLine();

            while (inzet > 0 && totaalSpeler < 21)
            {
                do
                {
                    getrokkenKaartSpeler = new Random().Next(1, 14);

                    if (totaalBank < 17)
                    {
                        getrokkenKaartBank = new Random().Next(1, 14);
                    }
                    else
                    {
                        totaalBank = new Random().Next(17, 27);
                    }

                    switch (getrokkenKaartSpeler)
                    {
                        case 11:
                            naamGetrokkenKaart = "Boer";
                            waardeGetrokkenKaartSpeler = waardeKaartBoer;
                            break;

                        case 12:
                            naamGetrokkenKaart = "Dame";
                            waardeGetrokkenKaartSpeler = waardeKaartDame;
                            break;

                        case 13:
                            naamGetrokkenKaart = "Heer";
                            waardeGetrokkenKaartSpeler = waardeKaartHeer;
                            break;

                        default:
                            naamGetrokkenKaart = getrokkenKaartSpeler.ToString();
                            waardeGetrokkenKaartSpeler = getrokkenKaartSpeler;
                            break;
                    }

                    switch (getrokkenKaartBank)
                    {
                        case 11:
                            waardeGetrokkenKaartBank = waardeKaartBoer;
                            break;

                        case 12:
                            waardeGetrokkenKaartBank = waardeKaartDame;
                            break;

                        case 13:
                            waardeGetrokkenKaartBank = waardeKaartHeer;
                            break;

                        default:
                            waardeGetrokkenKaartBank = getrokkenKaartBank;
                            break;
                    }

                    Console.WriteLine("Getrokken kaart: " + naamGetrokkenKaart + " ... " + waardeGetrokkenKaartSpeler + " ... " + waardeGetrokkenKaartBank);
                    totaalSpeler += waardeGetrokkenKaartSpeler;

                    if (totaalBank < 17)
                    {
                        totaalBank += waardeGetrokkenKaartBank;
                    }

                    Console.Write("Nieuw totaal: " + totaalSpeler + " ... " + totaalBank + "\n");

                    if (totaalBank < 17 && totaalSpeler < 21)
                    {
                        Console.Write("Nog een kaart (j/n)?: ");
                        nogKaart = Console.ReadLine();
                    }
                    else
                    {
                        nogKaart = "n";

                        if (totaalBank > 21)
                        {
                            if (totaalBank > totaalSpeler)
                            {
                                Console.WriteLine("Je verliest je inzet, de bank heeft gewonnen");
                            }
                            else
                            {
                                Console.Write("Je krijgt je inzet terug");
                            }
                        }
                        else if (totaalSpeler > 21)
                        {
                            Console.Write("Totaal > 21, je verliest je inzet");
                        }
                        else if (totaalBank == 21)
                        {
                            Console.WriteLine("Je verliest je inzet, de bank heeft blackjack");
                        }
                        else
                        {
                            Console.WriteLine("TODO");
                        }
                    }
                } while (nogKaart == "j");
            }

            Console.WriteLine("\n\nTHE END");
            Console.ReadLine();
        }
    }
}