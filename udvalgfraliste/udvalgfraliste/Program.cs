using System;
using System.Collections.Generic;
using System.Linq;

namespace udvalgfraliste
{
    class Program
    {
        static void UdskrivListe(List<int> intliste)
        {
            foreach (var item in intliste)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        static void UdskrivListe(List<car> carliste)
        {
            foreach (var item in carliste)
            {
                Console.Write(item.Id + ", ");
                Console.Write(item.Model + ", ");
                Console.Write(item.Brand + ", ");
                Console.Write(item.Year + ", ");
                Console.Write(item.Price + ", ");
                Console.Write(item.Color + ", ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void UdskrivListe(car item)
        {
            Console.Write(item.Id + ", ");
            Console.Write(item.Model + ", ");
            Console.Write(item.Brand + ", ");
            Console.Write(item.Year + ", ");
            Console.Write(item.Price + ", ");
            Console.Write(item.Color + ", ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> listetal = new List<int> { 4, 7, 12, 17, -3, 8, 0, -45, 101 };

            List<int> OpgaveA_1 = listetal.Where(tal => tal >= 0).ToList();
            List<int> OpgaveA_2 = listetal.Where(tal => tal == 7).ToList();
            List<int> OpgaveA_3 = listetal.Where(tal => tal > 4).ToList();

            UdskrivListe(OpgaveA_1);
            UdskrivListe(OpgaveA_2);
            UdskrivListe(OpgaveA_3);

            List<car> carliste = new List<car>()
            {
                new car(1, "Rio","Kia", 2006, 250000, "Red"),
                new car(2, "Rio", "Kia", 2007, 265000, "Black"),
                new car(3, "Panda", "Fiat", 2017, 265000, "Black"),
                new car(4, "Panda", "Fiat", 2017, 365000, "Yellow"),
                new car(5, "S40", "Volvo",  2018, 665000, "White"),
                new car(6, "S65", "Volvo", 2018, 600000, "White"),
                new car(7, "Gorm", "Ferrari", 2000, 4665000, "White"),
                new car(8, "Gorm","Ferrari", 2018, 4665000, "White")
            };

            List<car> OpgaveB_1 = carliste.Where(car => car.Model == "Rio").ToList();
            List<car> OpgaveB_2 = carliste.Where(car => car.Brand == "Ferrari").ToList();
            List<car> OpgaveB_3 = carliste.Where(car => car.Year >= 2010).ToList();
            List<car> OpgaveB_4 = carliste.Where(car => car.Color == "White").ToList();

            car OpgaveB_5 = carliste.SingleOrDefault(car => car.Id == 8);

            UdskrivListe(OpgaveB_1);
            UdskrivListe(OpgaveB_2);
            UdskrivListe(OpgaveB_3);
            UdskrivListe(OpgaveB_4);
            UdskrivListe(OpgaveB_5);

            Console.Read();
        }
    }
}