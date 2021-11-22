using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210920
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            //feladat11();




        }
        static void feladat1()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }
            Console.ReadLine();
        }
        static void feladat2()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám pozitív");
            }
            Console.ReadLine();
        }
        static void feladat3()
        {
            Console.WriteLine("Hány fok van kint? :");
            int homerseklet = Convert.ToInt32(Console.ReadLine());
            if (homerseklet < 0)
            {
                Console.WriteLine("Fagy van kint");
            }
            else
            {
                Console.WriteLine("Nincs kint fagy");
            }
            Console.ReadLine();
        }
        static void feladat4()
        {
            Console.WriteLine("Kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (-30 < szam && szam < 40)
            {
                Console.WriteLine("A szám a tartományban van");
            }
            else
            {
                Console.WriteLine("A szám nincs a tartományban");
            }
            Console.ReadLine();
        }
        static void feladat5()
        {
            Console.WriteLine("Kérek egy számot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 16)
            {
                szam = szam * 16;
                Console.WriteLine(szam);
            }
            else if (szam >= 16)
            {
                szam = szam / 3;
                Console.WriteLine(szam);
            }
            Console.ReadLine();
        }
        static void feladat6()
        {
            Console.WriteLine("Kérek egy számot 10 és 50 között :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (10 <= szam && szam <= 19)
            {
                Console.WriteLine("Tizesek közé tartozik");
            }
            else if (20 <= szam && szam <= 29)
            {
                Console.WriteLine("huszasok közé tartozik");
            }
            else if (30 <= szam && szam <= 39)
            {
                Console.WriteLine("Harmincasok közé tartozik");
            }
            else if (40 <= szam && szam <= 49)
            {
                Console.WriteLine("negyvenesek közé tartozik");
            }
            Console.ReadLine();
        }
        static void feladat7()
        {
            Console.WriteLine("Kérek egy számot : ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (12 < szam && szam < 25 && szam % 2 == 0)
            {
                Console.WriteLine("A tartományban lévő szám páros");
            }
            else
            {
                Console.WriteLine("A szám nincs a tartományban vagy nem páros");
            }
            Console.ReadLine();
        }
        static void feladat8()
        {
            Console.WriteLine("Kérem a víz hőmérsékletét");
            int szam = Convert.ToInt32(Console.ReadLine());
            if(szam<0)
            {
                Console.WriteLine("A víz szilárd halmazállapotú");
            }
            else if(0<=szam && szam<100)
            {
                Console.WriteLine("A víz folyékony halmazállapotú");
            }
            else if(100<=szam)
            {
                Console.WriteLine("A víz gáz halmazállapotú");
            }
            Console.ReadLine();
        }
        static void feladat9()
        {
            Console.WriteLine("Kérek egy számot : ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam%3==0 && szam%4==0 && szam%9==0)
            {
                Console.WriteLine("A szám osztahtó 3-mal 4-el és 9-el is");
            }
            else if(szam%3==0 && szam%4==0)
            {
                Console.WriteLine("A szám osztahtó 3-mal és 4-el");
            }

            else if(szam%3==0 && szam%9==0)
            {
                Console.WriteLine("A szám 3-mal és 9-el osztahtó");
            }
            else if (szam % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal");
            }
            else if(szam%4==0 && szam%9==0)
            {
                Console.WriteLine("A szám 4-el és 9-el osztható");
            }
            else if(szam%4==0)
            {
                Console.WriteLine("A szám 4-el osztható");
            }
           
            else
            {
                Console.WriteLine("Egyikkel sem osztható");
            }
            Console.ReadLine();
        }
        static void feladat10()
        {
            Console.WriteLine("Kérem az évszámot :");
            int szam = Convert.ToInt32(Console.ReadLine());
            if(szam%4==0)
            {
                Console.WriteLine("A megadott év szökőév");
            }
            else
            {
                Console.WriteLine("A megadott év nem szökőév");
            }
            Console.ReadLine();
        }
        static void feladat11()
        {
            Console.WriteLine("Kérek az a szakaszt :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek a b szakaszt :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek a c szakaszt :");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("A háromszög szerkezthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkezthető");
            }
            Console.ReadLine();

        }
        
        
        

        

    }
}
